using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    public class TuplesTests {
        /*
            Getting more than one value from a method
            Old way:
                - dynamics (performance and no static)
                - artifical temporary objects
                - out parameters (no async support)
         */

        [Test]
        public void basic_tuple() {
            (string, string) GetFirstTuple() {
                return ("Codely", "TV");
            }
            GetFirstTuple().Item1.Should().Be("Codely");
            GetFirstTuple().Item2.Should().Be("TV");
        }
    }
}