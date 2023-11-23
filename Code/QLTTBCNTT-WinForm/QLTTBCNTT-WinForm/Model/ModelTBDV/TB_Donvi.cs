namespace QLTTBCNTT_WinForm.Model.ModelTBDV
{
    using QLTTBCNTT_WinForm.Model.ModelTB;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Donvi
    {
        [Key]
        [Column(Order = 0)]
        public int IdTBDonvi { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idDonvi { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idThietbi { get; set; }

        [StringLength(50)]
        public string DateBorrow { get; set; }

        [StringLength(50)]
        public string DateReturn { get; set; }

        public virtual DM_DonviDV DM_Donvi { get; set; }

        public virtual DM_ThietBiDV DM_ThietBi { get; set; }
    
        public virtual DM_LoaiThietBi DM_LoaiThietBi { get; set; }
    }
}
