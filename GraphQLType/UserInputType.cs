using aspnetcore_graphql.Models;
using GraphQL.Types;

namespace aspnetcore_graphql.GraphQLTypes
{
    public class UserInputType : InputObjectGraphType<User>
    {
        public UserInputType()
        {
            Name = "UserInput";

            Field(d => d.Id);
            Field(d => d.Name);
        }
    }
}