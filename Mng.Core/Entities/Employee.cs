using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mng.Core.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string IdentityNumber { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly BirthDate { get; set; }
        public GenderType Gender { get; set; }
        public bool IsActivate { get; set; }
        public IEnumerable<RoleForEmployee>RolesForEmployee { get; set; }

    }
    public enum GenderType
    {
        Male,
        Female,
    }
}
