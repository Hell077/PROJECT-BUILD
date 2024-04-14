using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PROJECT_BUILD;
using System.Diagnostics.Eventing.Reader;


namespace PROJECT_BUILD
{

    public partial class MainForm : Form
    {
        public MainForm(string loginUser)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MessageBox.Show($"Добро пожаловать, {loginUser}!");

            string level = "";
            if (loginUser == "admin")
            {
                level = "admin";
            }
            else if (loginUser == "accountant")
            {
                level = "accountant";
            }
            else
            {
                level = "user";
            }


            label1.Text = $"Ваш уровень доступа {level}";
            label2.Visible = false;

            if (loginUser == "admin")
            {
                label2.Visible = true;
                button6.Visible = false;
            }
            else if (loginUser == "accountant")
            {
                button6.Visible = false;
                button1.Enabled = false;
            }
            else
            {
                button6.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
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
    }
}
