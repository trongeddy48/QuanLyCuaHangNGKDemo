namespace QuanLyCuaHangNuocGiaiKhat.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string SoHoaDon { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(25)]
        public string MaNV { get; set; }

        [StringLength(30)]
        public string NgayLapHoaDon { get; set; }

        public bool? trangthai { get; set; }
    }
}
