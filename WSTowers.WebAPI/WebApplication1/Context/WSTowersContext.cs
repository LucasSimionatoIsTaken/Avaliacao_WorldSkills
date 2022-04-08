using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication1.Domains;

namespace WebApplication1.Context
{
    public partial class WSTowersContext : DbContext
    {
        public WSTowersContext()
        {
        }

        public WSTowersContext(DbContextOptions<WSTowersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<Cidade> Cidades { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Estoque> Estoques { get; set; } = null!;
        public virtual DbSet<Genero> Generos { get; set; } = null!;
        public virtual DbSet<Loja> Lojas { get; set; } = null!;
        public virtual DbSet<Participante> Participantes { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<Regiao> Regiaos { get; set; } = null!;
        public virtual DbSet<Venda> Vendas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KVKV9TT\\SA; initial catalog=WSTowers; user id=sa; pwd=senai@132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.ToTable("categoria");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(255)
                    .HasColumnName("categoria");
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.ToTable("cidade");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cidade1)
                    .HasMaxLength(255)
                    .HasColumnName("Cidade");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Cidades)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK_cidade_estado");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("estado");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Estado1)
                    .HasMaxLength(255)
                    .HasColumnName("Estado");

                entity.Property(e => e.Sigla).HasMaxLength(255);

                entity.HasOne(d => d.Regiao)
                    .WithMany(p => p.Estados)
                    .HasForeignKey(d => d.RegiaoId)
                    .HasConstraintName("FK_estado_regiao");
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.ToTable("estoque");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Loja).HasColumnName("loja");

                entity.Property(e => e.ProdutoId).HasColumnName("produtoId");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.Estoques)
                    .HasForeignKey(d => d.ProdutoId)
                    .HasConstraintName("FK_estoque_produto");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.ToTable("genero");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Genero1)
                    .HasMaxLength(255)
                    .HasColumnName("genero");
            });

            modelBuilder.Entity<Loja>(entity =>
            {
                entity.ToTable("loja");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Loja1)
                    .HasMaxLength(255)
                    .HasColumnName("loja");
            });

            modelBuilder.Entity<Participante>(entity =>
            {
                entity.ToTable("participante");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CidadeId).HasColumnName("cidadeId");

                entity.Property(e => e.GeneroId).HasColumnName("generoId");

                entity.Property(e => e.Idade).HasColumnName("idade");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .HasColumnName("nome");

                entity.HasOne(d => d.Cidade)
                    .WithMany(p => p.Participantes)
                    .HasForeignKey(d => d.CidadeId)
                    .HasConstraintName("FK_participante_cidade");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.Participantes)
                    .HasForeignKey(d => d.GeneroId)
                    .HasConstraintName("FK_participante_genero");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produto");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CategoriaId).HasColumnName("categoriaId");

                entity.Property(e => e.Produto1)
                    .HasMaxLength(255)
                    .HasColumnName("produto");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.CategoriaId)
                    .HasConstraintName("FK_produto_categoria");
            });

            modelBuilder.Entity<Regiao>(entity =>
            {
                entity.ToTable("regiao");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Regiao1)
                    .HasMaxLength(255)
                    .HasColumnName("Regiao");
            });

            modelBuilder.Entity<Venda>(entity =>
            {
                entity.ToTable("vendas");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("hora");

                entity.Property(e => e.LojaId).HasColumnName("lojaId");

                entity.Property(e => e.ParticipanteId).HasColumnName("participanteId");

                entity.Property(e => e.ProdutoId).HasColumnName("produtoId");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.Transação).HasColumnName("transação");

                entity.HasOne(d => d.Loja)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.LojaId)
                    .HasConstraintName("FK_vendas_loja");

                entity.HasOne(d => d.Participante)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.ParticipanteId)
                    .HasConstraintName("FK_vendas_participante");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.ProdutoId)
                    .HasConstraintName("FK_vendas_produto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
