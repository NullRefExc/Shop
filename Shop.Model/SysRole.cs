using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    [Table("SysRole")]
    public partial class SysRole
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [StringLength(20)]
        public string RoleName { get; set; }
    }
}
