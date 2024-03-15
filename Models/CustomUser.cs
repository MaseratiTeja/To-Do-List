using Microsoft.AspNetCore.Identity;

namespace To_Do_List.Models
{
    public class CustomUser : IdentityUser
    {
        public string? Name { get; set; }
        public List<Todo>? Todos { get; set; }
    }
}
