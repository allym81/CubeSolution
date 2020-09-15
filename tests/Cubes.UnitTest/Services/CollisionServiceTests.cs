using Cubes.Domain.Core.Models;
using Cubes.Domain.Logic.Builders;
using Cubes.Domain.Logic.Services;
using Xunit;

namespace Cubes.UnitTest.Services
{
    public class CollisionServiceTests
    {
        [Fact]
        public void No_Objects_Should_Not_Collide()
        {
            var space = new Space3D();
            var collisionService = new CollisionService();
            var result= collisionService.Collide(space);
            Assert.False(result.IsCollision);
        }

        [Fact]
        public void One_Object_Should_Not_Collide()
        {
            var space = new Space3D();
            space.AddShape(new Cube(2), new Position3D(1,2,3));
            var collisionService = new CollisionService();
            var result = collisionService.Collide(space);
            Assert.False(result.IsCollision);
            Assert.Equal(0, result.CollisionVolume);
        }

        [Fact]
        public void Two_Objects_Should_Not_Collide()
        {
            var space = new Space3D();
            space.AddShape(new Cube(2), new Position3D(1, 2, 3));
            space.AddShape(new Cube(2), new Position3D(1, 5, 3));
            var collisionService = new CollisionService();
            var result = collisionService.Collide(space);
            Assert.True(result.IsCollision);
            Assert.Equal(4, result.CollisionVolume);
        }
    }
}
