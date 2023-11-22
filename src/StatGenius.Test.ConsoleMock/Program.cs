

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StatGenius.DataFeed.Models.Repository;
using StatGenius.DataFeed.Models.Repository.Implementation;

class Program
{
    public static IConfiguration Configuration { get; set; }

    static async Task Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddEnvironmentVariables();

        Configuration = builder.Build();

        serviceCollection.AddLogging(c => c.AddConsole());
        serviceCollection.AddSingleton<IConfiguration>(Configuration);
        serviceCollection.AddSingleton<ITypesRepository, TypesRepository>();
        serviceCollection.AddSingleton<IBookmakersRepository, BookmakersRepository>();
        var serviceProvider = serviceCollection.BuildServiceProvider();

        var sportMonksWorker_types = serviceProvider.GetService<ITypesRepository>();
        var sportMonksWorker_bookmakers = serviceProvider.GetService<IBookmakersRepository>();

        Console.WriteLine("What do you want to do?");
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1: Test SportMonks Types");
            Console.WriteLine();
            Console.Write("Write your choice number:");
            Console.ResetColor();

            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    Console.WriteLine(await sportMonksWorker_types.GetAll());
                    continue;
                case "2":
                    Console.WriteLine(await sportMonksWorker_bookmakers.GetAll());
                    continue;
                case "x":
                    break;
            }

            Console.WriteLine("Execution finished. Press any key to exit");
            Console.ReadLine();
        }
    }

}