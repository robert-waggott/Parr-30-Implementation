namespace PARR30.Domain
{
	using System;

	public enum HealthCondition
	{
		[Description("Congestive heart failure")]
		[Coefficient(0.0950)]
		CongestiveHeartFailure,

		[Description("Peripheral vascular disease")]
		[Coefficient(0.1043)]
		PeripheralVascularDisease,

		[Description("Chronic pulmonary disease")]
		[Coefficient(0.2243)]
		ChronicPulmonaryDisease,

		[Description("Diabetes with chronic complications")]
		[Coefficient(0.1457)]
		DiabetesWithChronicComplications,

		[Description("Renal disease")]
		[Coefficient(0.1977)]
		RenalDisease,

		[Description("Metastatic cancer with solid tumor")]
		[Coefficient(0.2762)]
		MetastaticCancerWithSolidTumor,

		[Description("Other malignant cancer")]
		[Coefficient(0.5069)]
		OtherMalignantCancer,

		[Description("Moderate/severe liver disease")]
		[Coefficient(0.2673)]
		ModerateSevereLiverDisease,

		[Description("Other liver disease")]
		[Coefficient(0.2133)]
		OtherLiverDisease,

		[Description("Hemiplegia or Paraplegia")]
		[Coefficient(0.1061)]
		HemiplegiaOrParaplegia,

		[Description("Dementia")]
		[Coefficient(0.0467)]
		Dementia
	}

	[AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
	public class DescriptionAttribute : Attribute
	{
		public DescriptionAttribute(string description)
		{
			this.Description = description;
		}

		public string Description { get; private set; }
	}

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