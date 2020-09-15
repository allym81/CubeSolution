using System.Collections.Generic;
using System.Linq;
using Cubes.Domain.Core.Abstractions;
using Cubes.Domain.Core.Models;
using Cubes.Domain.Logic.Builders;
using Xunit;

namespace Cubes.UnitTest.Builders
{
    public class SpaceBuilderTests
    {
        [Fact]
        public void Should_Create_New_Space_With_No_Items()
        {
            var spaceBuilder = new SpaceBuilder();
            var space = spaceBuilder.Create3DSpace(new List<(I3DShape shape, Position3D position3D)>());
            Assert.Empty(space.Shapes);
        }

        [Fact]
        public void Should_Create_New_Space_With_Items()
        {
            var spaceBuilder = new SpaceBuilder();
            var space = spaceBuilder.Create3DSpace(new List<(I3DShape shape, Position3D position3D)>
            {
                (new Cube(2), new Position3D(1,2,3)),
                (new Cube(3), new Position3D(4,5,6))
            });
            Assert.Equal(2, space.Shapes.Count());
        }
    }
}
