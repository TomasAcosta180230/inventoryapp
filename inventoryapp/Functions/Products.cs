using inventoryapp.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static inventoryapp.Functions.Scan;

namespace inventoryapp.Functions
{
    public class Products
    {
       
        public static string insertinsertnewqty(SqlConnection db, string ID)
        {
            valuesBool valBool = new valuesBool();
            DateTime currentTime = DateTime.Now;
            string sql = "SELECT QTY FROM C_INVENTORY WHERE ITEM_ID = @ID";
            SqlCommand cmd = new SqlCommand(sql, db);
            cmd.Parameters.AddWithValue("@ID", ID);
            var resultS = (int)cmd.ExecuteScalar();
            int result = 0;
            string sqlS = "UPDATE C_INVENTORY SET QTY = @resultS WHERE ITEM_ID = @ID";
            using (SqlCommand commmand1 = new SqlCommand(sqlS, db))
            {
                commmand1.Parameters.AddWithValue("@ID", ID);
                commmand1.Parameters.AddWithValue("@resultS", resultS + 1);

                result = (int)commmand1.ExecuteNonQuery();
            }
            if (result != null)
            {
                return valBool.YES();
                Scan scan = new Scan();
                scan.donelabel.Visible = true;
                scan.donelabel.Text = "Succesfuly added";
            }
            else
            {

                return valBool.NO();
            }

        }

            public static string checkifitemisregister(SqlConnection db, string ID)
        {
            valuesBool valBool = new valuesBool();
            string sql = "SELECT ID FROM C_ITEMS_INV WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(sql, db);
            cmd.Parameters.AddWithValue("@ID", ID);
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

            public static string checkifproductexist(SqlConnection db, string ID)
        {
            valuesBool valBool = new valuesBool();
            string sql = "SELECT ITEM_NAME FROM C_INVENTORY WHERE ITEM_ID = @ID";
            SqlCommand cmd = new SqlCommand(sql, db);
            cmd.Parameters.AddWithValue("@ID", ID);
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
        public static string insertnewproducts(SqlConnection db, string id, string Item_Name, string desc, string price, int qty)
        {
            valuesBool valBool = new valuesBool();
            DateTime currentTime = DateTime.Now;
            int result = 0;
            string sql = "INSERT INTO C_INVENTORY VALUES" +
                "(@ID,@Item_Name,@Desc,@price,@Edit_Time,@qty)";
            using (SqlCommand commmand1 = new SqlCommand(sql, db))
            {
                commmand1.Parameters.AddWithValue("@ID", id);
                commmand1.Parameters.AddWithValue("@Item_Name", Item_Name);
                commmand1.Parameters.AddWithValue("@Desc", desc);
                commmand1.Parameters.AddWithValue("@price", price);
                commmand1.Parameters.AddWithValue("@Edit_Time", currentTime);
                commmand1.Parameters.AddWithValue("@qty", qty);

                result = (int)commmand1.ExecuteNonQuery();
            }



            if (result > 0)
            {
                return valBool.YES();
            }
            else
            {
                MessageBox.Show("No ingreso ningun producto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return valBool.NO();
            }

        }
    }
}
