using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FPTBookStore.Models;

namespace FPTBookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FPTBookStore.Models.Category> Category { get; set; } = default!;
        public DbSet<FPTBookStore.Models.Author> Author { get; set; } = default!;
    }
}