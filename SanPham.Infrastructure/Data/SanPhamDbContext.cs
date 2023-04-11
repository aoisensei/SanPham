using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using SanPham.Application.Interfaces;
using SanPham.Domain.Entities;
using SharedKernel.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.Infrastructure.Data;

public class SanPhamDbContext : BaseDbContext<SanPhamDbContext>, ISanPhamDbContext
{
    public SanPhamDbContext(DbContextOptions<SanPhamDbContext> options, AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor) : base(options, auditableEntitySaveChangesInterceptor)
    {
    }

    public DbSet<san_pham> san_pham { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("sanpham");
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public void BulkInsert<T>(IList<T> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null) where T : class
    {
        this.BulkInsertOrUpdate(entities, bulkConfig, progress);
    }
}
