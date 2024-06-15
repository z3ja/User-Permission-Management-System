using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.Entity;

namespace UPMS.WindowsFormsApp.DataAccess.DAO
{
    public class UserDao
    {

        SqlConnection _connection = new SqlConnection(dbConnection.dbCon("upmsDB"));
        

        public DataTable GetALL()
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("select u.[uid], r.role_name, u.username, u.[password], u.is_active from user_tb u inner join role_tb r on u.role_id=r.rid");
            cmd.Connection = _connection;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            _connection.Close();
            return dt;
        }
        public DataTable GetAccessUser(UserEntity ue)
        {
            _connection.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM user_tb u INNER JOIN role_tb r ON u.role_id = r.rid INNER JOIN permission_tb p ON p.role_id = r.rid WHERE u.username = @username AND u.password = @password AND u.is_active = 1");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@username", ue.UserName);
                cmd.Parameters.AddWithValue("@password", ue.Password);
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
            SqlCommand cmd = new SqlCommand("SELECT user_tb.[uid], role_tb.role_name, user_tb.username, user_tb.[password], user_tb.is_active FROM user_tb INNER JOIN role_tb ON user_tb.role_id=role_tb.rid WHERE concat(uid , [role_name], username, [password], is_active ) LIKE '%" + search + "%' ");
            cmd.Connection = _connection;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
            _connection.Close();
        }

        public bool Save(UserEntity ue)
        {
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into user_tb ([role_id], username, [password], is_active) values (@rid, @username, @password, @isactive)");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@rid", ue.RId);
                cmd.Parameters.AddWithValue("@username", ue.UserName);
                cmd.Parameters.AddWithValue("@password", ue.Password);
                cmd.Parameters.AddWithValue("@isactive", ue.IsAdmin);
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

        public bool Edit(UserEntity ue)
        {
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update user_tb set [role_id]=@rid, username=@username, [password]=@password, is_active=@isactive where [uid]=@uid");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@uid", ue.UId);
                cmd.Parameters.AddWithValue("@rid", ue.RId);
                cmd.Parameters.AddWithValue("@username", ue.UserName);
                cmd.Parameters.AddWithValue("@password", ue.Password);
                cmd.Parameters.AddWithValue("@isactive", ue.IsAdmin);
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

        public bool Delete(UserEntity ue)
        {
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete from user_tb where [uid]=@uid");
                cmd.Connection = _connection;
                cmd.Parameters.AddWithValue("@uid", ue.UId);
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
