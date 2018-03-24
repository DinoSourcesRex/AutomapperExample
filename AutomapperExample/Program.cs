using System;
using AutomapperExample.Converters.Automapper;
using AutoMapper;
using Serilog;

namespace AutomapperExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(200, Console.WindowHeight);

            var log = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.ColoredConsole()
                .CreateLogger();

            // Load the maping profie
            Mapper.Initialize(cfg => cfg.AddProfile<AssetProfile>());

            // Fake an api model
            var apiAsset = new Api.Models.Asset
            {
                Name = "Asset_01",
                Id = 0111215454,
                TimeStamp = DateTime.Now,
                CustomApiProperty = "I am a random property"
            };

            // Log forwards
            log.Verbose("Api > Business > Repository");
            // Map api > business
            var businessAsset = Mapper.Map<Business.Models.Asset>(apiAsset);
            // Map business to repository
            var repositoryAsset = Mapper.Map<Repository.Models.Asset>(businessAsset);
            // Print
            log.Information("Api {@Asset}", apiAsset);
            log.Information("Business {@Asset}", businessAsset);
            log.Information("Repository {@Asset}", repositoryAsset);

            // Log backwards
            log.Verbose("Repository > Business > Api");
            // Map repository > business
            businessAsset = Mapper.Map<Business.Models.Asset>(repositoryAsset);
            // Map business > api
            apiAsset = Mapper.Map<Api.Models.Asset>(businessAsset);
            // Print
            log.Information("Repository {@Asset}", repositoryAsset);
            log.Information("Business {@Asset}", businessAsset);
            log.Information("Api {@Asset}", apiAsset);

            Console.ReadKey();
        }
    }
}
