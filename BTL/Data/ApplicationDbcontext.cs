using Microsoft.EntityFrameworkCore;
using BTL.Models;

namespace BTL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<BTL.Models.SanPham> SanPham { get; set; } = default!;
        public DbSet<BTL.Models.NhaCC> NhaCC { get; set; } = default!;
        public DbSet<BTL.Models.KhoHang> KhoHang { get; set; } = default!;
        public DbSet<BTL.Models.HoaDon> HoaDon { get; set; } = default!;
       
        
    }
}