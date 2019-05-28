using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int MerchandiseId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Merchandise Merchandise { get; set; }
        public virtual Order Order { get; set; }
    }
}
