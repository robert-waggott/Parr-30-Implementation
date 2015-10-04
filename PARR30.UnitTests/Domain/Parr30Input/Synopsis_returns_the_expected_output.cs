namespace PARR30.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FakeItEasy;

    using Machine.Fakes;
    using Machine.Specifications;

    using PARR30.Domain;

    public class Synopsis_returns_the_expected_output : WithSubject<Parr30Input>
    {
        static List<string> parts = new List<string>();

        Establish Context = () => 
            {
                Subject.Age = 54;

                Subject.CurrentAdmissionIsEmergencyOrUnPlanned = true;

                Subject.DeprivationScore = 2.1;

                Subject.HealthConditions = new List<HealthCondition>()
                    {
                        HealthCondition.ChronicPulmonaryDisease,
                        HealthCondition.CongestiveHeartFailure,
                        HealthCondition.Dementia
                    };

                Subject.Hospital = new Hospital() 
                    {
                        Name = "Whipps cross",
                        Coefficient = 4.3
                    };

                Subject.NumberOfAdmissionsLastYear = 2;

                Subject.AdmissionInLastMonth = true;
            };

        Because Of = () => 
            {
                parts = Subject.Synopsis
                    .Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
                    .Select(part => part.Trim())
                    .ToList();
            };

        It Should_contain_health_conditions_as_first_part = () => parts.ToArray()[0].ShouldEqual("Health conditions: Chronic pulmonary disease, Congestive heart failure, Dementia");

        It Should_contain_hospital_as_second_part = () => parts.ToArray()[1].ShouldEqual("Hospital: Whipps cross (4.3)");

        It Should_contain_age_as_third_part = () => parts.ToArray()[2].ShouldEqual("Age: 54");

        It Should_contain_deprivation_score_as_fourth_part = () => parts.ToArray()[3].ShouldEqual("Deprivation score: 2.1");

        It Should_contain_number_of_admissions_in_last_year_as_fifth_part = () => parts.ToArray()[4].ShouldEqual("# of admissions in last year: 2");

        It Should_contain_admissions_in_last_month_as_sixth_part = () => parts.ToArray()[5].ShouldEqual("Admission in last month?: True");

        It Should_contain_is_current_admission_an_emergency_as_seventh_part = () => parts.ToArray()[6].ShouldEqual("Is current admission emergency/un-planned?: True");
    }
}