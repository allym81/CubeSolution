using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Core.Abstractions
{
    public interface IPositionBuilder
    {
        Position3D CreatePosition3D((double x, double y, double z) position);
    }
}