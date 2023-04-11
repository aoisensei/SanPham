using Microsoft.EntityFrameworkCore;
using SharedKernel.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.Infrastructure.Data
{
    public class SanPhamDbContextInitial
    {
        private readonly SanPhamDbContext _context;
        private readonly LogDbContextInitial _logDbContextInitial;

        public SanPhamDbContextInitial(SanPhamDbContext context, LogDbContextInitial logDbContextInitial)
        {
            _context = context;
            _logDbContextInitial = logDbContextInitial;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                await _logDbContextInitial.InitialiseAsync();
                try
                {
                    await _context.Database.MigrateAsync();
                }
                catch { }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task SeedAsync()
        {
            try
            {
                await TrySeedAsync();
            }
            catch (Exception)
            {
            }
        }
        public async Task TrySeedAsync()
        {

            //if (_context.nguoi_dung.Any())
            //{
            //    return;
            //}

            _context.SaveChanges();
        }
    }
}
