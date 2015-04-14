using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Scalesque.Options {

    [TestFixture]
    public class When_FirstOption_is_called : UnitTestBase {
        public override void Because() {}

        [Test]
        public void It_should_be_none_for_empty_list() {
            var firstOption = new List<Option<string>>().FirstOption();
            Option.IsNone(firstOption).Should().BeTrue();
        }

        [Test]
        public void It_should_be_some_for_a_non_empty_list()
        {
            var firstOption = new List<string>{"value"}.FirstOption();
            Option.IsNone(firstOption).Should().BeFalse();
        }
    }
}
