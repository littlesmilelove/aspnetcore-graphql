using aspnetcore_graphql.Models;
using aspnetcore_graphql.Services;
using GraphQL.Types;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class RootMutation:ObjectGraphType
    {
        public RootMutation(OrderService service)
        {
            Name = "Mutation";

            Field<OrderType>(
                "createOrder",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<OrderInputType>>{Name = "order"}
                ),
                resolve: context => 
                {
                    var order = context.GetArgument<Order>("order");
                    return service.AddOrder(order);
                }
            );
        }
    }
}