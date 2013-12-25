namespace RawAnalytics.Data
{
	using System;

	public class TagsService : ITagsService
	{
		private TagsContext _context { get; set; }

		public void InsertTag(Tag tag)
		{
			tag.Creation = DateTime.Now;

			_context.Tags.Add(tag);
			_context.SaveChanges();
		}
	}
}
