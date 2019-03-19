using GraphQL.Types;
using aspnetcore_graphql.Models;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType()
        {
            Name = "Order";

            Field(d => d.Id).Description("The id of the order.");
            Field(d => d.Amount).Description("The amount of the order.");
            Field(d => d.CreateTime).Description("The createTime of the order.");

            Field<OrderStatusEnum>("status", "The status of the order.");

            Field<UserType>("user", "The user of the order.");
            Field<ListGraphType<OrderItemType>>("orderItems", "the orderItems of the order.");
        }
    }

    public class OrderStatusEnum : EnumerationGraphType<OrderStatus>
    {
    }
}