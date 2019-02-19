using System;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    public class PatternMatchingTests {
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
            y.Should().Be(x); // note that y is visible here
        }

        [Test]
        public void var_pattern () {
            var x = 3;
            (x is var y).Should().BeTrue(); 
            y.Should().Be(x);
        }

        [Test]
        public void patterns_in_switch_case () {
            Shape rectangle = new Rectangle(2, 4);
            Shape square = new Rectangle(2, 2);
            Shape circle = new Circle(2);
            
            string ToString(Shape shape) { // local function
                switch (shape) { // case patterns
                    case Circle c: 
                        return $"circle with radius: {c.Radius}"; // string interpolation
                    case Rectangle s when (s.Width == s.Height):  // order matterns
                        return $"square with size: {s.Width}";
                    case Rectangle r: 
                        return $"rectangle with sizes: {r.Width} x {r.Height}";
                    case null:
                        throw new ArgumentNullException();
                    default:
                        return string.Empty;
                }    
            }

            Func<string> nullCase = () => ToString((Circle) null);
            nullCase.Should().Throw<ArgumentNullException>();            
            ToString(rectangle).Should().Be("rectangle with sizes: 2 x 4");
            ToString(square).Should().Be("square with size: 2");
            ToString(circle).Should().Be("circle with radius: 2");
        }
    }
}