using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    public class OutParametersTests {
        [Test]
        public void out_parameters_one_line_definition() {
            GetCoordinates(out var x, out var y);
            x.Should().Equals(3);
            y.Should().Equals(2);
        }

        private void GetCoordinates(out int x, out int y) {
            x = 3;
            y = 2;
        }
    }

    public class PatternMatching {
        /*
         * Pattern Types
           - constants "c"
           - types "T x"
           - var
         * Patterns constructions keywords
           - is
           - case
         */

        [Test]
        public void constant_pattern () {
            var x = 3;
            (x is 3).Should().BeTrue();
        }
        
        [Test]
        public void type_pattern () {
            var x = 3;
            (x is int y).Should().BeTrue();
            y.Should().Be(3);
        }
    }
}