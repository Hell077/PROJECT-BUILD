using System;
using System.Data.SqlClient;

namespace PROJECT_BUILD
{
    internal class Database
    {
        private SqlConnection sqlConnection;

        public Database()
        {
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


        public string GetPhotoPath(string loginUser)
        {
            string query = "SELECT photo_user FROM register WHERE login_user = @LoginUser";
            string photoPath = "";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@LoginUser", loginUser);
                OpenConnection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        photoPath = reader["photo_user"].ToString();
                    }
                }

                CloseConnection();
            }

            return photoPath;
        }

        public bool DoesPhotoExist(string loginUser)
        {
            string query = "SELECT COUNT(*) FROM register WHERE login_user = @LoginUser AND photo_user IS NOT NULL";
            int count = 0;

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@LoginUser", loginUser);
                OpenConnection();
                count = (int)command.ExecuteScalar();
                CloseConnection();
            }

            return count > 0;
        }


        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
