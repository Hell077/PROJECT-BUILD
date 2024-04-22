using PROJECT_BUILD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace PROJECT_BUILD
{
    public partial class employeeForm : Form
    {
        Database database = new Database();
        public employeeForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void textBox5_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (NameBox.Text.Length >= 12 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {

                e.Handled = true;
            }
        }

        private void employee_Load(object sender, EventArgs e)
        {
            CreateColumns();
            UpdateDataGridView(dataGridView1);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("second_name", "Фамилия");
            dataGridView1.Columns.Add("job_title", "Должность");
            dataGridView1.Columns.Add("Salary", "Зарплата");
            dataGridView1.Columns.Add("Phone_number", "Телефон");
            dataGridView1.Columns.Add("IIN", "ИИН");
            dataGridView1.Columns.Add("email", "Почта");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }


        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.IsDBNull(1) ? string.Empty : record.GetString(1),
                record.IsDBNull(2) ? string.Empty : record.GetString(2),
                record.IsDBNull(3) ? string.Empty : record.GetString(3),
                record.IsDBNull(4) ? 0 : record.GetDecimal(4),
                record.IsDBNull(5) ? string.Empty : record.GetString(5),
                record.IsDBNull(6) ? string.Empty : record.GetString(6),
                record.IsDBNull(7) ? string.Empty : record.GetString(7)
            );
        }




        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string quertString = $"select * from dbo.Сотрудники";
            SqlCommand command = new SqlCommand(quertString, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                NameBox.Text = null;
                LastNameBox.Text = null;
                JobTitleBox.Text = null;
                SalaryBox.Text = null;
                PhoneNumber.Text = null;
                IINBox.Text = null;
                emailBox.Text = null;

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string field1Value = selectedRow.Cells[1].Value.ToString();
                string field2Value = selectedRow.Cells[2].Value.ToString();
                string field3Value = selectedRow.Cells[3].Value.ToString();
                string field4Value = selectedRow.Cells[4].Value.ToString();
                string field5Value = selectedRow.Cells[5].Value.ToString();
                string field6Value = selectedRow.Cells[6].Value.ToString();
                string field7Value = selectedRow.Cells[7].Value.ToString();
                NameBox.Text = field1Value;
                LastNameBox.Text = field2Value;
                JobTitleBox.Text = field3Value;
                SalaryBox.Text = field4Value;
                PhoneNumber.Text = field5Value;
                IINBox.Text = field6Value;
                emailBox.Text = field7Value;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string newFieldValue1 = NameBox.Text;
            string newFieldValue2 = LastNameBox.Text;
            string newFieldValue3 = JobTitleBox.Text;

            decimal newFieldValue4;
            string newFieldValue5 = PhoneNumber.Text;
            string newFieldValue6 = IINBox.Text;
            string newFieldValue7 = emailBox.Text;

            if (decimal.TryParse(SalaryBox.Text, out newFieldValue4))
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedRow.Cells[1].Value = newFieldValue1;
                    selectedRow.Cells[2].Value = newFieldValue2;
                    selectedRow.Cells[3].Value = newFieldValue3;
                    selectedRow.Cells[4].Value = newFieldValue4;
                    selectedRow.Cells[5].Value = newFieldValue5;
                    selectedRow.Cells[6].Value = newFieldValue6;
                    selectedRow.Cells[7].Value = newFieldValue7;
                    string id = selectedRow.Cells[0].Value.ToString();

                    if (UpdateDataInDatabase(id, newFieldValue1, newFieldValue2, newFieldValue3, newFieldValue4, newFieldValue5, newFieldValue6, newFieldValue7))
                    {
                        MessageBox.Show("Данные успешно обновлены.");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить данные в базе данных.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите корректное значение для зарплаты.");
            }
        }


        private bool UpdateDataInDatabase(string id, string newValue1, string newValue2, string newValue3, decimal newValue4, string newValue5, string newValue6, string newValue7)
        {
            try
            {
                string updateQuery = "UPDATE Сотрудники SET Имя = @newValue1, Фамилия = @newValue2, Должность = @newValue3, Зарплата = @newValue4, Телефон = @newValue5,ИИН = @newValue6, Почта = @newValue7 WHERE ID_сотрудника = @id";
                using (SqlCommand command = new SqlCommand(updateQuery, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@newValue1", newValue1);
                    command.Parameters.AddWithValue("@newValue2", newValue2);
                    command.Parameters.AddWithValue("@newValue3", newValue3);
                    command.Parameters.AddWithValue("@newValue4", newValue4);
                    command.Parameters.AddWithValue("@newValue5", newValue5);
                    command.Parameters.AddWithValue("@newValue6", newValue6);
                    command.Parameters.AddWithValue("@newValue7", newValue7);
                    command.Parameters.AddWithValue("@id", id);

                    database.OpenConnection();
                    int rowsAffected = command.ExecuteNonQuery();
                    database.CloseConnection();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных в базе данных: " + ex.Message);
                return false;
            }
        }





        private void AddNewButton_Click(object sender, EventArgs e)
        {
            string FirstName = NameBox.Text;
            string LastName = LastNameBox.Text;
            string job_title = JobTitleBox.Text;
            string Salary = SalaryBox.Text;
            string Number = PhoneNumber.Text;
            string IIN = IINBox.Text;
            string email = emailBox.Text;


            string queryString = $"INSERT INTO Сотрудники (Имя, Фамилия, Должность, Зарплата, Телефон, Иин, Почта) VALUES ('{FirstName}', '{LastName}', '{job_title}','{Salary}' , '{Number}', '{IIN}', '{email}') ";

            using (SqlCommand command = new SqlCommand(queryString, database.GetConnection()))
            {
                try
                {
                    database.OpenConnection();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Сотрудник успешно добавлен.");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при добавлении сотрудника.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
                finally
                {
                    database.CloseConnection();
                }
            }
        }






        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int idToDelete = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["id"].Value);
                DeleteRecordFromDatabase(idToDelete);
                dataGridView1.Rows.RemoveAt(selectedIndex);

                MessageBox.Show("Запись удалена из базы данных и из DataGridView.");
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }


        private void DeleteRecordFromDatabase(int id)
        {
            Database database = new Database();
            SqlConnection connection = database.GetConnection();
            try
            {
                database.OpenConnection();
                SqlCommand command = new SqlCommand("DELETE FROM Сотрудники WHERE Id_сотрудника = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись удалена из базы данных.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении записи из базы данных: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void RefreshDB_Click(object sender, EventArgs e)
        {
            UpdateDataGridView(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            LastNameBox.Text = "";
            JobTitleBox.Text = "";
            SalaryBox.Text = "";
            PhoneNumber.Text = "";
            IINBox.Text = "";
            emailBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Stats stats  = new Stats();
            stats.ShowDialog();
                
        }
    }

}