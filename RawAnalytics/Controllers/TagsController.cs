namespace RawAnalytics.Controllers
{
	using RawAnalytics.Data;
	using RawAnalytics.Data.Interfaces;
	using RawAnalytics.Helpers;
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
			HttpResponseMessage httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK);

			if (viewModel != null)
			{
				_service.InsertTag(TagsHelper.FromViewModelToModel(viewModel));
			}
			else
			{
				httpResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest);
			}

			return httpResponseMessage;
		}
	}
}
