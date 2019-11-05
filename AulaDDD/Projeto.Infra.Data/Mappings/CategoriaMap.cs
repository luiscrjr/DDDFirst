using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            //chave primária
            builder.HasKey(c => c.Id);

            //mapeamento do relacionamento
            builder.HasOne(c => c.Produto)
                .WithOne(p => p.Categoria)
                .HasForeignKey<Categoria>(c => c.IdProduto); // Chave estrangeira
        }
    }
}
