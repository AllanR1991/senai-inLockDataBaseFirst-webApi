using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using senai_inLockDataBaseFirst_webApi.Domains;

namespace senai_inLockDataBaseFirst_webApi.Contexts;

public partial class InLockContext : DbContext
{
    public InLockContext()
    {
    }

    public InLockContext(DbContextOptions<InLockContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estudio> Estudios { get; set; }

    public virtual DbSet<Jogo> Jogos { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source = ALLANR1991-DESK\\SQLEXPRESS; initial catalog = inLock_games_manha; user Id = SA; pwd = 123456; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudio>(entity =>
        {
            entity.HasKey(e => e.IdEstudio).HasName("PK__Estudio__0C3B4355E6C68F0A");

            entity.ToTable("Estudio");

            entity.HasIndex(e => e.NomeEstudio, "UQ__Estudio__112A56903974FF39").IsUnique();

            entity.Property(e => e.NomeEstudio)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Jogo>(entity =>
        {
            entity.HasKey(e => e.IdJogo).HasName("PK__Jogo__69E08513CB2A176D");

            entity.ToTable("Jogo");

            entity.HasIndex(e => e.NomeJogo, "UQ__Jogo__89AF93E47B3CCC33").IsUnique();

            entity.Property(e => e.DataLancamento).HasColumnType("date");
            entity.Property(e => e.Descricao)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.NomeJogo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("smallmoney");

            entity.HasOne(d => d.IdEstudioNavigation).WithMany(p => p.Jogos)
                .HasForeignKey(d => d.IdEstudio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Jogo__IdEstudio__4D94879B");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTipoUsuario).HasName("PK__TipoUsua__CA04062B87B332C9");

            entity.ToTable("TipoUsuario");

            entity.HasIndex(e => e.Titulo, "UQ__TipoUsua__7B406B56B26BE919").IsUnique();

            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF97BDF7C898");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.Email, "UQ__Usuario__A9D105346CC4B648").IsUnique();

            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTipoUsuarioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdTipoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__IdTipoU__5441852A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
