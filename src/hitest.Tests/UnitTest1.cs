using Xunit;

namespace hitest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TrueShouldBeTrue() 
            => Assert.True(true);

        [Fact]
        public void TrueShouldBeFalse()
            => Assert.False(true);
    }
}
