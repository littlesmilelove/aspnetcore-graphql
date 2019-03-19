using aspnetcore_graphql.Models;
using GraphQL.Types;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class OrderInputType : InputObjectGraphType<Order>
    {
        public OrderInputType()
        {
            Name = "OrderInput";
            
            Field<UserInputType>(nameof(Order.User), "The user of the order.");
            Field<ListGraphType<OrderItemInputType>>(nameof(Order.OrderItems), "The orderItems of the order.");
        }
    }
}