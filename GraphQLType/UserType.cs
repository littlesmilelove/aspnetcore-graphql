using aspnetcore_graphql.Models;
using GraphQL.Types;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Name = "User";

            Field(d => d.Id).Description("The id of the user");
            Field(d => d.Name).Description("The name of the user");
        }
    }
}