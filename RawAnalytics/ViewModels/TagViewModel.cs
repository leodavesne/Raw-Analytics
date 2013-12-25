namespace RawAnalytics.ViewModels
{
	using RawAnalytics.Interfaces;

	public class TagViewModel : ITagViewModel
	{
		public string Label { get; set; }

		public string Value { get; set; }
	}
}
