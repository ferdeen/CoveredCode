using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoveredCode.MsTest.Tests
{
    [TestClass]
    public class SquareRootTests
    {
        [TestMethod]
        public void SquareRoot_ThrowsOnNegative()
        {
            var covered = new Covered();
            new Action(() => covered.SquareRoot(-25)).Should().Throw<NotImplementedException>();
        }
    }
}
