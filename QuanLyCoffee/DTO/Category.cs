using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Category
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Category(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
