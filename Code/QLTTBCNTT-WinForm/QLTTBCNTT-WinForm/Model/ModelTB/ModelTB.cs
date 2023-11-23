using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTTBCNTT_WinForm.Model.ModelTB
{
    public partial class ModelTB : DbContext
    {
        public ModelTB()
            : base("name=ModelTB")
        {
        }

        public virtual DbSet<DM_Donvi> DM_Donvi { get; set; }
        public virtual DbSet<DM_LoaiThietBi> DM_LoaiThietBi { get; set; }
        public virtual DbSet<DM_QuanNhan> DM_QuanNhan { get; set; }
        public virtual DbSet<DM_ThietBi> DM_ThietBi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DM_Donvi>()
                .HasMany(e => e.DM_QuanNhan)
                .WithRequired(e => e.DM_Donvi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DM_Donvi>()
                .HasMany(e => e.DM_ThietBi)
                .WithOptional(e => e.DM_Donvi)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DM_LoaiThietBi>()
                .HasMany(e => e.DM_ThietBi)
                .WithRequired(e => e.DM_LoaiThietBi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DM_QuanNhan>()
                .HasMany(e => e.DM_ThietBi)
                .WithOptional(e => e.DM_QuanNhan)
                .WillCascadeOnDelete();
        }
    }
}
