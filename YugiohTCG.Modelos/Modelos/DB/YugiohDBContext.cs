using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace YugiohTCG.Modelos.Modelos.DB
{
    public partial class YugiohDBContext : DbContext
    {
        public YugiohDBContext()
        {
        }

        public YugiohDBContext(DbContextOptions<YugiohDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MagicCard> MagicCards { get; set; } = null!;
        public virtual DbSet<MonsterCard> MonsterCards { get; set; } = null!;
        public virtual DbSet<TrapCard> TrapCards { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-V93U8FK;Database=YugiohDB;Trusted_Connection=True;User Id=sa;Password=d&;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MagicCard>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Atributo).HasMaxLength(50);

                entity.Property(e => e.Carta).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Duracion).HasMaxLength(50);

                entity.Property(e => e.Icono).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Velocidad).HasMaxLength(50);
            });

            modelBuilder.Entity<MonsterCard>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Atributo).HasMaxLength(50);

                entity.Property(e => e.Carta).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Tipo).HasMaxLength(50);
            });

            modelBuilder.Entity<TrapCard>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Atributo).HasMaxLength(50);

                entity.Property(e => e.Carta).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Duracion).HasMaxLength(50);

                entity.Property(e => e.Icono).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Velocidad).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
