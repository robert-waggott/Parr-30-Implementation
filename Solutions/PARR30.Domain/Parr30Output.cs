namespace PARR30.Domain
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Parr30Output
	{
		public Parr30Output(List<Parr30OutputLine> lines)
		{
			this.Lines = lines;
			this.Total = lines.Sum(line => line.Total);
			this.Probability = Math.Round(Math.Exp(this.Total) / (1 + Math.Exp(this.Total)) * 100, 1);
		}

		public IList<Parr30OutputLine> Lines { get; set; }
		public double Total { get; set; }
		public double Probability { get; set; }

		public bool Recommended 
		{
			get { return this.Probability > 19; }
		}
	}
}