namespace PARR30.Providers.Interfaces
{
	using System;

	using PARR30.Domain;

	public interface ICalculationProvider
	{
		Parr30Output Calculate(Parr30Input args);
	}
}