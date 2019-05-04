namespace cookBoard
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=cookBoard")
        {
        }

        public virtual DbSet<EmentaSemanal> EmentaSemanals { get; set; }
        public virtual DbSet<EmentaSemanal_Receita> EmentaSemanal_Receita { get; set; }
        public virtual DbSet<Ingrediente> Ingredientes { get; set; }
        public virtual DbSet<Local> Locals { get; set; }
        public virtual DbSet<Receita> Receitas { get; set; }
        public virtual DbSet<Receita_Ingrediente> Receita_Ingrediente { get; set; }
        public virtual DbSet<Receita_ReceitaAuxiliar> Receita_ReceitaAuxiliar { get; set; }
        public virtual DbSet<ReceitaAuxiliar> ReceitaAuxiliars { get; set; }
        public virtual DbSet<Supermercado> Supermercadoes { get; set; }
        public virtual DbSet<Utilizador> Utilizadors { get; set; }
        public virtual DbSet<Utilizador_Receita> Utilizador_Receita { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmentaSemanal>()
                .Property(e => e.UtilizadorUsername)
                .IsUnicode(false);

            modelBuilder.Entity<EmentaSemanal>()
                .HasMany(e => e.EmentaSemanal_Receita)
                .WithRequired(e => e.EmentaSemanal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmentaSemanal_Receita>()
                .Property(e => e.Dia)
                .IsUnicode(false);

            modelBuilder.Entity<Ingrediente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Ingrediente>()
                .HasMany(e => e.Receita_Ingrediente)
                .WithRequired(e => e.Ingrediente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ingrediente>()
                .HasMany(e => e.Locals)
                .WithMany(e => e.Ingredientes)
                .Map(m => m.ToTable("Ingrediente_Local").MapLeftKey("IngredienteId").MapRightKey("LocalId"));

            modelBuilder.Entity<Local>()
                .Property(e => e.Rua)
                .IsUnicode(false);

            modelBuilder.Entity<Local>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<Local>()
                .Property(e => e.Localidade)
                .IsUnicode(false);

            modelBuilder.Entity<Local>()
                .HasMany(e => e.Supermercadoes)
                .WithMany(e => e.Locals)
                .Map(m => m.ToTable("Supermercado_Local").MapLeftKey("LocalId").MapRightKey("SupermercadoId"));

            modelBuilder.Entity<Receita>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Receita>()
                .Property(e => e.Imagem)
                .IsUnicode(false);

            modelBuilder.Entity<Receita>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<Receita>()
                .Property(e => e.InfoNutricional)
                .IsUnicode(false);

            modelBuilder.Entity<Receita>()
                .Property(e => e.Dificuldade)
                .IsUnicode(false);

            modelBuilder.Entity<Receita>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Receita>()
                .Property(e => e.TempoConfecao)
                .IsUnicode(false);

            modelBuilder.Entity<Receita>()
                .Property(e => e.UtilizadorUsername)
                .IsUnicode(false);

            modelBuilder.Entity<Receita>()
                .HasMany(e => e.EmentaSemanal_Receita)
                .WithRequired(e => e.Receita)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receita>()
                .HasMany(e => e.Receita_Ingrediente)
                .WithRequired(e => e.Receita)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receita>()
                .HasMany(e => e.Receita_ReceitaAuxiliar)
                .WithRequired(e => e.Receita)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receita>()
                .HasMany(e => e.Utilizador_Receita)
                .WithRequired(e => e.Receita)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receita_Ingrediente>()
                .Property(e => e.Quantidade)
                .IsUnicode(false);

            modelBuilder.Entity<Receita_ReceitaAuxiliar>()
                .Property(e => e.ReceitaAuxiliarNome)
                .IsUnicode(false);

            modelBuilder.Entity<ReceitaAuxiliar>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<ReceitaAuxiliar>()
                .HasMany(e => e.Receita_ReceitaAuxiliar)
                .WithRequired(e => e.ReceitaAuxiliar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supermercado>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizador>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizador>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizador>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizador>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizador>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizador>()
                .HasMany(e => e.EmentaSemanals)
                .WithRequired(e => e.Utilizador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Utilizador>()
                .HasMany(e => e.Receitas)
                .WithRequired(e => e.Utilizador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Utilizador>()
                .HasMany(e => e.Utilizador_Receita)
                .WithRequired(e => e.Utilizador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Utilizador_Receita>()
                .Property(e => e.UtilizadorUsername)
                .IsUnicode(false);
        }
    }
}
