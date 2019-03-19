using System;
using System.Collections.Generic;
using System.Linq;
using aspnetcore_graphql.Models;

namespace aspnetcore_graphql.Services
{
    public class OrderService
    {
        private List<Order> _orders = new List<Order>(){
            new Order{Id = 1, Amount = 100, Status = OrderStatus.Active, CreateTime = DateTime.Now},
            new Order{Id = 3, Amount = 500, Status = OrderStatus.Finish, CreateTime = DateTime.Now},
            new Order{Id = 2, Amount = 300, Status = OrderStatus.Finish, CreateTime = DateTime.Now},
            new Order{Id = 4, Amount = 700, Status = OrderStatus.Active, CreateTime = DateTime.Now},
        };

        public OrderService()
        {
        }

        public Order GetOrder(int Id)
        {
            return _orders.FirstOrDefault(d => d.Id == Id);
        }
    }
}