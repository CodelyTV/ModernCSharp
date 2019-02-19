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
}