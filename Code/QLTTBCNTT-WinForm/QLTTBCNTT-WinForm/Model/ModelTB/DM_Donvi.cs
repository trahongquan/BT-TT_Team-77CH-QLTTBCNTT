namespace QLTTBCNTT_WinForm.Model.ModelTB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_Donvi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_Donvi()
        {
            DM_QuanNhan = new HashSet<DM_QuanNhan>();
            DM_ThietBi = new HashSet<DM_ThietBi>();
        }

        [Key]
        public int IdDonvi { get; set; }

        [StringLength(50)]
        public string Doi { get; set; }

        [StringLength(50)]
        public string TieuDoan { get; set; }

        [Required]
        [StringLength(50)]
        public string LuDoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_QuanNhan> DM_QuanNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_ThietBi> DM_ThietBi { get; set; }
    }
}
