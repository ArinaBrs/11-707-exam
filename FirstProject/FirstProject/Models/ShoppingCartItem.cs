using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public Merchandise Merchandise { get; set; }

        public int MerchandiseId { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

    }
}
