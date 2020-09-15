using System;
using Cubes.Domain.Core.Abstractions;
using Cubes.Domain.Logic.Builders;
using Moq;
using Xunit;

namespace Cubes.UnitTest.Builders
{
    public class ShapeBuilderUnitTest
    {
        [Trait("Category", "UnitTest")]
        [Fact(DisplayName = "ShapeBuilder-Should Create new cube")]
        public void ShapeBuilder_Should_Create_New_Cube()
        {
            var height = 5;
            var shapeBuider = new ShapeBuilder();
            var result = shapeBuider.CreateCube(height);
            Assert.True(result != null);
            Assert.Equal(5, result.Height);
            Assert.Equal(5, result.Length);
            Assert.Equal(5, result.Width);
        }

        [Fact(DisplayName = "ShapeBuilder-Should Not Create new cube")]
        public void ShapeBuilder_Should_Throw_Exception()
        {
            var height = 0;
            var shapeBuider = new ShapeBuilder();
            Assert.Throws<ArgumentException>(() => shapeBuider.CreateCube(height));
        }
    }
}
