using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace seldin.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Senior Living"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Apartments"
                }
            };
        }
    }
}