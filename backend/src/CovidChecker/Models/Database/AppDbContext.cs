using CovidChecker.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CovidChecker.Models.Database{
    public class AppDbContext : DbContext{
        public DbSet<User>? User{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder option){
            option.UseMySQL("server=localhost;database=COVID;uid=medic;pwd=Ast@r0tt3;");
        }
    }
}