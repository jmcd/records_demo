namespace Records;

using System.Collections.Generic;
using System.Threading.Tasks;

public class UseCaseCommands
{
    public class User { }

    // Mediatr handler
    public class GetFilteredUsers
    {
        public class Query
        {
            private readonly string role;

            public Query(string nameContains, string role)
            {
                this.role = role;
                NameContains = nameContains;
            }

            public string NameContains { get; }
        }

        public class Handler
        {
            public Task<IEnumerable<User>> Handle(Query query) => throw new("");
        }
    }
}