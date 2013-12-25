namespace RawAnalytics.Data.Interfaces
{
	using RawAnalytics.Data.Models;
	using System.Data.Entity;

	public class ITagsContext
	{
		DbSet<Tag> Tags { get; set; }
	}
}
