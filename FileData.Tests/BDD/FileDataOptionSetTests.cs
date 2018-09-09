using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using NDesk.Options;

namespace FileData.Tests.BDD
{

    [Subject("matching abbreviated functionality version with single dash")]
    public class when_receiving_v_with_a_single_dash
    {
        private static OptionSet optionsSet;
        private static readonly string arg = "-v";
        private static List<String> unmatched;
        private Establish context = () => optionsSet = new FileDataOptionSet();

        Because of = () => unmatched = optionsSet.Parse(new[] { arg });

        It should_not_have_any_unmatched = () => unmatched.ShouldBeEmpty();
    }

    [Subject("matching abbreviated functionality version with double dash")]
    public class when_receiving_v_with_a_double_dash
    {
        private static OptionSet optionsSet;
        private static readonly string arg = "--v";
        private static List<String> unmatched;
        private Establish context = () => optionsSet = new FileDataOptionSet();

        Because of = () => unmatched = optionsSet.Parse(new[] { arg });

        It should_not_have_any_unmatched = () => unmatched.ShouldBeEmpty();
    }

    [Subject("matching abbreviated functionality version with forward slash")]
    public class when_receiving_v_with_a_forward_slash
    {
        private static OptionSet optionsSet;
        private static readonly string arg = "/v";
        private static List<String> unmatched;
        private Establish context = () => optionsSet = new FileDataOptionSet();

        Because of = () => unmatched = optionsSet.Parse(new[] { arg });

        It should_not_have_any_unmatched = () => unmatched.ShouldBeEmpty();
    }

    [Subject("matching abbreviated functionality size with single dash")]
    public class when_receiving_s_with_a_single_dash
    {
        private static OptionSet optionsSet;
        private static readonly string arg = "-s";
        private static List<String> unmatched;
        private Establish context = () => optionsSet = new FileDataOptionSet();

        Because of = () => unmatched = optionsSet.Parse(new[] { arg });

        It should_not_have_any_unmatched = () => unmatched.ShouldBeEmpty();
    }

    [Subject("matching abbreviated functionality size with double dash")]
    public class when_receiving_s_with_a_double_dash
    {
        private static OptionSet optionsSet;
        private static readonly string arg = "--s";
        private static List<String> unmatched;
        private Establish context = () => optionsSet = new FileDataOptionSet();

        Because of = () => unmatched = optionsSet.Parse(new[] { arg });

        It should_not_have_any_unmatched = () => unmatched.ShouldBeEmpty();
    }

    [Subject("matching abbreviated functionality size with forward slash")]
    public class when_receiving_s_with_a_forward_slash
    {
        private static OptionSet optionsSet;
        private static readonly string arg = "/s";
        private static List<String> unmatched;
        private Establish context = () => optionsSet = new FileDataOptionSet();

        Because of = () => unmatched = optionsSet.Parse(new[] { arg });

        It should_not_have_any_unmatched = () => unmatched.ShouldBeEmpty();
    }
}
