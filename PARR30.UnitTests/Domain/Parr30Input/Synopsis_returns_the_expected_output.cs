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
                
            };

        Because Of = () => 
            {
                parts = Subject.Synopsis
                    .Split(',')
                    .Select(part => part.Trim())
                    .ToList();
            };

        It Should_contain_age_as_third_part = () => {};

        It Should_contain_deprivation_score_as_fourth_part = () => {};

        It Should_contain_number_of_admissions_in_last_year_as_fifth_part = () => {};
    }
}