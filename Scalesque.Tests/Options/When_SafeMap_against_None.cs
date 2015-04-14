using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Scalesque.Options {

    [TestFixture]
    public class When_SafeMap_against_None : UnitTestBase
    {
        private static readonly Option<string> NoneOption = Option.None();

        private Option<string> option;
        
        public override void Because() {
            option = NoneOption.SafeMap<String>(_ => { throw new Exception(); });
        }

        [Test]
        public void It_should_return_none() {
            Option.IsNone(option).Should().BeTrue();
        }
    }
}
