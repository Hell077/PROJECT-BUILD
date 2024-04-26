﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROJECT_BUILD
{
    public partial class Statistic : Form
    {
        Database database = new Database();
        public Statistic()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            CreateColumns();
            UpdateDataGridView(dataGridView1);
            PopulateChart();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("second_name", "Фамилия");
            dataGridView1.Columns.Add("job_title", "Должность");
            dataGridView1.Columns.Add("Salary", "Зарплата");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.IsDBNull(1) ? string.Empty : record.GetString(1),
                record.IsDBNull(2) ? string.Empty : record.GetString(2),
                record.IsDBNull(3) ? string.Empty : record.GetString(3),
                record.IsDBNull(4) ? 0 : record.GetDecimal(4)
            );
        }

        private void UpdateDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string quertString = $"select * from dbo.Сотрудники";
            SqlCommand command = new SqlCommand(quertString, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }

        private void PopulateChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Зарплата");

            string quertString = $"select ID_сотрудника, Зарплата from dbo.Сотрудники";
            SqlCommand command = new SqlCommand(quertString, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["Зарплата"].Points.AddXY(reader.GetInt32(0), reader.GetDecimal(1));
            }
            reader.Close();
        }
    }
}