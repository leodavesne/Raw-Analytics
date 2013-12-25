namespace RawAnalytics.Controllers
{
	using RawAnalytics.Data;
	using RawAnalytics.Data.Interfaces;
	using RawAnalytics.Data.Models;
	using RawAnalytics.ViewModels;
	using System.Net;
	using System.Net.Http;
	using System.Web.Http;

	public class TagsController : ApiController
	{
		private ITagsService _service { get; set; }

		public TagsController()
		{
			_service = new TagsService();
		}

		public TagsController(ITagsService service)
		{
			_service = service;
		}

		public HttpResponseMessage Insert(TagViewModel viewModel)
		{
			Tag tag = new Tag
			{
				Label = viewModel.Label,
				Value = viewModel.Value
			};

			_service.InsertTag(tag);

			HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);

			return response;
		}
	}
}
