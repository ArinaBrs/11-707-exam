using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Models;
using FirstProject.Interfaces;

namespace FirstProject.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
