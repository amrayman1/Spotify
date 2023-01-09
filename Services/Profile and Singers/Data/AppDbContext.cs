using Microsoft.EntityFrameworkCore;
using Profile_and_Singers.Models;

namespace Profile_and_Singers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Singer> singers { get; set; }
        public DbSet<Music> musics { get; set; }
        public DbSet<SingerMusic> singerMusics { get; set; }
    }
}
