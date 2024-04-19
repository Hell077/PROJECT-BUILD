using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECT_BUILD
{
    public partial class LoginListForm : Form
    {
        Database database = new Database();
        public LoginListForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginListForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            UpdateDataGridView(dataGridView1);
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Логин");
            dataGridView1.Columns.Add("password", "Пароль");
        }

        private void ReadSinglRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                Convert.ToInt32(record[0]).ToString(),
                record.GetString(1),
                record.GetString(2),
                RowState.ModifiedNew
            );
        }
        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string quertString = $"select * from dbo.register";
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
                SqlCommand command = new SqlCommand("DELETE FROM dbo.register WHERE id_user = @Id", connection);
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

    }
}
