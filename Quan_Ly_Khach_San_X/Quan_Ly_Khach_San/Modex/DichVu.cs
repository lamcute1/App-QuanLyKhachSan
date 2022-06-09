namespace Quan_Ly_Khach_San.Modex
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            Phongs = new HashSet<Phong>();
        }

        [Key]
        [StringLength(10)]
        public string MaDV { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaDV { get; set; }

        [StringLength(20)]
        public string TenDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
