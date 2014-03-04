namespace PARR30.Domain
{
	using System;
	using System.Linq;

	using PARR30.Domain.Attributes;

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

	public static class HealthConditionExtensionMethods
	{
		public static string GetDescription(this HealthCondition healthCondition)
		{
			var attribute = healthCondition.GetType()
				.GetMember(healthCondition.ToString())[0]
				.GetCustomAttributes(typeof(DescriptionAttribute), false)
				.FirstOrDefault() as DescriptionAttribute;

			return attribute != null ? attribute.Description : null;
		}

		public static double GetCoefficient(this HealthCondition healthCondition)
		{
			var attribute = healthCondition.GetType()
				.GetMember(healthCondition.ToString())[0]
				.GetCustomAttributes(typeof(CoefficientAttribute), false)
				.FirstOrDefault() as CoefficientAttribute;

			return attribute != null ? attribute.Coefficient : 0;
		}
	}
}