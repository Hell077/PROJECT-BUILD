using System.Data.SqlClient;

namespace PROJECT_BUILD
{
    public partial class MainForm : Form
    {
        Database database = new Database();

        public MainForm(string loginUser)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            string access = ""; 

            label4.Text = loginUser;
           

            try
            {
                string queryString = "SELECT user_access FROM register WHERE login_user = @loginUser";
                using (SqlCommand command = new SqlCommand(queryString, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@loginUser", loginUser);

                    database.OpenConnection();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        access = reader.GetString(0); 
                        label1.Text = $"Ваш уровень доступа {access}";
                        label2.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден в базе данных.");
                    }
                    reader.Close();
                    database.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении данных из базы данных: " + ex.Message);
            }

            LoadImageOnStartup(loginUser);
            if (access == "Admin")
            {
                button6.Visible = false;
                button5.Visible = false;
            }
            if (access == "Manager")
            {
                button6.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
            }
            if (access == "User")
            {
                button4.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
            }

        }




        private void LoadImageOnStartup(string loginUser)
        {
            if (database.DoesPhotoExist(loginUser))
            {
                string photoPath = database.GetPhotoPath(loginUser);
                if (!string.IsNullOrEmpty(photoPath))
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = Image.FromFile(photoPath);
                }
            }
        }



        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, groupBox2.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeForm employee = new employeeForm();
            employee.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrdersList ordersList = new OrdersList();
            ordersList.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginListForm loginListForm = new LoginListForm();
            loginListForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rewiew rewiew = new Rewiew();
            rewiew.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private string selectedImagePath;
        private void ChangePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.jpg;*.png)|*.jpg;*.png|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                string loginUser = label4.Text;
                database.SavePhotoPath(selectedImagePath, loginUser);
                LoadImageFromDatabase(loginUser);
            }
            else
            {
                MessageBox.Show("Ошибка при выборе изображения");
            }
        }

        private void LoadImageFromDatabase(string loginUser)
        {
            string photoPath = database.GetPhotoPath(loginUser);
            if (!string.IsNullOrEmpty(photoPath))
            {
                pictureBox1.Image = Image.FromFile(photoPath);
            }
            else
            {
                MessageBox.Show("Изображение не найдено для данного пользователя");
            }
        }



        //styles
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightGray;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Silver;
        }

        private void button5_MouseEnter_1(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGray;
        }

        private void button5_MouseLeave_1(object sender, EventArgs e)
        {
            button5.BackColor = Color.Silver;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Silver;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightGray;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Silver;
        }
    }
}
