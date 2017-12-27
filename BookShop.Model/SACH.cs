namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [Key]
        [Display(Name ="Mã sách")]
        public int Masach { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Tên sách")]
        public string Tensach { get; set; }

        [Display(Name = "Đơn giá")]
        public int? Dongia { get; set; }

        [StringLength(10)]
        [Display(Name = "Đơn vị tính")]
        public string Donvitinh { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Mô tả")]
        public string Mota { get; set; }

        [StringLength(50)]
        [Display(Name = "Hình minh họa")]
        public string Hinhminhhoa { get; set; }

        [Display(Name = "Mã chủ đề")]
        public int? MaCD { get; set; }


        [Display(Name = "Mã Nhà xuất bản")]
        public int? MaNXB { get; set; }

        [Display(Name = "Ngày cập nhật")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngaycapnhat { get; set; }

        [Display(Name = "Số lượng bán")]
        public int? Soluongban { get; set; }

        [Display(Name = "Số lần xem")]
        public int? Solanxem { get; set; }
    }
}
