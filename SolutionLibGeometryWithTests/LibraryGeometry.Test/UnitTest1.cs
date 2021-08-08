using System;
using Xunit;

namespace LibraryGeometry.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ÑircleTest()
        {
            Assert.Equal(Math.PI * 2 * 2, Square.Ñircle(2));
            Assert.Equal(double.NaN, Square.Ñircle(0));
            Assert.Equal(Math.PI, Square.Ñircle(1));
            Assert.Equal(double.NaN, Square.Ñircle(-1));
        }

        [Fact]
        public void TriangleTest()
        {
            Assert.Equal(Math.Sqrt(0.1875), Square.Triangle(1, 1, 1));
            Assert.Equal(double.NaN, Square.Triangle(0, 0, 0));
            Assert.Equal(double.NaN, Square.Triangle(-1, 1, 0));
            Assert.Equal(double.NaN, Square.Triangle(-1, -1, -1));
            Assert.Equal(12, Square.Triangle(5, 5, 8));
        }

        [Fact]
        public void IsTriangleTest()
        {
            Assert.True(Square.IsTriangle(1, 1, 1));
            Assert.False(Square.IsTriangle(0, 0, 0));
            Assert.True(Square.IsTriangle(5, 5, 8));
            Assert.False(Square.IsTriangle(-1, 1, 1));
        }

        [Fact]
        public void IsRightTriangleTest()
        {
            Assert.False(Square.IsRightTriangle(1, 1, 1));
            Assert.False(Square.IsRightTriangle(5, 3, 2));
            Assert.False(Square.IsRightTriangle(0, 0, 0));
            Assert.False(Square.IsRightTriangle(5, 3, 3.5));
            Assert.True(Square.IsRightTriangle(4, 3, 5));
            Assert.False(Square.IsRightTriangle(-1, 1, 1));
        }
    }
}
