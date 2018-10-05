using System;
using FluentAssertions;
using Xunit;

namespace CoveredCode.Tests
{
    public class SquareRootTests
    {
        [Fact]
        public void SquareRoot_ThrowsOnNegative()
        {
            var covered = new Covered();
            new Action(() => covered.SquareRoot(-25)).Should().Throw<NotImplementedException>();
        }

        [Fact]
        public void SquareRoot_ThrowsOnNonIntegerRoot()
        {
            var covered = new Covered();
            new Action(() => covered.SquareRoot(37)).Should().Throw<NotImplementedException>();
        }
    }
}
