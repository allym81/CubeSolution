using CommandLine;

namespace Cubes.Domain.Core.Models
{
    public class Options
    {
        [Value(0)]
        public int C1Height { get; set; }

        [Value(1)]
        public double C1X { get; set; }

        [Value(2)]
        public double C1Y { get; set; }

        [Value(3)]
        public double C1Z { get; set; }

        [Value(4)]
        public int C2Height { get; set; }

        [Value(5)]
        public double C2X { get; set; }

        [Value(6)]
        public double C2Y { get; set; }

        [Value(7)]
        public double C2Z { get; set; }

    }
}