using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Scalesque.Options {

    [TestFixture]
    public class When_Match_on_a_None : UnitTestBase {
      private static readonly Option<string> SomeOption = Option.None();
      private static Boolean matchResult;

      public override void Because()
      {
        matchResult = SomeOption.Match<Boolean>(Some: _ => false, None: () => true);
      }

      [Test]
      public void None_function_should_be_called()
      {
        matchResult.Should().BeTrue();
      }
    }
}
