using System.ComponentModel.DataAnnotations;

namespace DataSenseSample.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
