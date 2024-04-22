using System.Data.SqlClient;

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
            Calculate();
            string FirstName = textBox1.Text;
            string LastName = textBox3.Text;
            string email = textBox4.Text;
            string orderName = textBox5.Text;
            string order = textBox2.Text;
            string Sqare = maskedTextBox1.Text;
            string status = comboBox1.Text;
            string totalPrice = totalPriceTextBox.Text;

            string queryString = $"INSERT INTO Закзачик (Название_проекта, Описание, Имя_заказчика, Фамилия_заказчика, Почта_заказчика, Площадь, Ремонт, Расчетн" +
                $"ая_стоимость) " +
                                 $"VALUES ('{orderName}', '{order}', '{FirstName}', '{LastName}', '{email}' , '{Sqare}' ,'{status}' ,'{totalPrice}') ";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            try
            {
                database.OpenConnection();
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"Ваша заявка успешно добавлена, с вами свяжутся в скором времени");
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                maskedTextBox1.Text = null;
                comboBox1.Text = null;
                totalPriceTextBox.Text = null;
                OrdersForm ordersForm = new OrdersForm();
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка при добавлении заявки: {ex.Message}");
            }

        }

        private void Calculate()
        {
            decimal Price = 0;
            if (decimal.TryParse(maskedTextBox1.Text, out decimal square))
            {
                string type = comboBox1.Text;
                if (type == "Обычный")
                {
                    Price = 1000000M;
                }
                else if (type == "Средний")
                {
                    Price = 3000000M;
                }
                else if (type == "Элитный")
                {
                    Price = 5000000M;
                }
                else
                {
                    MessageBox.Show("Invalid type selected.");
                }

                decimal totalPrice  = square * 690000 + Price;
                totalPriceTextBox.Text = $" {totalPrice}.00 ₸";
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }





        private void button2_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
