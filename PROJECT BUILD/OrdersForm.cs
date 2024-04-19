using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT_BUILD
{
    public partial class OrdersForm : Form
    {
        Database database = new Database();

        public OrdersForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = textBox1.Text;
            string LastName = textBox3.Text;
            string email = textBox4.Text;
            string orderName = textBox5.Text;
            string order = textBox2.Text;

            string queryString = $"INSERT INTO Заказчик (Название_проекта, Описание, Имя_заказчика, Фамилия_заказчика, Почта_заказчика) " +
                                 $"VALUES ('{orderName}', '{order}', '{FirstName}', '{LastName}', '{email}')";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            try
            {
                database.openConnection();
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"Ваша заявка успешно добавлена, с вами свяжутся в скором времени");
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text= null;
                textBox5.Text = null;
                OrdersForm ordersForm = new OrdersForm();
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка при добавлении заявки: {ex.Message}");
            }
            
        }
    }
}
