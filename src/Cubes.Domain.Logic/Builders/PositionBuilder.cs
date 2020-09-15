using Cubes.Domain.Core;
using Cubes.Domain.Core.Abstractions;
using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Logic.Builders
{
    public class PositionBuilder :IPositionBuilder
    {
        public Position3D CreatePosition3D((double x, double y, double z) position)
        {
            return new Position3D(position.x, position.y, position.z);
        }
    }
}
