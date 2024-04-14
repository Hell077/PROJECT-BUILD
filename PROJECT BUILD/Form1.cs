using System.Data.SqlClient;
using System.IO;
using System.Data;


namespace PROJECT_BUILD

{

    public partial class Identification : Form
    {
        Database database = new Database();
        public Identification()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            passwordbox.PasswordChar = '*';
            passwordbox.MaxLength = 50;
            loginbox.MaxLength = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();

        }

        private void Eye_Click(object sender, EventArgs e)
        {
            Eye.Visible = false;
            Eye_slash.Visible = true;
            passwordbox.PasswordChar = '\0';
        }

        private void Eye_slash_Click(object sender, EventArgs e)
        {
            Eye_slash.Visible = false;
            Eye.Visible = true;
            passwordbox.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Hide();
        }

        private void authorization_button_Click(object sender, EventArgs e)
        {
            var loginUser = loginbox.Text;
            var loginPassword = passwordbox.Text;


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"Select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{loginPassword}'";
            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Авторизация успешная");
                MainForm mainForm = new MainForm(loginUser);
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует,зарегистрируйтесь");
            }
            
        }
    }
}
