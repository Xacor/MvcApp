using System.Security.Cryptography;
using System.Text;

namespace DbMvcApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public static string HashPassword(string password) =>
            Convert.ToHexString(SHA512.HashData(Encoding.UTF8.GetBytes(password)));
    }
    public enum Role
    {
       Admin,
       Moderator,
       User
        
    }
}
