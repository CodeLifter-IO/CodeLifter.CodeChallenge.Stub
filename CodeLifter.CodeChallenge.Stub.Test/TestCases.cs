using System;
using Xunit;

namespace CodeLifter.CodeChallenge.Stub.Test
{
    public class TestCases
    {
        [Fact]
        public void TestSimulateFailure()
        {
            Assert.False(true);
        }

        [Fact]
        public void TestSimulateSuccess()
        {
            Assert.False(false);
        }
    }
}
