using Cubes.Domain.Core.Models;

namespace Cubes.Domain.Core.Abstractions
{

    public interface ICollisionService
    {
        CollisionResult Collide(I3DSpace space);
    }
}
