﻿namespace RawAnalytics.Data
{
	using RawAnalytics.Data.Interfaces;
	using RawAnalytics.Data.Models;
	using System.Data.Entity;

	public class TagsContext : DbContext
	{
		public DbSet<Tag> Tags { get; set; }
	}
}
