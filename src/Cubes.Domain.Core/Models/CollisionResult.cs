namespace Cubes.Domain.Core.Models
{
    public sealed class CollisionResult
    {
        public bool IsCollision { get; }

        public double CollisionVolume { get; }

        public CollisionResult(bool isCollision, double collisionVolume)
        {
            IsCollision = isCollision;
            CollisionVolume = collisionVolume;
        }
    }
}
