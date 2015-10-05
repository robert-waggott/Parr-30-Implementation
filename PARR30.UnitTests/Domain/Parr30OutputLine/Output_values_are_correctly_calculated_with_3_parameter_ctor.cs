namespace PARR30.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FakeItEasy;

    using Machine.Fakes;
    using Machine.Specifications;

    using PARR30.Domain;

    public class Output_values_are_correctly_calculated_with_3_parameter_ctor
    {
        static Parr30OutputLine line = new Parr30OutputLine("blah blah blah", 100, 0.4);

        It Should_have_set_Information = () => line.Information.ShouldEqual("blah blah blah");

        It Should_have_set_Value = () => line.Value.HasValue.ShouldBeTrue();

        It Should_have_set_Value_correctly = () => line.Value.ShouldEqual(100);

        It Should_have_set_the_Coefficient = () => line.Coefficient.ShouldEqual(0.4);

        It Should_have_set_the_Total_correctly = () => line.Total.ShouldEqual(Math.Round(line.Value.Value * line.Coefficient, 3));
    }
}