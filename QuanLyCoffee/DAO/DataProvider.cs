using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {

        public SqlConnection cn;
        public DataProvider()
        {
            string cnStr = @"Data Source=DESKTOP-8916OSA\SQLEXPRESS2008;Initial Catalog=CoffeeShop;Integrated Security=True";
            cn = new SqlConnection(cnStr);
        }

        public void Connect()
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DisConnect()
        {
            if (cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }

        public int MyExecuteScalar(string sql)
        {
            Connect();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;

            int NumberOfRows = (int)cmd.ExecuteScalar();
            DisConnect();
            return NumberOfRows;
        }

        public DataTable GetTable(string sql)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            int numberOfRows = da.Fill(dt);
            if (numberOfRows > 0)
                return dt;
            else return null;
        }

        public SqlDataReader MyExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }

        public int MyExecuteNonQuery(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            int NumberOfRows = cmd.ExecuteNonQuery();

            DisConnect();
            return NumberOfRows;
        }
    }
    
}
