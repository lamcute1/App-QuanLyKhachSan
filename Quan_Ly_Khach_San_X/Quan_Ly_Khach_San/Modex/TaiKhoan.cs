namespace Quan_Ly_Khach_San.Modex
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(10)]
        public string MaTK { get; set; }

        [Required]
        [StringLength(20)]
        public string TenTK { get; set; }

        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }

        public bool LoaiTK { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }
        public virtual NhanVien nhanvien { get; set; }
        public List<TaiKhoan> GetAll()
        {
            Model1 context = new Model1();
            return context.TaiKhoans.ToList();
        }
    }
}
