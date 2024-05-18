using librarydb_app.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class DepsForm : Form
    {
        public DepsForm()
        {
            InitializeComponent();
            dataGridViewDeps.DataSource = Program.loginForm.DataContext.BookdepartmentSak.ToList();
        }

        private void buttonAddDep_Click(object sender, System.EventArgs e)
        {
            BookdepartmentSak newDep = new BookdepartmentSak
            {
                DepName = textBoxDepName.Text,
                DepPhoneNumber = textBoxPhoneNumber.Text
            };

            Program.loginForm.DataContext.Add(newDep);
            Program.loginForm.DataContext.SaveChanges();

            // обновляем источники данных и обновляем таблицу и combobox
            dataGridViewDeps.DataSource = null;
            dataGridViewDeps.DataSource = Program.loginForm.DataContext.BookdepartmentSak.ToList();
            dataGridViewDeps.Refresh();
        }

        private void buttonEdit_Click(object sender, System.EventArgs e)
        {
            var selectedDep = Program.loginForm.DataContext.BookdepartmentSak.FirstOrDefault(dep => dep.DepId.Equals((int)dataGridViewDeps.CurrentRow.Cells[0].Value));
            if (selectedDep != null)
            {
                MessageBox.Show($"Reader with ReaderID = {selectedDep.DepId} has edited");

                // изменяем данные отдела
                selectedDep.DepName = textBoxDepName.Text;
                selectedDep.DepPhoneNumber = textBoxPhoneNumber.Text;


                // сохраняем изменения и обновляем datagridview
                Program.loginForm.DataContext.SaveChanges();
                dataGridViewDeps.DataSource = null;
                dataGridViewDeps.DataSource = Program.loginForm.DataContext.BookdepartmentSak.ToList();
                dataGridViewDeps.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewDeps.SelectedRows)
            {
                int id = (int)selectedRow.Cells[0].Value;
                // ищем элемент для удаления по первичному ключу
                var toDelete = Program.loginForm.DataContext.BookdepartmentSak.FirstOrDefault(dep => dep.DepId.Equals(id));
                if (toDelete != null)
                {
                    Program.loginForm.DataContext.BookdepartmentSak.Remove(toDelete);
                    Program.loginForm.DataContext.SaveChanges();
                }
            }

            // обновляем источники данных и обновляем таблицу и combobox
            dataGridViewDeps.DataSource = null;
            dataGridViewDeps.DataSource = Program.loginForm.DataContext.BookdepartmentSak.ToList();
            dataGridViewDeps.Refresh();
        }

        private void dataGridViewDeps_SelectionChanged(object sender, EventArgs e)
        {
            // заполняем textbox по выделенной строке
            if (dataGridViewDeps.CurrentRow != null) // выделенная строка
            {
                textBoxDepName.Text = dataGridViewDeps.CurrentRow.Cells[1].Value.ToString();
                textBoxPhoneNumber.Text = dataGridViewDeps.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim().ToLower(); // исходная строка без лишних пробелов

            // Проверяем, не является ли значение поисковой строки пустой строкой
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если значение пустое, то сбрасываем видимость всех строк и выходим из метода
                foreach (DataGridViewRow row in dataGridViewDeps.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Отображаем только подходящие по поиску строки
            foreach (DataGridViewRow row in dataGridViewDeps.Rows)
            {
                dataGridViewDeps.CurrentCell = null;

                if (!(row.Cells[0].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[1].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[2].Value.ToString().ToLower().Contains(searchValue)
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
            foreach (DataGridViewColumn column in dataGridViewDeps.Columns)
            {
                // Добавляем столбец в DataTable
                dataTable.Columns.Add(column.HeaderText);
            }

            // Заполнение DataTable данными из DataGridView
            foreach (DataGridViewRow row in dataGridViewDeps.Rows)
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
                .Combine("..\\..\\DbReports", $"Departments_{DateTime.Now:ddMMyyyy_HHmmss}.xml");
            // Сохранение DataTable в XML файл
            dataTable.WriteXml(fileName);

            MessageBox.Show("Отчёт сохранен.");
        }
    }
}
