namespace Quan_Ly_Khach_San.Modex
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SuCo")]
    public partial class SuCo
    {
        [Key]
        [StringLength(10)]
        public string MaSC { get; set; }

        [StringLength(20)]
        public string TenSC { get; set; }

        [StringLength(50)]
        public string ChiTietVeSuCo { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
