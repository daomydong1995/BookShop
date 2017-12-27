namespace BookShop.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookShopDbContext : DbContext
    {
        public BookShopDbContext()
            : base("name=BookShopDbContext")
        {
        }

        public virtual DbSet<CHUDE> CHUDEs { get; set; }
        public virtual DbSet<CTDATHANG> CTDATHANGs { get; set; }
        public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<QUANGCAO> QUANGCAOs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<THAMGIA> THAMGIAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DONDATHANG>()
                .Property(e => e.Dienthoainhan)
                .IsUnicode(false);

            modelBuilder.Entity<DONDATHANG>()
                .Property(e => e.Trigia)
                .HasPrecision(9, 2);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DienthoaiKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.TenDN)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NHAXUATBAN>()
                .Property(e => e.DienthoaiNXB)
                .IsUnicode(false);

            modelBuilder.Entity<QUANGCAO>()
                .Property(e => e.HinhMinhHoa)
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.Hinhminhhoa)
                .IsUnicode(false);

            modelBuilder.Entity<TACGIA>()
                .Property(e => e.DienthoaiTG)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<BookShop.Model.ADMIN> ADMINSTRATORs { get; set; }
    }
}
