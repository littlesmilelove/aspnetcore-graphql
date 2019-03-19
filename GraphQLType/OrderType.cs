using GraphQL.Types;
using aspnetcore_graphql.Models;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType()
        {
            Name = "Order";

            Field(d=>d.Id).Description("The id of the order.");
            Field(d=>d.Amount).Description("The amount of the order.");
            // Field(d=>d.Status).Description("The status of the order.");
            Field(d=>d.CreateTime).Description("The createTime of the order.");
        }
    }
}