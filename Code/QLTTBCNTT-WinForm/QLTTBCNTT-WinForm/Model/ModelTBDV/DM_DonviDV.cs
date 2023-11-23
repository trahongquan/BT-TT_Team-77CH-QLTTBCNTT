namespace QLTTBCNTT_WinForm.Model.ModelTBDV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_DonviDV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_DonviDV()
        {
            DM_ThietBi = new HashSet<DM_ThietBiDV>();
            TB_Donvi = new HashSet<TB_Donvi>();
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
        public virtual ICollection<DM_ThietBiDV> DM_ThietBi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Donvi> TB_Donvi { get; set; }
    }
}
