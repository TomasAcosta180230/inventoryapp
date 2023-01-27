using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace inventoryapp.Functions
{
    public class USER
    {
        public static string checkifexistuser(string conc, SqlConnection db)
        {
            valuesBool valBool = new valuesBool();
            string sql = "SELECT ID FROM C_USER WHERE username = @username";
            SqlCommand cmd = new SqlCommand(sql, db);
            cmd.Parameters.AddWithValue("@username", conc);
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return valBool.YES();
            }
            else
            {
                
                return valBool.NO();
            }


           
        }

            public static string createuser(string name,string lastname, SqlConnection db)
        {
            var us = "";
            us = name.Substring(0, 2) + lastname.Substring(0, 5);
            return us;
        }

            public static string roleid(string role,SqlConnection db)
        {
            valuesBool valBool = new valuesBool();
            string sql = "SELECT ID FROM C_ROLES WHERE Role_Name = @role";
            SqlCommand cmd = new SqlCommand(sql, db);
            cmd.Parameters.AddWithValue("@role", role);
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contrasena incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return valBool.NO();
            }

        }

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
        public static string createUser(string name,string lastname,string pass,string role, SqlConnection db)

        {

            valuesBool valBool = new valuesBool();
            SqlCommand command = new SqlCommand("sp_createid", db);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@NAME", "C_USER");
            var id = command.ExecuteScalar();
            int result = 0;
            var conc = createuser(name, lastname,db);
            var conccheck =  checkifexistuser(conc, db);
            if (conccheck == "1")
            {
                MessageBox.Show("Usuario ya registrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return valBool.NO();
            }
            DateTime currentTime = DateTime.Now;
            string sql = "INSERT INTO C_USER (ID,Name,apellido,username,Contrasena,EDIT_TIME,active,ROLE_ID) VALUES" +
                "(@ID,@Name,@lastname,@username,@pass,@time,@active,@role)";
            using (SqlCommand commmand1 = new SqlCommand(sql, db))
            {
                commmand1.Parameters.AddWithValue("@ID", id);
                commmand1.Parameters.AddWithValue("@Name", name);
                commmand1.Parameters.AddWithValue("@lastname", lastname);
                commmand1.Parameters.AddWithValue("username", conc.ToLower());
                commmand1.Parameters.AddWithValue("@pass", pass);
                commmand1.Parameters.AddWithValue("@time", currentTime);
                commmand1.Parameters.AddWithValue("@active", "1");
                commmand1.Parameters.AddWithValue("@role", role);
                result = (int)commmand1.ExecuteNonQuery();
            }
                
            

            if (result > 0)
            {
                return valBool.YES();
            }
            else
            {
                MessageBox.Show("No se creo el usuario intente nuevamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return valBool.NO();
            }

        }
    }
}
