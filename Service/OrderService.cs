using System;
using System.Collections.Generic;
using System.Linq;
using aspnetcore_graphql.Models;

namespace aspnetcore_graphql.Services
{
    public class OrderService
    {
        private List<Order> _orders = new List<Order>(){
            new Order{Id = 1, Status = OrderStatus.Active, CreateTime = DateTime.Now,
            User = new User{Id = 2, Name = "yaozheng",},
            OrderItems = new List<OrderItem>{
                new OrderItem{
                    Id = 3,
                    Price = 32.5m,
                },
                new OrderItem{
                    Id = 5,
                    Price = 62.5m,
                },
                new OrderItem{
                    Id = 7,
                    Price = 232.5m,
                },
            },},
            new Order{Id = 3, Status = OrderStatus.Finish, CreateTime = DateTime.Now,
            User = new User{Id = 2, Name = "xiaofeng",},
            OrderItems = new List<OrderItem>{
                new OrderItem{
                    Id = 3,
                    Price = 63.5m,
                },
                new OrderItem{
                    Id = 5,
                    Price = 98.5m,
                },
                new OrderItem{
                    Id = 9,
                    Price = 66.5m,
                },
            },},
            new Order{Id = 2, Status = OrderStatus.Finish, CreateTime = DateTime.Now,
            User = new User{Id = 2, Name = "guanghua",},
            OrderItems = new List<OrderItem>{
                new OrderItem{
                    Id = 3,
                    Price = 21.5m,
                },
                new OrderItem{
                    Id = 5,
                    Price = 63.5m,
                },
                new OrderItem{
                    Id = 11,
                    Price = 44.5m,
                },
            },},
            new Order{Id = 4, Status = OrderStatus.Active, CreateTime = DateTime.Now,
            User = new User{Id = 2, Name = "jianquan",},
            OrderItems = new List<OrderItem>{
                new OrderItem{
                    Id = 3,
                    Price = 55.5m,
                },
                new OrderItem{
                    Id = 5,
                    Price = 25.5m,
                },
                new OrderItem{
                    Id = 6,
                    Price = 87.5m,
                },
            },},
        };

        public OrderService()
        {
        }

        public Order GetOrder(int Id)
        {
            return _orders.FirstOrDefault(d => d.Id == Id);
        }

        public Order AddOrder(Order order)
        {
            order.Id = new Random().Next(100);
            order.CreateTime = DateTime.Now;
            order.Status = OrderStatus.Active;

            _orders.Add(order);

            return order;
        }
    }
}