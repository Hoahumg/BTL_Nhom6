using System.Net.Mime;
using BTL_Nhom6.Models;
using Microsoft.EntityFrameworkCore;

namespace BTL_Nhom6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BTL_Nhom6.Models.Dangnhap> Dangnhap {get; set;}  
        public DbSet<BTL_Nhom6.Models.Nhanvien> Nhanvien {get; set;} 
        public DbSet<BTL_Nhom6.Models.Sanpham> Sanpham {get; set;} 
        public DbSet<BTL_Nhom6.Models.Khachhang> Khachhang {get; set;} 
    }
}