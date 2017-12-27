namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [Key]
        public int MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string HotenKH { get; set; }

        [StringLength(50)]
        public string DiachiKH { get; set; }

        [StringLength(50)]
        public string DienthoaiKH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDN { get; set; }

        [Required]
        [StringLength(50)]
        public string Matkhau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngaysinh { get; set; }

        public bool Gioitinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
