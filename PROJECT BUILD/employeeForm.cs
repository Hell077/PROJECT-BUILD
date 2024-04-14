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
            StartPosition = FormStartPosition.CenterScreen;
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
            dataGridView1.Columns.Add("date", "Дата приема");
            dataGridView1.Columns.Add("Salary", "Зарплата");
            dataGridView1.Columns.Add("Department_ID", "ID отдела");

            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        
            private void ReadSinglRows(DataGridView dgw, IDataRecord record)
            {
                dgw.Rows.Add(
                    record.GetInt32(0),
                    record.GetString(1),
                    record.GetString(2),
                    record.GetString(3),
                    record.GetDateTime(4).ToString("yyyy-MM-dd"), // Преобразуем дату в строку с нужным форматом
                    record.IsDBNull(5) ? "NULL" : record.GetDecimal(5).ToString(), // Проверяем, не является ли значение NULL
                    record.IsDBNull(6) ? "NULL" : record.GetInt32(6).ToString() // Проверяем, не является ли значение NULL
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

        
    }
}
