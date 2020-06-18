using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data;

namespace BUS
{
   public class TableBUS
    {
        TableDAO tb = new TableDAO();
        public DataTable Get()
        {
            return tb.Get();
        }
    }
}
