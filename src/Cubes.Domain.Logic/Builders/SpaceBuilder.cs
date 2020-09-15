using System.Collections.Generic;
using System.Linq;
using Cubes.Domain.Core;
using Cubes.Domain.Core.Abstractions;
using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Logic.Builders
{
    public class SpaceBuilder :ISpaceBuilder
    {
        public I3DSpace Create3DSpace(IEnumerable<(I3DShape shape, Position3D position3D)> shapes)
        {
            // TODO Validation
            var space = new Space3D();
            shapes.ToList().ForEach(sp => space.AddShape(sp.shape, sp.position3D));
            return space;
        }
    }
}
