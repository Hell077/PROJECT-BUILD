using System.Data;
using System.Data.SqlClient;

namespace PROJECT_BUILD
{
    public partial class salaryTaxes : Form
    {
        Database database = new Database();
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        public salaryTaxes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salaryTaxes_Load(object sender, EventArgs e)
        {
        
            Database database = new Database();

    
            database.OpenConnection();

            try
            {
                string clearQuery = "TRUNCATE TABLE Зарплата";
                SqlCommand clearCommand = new SqlCommand(clearQuery, database.GetConnection());
                clearCommand.ExecuteNonQuery();

                // SQL-запрос для вставки данных из таблицы Сотрудники в таблицу Зарплата
                string query = @"
            INSERT INTO Зарплата (ID_сотрудника, Зарплата_до)
            SELECT ID_сотрудника, Зарплата
            FROM Сотрудники;
            ";
                SqlCommand command = new SqlCommand(query, database.GetConnection());
                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при добавлении данных в таблицу Зарплата: " + ex.Message, "Ошибка");
            }
            finally
            {

                database.CloseConnection();
            }


            CreateColumns();
            UpdateDataGridView(dataGridView1);
            dataGridView1.Dock = DockStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }




        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_operation", "ID_операции");
            dataGridView1.Columns.Add("ID_сотрудника", "ID сотрудника");
            dataGridView1.Columns.Add("Имя", "Имя сотрудника"); // Новый столбец для имени
            dataGridView1.Columns.Add("Фамилия", "Фамилия сотрудника"); // Новый столбец для фамилии
            dataGridView1.Columns.Add("Зарплата_до", "Изначальный оклад");
            dataGridView1.Columns.Add("ОМС", "ОМС");
            dataGridView1.Columns.Add("Пенсионные", "Пенсионные");
            dataGridView1.Columns.Add("ИПН", "ИПН");
            dataGridView1.Columns.Add("Результат", "Оклад после вычета налогов");
        }



        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear(); // Очищаем таблицу перед добавлением новых данных

            string queryString = "SELECT Зарплата.Id_operation, Сотрудники.ID_сотрудника, Сотрудники.Имя, Сотрудники.Фамилия, Сотрудники.Зарплата AS Зарплата_до, Зарплата.Зарплата_после AS Зарплата_после FROM Зарплата JOIN Сотрудники ON Зарплата.ID_сотрудника = Сотрудники.ID_сотрудника";

            using (SqlCommand command = new SqlCommand(queryString, database.GetConnection()))
            {
                database.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No rows found."); // Отладочный вывод, если нет строк
                }
                else
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ReadSingleRow: {reader["ID_сотрудника"]}"); // Отладочный вывод

                        ReadSingleRow(dgw, reader); // Добавляем данные каждого сотрудника в таблицу
                    }
                }

                reader.Close();
                database.CloseConnection();
            }
        }



        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            int idOperation = Convert.ToInt32(record["Id_operation"]);
            int idEmployee = Convert.ToInt32(record["ID_сотрудника"]);
            string firstName = record["Имя"].ToString(); // Чтение имени сотрудника
            string lastName = record["Фамилия"].ToString(); // Чтение фамилии сотрудника
            decimal salaryBefore = Convert.ToDecimal(record["Зарплата_до"]);

            decimal oms = salaryBefore * 0.03m;
            decimal pension = salaryBefore * 0.1m;
            decimal ipn = salaryBefore * 0.05m;

            // Вычисление значения Результата (оклад после вычета налогов)
            decimal salaryAfter = salaryBefore - oms - pension - ipn;

            // Добавляем строку в DataGridView
            dgw.Rows.Add(idOperation, idEmployee, firstName, lastName, salaryBefore, oms, pension, ipn, salaryAfter);
        }







        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
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
