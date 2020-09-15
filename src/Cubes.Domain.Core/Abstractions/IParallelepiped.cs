namespace Cubes.Domain.Core.Abstractions
{
    public interface IParallelepiped : I3DShape
    {
        int Length { get; }
        int Width { get; }
        int Height { get; }
    }

    // can add round shapes
}