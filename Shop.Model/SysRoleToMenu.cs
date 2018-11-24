using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    [Table("SysRoleToMenu")]
    public partial class SysRoleToMenu
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int MenuId { get; set; }
    }
}
