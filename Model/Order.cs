using System;
using System.Collections.Generic;
using System.Linq;

namespace aspnetcore_graphql.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount => OrderItems == null ? 0 : OrderItems.Sum(d => d.Price);
        public OrderStatus Status { get; set; }
        public DateTime CreateTime { get; set; }
        public User User { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public enum OrderStatus
    {
        Active,
        Finish,
    }
}