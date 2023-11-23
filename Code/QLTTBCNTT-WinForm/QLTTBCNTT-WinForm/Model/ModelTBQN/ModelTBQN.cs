using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTTBCNTT_WinForm.Model.ModelTBQN
{
    public partial class ModelTBQN : DbContext
    {
        public ModelTBQN()
            : base("name=ModelTBQN")
        {
        }

        public virtual DbSet<DM_QuanNhan> DM_QuanNhan { get; set; }
        public virtual DbSet<DM_ThietBiQN> DM_ThietBi { get; set; }
        public virtual DbSet<TB_QN> TB_QN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DM_QuanNhan>()
                .HasMany(e => e.DM_ThietBi)
                .WithOptional(e => e.DM_QuanNhan)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DM_QuanNhan>()
                .HasMany(e => e.TB_QN)
                .WithRequired(e => e.DM_QuanNhan)
                .WillCascadeOnDelete(false);
        }
    }
}
