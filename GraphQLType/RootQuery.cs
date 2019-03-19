using System;
using GraphQL.Types;
using aspnetcore_graphql.Services;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class RootQuery : ObjectGraphType<object>
    {
        public RootQuery(OrderService service)
        {
            Name = "Query";

            Field<OrderType>(
                "order",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "id of the order" }
                ),
                resolve: context => service.GetOrder(context.GetArgument<int>("id"))
                );
        }
    }
}