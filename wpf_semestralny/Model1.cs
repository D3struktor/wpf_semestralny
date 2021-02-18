namespace wpf_semestralny
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Employers> Employers { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Performance> Performance { get; set; }
        public virtual DbSet<Performance_staff> Performance_staff { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employers>()
                .Property(e => e.Employer_name)
                .IsFixedLength();

            modelBuilder.Entity<Employers>()
                .Property(e => e.Employer_last_name)
                .IsFixedLength();

            modelBuilder.Entity<Employers>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employers>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Employers>()
                .HasMany(e => e.Performance_staff)
                .WithRequired(e => e.Employers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Items>()
                .Property(e => e.Item_name)
                .IsFixedLength();

            modelBuilder.Entity<Items>()
                .HasMany(e => e.Performance)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("Performance_items").MapLeftKey("Item_ID").MapRightKey("Performance_id"));

            modelBuilder.Entity<Performance>()
                .Property(e => e.Performance_name)
                .IsFixedLength();

            modelBuilder.Entity<Performance>()
                .Property(e => e.Performace_visit_cost)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Performance>()
                .HasMany(e => e.Performance_staff)
                .WithRequired(e => e.Performance)
                .WillCascadeOnDelete(false);
        }
    }
}
