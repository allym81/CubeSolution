using System.Collections.Generic;
using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Core.Abstractions
{
    public interface I3DSpace
    {
        IEnumerable<(I3DShape shape, Position3D position)> Shapes { get; }
        void AddShape(I3DShape shape, Position3D position);
    }
}
