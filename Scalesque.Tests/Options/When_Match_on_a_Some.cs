using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Scalesque.Options {

    [TestFixture]
    public class When_Match_on_a_Some : UnitTestBase
    {
        private static readonly Option<string> SomeOption = Option.apply("value");
        private static Boolean matchResult;

        public override void Because() {
            matchResult = SomeOption.Match<Boolean>(Some: _ => true, None: () => false);
        }

        [Test]
        public void Some_function_should_be_called() {
            matchResult.Should().BeTrue();
        }
    }
}
