using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace PROJECT_BUILD

{

    public partial class Identification : Form
    {
        Database database = new Database();
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        public Identification()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            passwordbox.PasswordChar = '*';
            passwordbox.MaxLength = 50;
            loginbox.MaxLength = 20;
            this.FormBorderStyle = FormBorderStyle.None;
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


            if (string.IsNullOrEmpty(loginUser) || string.IsNullOrEmpty(loginPassword))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль");
                return;
            }

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
                loginbox.Text = null;
                passwordbox.Text = null;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
    }
}
