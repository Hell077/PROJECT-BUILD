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
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        public Rewiew()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
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
                        database.OpenConnection();
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
                        database.CloseConnection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля и выберите рейтинг.");
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
