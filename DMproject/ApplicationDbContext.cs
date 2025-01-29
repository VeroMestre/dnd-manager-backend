using DMproject.Models;
using Microsoft.EntityFrameworkCore;

namespace DMproject
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Campaign> Campaigns { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<NonPlayerCharacter> NonPlayerCharacters { get; set; }
		public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
		public DbSet<Session> Sessions { get; set; }	
		public DbSet<World> Worlds { get; set; }
	}
}
