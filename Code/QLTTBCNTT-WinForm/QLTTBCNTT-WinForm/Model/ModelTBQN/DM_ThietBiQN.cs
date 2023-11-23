namespace QLTTBCNTT_WinForm.Model.ModelTBQN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_ThietBiQN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_ThietBiQN()
        {
            TB_QN = new HashSet<TB_QN>();
        }

        [Key]
        public int IdThietBi { get; set; }

        public int idLoaiTB { get; set; }

        [StringLength(50)]
        public string TenTB { get; set; }

        [StringLength(50)]
        public string Seri { get; set; }

        [StringLength(50)]
        public string MAC { get; set; }

        [StringLength(50)]
        public string CoreCPU { get; set; }

        [StringLength(50)]
        public string RAM { get; set; }

        [StringLength(50)]
        public string HardDisk { get; set; }

        [StringLength(50)]
        public string Monitor { get; set; }

        public int? idQuannhan { get; set; }

        public int? idDonvi { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public int? Kho { get; set; }

        public virtual DM_QuanNhan DM_QuanNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_QN> TB_QN { get; set; }
    }
}
