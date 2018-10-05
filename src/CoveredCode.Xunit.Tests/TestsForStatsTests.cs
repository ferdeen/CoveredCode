using System;
using FluentAssertions;
using Xunit;

namespace CoveredCode.Xunit.Tests
{
    public class TestsForStatsTests
    {
        [Fact]
        public void DodgyTest_RandomlyFails()
        {
            var random = new Random(DateTime.Now.Millisecond);
            var shouldTestFail = random.Next(0, 100) > 70;

            shouldTestFail.Should().BeFalse();
        }

        #region always working
        [Fact] public void Works001() { true.Should().BeTrue(); }
        [Fact] public void Works002() { true.Should().BeTrue(); }
        [Fact] public void Works003() { true.Should().BeTrue(); }
        [Fact] public void Works004() { true.Should().BeTrue(); }
        [Fact] public void Works005() { true.Should().BeTrue(); }
        [Fact] public void Works006() { true.Should().BeTrue(); }
        [Fact] public void Works007() { true.Should().BeTrue(); }
        [Fact] public void Works008() { true.Should().BeTrue(); }
        [Fact] public void Works009() { true.Should().BeTrue(); }
        [Fact] public void Works010() { true.Should().BeTrue(); }
        [Fact] public void Works011() { true.Should().BeTrue(); }
        [Fact] public void Works012() { true.Should().BeTrue(); }
        [Fact] public void Works013() { true.Should().BeTrue(); }
        [Fact] public void Works014() { true.Should().BeTrue(); }
        [Fact] public void Works015() { true.Should().BeTrue(); }
        [Fact] public void Works016() { true.Should().BeTrue(); }
        [Fact] public void Works017() { true.Should().BeTrue(); }
        [Fact] public void Works018() { true.Should().BeTrue(); }
        [Fact] public void Works019() { true.Should().BeTrue(); }
        [Fact] public void Works020() { true.Should().BeTrue(); }
        [Fact] public void Works021() { true.Should().BeTrue(); }
        [Fact] public void Works022() { true.Should().BeTrue(); }
        [Fact] public void Works023() { true.Should().BeTrue(); }
        [Fact] public void Works024() { true.Should().BeTrue(); }
        [Fact] public void Works025() { true.Should().BeTrue(); }
        [Fact] public void Works026() { true.Should().BeTrue(); }
        [Fact] public void Works027() { true.Should().BeTrue(); }
        [Fact] public void Works028() { true.Should().BeTrue(); }
        [Fact] public void Works029() { true.Should().BeTrue(); }
        [Fact] public void Works030() { true.Should().BeTrue(); }
        [Fact] public void Works031() { true.Should().BeTrue(); }
        [Fact] public void Works032() { true.Should().BeTrue(); }
        [Fact] public void Works033() { true.Should().BeTrue(); }
        [Fact] public void Works034() { true.Should().BeTrue(); }
        [Fact] public void Works035() { true.Should().BeTrue(); }
        [Fact] public void Works036() { true.Should().BeTrue(); }
        [Fact] public void Works037() { true.Should().BeTrue(); }
        [Fact] public void Works038() { true.Should().BeTrue(); }
        [Fact] public void Works039() { true.Should().BeTrue(); }
        [Fact] public void Works040() { true.Should().BeTrue(); }
        [Fact] public void Works041() { true.Should().BeTrue(); }
        [Fact] public void Works042() { true.Should().BeTrue(); }
        [Fact] public void Works043() { true.Should().BeTrue(); }
        [Fact] public void Works044() { true.Should().BeTrue(); }
        [Fact] public void Works045() { true.Should().BeTrue(); }
        [Fact] public void Works046() { true.Should().BeTrue(); }
        [Fact] public void Works047() { true.Should().BeTrue(); }
        [Fact] public void Works048() { true.Should().BeTrue(); }
        [Fact] public void Works049() { true.Should().BeTrue(); }
        [Fact] public void Works050() { true.Should().BeTrue(); }
        [Fact] public void Works051() { true.Should().BeTrue(); }
        [Fact] public void Works052() { true.Should().BeTrue(); }
        [Fact] public void Works053() { true.Should().BeTrue(); }
        [Fact] public void Works054() { true.Should().BeTrue(); }
        [Fact] public void Works055() { true.Should().BeTrue(); }
        [Fact] public void Works056() { true.Should().BeTrue(); }
        [Fact] public void Works057() { true.Should().BeTrue(); }
        [Fact] public void Works058() { true.Should().BeTrue(); }
        [Fact] public void Works059() { true.Should().BeTrue(); }
        [Fact] public void Works060() { true.Should().BeTrue(); }
        [Fact] public void Works061() { true.Should().BeTrue(); }
        [Fact] public void Works062() { true.Should().BeTrue(); }
        [Fact] public void Works063() { true.Should().BeTrue(); }
        [Fact] public void Works064() { true.Should().BeTrue(); }
        [Fact] public void Works065() { true.Should().BeTrue(); }
        [Fact] public void Works066() { true.Should().BeTrue(); }
        [Fact] public void Works067() { true.Should().BeTrue(); }
        [Fact] public void Works068() { true.Should().BeTrue(); }
        [Fact] public void Works069() { true.Should().BeTrue(); }
        [Fact] public void Works070() { true.Should().BeTrue(); }
        [Fact] public void Works071() { true.Should().BeTrue(); }
        [Fact] public void Works072() { true.Should().BeTrue(); }
        [Fact] public void Works073() { true.Should().BeTrue(); }
        [Fact] public void Works074() { true.Should().BeTrue(); }
        [Fact] public void Works075() { true.Should().BeTrue(); }
        [Fact] public void Works076() { true.Should().BeTrue(); }
        [Fact] public void Works077() { true.Should().BeTrue(); }
        [Fact] public void Works078() { true.Should().BeTrue(); }
        [Fact] public void Works079() { true.Should().BeTrue(); }
        [Fact] public void Works080() { true.Should().BeTrue(); }
        [Fact] public void Works081() { true.Should().BeTrue(); }
        [Fact] public void Works082() { true.Should().BeTrue(); }
        [Fact] public void Works083() { true.Should().BeTrue(); }
        [Fact] public void Works084() { true.Should().BeTrue(); }
        [Fact] public void Works085() { true.Should().BeTrue(); }
        [Fact] public void Works086() { true.Should().BeTrue(); }
        [Fact] public void Works087() { true.Should().BeTrue(); }
        [Fact] public void Works088() { true.Should().BeTrue(); }
        [Fact] public void Works089() { true.Should().BeTrue(); }
        [Fact] public void Works090() { true.Should().BeTrue(); }
        [Fact] public void Works091() { true.Should().BeTrue(); }
        [Fact] public void Works092() { true.Should().BeTrue(); }
        [Fact] public void Works093() { true.Should().BeTrue(); }
        [Fact] public void Works094() { true.Should().BeTrue(); }
        [Fact] public void Works095() { true.Should().BeTrue(); }
        [Fact] public void Works096() { true.Should().BeTrue(); }
        [Fact] public void Works097() { true.Should().BeTrue(); }
        [Fact] public void Works098() { true.Should().BeTrue(); }
        [Fact] public void Works099() { true.Should().BeTrue(); }
        [Fact] public void Works100() { true.Should().BeTrue(); }

        #endregion
    }
}
