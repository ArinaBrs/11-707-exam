using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Interfaces;
using FirstProject.Models;

namespace FirstProject.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DBContext context;
        private readonly ShoppingCart shoppingCart;

        public OrderRepository(DBContext appDbContext, ShoppingCart shoppingCart)
        {
            this.context = appDbContext;
            this.shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            context.Orders.Add(order);

            var shoppingCartItems = shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    MerchandiseId = shoppingCartItem.Merchandise.Id,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Merchandise.Price
                };

                context.OrderDetails.Add(orderDetail);
            }

            context.SaveChanges();
        }
    }
}
