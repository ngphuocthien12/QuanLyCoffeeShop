using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAO
{
    public class ItemDAO:DataProvider
    {
        public DataTable Get(int tableID)
        {
            string sql = "SELECT i.productId, i.quantity, p.sellingPrice, i.quantity * p.sellingPrice AS TTien FROM Orders o, OrderItem i, Product p WHERE i.orderId  = o.id AND i.productId = p.id and tableId = '" + tableID + "'";
            return GetTable(sql);
        }
    }
}
