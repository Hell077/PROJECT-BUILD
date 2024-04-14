using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using PROJECT_BUILD;
using System.Drawing.Text;

namespace PROJECT_BUILD
{
    public partial class Registration : Form
    {
        Database database = new Database();
        public Registration()
        {

            InitializeComponent();
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


            string queryString = $"Insert into register (login_user, password_user) values('{login}', '{password2}')";


            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();



            if (command.ExecuteNonQuery() == 1 &&
                !string.IsNullOrEmpty(login) &&
                !string.IsNullOrEmpty(password2) &&
                !string.IsNullOrEmpty(password3) &&
                password2 == password3
                )
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
        private Boolean checkuser()
        {
            var loginUser = loginbox.Text;
            var passwordUser = Password2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user,  from register where login_user = '{loginUser} password_user = '{passwordUser}'";
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
            Identification identification = new Identification();
            identification.Show(); 
            Close();
        }
    }
}
