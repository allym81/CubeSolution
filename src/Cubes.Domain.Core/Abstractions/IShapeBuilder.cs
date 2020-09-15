namespace Cubes.Domain.Core.Abstractions
{
    public interface IShapeBuilder
    {
        IParallelepiped CreateCube(int height);
    }
}