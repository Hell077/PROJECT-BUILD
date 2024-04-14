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
        public OrdersList()
        {

            InitializeComponent();
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
            dataGridView1.Columns.Add("name", "Название проекта");
            dataGridView1.Columns.Add("description", "Описание проекта");
            dataGridView1.Columns.Add("customer_name", "Имя заказчика");
            dataGridView1.Columns.Add("customer_lastname", "Фамилия заказчика");
            dataGridView1.Columns.Add("customer_email", "Почта заказчика");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }


        private void ReadSinglRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                Convert.ToInt32(record[0]).ToString(),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetString(5),
                RowState.ModifiedNew
            );
        }


        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string quertString = $"select * from dbo.Заказчик";
            SqlCommand command = new SqlCommand(quertString, database.GetConnection());
            database.openConnection();
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
                database.openConnection();
                SqlCommand command = new SqlCommand("DELETE FROM dbo.Заказчик WHERE Id = @Id", connection);
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
                database.closedConnection();
            }
        }

    }
}