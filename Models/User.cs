using System.ComponentModel.DataAnnotations;

namespace DataSenseSample.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}
