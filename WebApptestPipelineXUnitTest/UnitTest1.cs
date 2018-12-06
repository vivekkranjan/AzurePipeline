using System;
using Xunit;

namespace WebApptestPipelineXUnitTest
{
     
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(string.Empty, string.Empty);
        }
        [Fact]
        public void Test2()
        {
            Assert.True(true);
        }
    }
}
