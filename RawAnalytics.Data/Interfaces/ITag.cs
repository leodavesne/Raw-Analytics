namespace RawAnalytics.Data.Interfaces
{
	using System;

	public interface ITag
	{
		int Id { get; set; }

		string Label { get; set; }

		string Value { get; set; }

		DateTime Creation { get; set; }
	}
}
