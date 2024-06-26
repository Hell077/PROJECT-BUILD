﻿using System;
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
    public partial class OrdersList : Form
    {
        Database database = new Database();
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        public OrdersList()
        {

            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void OrdersList_Load(object sender, EventArgs e)
        {
            CreateColumns();
            UpdateDataGridView(dataGridView1);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("GetStatus", "Статус выполнения");
            dataGridView1.Columns.Add("name", "Название проекта");
            dataGridView1.Columns.Add("description", "Описание проекта");
            dataGridView1.Columns.Add("customer_name", "Имя заказчика");
            dataGridView1.Columns.Add("customer_lastname", "Фамилия заказчика");
            dataGridView1.Columns.Add("customer_email", "Почта заказчика");
            dataGridView1.Columns.Add("square", "Площадь");
            dataGridView1.Columns.Add("status", "Ремонт");
            dataGridView1.Columns.Add("FinalPrice", "Расчетная_стоимость");
            dataGridView1.Columns.Add("User", "User Login");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }


        private void ReadSinglRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                Convert.ToInt32(record[0]).ToString(),
                record.GetString(10),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetString(5),
                record.GetInt32(6),
                record.GetString(7),
                record.GetString(8),
                record.GetString(9),
                RowState.ModifiedNew
            );
        }


        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string quertString = $"select * from dbo.Заказчик";
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
                SqlCommand command = new SqlCommand("DELETE FROM dbo.Заказчик WHERE ID_заказчика = @Id", connection);
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(System.Windows.Forms.Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string access = comboBox1.Text;
            string newAccesValue = access;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells[1].Value = newAccesValue;
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
                string updateQuery = "UPDATE Заказчик SET Статус = @newAccessValue WHERE ID_заказчика = @id";
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
    }
}
