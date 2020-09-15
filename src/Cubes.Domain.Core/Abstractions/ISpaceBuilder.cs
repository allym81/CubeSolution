using System.Collections.Generic;
using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Core.Abstractions
{
    public interface ISpaceBuilder
    {
        I3DSpace Create3DSpace(IEnumerable<(I3DShape shape, Position3D position3D)> shapes);
    }
}
