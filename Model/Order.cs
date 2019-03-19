using System;

namespace aspnetcore_graphql.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreateTime { get; set; }
    }

    public enum OrderStatus
    {
        Active,
        Finish,
    }
}