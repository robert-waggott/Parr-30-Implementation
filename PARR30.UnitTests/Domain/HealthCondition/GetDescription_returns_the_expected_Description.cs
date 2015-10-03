namespace PARR30.UnitTests
{
    using System;

    using FakeItEasy;

    using Machine.Fakes;
    using Machine.Specifications;

    using PARR30.Domain;

    public class GetDescription_returns_the_expected_Description
    {
        static HealthCondition condition = HealthCondition.Dementia;

        It Should_have_the_expected_attribute  = () => condition.GetDescription().ShouldEqual("Dementia");
    }
}