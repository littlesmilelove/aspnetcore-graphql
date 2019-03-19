using aspnetcore_graphql.Models;
using GraphQL.Types;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class OrderItemInputType : InputObjectGraphType<OrderItem>
    {
        public OrderItemInputType()
        {
            Name = "OrderItem";

            Field(d => d.Id);
            Field(d => d.Name);
            Field(d => d.Price);
        }
    }
}