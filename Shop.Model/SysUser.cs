namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUser")]
    public partial class SysUser
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(10)]
        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string UserPwd { get; set; }

        [Required]
        [StringLength(20)]
        public string Mobile { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
