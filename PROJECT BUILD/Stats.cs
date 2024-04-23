using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT_BUILD
{
    public partial class Stats : Form
    {
        Database database = new Database();

        public Stats()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            CreateColumns();
            UpdateDataGridView(dataGridView1);
            CalculateAndDisplayStats();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID_сотрудника");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("lastName", "Фамилия");
            dataGridView1.Columns.Add("Salary", "Зарплата");
        }

        private void ReadSinglRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                Convert.ToInt32(record[0]).ToString(),
                record.GetString(1),
                record.GetString(2),
                record.GetDecimal(4) 
            );
        }

        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string quertString = "SELECT * FROM dbo.Сотрудники";
            SqlCommand command = new SqlCommand(quertString, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRows(dgw, reader);
            }
            reader.Close();
        }

        private void CalculateAndDisplayStats()
        {
            decimal sumSalary = 0;
            decimal maxSalary = decimal.MinValue;
            decimal minSalary = decimal.MaxValue;
            int rowCount = dataGridView1.Rows.Count;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                decimal salary = Convert.ToDecimal(row.Cells["Salary"].Value);
                sumSalary += salary;
                maxSalary = Math.Max(maxSalary, salary);
                minSalary = Math.Min(minSalary, salary);
            }

            decimal averageSalary = rowCount > 0 ? sumSalary / rowCount : 0;

            lblAverageSalary.Text = $"{averageSalary:F2}₸"; 
            lblMaxSalary.Text = $"{maxSalary:F2}₸";  
            lblMinSalary.Text = $"{minSalary:F2}₸";  
        }
    }
}
