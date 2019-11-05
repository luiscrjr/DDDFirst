using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class MarcaMap : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            // chave primária
            builder.HasKey(m => m.Id);

            //mapeamento do relacionamento 1p1
            builder.HasOne(m => m.Produto)
                .WithOne(p => p.Marca)
                .HasForeignKey<Marca>(m => m.IdProduto); //chave estrangeira
        }
    }
}
