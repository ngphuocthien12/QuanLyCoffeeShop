using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class Food
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }

        public Food(string id, string name, int categoryId, float price)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryId = categoryId;
            this.Price = price;
        }
    }
}
