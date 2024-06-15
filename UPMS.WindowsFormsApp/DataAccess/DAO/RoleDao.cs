using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.Entity;

namespace UPMS.WindowsFormsApp.DataAccess.DAO
{
    public class RoleDao
    {
        SqlConnection _connection = new SqlConnection(dbConnection.dbCon("upmsDB"));
        RoleEntity re = new RoleEntity();

        public DataTable GetALL()
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From role_tb");
            cmd.Connection = _connection;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            _connection.Close();
            return dt;
        }
        public DataTable GetAllActiveUserData()
        {
            _connection.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT role_tb.rid, role_tb.role_name, user_tb.is_active FROM role_tb INNER JOIN user_tb ON role_tb.rid=user_tb.role_id WHERE user_tb.is_active=1");
                cmd.Connection = _connection;
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
        public void GetSearch(string search, DataGridView dgv)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM role_tb where concat(rid, role_name) LIKE '%" + search + "%' ");
            cmd.Connection = _connection;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
            _connection.Close();
        }

        public bool Save(RoleEntity re)
        {
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into role_tb (role_name) values (@rolename)");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@rolename", re.RoleName);
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

        public bool Edit(RoleEntity re)
        {
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update role_tb set role_name=@rolename where rid=@rid");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@rid", re.RId);
                cmd.Parameters.AddWithValue("@rolename", re.RoleName);
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

        public bool Delete(RoleEntity re)
        {
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete from role_tb where rid=@rid");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@rid", re.RId);
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
