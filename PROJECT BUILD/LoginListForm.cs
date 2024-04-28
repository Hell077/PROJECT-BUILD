using System.Data;
using System.Data.SqlClient;

namespace PROJECT_BUILD
{
    public partial class LoginListForm : Form
    {
        Database database = new Database();
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        public LoginListForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

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
            dataGridView1.Columns.Add("avatarLink", "Ссылка на аватарку");
            dataGridView1.Columns.Add("user_access", "Уровень Доступа");
        }

        private void ReadSinglRows(DataGridView dgw, IDataRecord record)
        {
            string column1Value = DBNull.Value.Equals(record[0]) ? string.Empty : Convert.ToInt32(record[0]).ToString();
            string column2Value = DBNull.Value.Equals(record[1]) ? string.Empty : record.GetString(1);
            string column3Value = DBNull.Value.Equals(record[2]) ? string.Empty : record.GetString(2);
            string column4Value = DBNull.Value.Equals(record[3]) ? string.Empty : record.GetString(3);
            string column5Value = DBNull.Value.Equals(record[4]) ? string.Empty : record.GetString(4);

            dgw.Rows.Add(column1Value, column2Value, column3Value, column4Value, column5Value, RowState.ModifiedNew);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string access = comboBox1.Text;
            string newAccesValue = access;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells[4].Value = newAccesValue;
                string id = selectedRow.Cells[0].Value.ToString(); ;

                if (UpdateDataInDatabase(id, newAccesValue))
                {
                    MessageBox.Show("Данные успешно обновлены.");
                }
                else
                {
                    MessageBox.Show("Не удалось обновить данные в базе данных.");
                }

            }


        }

        private bool UpdateDataInDatabase(string id, string newAccessValue)
        {
            try
            {
                string updateQuery = "UPDATE register SET user_access = @newAccessValue WHERE id_user = @id";
                using (SqlCommand command = new SqlCommand(updateQuery, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@newAccessValue", newAccessValue);
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = System.Windows.Forms.Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(System.Windows.Forms.Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

    }
}
