namespace PARR30.Domain.Attributes
{
	using System;

	[AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
	public class DescriptionAttribute : Attribute
	{
		public DescriptionAttribute(string description)
		{
			this.Description = description;
		}

		public string Description { get; private set; }
	}
}