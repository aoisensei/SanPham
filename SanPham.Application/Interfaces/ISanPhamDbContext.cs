using Microsoft.EntityFrameworkCore;
using SanPham.Domain.Entities;
using SharedKernel.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.Application.Interfaces
{
    public interface ISanPhamDbContext : IBaseDbContext
    {
        DbSet<san_pham> san_pham { get; set; }
    }
}
