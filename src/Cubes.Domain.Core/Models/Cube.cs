using System;
using Cubes.Domain.Core.Abstractions;

namespace Cubes.Domain.Core.Models
{
    public class Cube : IParallelepiped
    {
        public int Length { get; }
        public int Width { get; }
        public int Height { get; }
        public Cube(int height)
        {
            if (height <= 0) 
                throw new ArgumentException(nameof(height));

            Width = Length = Height = height;
        }

        public double Area() => Width ^ 2;

        public double Perimeter() => 6 * (Height ^ 2);
        public double Volume() => Height ^ 3;
        public (double x, double y, double z) CalculateCenter(Position3D position)
        {
            throw new NotImplementedException();
        }
    }
}