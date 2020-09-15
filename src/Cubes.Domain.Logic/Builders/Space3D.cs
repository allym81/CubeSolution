using System;
using System.Collections.Generic;
using Cubes.Domain.Core;
using Cubes.Domain.Core.Abstractions;
using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Logic.Builders
{
    public class Space3D : I3DSpace
    {
        public IEnumerable<(I3DShape shape, Position3D position)> Shapes { get; }
        public void AddShape(I3DShape shape, Position3D position)
        {
            throw new NotImplementedException();
        }
    }
}