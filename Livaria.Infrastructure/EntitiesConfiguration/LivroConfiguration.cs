using Livaria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livaria.Infrastructure.EntitiesConfiguration
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(a => a.LivroId);
            builder.Property(a => a.Titulo).HasMaxLength(150).IsRequired();
            builder.Property(a => a.Autor).HasMaxLength(200).IsRequired();
            builder.Property(a => a.Lancamento).IsRequired();
            builder.Property(a => a.Capa).HasMaxLength(200);

        }
    }
}
