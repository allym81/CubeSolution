using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Core.Abstractions
{
    public interface I3DShape : IShape
    {
        double Volume();
        (double x, double y, double z) CalculateCenter(Position3D position);
    }
}