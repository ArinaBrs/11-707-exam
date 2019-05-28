using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }

        public Restaurant()
        {
            Dishes = new List<Dish>();
        }

        public ICollection<Dish> Dishes { get; set; }
    }
}
