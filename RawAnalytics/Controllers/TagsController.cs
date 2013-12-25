namespace RawAnalytics.Controllers
{
	using RawAnalytics.Data.Interfaces;
	using RawAnalytics.Data.Models;
	using RawAnalytics.ViewModels;
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
