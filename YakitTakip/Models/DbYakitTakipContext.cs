using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace YakitTakip.Models;

public partial class DbYakitTakipContext : DbContext
{
    public DbYakitTakipContext()
    {
    }

    public DbYakitTakipContext(DbContextOptions<DbYakitTakipContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbArac> TbAracs { get; set; }

    public virtual DbSet<TbGorev> TbGorevs { get; set; }

    public virtual DbSet<TbKod> TbKods { get; set; }

    public virtual DbSet<TbPersonel> TbPersonels { get; set; }

    public virtual DbSet<TbYakit> TbYakits { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=dbYakitTakip;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbArac>(entity =>
        {
            entity.ToTable("tbArac");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IlkKayitTarihi).HasColumnType("datetime");
            entity.Property(e => e.MuayeneGecerlilikTarihi).HasColumnType("datetime");
            entity.Property(e => e.Plaka)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.SonKayitTarihi).HasColumnType("datetime");

            entity.HasOne(d => d.MarkaKod).WithMany(p => p.TbAracMarkaKods)
                .HasForeignKey(d => d.MarkaKodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbArac_tbKodMarka");

            entity.HasOne(d => d.ModelKod).WithMany(p => p.TbAracModelKods)
                .HasForeignKey(d => d.ModelKodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbArac_tbKodModel");

            entity.HasOne(d => d.VitesKod).WithMany(p => p.TbAracVitesKods)
                .HasForeignKey(d => d.VitesKodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbArac_tbKodVites");

            entity.HasOne(d => d.YakitTipiKod).WithMany(p => p.TbAracYakitTipiKods)
                .HasForeignKey(d => d.YakitTipiKodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbArac_tbKodYakit");
        });

        modelBuilder.Entity<TbGorev>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tbGorevdeKullanılanArac");

            entity.ToTable("tbGorev");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).IsUnicode(false);
            entity.Property(e => e.AracId).HasColumnName("AracID");
            entity.Property(e => e.GorevBaslangicTarihi).HasColumnType("smalldatetime");
            entity.Property(e => e.GorevSonuTarihi).HasColumnType("smalldatetime");
            entity.Property(e => e.IlkKayitTarihi).HasColumnType("datetime");
            entity.Property(e => e.PersonelId).HasColumnName("PersonelID");
            entity.Property(e => e.SonKayitTarihi).HasColumnType("datetime");

            entity.HasOne(d => d.Arac).WithMany(p => p.TbGorevs)
                .HasForeignKey(d => d.AracId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbGorev_tbArac");

            entity.HasOne(d => d.Personel).WithMany(p => p.TbGorevs)
                .HasForeignKey(d => d.PersonelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbGorev_tbPersonel");
        });

        modelBuilder.Entity<TbKod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Kod");

            entity.ToTable("tbKod");

            entity.Property(e => e.Ad).HasMaxLength(50);
            entity.Property(e => e.IlkKayitTarihi).HasColumnType("datetime");
            entity.Property(e => e.SiraNo).HasDefaultValueSql("((1))");
            entity.Property(e => e.SonKayitTarihi).HasColumnType("datetime");
        });


        modelBuilder.Entity<TbPersonel>(entity =>
        {
            entity.ToTable("tbPersonel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IlkKayitTarihi).HasColumnType("datetime");
            entity.Property(e => e.SonKayitTarihi).HasColumnType("datetime");
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonNo)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbYakit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Yakit");

            entity.ToTable("tbYakit");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GorevId).HasColumnName("GorevID");
            entity.Property(e => e.IlkKayitTarihi).HasColumnType("datetime");
            entity.Property(e => e.SonKayitTarihi).HasColumnType("datetime");

            entity.HasOne(d => d.Gorev).WithMany(p => p.TbYakits)
                .HasForeignKey(d => d.GorevId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbYakit_tbGorev");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
