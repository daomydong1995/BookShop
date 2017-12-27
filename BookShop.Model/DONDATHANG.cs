namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONDATHANG")]
    public partial class DONDATHANG
    {
        [Key]
        public int SoDH { get; set; }

        public int? MaKH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngaydathang { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngaygiaohang { get; set; }

        [StringLength(50)]
        public string Tennguoinhan { get; set; }

        [StringLength(50)]
        public string Diachinhan { get; set; }

        [StringLength(30)]
        public string Dienthoainhan { get; set; }

        public bool? HTThanhtoan { get; set; }

        public bool? HTGiaohang { get; set; }

        public decimal? Trigia { get; set; }

        public bool Dagiaohang { get; set; }
    }
}
