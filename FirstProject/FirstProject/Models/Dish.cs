using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Models
{
    public class Dish
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }

        public Dish()
        {
            Merchandises = new List<Merchandise>();
        }

        public ICollection<Merchandise> Merchandises { get; set; }
    }
}
