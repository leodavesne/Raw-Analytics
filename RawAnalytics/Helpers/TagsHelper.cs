namespace RawAnalytics.Helpers
{
	using RawAnalytics.Data.Models;
	using RawAnalytics.ViewModels;

	public static class TagsHelper
	{
		public static Tag FromViewModelToModel(TagViewModel viewModel)
		{
			Tag model = new Tag
			{
				Label = viewModel.Label,
				Value = viewModel.Value
			};

			return model;
		}
	}
}
