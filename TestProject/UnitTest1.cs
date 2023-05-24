using System.Globalization;
using TimeZoneNames;
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
            var name = GetFormattedDateTime();

            _output.WriteLine("Does 1 equal 1....");
            Assert.Equal("bob",name);
        }

        [Fact]
        public void Test2()
        {
            _output.WriteLine("Does 1 equal 1....");
            Assert.Equal(2, 2);
        }

        private static string GetFormattedDateTime()
        {
            try
            {
                var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id);
                var abbreviation = TZNames.GetAbbreviationsForTimeZone(timeZoneInfo.Id, CultureInfo.CurrentCulture.Name).Standard;

                //return DateTime.Now.ToString($"ddd MMM dd HH:mm:ss '{abbreviation}' yyyy");

                return "bob";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not find language for the code {CultureInfo.CurrentCulture.Name}");
                throw;
            }
            
        }

    }
}