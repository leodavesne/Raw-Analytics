namespace RawAnalytics.Controllers
{
	using RawAnalytics.ViewModels;
	using RawAnalytics.Data;
	using System.Web.Http;

	public class TagsController : ApiController
	{
		private ITagsService _service { get; set; }

		public TagsController(ITagsService service)
		{
			_service = service;
		}

		public void Insert(TagViewModel viewModel)
		{
			Tag tag = new Tag
			{
				Label = viewModel.Label,
				Value = viewModel.Value
			};

			_service.InsertTag(tag);
		}
	}
}
