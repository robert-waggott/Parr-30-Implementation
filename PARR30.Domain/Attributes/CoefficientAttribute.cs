namespace PARR30.Domain.Attributes
{
	using System;

	[AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
	public class CoefficientAttribute : Attribute
	{
		public CoefficientAttribute(double coefficient)
		{
			this.Coefficient = coefficient;
		}

		public double Coefficient { get; private set; }
	}
}