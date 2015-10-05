namespace PARR30.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FakeItEasy;

    using Machine.Fakes;
    using Machine.Specifications;

    using PARR30.Domain;

    public class Output_values_are_correctly_calculated_with_2_parameter_ctor
    {
        static Parr30OutputLine line = new Parr30OutputLine("blah blah blah", 0.2);

        It Should_have_set_Information = () => line.Information.ShouldEqual("blah blah blah");

        It Should_have_set_Value_to_null = () => line.Value.HasValue.ShouldBeFalse();

        It Should_have_set_the_Coefficient = () => line.Coefficient.ShouldEqual(0.2);

        It Should_have_set_the_Total_to_be_the_same_as_the_Coefficient = () => line.Total.ShouldEqual(line.Coefficient);
    }
}