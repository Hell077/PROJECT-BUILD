using Guna.UI2.WinForms;
using System.Data.SqlClient;

namespace PROJECT_BUILD
{
    public partial class MainForm : Form
    {
        Database database = new Database();
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        public MainForm(string loginUser)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            string access = "";
            this.MinimizeBox = true;
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
                panel10.Visible = false;
                panel18.Visible = false;
                panel20.Visible = false;
            }
            if (access == "Manager")
            {
                panel10.Visible = false;
                panel18.Visible = false;
                panel3.Visible = false;
                panel20.Visible = false;
            }
            if (access == "User")
            {
                panel14.Visible = false;
                panel5.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
            }

        }
        private void LoadImageOnStartup(string loginUser)
        {
            if (database.DoesPhotoExist(loginUser))
            {
                string photoPath = database.GetPhotoPath(loginUser);
                if (!string.IsNullOrEmpty(photoPath))
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(photoPath);
                }
            }
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

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string selectedImagePath;
        private void ChangePhoto_LinkClicked(object sender, EventArgs e)
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

        private void iconButton8_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

