using System.Data.SqlClient;
using System.Data;

namespace UPMS.WindowsFormsApp.DataAccess.DAO
{
    public class titleDao
    {
        SqlConnection _connection = new SqlConnection(dbConnection.dbCon("upmsDB"));
        public DataTable GetALL()
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From title_tb");
            cmd.Connection = _connection;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            _connection.Close();
            return dt;
        }

    }
}
