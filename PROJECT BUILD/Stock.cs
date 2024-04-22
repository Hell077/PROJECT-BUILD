using System.Data;
using System.Data.SqlClient;

namespace PROJECT_BUILD
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        Deleted,
        ModifiedNew
    }

    public partial class Stock : Form
    {
        Database database = new Database();


        public Stock()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            CreateColumns();
            UpdateDataGridView(dataGridView1);
            dataGridView1.Dock = DockStyle.None; // Занимает всё доступное пространство
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Адаптивное заполнение по горизонтали
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Оставить высоту строк фиксированной

        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Название материала");
            dataGridView1.Columns.Add("unit", "Единица измерения");
            dataGridView1.Columns.Add("count", "Колличество");
            dataGridView1.Columns.Add("unit_cost", "Стоимость за единицу");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSinglRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                Convert.ToInt32(record[0]).ToString(),
                record.GetString(1),
                record.GetString(2),
                Convert.ToInt32(record[3]).ToString(),
                record.GetDecimal(4)

            );
        }
        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string quertString = $"select * from dbo.Материалы";
            SqlCommand command = new SqlCommand(quertString, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRows(dgw, reader);
            }
            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Введите текст для поиска");
                return;
            }
            var filteredRows = from DataGridViewRow row in dataGridView1.Rows
                               where row.Cells["name"].Value != null && row.Cells["name"].Value.ToString().ToLower().StartsWith(searchValue)
                               select row;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
            }
            foreach (DataGridViewRow row in filteredRows)
            {
                row.Selected = true;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
            }
        }
    }
}
