using FPTBookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FPTBookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FPTBookStore.Models.Category> Category { get; set; } = default!;
        public DbSet<FPTBookStore.Models.Author> Author { get; set; } = default!;
        public DbSet<FPTBookStore.Models.Book> Book { get; set; } = default!;
        public DbSet<FPTBookStore.Models.ApplicationRole> ApplicationRole { get; set; } = default!;
        public DbSet<FPTBookStore.Models.ApplicationUser> ApplicationUsers { get; set; } = default!;
        public DbSet<FPTBookStore.Models.ApplicationUser> User { get; set; }
    }
}