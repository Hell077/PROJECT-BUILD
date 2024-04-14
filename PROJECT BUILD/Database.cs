using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace PROJECT_BUILD
{
    internal class Database
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=AlexPC;Initial Catalog = Строй_Фирма; Integrated Security=True");
       
        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed){
               sqlConnection.Open();
            }
            
        }

        public void closedConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }


        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
            
        



    }
}
