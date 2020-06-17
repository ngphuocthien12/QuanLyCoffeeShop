using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DAO
{
    public class UserDAO : DataProvider
    {
        public bool Login(string user, string pass)
        {
            string sql = "SELECT COUNT(UserName) FROM Users WHERE UserName = '" + user + "' AND Password = '" + pass + "'";
            int NumberOfRows = MyExecuteScalar(sql);
            if (NumberOfRows > 0)
                return true;
            else return false;
        }
    }
}

