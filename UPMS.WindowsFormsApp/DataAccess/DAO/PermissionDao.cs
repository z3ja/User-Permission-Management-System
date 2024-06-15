using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.Entity;

namespace UPMS.WindowsFormsApp.DataAccess.DAO
{
    public class PermissionDao
    {
        SqlConnection _connection = new SqlConnection(dbConnection.dbCon("upmsDB"));

        public DataTable SelectPermissionBasedOnUsername(string role_id)
        {
            DataTable dt = new DataTable();
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from permission_tb where role_id = @role_id");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@role_id", role_id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            _connection.Close();
            return dt;
        }
        public bool Save(PermissionEntity pe)
        {
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into permission_tb (role_id, button1, button2, button3, button4, button5) values (@rid, @b1, @b2, @b3, @b4, @b5)");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@rid", pe.Role_Id);
                cmd.Parameters.AddWithValue("@b1", pe.button1= true);
                cmd.Parameters.AddWithValue("@b2", pe.button2 = true);
                cmd.Parameters.AddWithValue("@b3", pe.button3 = true);
                cmd.Parameters.AddWithValue("@b4", pe.button4 = true);
                cmd.Parameters.AddWithValue("@b5", pe.button5 = true);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _connection.Close();
            return true;

        }
        public bool Edit(PermissionEntity pe)
        {
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update permission_tb set button1= @b1, button2= @b2, button3= @b3, button4= @b4, button5= @b5 where role_id=@role_id");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@role_id", pe.Role_Id);
                cmd.Parameters.AddWithValue("@b1", pe.button1);
                cmd.Parameters.AddWithValue("@b2", pe.button2);
                cmd.Parameters.AddWithValue("@b3", pe.button3);
                cmd.Parameters.AddWithValue("@b4", pe.button4);
                cmd.Parameters.AddWithValue("@b5", pe.button5);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _connection.Close();
            return true;
        }
    }
}
