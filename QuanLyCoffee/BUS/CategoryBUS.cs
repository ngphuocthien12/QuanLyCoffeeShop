using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
   public class CategoryBUS
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public List<Category> LoadCategory()
        {
            return categoryDAO.LoadCategory();
        }
    }
}
