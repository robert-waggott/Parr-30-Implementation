namespace PARR30.UnitTests
{
    using System;

    using FakeItEasy;

    using Machine.Fakes;
    using Machine.Specifications;

    using PARR30.Domain;

    public class HealthConditions_defaults_to_an_empty_list : WithSubject<Parr30Input>
    {
        It Should_have_a_list_that_isnt_null = () => Subject.HealthConditions.ShouldNotBeNull();

        It Should_have_an_empty_list = () => Subject.HealthConditions.ShouldBeEmpty();
    }
}