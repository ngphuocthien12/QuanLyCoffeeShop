using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
namespace BUS
{
   public class UserBUS
    {
        UserDAO u = new UserDAO();

        public bool Login(string user, string pass)
        {
            return u.Login(user, pass);
        }
    }
}
