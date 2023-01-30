using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryapp.Functions
{
    public class db
    {
     
            public static DataTable allinventory (SqlConnection db)
        {
            SqlDataAdapter command = new SqlDataAdapter("SELECT * FROM C_INVENTORY", db);
            DataSet dataset = new DataSet();
            command.Fill(dataset);
            var table = dataset.Tables[0];
            return table;
        }
        public static SqlCommand commandRole(SqlConnection db)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM C_ROLES", db);
            return command;
        }
        public static SqlConnection Conns()
        {
            SqlConnection connection = new SqlConnection();

            //connection.ConnectionString = "Server=appserver32.ddns.net;Database=master;Trusted_Connection=false;User Id=user12;Password=Alejandro12;";
            connection.ConnectionString = "Server=YAEN-PC;Database=master;Trusted_Connection=true;User Id=user12;Password=Alejandro12;";
   
            try
            {
                connection.Open();
               
            }
            catch (SqlException es)
            {
                connection.Close();
                MessageBox.Show(es.ToString(), "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

            return connection;
        }
    }
}
