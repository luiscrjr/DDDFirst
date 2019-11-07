using Microsoft.EntityFrameworkCore;
using Projeto.Domain.AggregatesModel.FornecedorAggregate;
using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using Projeto.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Context
{
    //REGRA1) Herdar a classe DbContext
    public class DataContext : DbContext
    {

        //construtor co entrada de argumentos

        public DataContext(DbContextOptions<DataContext> builder) : base(builder)
        {

        }

        //REGRA2) Sobrescrever (override) do método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new MarcaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

        //REGRA3) Declarar uma propriedade (get/set) para cada entidade do dominio utilizando a classe DbSet<T>

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
