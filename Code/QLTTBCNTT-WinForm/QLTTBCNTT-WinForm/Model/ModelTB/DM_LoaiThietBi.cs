namespace QLTTBCNTT_WinForm.Model.ModelTB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_LoaiThietBi()
        {
            DM_ThietBi = new HashSet<DM_ThietBi>();
        }

        [Key]
        public int IdLoaiTB { get; set; }

        [StringLength(50)]
        public string loai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_ThietBi> DM_ThietBi { get; set; }
    }
}
