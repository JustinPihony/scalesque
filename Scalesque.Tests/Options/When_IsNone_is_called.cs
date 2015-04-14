using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Scalesque.Options {

    [TestFixture]
    public class When_IsNone_is_called : UnitTestBase {
        public override void Because() {}

        [Test]
        public void It_should_be_true_for_none() {
            Option.IsNone(Option.None()).Should().BeTrue();
        }

        [Test]
        public void It_should_be_true_for_noneT()
        {
            Option.IsNone(Option.apply<string>(null)).Should().BeTrue();
        }

        [Test]
        public void It_should_be_false_for_some()
        {
            Option.IsNone(Option.apply("value")).Should().BeFalse();
        }
    }
}
