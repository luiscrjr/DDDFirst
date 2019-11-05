using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.AggregatesModel.FornecedorAggregate;
using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            //mapeamento do relacionamento 1pN
            builder.HasOne(e => e.Fornecedor) //Endereço tem 1 fornecedor
                .WithMany(f => f.Enderecos) // fornecedor tem muitos enderecos
                .HasForeignKey(e => e.IdFornecedor); // chave estrangeira
        }
    }
}
