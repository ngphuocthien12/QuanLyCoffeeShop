using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
   public class FoodBUS
    {
        FoodDAO foodDAO = new FoodDAO();
        public List<Food> LoadFood(string id)
        {
            return foodDAO.LoadFood(id);
        }
    }
}
