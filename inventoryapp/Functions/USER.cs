using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace inventoryapp.Functions
{
    public class USER
    {

        public static string logiUser(string user, string pass,SqlConnection db)
        {
            valuesBool valBool = new valuesBool();
            string sql = "SELECT COUNT(*) FROM C_USER WHERE username = @user AND Contrasena = @pass";
            SqlCommand command = new SqlCommand(sql, db);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            int result = (int)command.ExecuteScalar();
            if (result > 0)
            {
                return valBool.YES();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contrasena incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return valBool.NO();
            }
        }

    }
}
