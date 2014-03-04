namespace PARR30.Domain
{
	using System;

	public class Parr30OutputLine
	{
		public Parr30OutputLine(string information, double? value, double coefficient)
		{
			this.Information = information;
			this.Value = value;
			this.Coefficient = coefficient;
			this.Total = this.CalculateTotal();
		}

		public Parr30OutputLine(string information, double coefficient)
			: this(information, null, coefficient)
		{
		}

		public string Information { get; set; }
		public double? Value { get; set; }
		public double Coefficient { get; set; }
		public double Total { get; private set; }

		private double CalculateTotal()
		{
			var total = this.Value.HasValue ? this.Value.Value * this.Coefficient : this.Coefficient;
			return Math.Round((double)total, 3);
		}
	}
}