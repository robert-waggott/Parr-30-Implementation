namespace PARR30.Domain
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Parr30Input
	{
		public Parr30Input()
		{
			this.HealthConditions = new List<HealthCondition>();
		}

		public IList<HealthCondition> HealthConditions { get; set; } 

		public Hospital Hospital { get; set; }

		public int? Age { get; set; }

		public double? DeprivationScore { get; set; }

		public int? NumberOfAdmissionsLastYear { get; set; }

		public bool? AdmissionInLastMonth { get; set; }

		public bool? CurrentAdmissionIsEmergencyOrUnPlanned { get; set; }

		public string Synopsis
		{
			get
			{
				var items = new string[] { 
					"Health conditions: " + string.Join(", ", this.HealthConditions.Select(c => c.GetDescription())),
					"Hospital: " + this.Hospital.Name + " (" + this.Hospital.Coefficient + ")",
					"Age: " + this.Age.ToString(),
					"Deprivation score: " + this.DeprivationScore.ToString(),
					"# of admissions in last year: " + this.NumberOfAdmissionsLastYear.ToString(),
					"Admission in last month?: " + this.AdmissionInLastMonth.ToString(),
					"Is current admission emergency/un-planned?: " + this.CurrentAdmissionIsEmergencyOrUnPlanned.ToString()
				};
				return string.Join(", ", items);
			}
		}
	}
}