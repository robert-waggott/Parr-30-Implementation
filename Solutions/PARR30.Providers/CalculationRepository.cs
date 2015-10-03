namespace PARR30.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PARR30.Domain;

    public class CalculationRepository : Interfaces.ICalculationProvider
    {
        private const double _CONSTANT = -2.91821;

        public Parr30Output Calculate(Parr30Input args)
        {
            var healthConditions = args.HealthConditions
				.Select(condition => new Parr30OutputLine(condition.GetDescription(), 1, condition.GetCoefficient()));
            var lines = new List<Parr30OutputLine>();  

            if (args.Hospital != null)
            {
                lines.Add(new Parr30OutputLine(args.Hospital.Name, args.Hospital.Coefficient));
            }

            if (args.Age.HasValue)
            {
                lines.Add(new Parr30OutputLine("Squared age", args.Age.Value * args.Age.Value, 0.000060581));
            }

            if (args.DeprivationScore.HasValue)
            {
                var deprivationScoreCoefficient = this.GetDeprivationScoreCoefficient(args.DeprivationScore.Value);
                lines.Add(new Parr30OutputLine("Deprivation", deprivationScoreCoefficient));
            }

            if (args.NumberOfAdmissionsLastYear.HasValue)
            {
                lines.Add(new Parr30OutputLine("Number of admissions last year", args.NumberOfAdmissionsLastYear.Value, 0.1215));
            }

            if (args.AdmissionInLastMonth.HasValue)
            {
                lines.Add(new Parr30OutputLine("Admission in last month", args.AdmissionInLastMonth.Value ? 1 : 0, 0.5258));
            }

            if (args.CurrentAdmissionIsEmergencyOrUnPlanned.HasValue)
            {
                lines.Add(new Parr30OutputLine("Current admission is emergency/un-planned", args.CurrentAdmissionIsEmergencyOrUnPlanned.Value ? 1 : 0, 0.5565));
            }

            lines.AddRange(healthConditions);
            lines.Add(new Parr30OutputLine("Constant", 1, _CONSTANT));

            return new Parr30Output(lines);
        }

        private double GetDeprivationScoreCoefficient(double deprivationScore)
        {
            if (deprivationScore < 10)
            {
                return 0.0;
            }
            else if (deprivationScore < 15)
            {
                return 0.0209;
            }
            else if (deprivationScore < 25)
            {
                return 0.0239;
            }
            else if (deprivationScore < 40)
            {
                return 0.0661;
            }
            else if (deprivationScore < 50)
            {
                return 0.1017;
            }
            else
            {
                return 0.0982;
            }
        }
    }
}