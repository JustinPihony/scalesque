﻿using NUnit.Framework;

namespace Scalesque
{
    [TestFixture]
    public abstract class UnitTestBase {

        [TestFixtureSetUp]
        public void PrepareFixture() {
            Given();
            Because();
        }

        public virtual void Given() {}

        public abstract void Because();



    }
}