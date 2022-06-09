namespace Quan_Ly_Khach_San.Modex
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VatTu")]
    public partial class VatTu
    {
        [Key]
        [StringLength(10)]
        public string MaVT { get; set; }

        [StringLength(20)]
        public string TenVT { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        public int? SoDem { get; set; }

        public int? SoKhach { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
