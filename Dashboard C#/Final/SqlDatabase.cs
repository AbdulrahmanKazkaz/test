using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Final
{
    class SqlDatabase
    {

        // Define instance
            SqlConnection sqlCon;
            SqlCommand cmd;
            SqlDataAdapter sda;

        // Connection String Path
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Abdulrahman\Documents\Visual Studio 2017\Projects\Final\Database.mdf;Integrated Security=True";

        public SqlDatabase() //initialize Connection
        {
            sqlCon = new SqlConnection(connectionstring);
        }

        public SqlConnection con() // return Status Connection
        {
            sqlCon = new SqlConnection(connectionstring);
            return sqlCon;
        }

        public void Open()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }


        public void RunCommand(string qry)
        {
            cmd = new SqlCommand(qry, sqlCon);
            cmd.ExecuteScalar();
        }


        public int RunCommand_int(string qry)
        {
            cmd = new SqlCommand(qry, sqlCon);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }


        public string RunCommand_string(string qry)
        {
            cmd = new SqlCommand(qry, sqlCon);
            return Convert.ToString(cmd.ExecuteScalar());
        }


        public void DataAdapter(string qry)
        {
            sda = new SqlDataAdapter(qry, sqlCon);
        }

        public void Close()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }


    }
}
