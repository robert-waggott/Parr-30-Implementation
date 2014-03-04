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

		public IEnumerable<HealthCondition> HealthConditions { get; set; } 
		public Hospital Hospital { get; set; }
		public int? Age { get; set; }
		public double? DeprivationScore { get; set; }
		public int? NumberOfAdmissionsLastYear { get; set; }
		public bool? AdmissionInLastMonth { get; set; }
		public bool? CurrentAdmissionIsEmergencyOrUnPlanned { get; set; }

		public string BuildSynopsis()
		{
			var items = new string[] 
			{ 
				"<b>Health conditions:</b> " + string.Join(", ", this.HealthConditions.Select(c => c.GetDescription())),
				"<b>Hospital:</b> " + this.Hospital.Name + " (" + this.Hospital.Coefficient + ")",
				"<b>Age:</b> " + this.Age.ToString(),
				"<b>Deprivation score:</b> " + this.DeprivationScore.ToString(),
				"<b># of admissions in last year:</b> " + this.NumberOfAdmissionsLastYear.ToString(),
				"<b>Admission in last month?:</b> " + this.AdmissionInLastMonth.ToString(),
				"<b>Is current admission emergency/un-planned?:</b> " + this.CurrentAdmissionIsEmergencyOrUnPlanned.ToString()
			};
			return string.Join(", ", items);
		}
	}
}

