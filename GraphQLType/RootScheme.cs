using GraphQL;
using GraphQL.Types;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class RootScheme : Schema
    {
        public RootScheme(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<RootQuery>();
            Mutation = resolver.Resolve<RootMutation>();
        }
    }
}