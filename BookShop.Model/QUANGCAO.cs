namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUANGCAO")]
    public partial class QUANGCAO
    {
        [Key]
        public int STT { get; set; }

        [StringLength(200)]
        public string TenCTy { get; set; }

        [StringLength(100)]
        public string HinhMinhHoa { get; set; }

        [StringLength(100)]
        public string HREF { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngaybatdau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngayhethan { get; set; }
    }
}
