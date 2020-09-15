using CommandLine;
using Cubes.Domain.Core.Abstractions;
using Cubes.Domain.Core.Models;
using Cubes.Domain.Logic.Builders;
using Cubes.Domain.Logic.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(RunApp,
                _ => Task.FromResult(0));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static async Task<int> RunApp(Options opt)
        {
            var collection = new ServiceCollection();
            collection.AddScoped<ISpaceBuilder, SpaceBuilder>();
            collection.AddScoped<IShapeBuilder, ShapeBuilder>();
            collection.AddScoped<IPositionBuilder, PositionBuilder>();
            collection.AddScoped<ICollisionService, CollisionService>();
            var serviceProvider = collection.BuildServiceProvider();
            var shapeBuilder = serviceProvider.GetService<IShapeBuilder>();
            var spaceBuilder = serviceProvider.GetService<ISpaceBuilder>();
            var collsionService = serviceProvider.GetService<ICollisionService>();
            var positionBuilder = serviceProvider.GetService<IPositionBuilder>();

            var cube1 = shapeBuilder.CreateCube(opt.C1Height);
            var cube2 = shapeBuilder.CreateCube(opt.C2Height);
            var position1 = positionBuilder.CreatePosition3D((opt.C1X, opt.C1Y, opt.C1Z));
            var position2 = positionBuilder.CreatePosition3D((opt.C2X, opt.C2Y, opt.C2Z));

            var listOfElements = new List<(I3DShape shape, Position3D position3D)>
            {
                (cube1, position1),
                (cube2, position2),
            };
            var space3D = spaceBuilder.Create3DSpace(listOfElements);
            var result = collsionService.Collide(space3D);
            Console.WriteLine(result);

            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
            return await Task.FromResult(1);
        }
    }
}
