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
using System.Windows.Media;

namespace PROJECT_BUILD
{
    public partial class OrderStatusUser : Form
    {
        Database database = new Database();
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        private string loginuser;
        public OrderStatusUser(string loginuser)
        {
            InitializeComponent();
            this.loginuser = loginuser;
            label2.Text = loginuser;
            CreateColumns();
            UpdateDataGridView(dataGridView1);
        }


        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_заказчика", "Ваш ID");
            dataGridView1.Columns.Add("Статус", "Статус");
            dataGridView1.Columns.Add("userLogin", "Имя аккаунта");
            dataGridView1.Columns.Add("Название_проекта", "Название_проекта");
            dataGridView1.Columns.Add("Описание_проекта", "Описание_проекта");
            dataGridView1.Columns.Add("Имя_заказчика", "Имя");
            dataGridView1.Columns.Add("Фамилия_заказчика", "Фамилия");
            dataGridView1.Columns.Add("Почта_заказчика", "Почта");
            dataGridView1.Columns.Add("Площадь", "Площадь");
            dataGridView1.Columns.Add("Ремонт", "Ремонт");
            dataGridView1.Columns.Add("Расчётная_стоимость", "Расчётная стоимость");
            

        }

        private void ReadSinglRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(10),
                record.GetString(9),  
                record.GetString(1),  
                record.GetString(2), 
                record.GetString(3),  
                record.GetString(4),  
                record.GetString(5),  // Почта_заказчика
                record.GetInt32(6),   // Площадь
                record.GetString(7),  // Ремонт
                record.GetString(8)  // Расчетная_стоимость
                
           );
        }


        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string userLogin = label2.Text; // Получаем текст из label2
            string queryString = $"SELECT * FROM dbo.Заказчик WHERE userLogin = '{userLogin}'"; // Добавляем кавычки вокруг userLogin
            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRows(dgw, reader); // Исправлено на ReadSingleRow
            }
            reader.Close();
        }




        private void iconButton1_Click(object sender, EventArgs e)
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
