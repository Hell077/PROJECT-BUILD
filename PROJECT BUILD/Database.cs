﻿using System;
using System.Data.SqlClient;

namespace PROJECT_BUILD
{
    internal class Database
    {
        private SqlConnection sqlConnection;

        public Database()
        {
            // Инициализация свойства ConnectionString
            sqlConnection = new SqlConnection(@"Data Source=AlexPC;Initial Catalog = Строй_Фирма; Integrated Security=True");
        }

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public void SavePhotoPath(string photoPath, string loginUser)
        {
            string query = "UPDATE register SET photo_user = @PhotoPath WHERE login_user = @LoginUser";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@PhotoPath", photoPath);
                command.Parameters.AddWithValue("@LoginUser", loginUser);

                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
