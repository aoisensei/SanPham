using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanPham.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.Infrastructure.Data.Configurations
{
    internal class SanPhamConfiguration : IEntityTypeConfiguration<san_pham>
    {
        public void Configure(EntityTypeBuilder<san_pham> builder)
        {
            builder.Property(p => p.Id)
                .IsRequired();

            builder.Property(p => p.Name)
                .IsRequired();

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.Type)
                .IsRequired();

            builder.Property(p => p.Quantity)
                .IsRequired();
        }
    }
}
