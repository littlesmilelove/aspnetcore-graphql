using aspnetcore_graphql.Models;
using GraphQL.Types;

namespace aspnetcore_graphql
{
    public class OrderItemType : ObjectGraphType<OrderItem>
    {
        public OrderItemType()
        {
            Name = "OrderItem";

            Field(d => d.Id).Description("The id of the orderitem");
            Field(d => d.Name, nullable: true).Description("The name of the orderitem");
            Field(d => d.Price).Description("The price of the orderitem");
        }
    }
}