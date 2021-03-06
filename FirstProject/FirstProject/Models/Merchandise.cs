﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Models
{
    public class Merchandise
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        public string ShortDescription { get; set; }

        public int DishID { get; set; }
        public Dish Dish { get; set; }
    }
}
