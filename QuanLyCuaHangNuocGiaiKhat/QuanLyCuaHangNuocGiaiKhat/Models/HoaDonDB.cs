namespace QuanLyCuaHangNuocGiaiKhat.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HoaDonDB : DbContext
    {
        public HoaDonDB()
            : base("name=HoaDonDB")
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.SoHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
