using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data;
namespace BUS
{
    public class ItemBUS
    {
        ItemDAO item = new ItemDAO();
        public DataTable Get(int tableID)
        {
            return item.Get(tableID);
        }
    }
}
