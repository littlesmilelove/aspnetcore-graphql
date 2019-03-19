using aspnetcore_graphql.Models;
using GraphQL.Types;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class OrderInputType : InputObjectGraphType<Order>
    {
        public OrderInputType()
        {
            Name = "OrderInput";
            
            Field<UserInputType>(nameof(Order.User));
            Field<ListGraphType<OrderItemInputType>>(nameof(Order.OrderItems));
        }
    }
}