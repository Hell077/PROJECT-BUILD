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
using System.Windows.Media;

namespace PROJECT_BUILD
{
    public partial class Registration : Form
    {
        Database database = new Database();
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        public Registration()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Password2.PasswordChar = '*';
            Password3.PasswordChar = '*';
            Password2.MaxLength = 50;
            Password3.MaxLength = 50;
        }

        private void Eye_slash_Click(object sender, EventArgs e)
        {
            Eye_slash.Visible = false;
            Eye.Visible = true;
            Password2.PasswordChar = '*';
            Password3.PasswordChar = '*';
        }

        private void Eye_Click(object sender, EventArgs e)
        {
            Eye.Visible = false;
            Eye_slash.Visible = true;
            Password2.PasswordChar = '\0';
            Password3.PasswordChar = '\0';
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            var login = loginbox.Text;
            var password2 = Password2.Text;
            var password3 = Password3.Text;
            string access = "User";

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password2) && !string.IsNullOrEmpty(password3) && password2 == password3)
            {
                if (!checkuser())
                {
                    string queryString = $"Insert into register (login_user, password_user, user_access) values('{login}', '{password2}', '{access}')";
                    SqlCommand command = new SqlCommand(queryString, database.GetConnection());
                    database.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Регистрация выполнена успешно");
                        Identification identification = new Identification();
                        identification.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Регистрация не удалась");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно");
            }
        }

        private bool checkuser()
        {
            var loginUser = loginbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            Close();
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
    }
}
