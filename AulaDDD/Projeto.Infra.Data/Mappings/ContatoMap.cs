using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.AggregatesModel.FornecedorAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(c => c.Id);

            //mapeamento do relacionamento 1pN
            builder.HasOne(c => c.Fornecedor) // Contato TEM 1 Fornecedor
                .WithMany(f => f.Contatos) // Fornecedor TEM muitos Contatos
                .HasForeignKey(c => c.IdFornecedor); // chave estrangeira
        }
    }
}
