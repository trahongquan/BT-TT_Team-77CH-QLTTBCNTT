using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTTBCNTT_WinForm.Model.ModelTBDV
{
    public partial class ModelTBDV : DbContext
    {
        public ModelTBDV()
            : base("name=ModelTBDV")
        {
        }

        public virtual DbSet<DM_DonviDV> DM_Donvi { get; set; }
        public virtual DbSet<DM_ThietBiDV> DM_ThietBi { get; set; }
        public virtual DbSet<TB_Donvi> TB_Donvi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DM_DonviDV>()
                .HasMany(e => e.DM_ThietBi)
                .WithOptional(e => e.DM_Donvi)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DM_DonviDV>()
                .HasMany(e => e.TB_Donvi)
                .WithRequired(e => e.DM_Donvi)
                .WillCascadeOnDelete(false);
        }
    }
}
