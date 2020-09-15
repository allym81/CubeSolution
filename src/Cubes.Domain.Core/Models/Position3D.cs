namespace Cubes.Domain.Core.Models
{
    public sealed class Position3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Position3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}