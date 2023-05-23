using Xunit.Abstractions;

namespace TestProject
{
    public class UnitTest1
    {
        ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            _output.WriteLine("Does 1 equal 1....");
            Assert.Equal(1,1);
        }

        [Fact]
        public void Test2()
        {
            _output.WriteLine("Does 1 equal 1....");
            Assert.Equal(2, 2);
        }
    }
}