using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAO
{
   public class userDAO
    {
        private static userDAO instance;

        public static userDAO Instance
        {
            get { if (instance == null) instance = new userDAO(); return instance; }
            private set { instance = value; }
        }

        private userDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT COUNT(UserName) FROM Users WHERE UserName = '" + userName + "' AND Password = '" + passWord + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            
            return result.Rows.Count > 0;
        }
    }
    }
