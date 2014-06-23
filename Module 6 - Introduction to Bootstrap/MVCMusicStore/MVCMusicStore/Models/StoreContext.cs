using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
	public class StoreContext : DbContext
	{
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Album> Albums { get; set; }
		public DbSet<Artist> Artists { get; set; }
	}
}