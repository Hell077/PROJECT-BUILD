using Microsoft.VisualBasic.Logging;
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
    public partial class Rewiew : Form

    {
        Database database = new Database();
        int rating = 0;
        string name = "";
        string rewiew = "";


        public Rewiew()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            if (Rating1.Checked) { rating = 1; }
            if (Rating2.Checked) { rating = 2; }
            if (Rating3.Checked) { rating = 3; }
            if (Rating4.Checked) { rating = 4; }
            if (Rating5.Checked) { rating = 5; }

            RewievNameTextbox.Text = name;
            RewiewTextbox.Text = rewiew;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = RewievNameTextbox.Text;
            rewiew = RewiewTextbox.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(rewiew) && (Rating1.Checked || Rating2.Checked || Rating3.Checked || Rating4.Checked || Rating5.Checked))
            {
                string queryString = $"INSERT INTO Отзывы (Имя, Отзыв, rating) VALUES ('{name}', '{rewiew}', {rating})";

                using (SqlCommand command = new SqlCommand(queryString, database.GetConnection()))
                {
                    try
                    {
                        database.openConnection();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Отзыв успешно добавлен.");
                            RewievNameTextbox.Text = "";
                            RewiewTextbox.Text = "";
                            Rating1.Checked = false;
                            Rating2.Checked = false;
                            Rating3.Checked = false;
                            Rating4.Checked = false;
                            Rating5.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при добавлении отзыва.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                    finally
                    {
                        database.closedConnection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля и выберите рейтинг.");
            }
        }

    }
}
