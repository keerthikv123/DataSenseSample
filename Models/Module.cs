using System.ComponentModel.DataAnnotations;

namespace DataSenseSample.Models
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
    }
}
