using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;


namespace DAO
{
   public class CategoryDAO:DataProvider
    {
       public List<Category> LoadCategory()
       {
           Connect();
           string sql = "SELECT * FROM ProductCategory";
           SqlDataReader dr = MyExecuteReader(sql);
           List<Category> list = new List<Category>();
           string id, name;
           while (dr.Read())
           {
               id = dr[0].ToString();
               name = dr[1].ToString();
               Category s = new Category(id, name);
               list.Add(s);

           }
           dr.Close();
           DisConnect();
           return list;


       }
    }
}
