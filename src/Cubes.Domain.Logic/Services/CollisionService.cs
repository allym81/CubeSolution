using System;
using Cubes.Domain.Core;
using Cubes.Domain.Core.Abstractions;
using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Logic.Services
{
    public class CollisionService : ICollisionService
    {
        public CollisionResult Collide(I3DSpace space)
        {
            var shapes = space.Shapes;
            // put collision logic here
            throw new NotImplementedException();
        }
    }
}
