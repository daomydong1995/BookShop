namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHAXUATBAN")]
    public partial class NHAXUATBAN
    {
        [Key]
        public int MaNXB { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNXB { get; set; }

        [StringLength(150)]
        public string DiachiNXB { get; set; }

        [StringLength(50)]
        public string DienthoaiNXB { get; set; }
    }
}
