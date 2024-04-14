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
                Convert.ToInt32(record[4]).ToString(),
                RowState.ModifiedNew
            );
        }

        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string quertString = $"select * from dbo.Материалы";
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
