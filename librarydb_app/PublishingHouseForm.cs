using librarydb_app.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class PublishingHouseForm : Form
    {
        public PublishingHouseForm()
        {
            InitializeComponent();
            dataGridViewHouses.DataSource = Program.loginForm.DataContext.PublishinghouseSak.ToList(); // связали данные с таблицей
        }

        private void buttonAddHouse_Click(object sender, EventArgs e)
        {
            PublishinghouseSak newPublishinghouse = new PublishinghouseSak
            {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                HousePhoneNumber = textBoxPhoneNumber.Text
            };

            Program.loginForm.DataContext.Add(newPublishinghouse);
            Program.loginForm.DataContext.SaveChanges();

            // обновляем источник данных и обновляем отображение таблицы
            dataGridViewHouses.DataSource = null;
            dataGridViewHouses.DataSource = Program.loginForm.DataContext.PublishinghouseSak.ToList();
            dataGridViewHouses.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewHouses.SelectedRows)
            {
                int id = (int)selectedRow.Cells[0].Value;
                // ищем элемент для удаления по первичному ключу
                var toDelete = Program.loginForm.DataContext.PublishinghouseSak.FirstOrDefault(house => house.PublishingHouseId.Equals(id));
                if (toDelete != null)
                {
                    Program.loginForm.DataContext.PublishinghouseSak.Remove(toDelete);
                    Program.loginForm.DataContext.SaveChanges();
                }
            }
            // обновляем источник данных и обновляем отображение таблицы
            dataGridViewHouses.DataSource = null;
            dataGridViewHouses.DataSource = Program.loginForm.DataContext.PublishinghouseSak.ToList();
            dataGridViewHouses.Refresh();
        }

        private void dataGridViewHouses_SelectionChanged(object sender, EventArgs e)
        {
            // заполняем textbox по выделенной строке
            if (dataGridViewHouses.CurrentRow != null) // выделенная строка
            {
                textBoxName.Text = dataGridViewHouses.CurrentRow.Cells[1].Value.ToString();
                textBoxPhoneNumber.Text = dataGridViewHouses.CurrentRow.Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridViewHouses.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedHouse = Program.loginForm.DataContext.PublishinghouseSak
                .FirstOrDefault(house => house.PublishingHouseId.Equals((int)dataGridViewHouses.CurrentRow.Cells[0].Value));
            if (selectedHouse != null)
            {
                MessageBox.Show($"publishing house with ID = {selectedHouse.PublishingHouseId} has edited");

                // перезаписываем
                selectedHouse.Name = textBoxName.Text;
                selectedHouse.HousePhoneNumber = textBoxPhoneNumber.Text;
                selectedHouse.Address = textBoxAddress.Text;

                // сохраняем изменения и обновляем datagridview
                Program.loginForm.DataContext.SaveChanges();
                dataGridViewHouses.DataSource = null;
                dataGridViewHouses.DataSource = Program.loginForm.DataContext.PublishinghouseSak.ToList();
                dataGridViewHouses.Refresh();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim().ToLower(); // исходная строка без лишних пробелов

            // Проверяем, не является ли значение поисковой строки пустой строкой
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если значение пустое, то сбрасываем видимость всех строк и выходим из метода
                foreach (DataGridViewRow row in dataGridViewHouses.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Отображаем только подходящие по поиску строки
            foreach (DataGridViewRow row in dataGridViewHouses.Rows)
            {
                dataGridViewHouses.CurrentCell = null;

                if (!(row.Cells[0].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[1].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[2].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[3].Value.ToString().ToLower().Contains(searchValue)
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
            foreach (DataGridViewColumn column in dataGridViewHouses.Columns)
            {
                // Добавляем столбец в DataTable
                dataTable.Columns.Add(column.HeaderText);
            }

            // Заполнение DataTable данными из DataGridView
            foreach (DataGridViewRow row in dataGridViewHouses.Rows)
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
                .Combine("..\\..\\DbReports", $"PublishingHouses_{DateTime.Now:ddMMyyyy_HHmmss}.xml");
            // Сохранение DataTable в XML файл
            dataTable.WriteXml(fileName);

            MessageBox.Show("Отчёт сохранен.");
        }
    }
}
