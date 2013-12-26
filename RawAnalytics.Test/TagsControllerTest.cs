namespace RawAnalytics.Test
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Moq;
	using RawAnalytics.Controllers;
	using RawAnalytics.Data.Interfaces;
	using RawAnalytics.Data.Models;
	using System;
	using System.Globalization;
	using System.Net.Http;

	[TestClass]
	public class TagsControllerTest
	{
		[TestMethod]
		public void WhenInsertActionWithNullTagViewModelThenReturnBadRequest()
		{
			Mock<ITagsService> service = new Mock<ITagsService>();

			Tag model = new Tag
			{
				Label = "Label",
				Value = "Value"
			};

			service.Setup(x => x.InsertTag(model))
				.Returns(true);

			TagsController controller = new TagsController(service.Object)
			{
				Request = new HttpRequestMessage()
			};

			HttpResponseMessage httpResponseMessage = controller.Insert(null) as HttpResponseMessage;

			if (httpResponseMessage == null)
			{
				Assert.Fail("Should have returned an HTTP response message.");
			}

			Assert.AreEqual("BadRequest", httpResponseMessage.StatusCode.ToString(CultureInfo.InvariantCulture));
		}
	}
}
