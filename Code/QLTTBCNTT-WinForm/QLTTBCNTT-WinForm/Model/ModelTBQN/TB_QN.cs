namespace QLTTBCNTT_WinForm.Model.ModelTBQN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_QN
    {
        [Key]
        [Column(Order = 0)]
        public int IdTBQN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idQuannhan { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idThietbi { get; set; }

        [StringLength(50)]
        public string DateBorrow { get; set; }

        [StringLength(50)]
        public string DateReturn { get; set; }

        public virtual DM_QuanNhan DM_QuanNhan { get; set; }

        public virtual DM_ThietBiQN DM_ThietBi { get; set; }
    }
}
