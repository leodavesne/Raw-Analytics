namespace RawAnalytics.Data
{
	using System;
	using System.Data.Entity;

	public class TagsContext : DbContext
	{
		public DbSet<Tag> Tags { get; set; }
	}
}
