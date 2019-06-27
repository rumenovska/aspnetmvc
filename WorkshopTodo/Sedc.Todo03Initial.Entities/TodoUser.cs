using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Sedc.Todo03Initial.Entities
{
    public class TodoUser : IdentityUser
    {
        
        public ICollection<Todo> Todos { get; set; }
    }
}
