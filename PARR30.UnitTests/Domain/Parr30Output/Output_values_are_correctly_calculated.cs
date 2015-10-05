namespace PARR30.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FakeItEasy;

    using Machine.Fakes;
    using Machine.Specifications;

    using PARR30.Domain;

    public class Output_values_are_correctly_calculated
    {
        static Parr30Output parr30Output = null;

        static List<Parr30OutputLine> lines = new List<Parr30OutputLine>()
            {
                new Parr30OutputLine("item 1", 10, 0.6),
                new Parr30OutputLine("item 2", 20, 2.6),
                new Parr30OutputLine("item 3", 30, 2.6)
            };

        Establish Context = () => 
            {
                parr30Output = new Parr30Output(lines);
            };

        It Should_have_set_the_lines_correctly = () => parr30Output.Lines.Count.ShouldEqual(lines.Count);

        It Should_have_calculated_the_Total_is_calculated_correctly = () => parr30Output.Total.ShouldEqual(lines.Sum(line => line.Total));

        It Should_have_calculated_the_probability_correctly = () => parr30Output.Probability.ShouldEqual(Math.Round(Math.Exp(parr30Output.Total) / (1 + Math.Exp(parr30Output.Total)) * 100, 1));
    }
}