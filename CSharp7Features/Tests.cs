using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;

namespace Tests {
    public class Tests {
        [Test]
        public void out_parameters_one_line_definition() {
            GetCoordinates(out var x, out var y);
            Assert.AreEqual(x, 3);
            Assert.AreEqual(y, 2);
        }

        private void GetCoordinates(out int x, out int y) {
            x = 3;
            y = 2;
        }
    }
}