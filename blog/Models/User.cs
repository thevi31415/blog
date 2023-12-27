using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace blog.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }
    }
}
