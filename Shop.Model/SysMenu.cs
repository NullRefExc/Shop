using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    [Table("SysMenu")]
    public partial class SysMenu
    {
        [Key]
        public int MenuId { get; set; }

        [Required]
        [StringLength(20)]
        public string MenuName { get; set; }

        [Required]
        public int ParentId { get; set; }

        public string Url { get; set; }

        public int Level { get; set; }
    }
}
