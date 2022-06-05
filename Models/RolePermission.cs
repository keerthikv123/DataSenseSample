﻿using System.ComponentModel.DataAnnotations;

namespace DataSenseSample.Models
{
    public class RolePermission
    {
        [Key]
        public int RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int ModuleId { get; set; }
        public Module Module { get; set; }

        public bool View { get; set; }
        public bool Add { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
    }
}
