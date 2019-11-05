using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PodcastPlayer.Models;

namespace PodcastPlayer
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //custom entity, override identity user with new column
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
