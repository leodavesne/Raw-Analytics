namespace RawAnalytics.Data.Models
{
	using RawAnalytics.Data.Interfaces;
	using System;

	public class Tag : ITag
	{
		public int Id { get; set; }

		public string Label { get; set; }

		public string Value { get; set; }

		public DateTime Creation { get; set; }
	}
}
