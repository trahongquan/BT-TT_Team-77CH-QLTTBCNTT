namespace QLTTBCNTT_WinForm.Model.ModelTBQN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_QuanNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_QuanNhan()
        {
            DM_ThietBi = new HashSet<DM_ThietBiQN>();
            TB_QN = new HashSet<TB_QN>();
        }

        [Key]
        public int IDQuannhan { get; set; }

        [Required]
        [StringLength(50)]
        public string CMTQD { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string Capbac { get; set; }

        [StringLength(50)]
        public string Chucvu { get; set; }

        public int idDonvi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_ThietBiQN> DM_ThietBi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_QN> TB_QN { get; set; }
    }
}
