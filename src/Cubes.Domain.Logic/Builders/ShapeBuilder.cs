using Cubes.Domain.Core;
using Cubes.Domain.Core.Abstractions;
using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Logic.Builders
{
    public class ShapeBuilder : IShapeBuilder
    {
        public IParallelepiped CreateCube(int height)
        {
            return new Cube(height);
        }
    }
}
