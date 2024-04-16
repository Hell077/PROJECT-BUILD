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
        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == '.')
            {

              //  e.Handled = true;
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
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }


        private void ReadSinglRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetDecimal(4)
            );
        }



        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string quertString = $"select * from dbo.Сотрудники";
            SqlCommand command = new SqlCommand(quertString, database.GetConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRows(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;


                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string field1Value = selectedRow.Cells[1].Value.ToString();
                string field2Value = selectedRow.Cells[2].Value.ToString();
                string field3Value = selectedRow.Cells[3].Value.ToString();
                string field4Value = selectedRow.Cells[4].Value.ToString();
                textBox1.Text = field1Value;
                textBox2.Text = field2Value;
                textBox3.Text = field3Value;
                textBox4.Text = field4Value;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string newFieldValue1 = textBox1.Text;
            string newFieldValue2 = textBox2.Text;
            string newFieldValue3 = textBox3.Text;
            decimal newFieldValue4;

            if (decimal.TryParse(textBox4.Text, out newFieldValue4))
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedRow.Cells[1].Value = newFieldValue1;
                    selectedRow.Cells[2].Value = newFieldValue2;
                    selectedRow.Cells[3].Value = newFieldValue3;
                    selectedRow.Cells[4].Value = newFieldValue4;

                    string id = selectedRow.Cells[0].Value.ToString();

                    if (UpdateDataInDatabase(id, newFieldValue1, newFieldValue2, newFieldValue3, newFieldValue4))
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


        private bool UpdateDataInDatabase(string id, string newValue1, string newValue2, string newValue3, decimal newValue4)
        {
            try
            {
                string updateQuery = "UPDATE Сотрудники SET Имя = @newValue1, Фамилия = @newValue2, Должность = @newValue3, Зарплата = @newValue4 WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(updateQuery, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@newValue1", newValue1);
                    command.Parameters.AddWithValue("@newValue2", newValue2);
                    command.Parameters.AddWithValue("@newValue3", newValue3);
                    command.Parameters.AddWithValue("@newValue4", newValue4);
                    command.Parameters.AddWithValue("@id", id);

                    database.openConnection();
                    int rowsAffected = command.ExecuteNonQuery();
                    database.closedConnection();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных в базе данных: " + ex.Message);
                return false;
            }
        }



    }

}