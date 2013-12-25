namespace RawAnalytics.Data
{
	using RawAnalytics.Data.Interfaces;
	using RawAnalytics.Data.Models;
	using System;

	public class TagsService : ITagsService
	{
		private TagsContext _context { get; set; }

		public void InsertTag(ITag model)
		{
			Tag tag = new Tag
			{
				Label = model.Label,
				Value = model.Value,
				Creation = DateTime.Now
			};

			_context.Tags.Add(tag);
			_context.SaveChanges();
		}
	}
}
