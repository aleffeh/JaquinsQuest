using Autofac;
using JaquinAdventures.Core.Containers;
using JaquinAdventures.Abstractions;

namespace JaquinAdventures
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}