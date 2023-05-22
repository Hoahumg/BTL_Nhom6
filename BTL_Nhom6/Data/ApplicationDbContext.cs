using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTL_Nhom6.Models;

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
        public DbSet<BTL_Nhom6.Models.Nhacungcap> Nhacungcap {get; set;}
        public DbSet<BTL_Nhom6.Models.Hoadon> Hoadon {get; set;}  
        public DbSet<BTL_Nhom6.Models.Nhaphang> Nhaphang {get; set;}
    }
}