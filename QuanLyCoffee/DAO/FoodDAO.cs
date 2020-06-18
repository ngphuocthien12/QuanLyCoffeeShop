using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
  public  class FoodDAO:DataProvider
    {
      public List<Food> LoadFood(string id)
      {
          Connect();
          int categoryId;
          string name;
          float price;
          string sql = "select * from Product where categoryId = '" + id + "'";
          SqlDataReader dr = MyExecuteReader(sql);
          List<Food> list = new List<Food>();

          while (dr.Read())
          {
              id = dr[0].ToString();
              name = dr[1].ToString();
              categoryId = Int32.Parse(dr[2].ToString());
              price = float.Parse(dr[3].ToString());
              Food f = new Food(id, name, categoryId, price);
              list.Add(f);

          }
          dr.Close();
          DisConnect();
          return list;


      }
    }
}
