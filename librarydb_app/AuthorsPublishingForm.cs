using librarydb_app.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class AuthorsPublishingForm : Form
    {
        public AuthorsPublishingForm()
        {
            InitializeComponent();
            InitializeData();
            InitializeComboBoxes();
        }

        private void InitializeData()
        {
            var query = from AP in Program.loginForm.DataContext.PublishingSak
                        join author in Program.loginForm.DataContext.AuthorSak on AP.AuthorId equals author.AuthorId
                        join house in Program.loginForm.DataContext.PublishinghouseSak on AP.PublishingHouseId equals house.PublishingHouseId
                        orderby author.LastName
                        select new
                        {
                            house.PublishingHouseId,
                            house.Name,
                            author.AuthorId,
                            author.LastName,
                            author.FirstName,
                            author.MiddleName,
                        };
            dataGridViewAP.DataSource = query.ToList();
        }

        private void InitializeComboBoxes()
        {
            comboBoxAuthors.DataSource = Program.loginForm.DataContext.AuthorSak
                .Select(author => author.LastName + " " + author.FirstName + " " + author.MiddleName).ToList();
            comboBoxHouses.DataSource = Program.loginForm.DataContext.PublishinghouseSak
                .Select(house => house.Name).ToList();
            comboBoxAuthors.SelectedItem = null;
            comboBoxHouses.SelectedItem = null;
        }

        private void buttonAddBA_Click(object sender, EventArgs e)
        {
            PublishingSak newAP;
            try
            {
                int houseId = Program.loginForm.DataContext.PublishinghouseSak
                    .FirstOrDefault(house => house.Name
                    .Equals(comboBoxHouses.SelectedItem.ToString())).PublishingHouseId;
                int authorID = Program.loginForm.DataContext.AuthorSak
                    .FirstOrDefault(author => (author.LastName + " " + author.FirstName + " " + author.MiddleName)
                    .Equals(comboBoxAuthors.SelectedItem.ToString())).AuthorId;

                newAP = new PublishingSak
                {
                    AuthorId = authorID,
                    PublishingHouseId = houseId
                };

                // чтобы не добавлять связь автор-книга, которая уже существует
                if (Program.loginForm.DataContext.PublishingSak
                    .FirstOrDefault(ap => ap.PublishingHouseId.Equals(houseId) && ap.AuthorId.Equals(authorID)) == null)
                {
                    Program.loginForm.DataContext.Add(newAP);
                    Program.loginForm.DataContext.SaveChanges();
                }
                else
                    MessageBox.Show("Такая связь автор-книга уже существует");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // обновляем источники данных и обновляем таблицу и combobox
            InitializeData();
            comboBoxAuthors.SelectedItem = null;
            comboBoxHouses.SelectedItem = null;
            dataGridViewAP.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewAP.SelectedRows)
            {
                int houseId = (int)selectedRow.Cells[0].Value;
                int authorId = (int)selectedRow.Cells[2].Value;
                // ищем элемент для удаления
                var toDelete = Program.loginForm.DataContext.PublishingSak
                    .FirstOrDefault(ap => ap.AuthorId.Equals(authorId) && ap.PublishingHouseId.Equals(houseId));
                if (toDelete != null)
                {
                    Program.loginForm.DataContext.PublishingSak.Remove(toDelete);
                    Program.loginForm.DataContext.SaveChanges();
                }
                else
                    MessageBox.Show(Program.loginForm.DataContext.PublishingSak
                    .FirstOrDefault(ap => ap.AuthorId.Equals(authorId) && ap.PublishingHouseId.Equals(houseId)).ToString());
            }

            // обновляем источники данных и обновляем таблицу и combobox
            comboBoxAuthors.SelectedItem = null;
            comboBoxHouses.SelectedItem = null;
            InitializeData();
            dataGridViewAP.Refresh();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim().ToLower(); // исходная строка без лишних пробелов

            // Проверяем, не является ли значение поисковой строки пустой строкой
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если значение пустое, то сбрасываем видимость всех строк и выходим из метода
                foreach (DataGridViewRow row in dataGridViewAP.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Отображаем только подходящие по поиску строки
            foreach (DataGridViewRow row in dataGridViewAP.Rows)
            {
                dataGridViewAP.CurrentCell = null;

                if (!(row.Cells[0].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[1].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[2].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[3].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[4].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[5].Value.ToString().ToLower().Contains(searchValue)
                    ))
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void buttonCreateXML_Click(object sender, EventArgs e)
        {
            // Создание нового DataTable
            DataTable dataTable = new DataTable("MyDataTable");

            // Добавление столбцов в DataTable
            foreach (DataGridViewColumn column in dataGridViewAP.Columns)
            {
                // Добавляем столбец в DataTable
                dataTable.Columns.Add(column.HeaderText);
            }

            // Заполнение DataTable данными из DataGridView
            foreach (DataGridViewRow row in dataGridViewAP.Rows)
            {
                // Проверяем, что строка видимая
                if (row.Visible)
                {
                    // Создаем новую строку для DataTable
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Заполняем значение ячейки в строке DataTable
                        dataRow[cell.OwningColumn.HeaderText] = cell.Value;
                    }
                    // Добавляем заполненную строку в DataTable
                    dataTable.Rows.Add(dataRow);
                }
            }

            // Формирование названия файла
            string fileName = Path
                .Combine("..\\..\\DbReports", $"AuthorPublising_{DateTime.Now:ddMMyyyy_HHmmss}.xml");
            // Сохранение DataTable в XML файл
            dataTable.WriteXml(fileName);

            MessageBox.Show("Отчёт сохранен.");
        }
    }
}
