using System;
using System.Collections.Generic;
using System.Linq;
using AutomapperExample.Converters;
using AutomapperExample.Converters.Automapper;
using AutoMapper;
using BenchmarkDotNet.Attributes;

namespace AutomapperBenchmarking
{
    public class Mappings
    {
        private AutomapperExample.Api.Models.Asset _initialRequest;

        private List<AutomapperExample.Api.Models.Asset> _initialRequestList;

        [GlobalSetup]
        public void Setup()
        {
            Mapper.Initialize(cfg => cfg.AddProfile<AssetProfile>());
            Mapper.Configuration.CompileMappings();

            _initialRequest = new AutomapperExample.Api.Models.Asset
            {
                Name = "Asset_01",
                Id = 0111215454,
                TimeStamp = DateTime.Now,
                CustomApiProperty = "I am a random property"
            };

            _initialRequestList = new List<AutomapperExample.Api.Models.Asset>();

            for (int i = 0; i < 1000000; i++)
            {
                _initialRequestList.Add(new AutomapperExample.Api.Models.Asset
                {
                    Name = "Asset_01",
                    Id = 0111215454,
                    TimeStamp = DateTime.Now,
                    CustomApiProperty = "I am a random property"
                });
            }
        }

        [Benchmark]
        public AutomapperExample.Api.Models.Asset AutomapperMapping()
        {
            // Forward
            var businessAsset = Mapper.Map<AutomapperExample.Business.Models.Asset>(_initialRequest);
            var repositoryAsset = Mapper.Map<AutomapperExample.Repository.Models.Asset>(businessAsset);
            // Backward
            businessAsset = Mapper.Map<AutomapperExample.Business.Models.Asset>(repositoryAsset);
            return Mapper.Map<AutomapperExample.Api.Models.Asset>(businessAsset);
        }

        [Benchmark]
        public List<AutomapperExample.Api.Models.Asset> AutomapperMappingList()
        {
            // Forward
            var businessAsset = Mapper.Map<List<AutomapperExample.Business.Models.Asset>>(_initialRequestList);
            var repositoryAsset = Mapper.Map<List<AutomapperExample.Repository.Models.Asset>>(businessAsset);
            // Backward
            businessAsset = Mapper.Map<List<AutomapperExample.Business.Models.Asset>>(repositoryAsset);
            return Mapper.Map<List<AutomapperExample.Api.Models.Asset>>(businessAsset);
        }

        [Benchmark]
        public AutomapperExample.Api.Models.Asset PocoMapping()
        {
            // Forward
            var businessAsset = _initialRequest.ConvertToBusiness();
            var repositoryAsset = businessAsset.ConvertToRepository();
            // Backward
            businessAsset = repositoryAsset.ConvertToBusiness();
            return businessAsset.ConvertToApi();
        }

        [Benchmark]
        public List<AutomapperExample.Api.Models.Asset> PocoMappingList()
        {
            // Forward
            var businessAsset = _initialRequestList.Select(r => r.ConvertToBusiness());
            var repositoryAsset = businessAsset.Select(r => r.ConvertToRepository());
            // Backward
            businessAsset = repositoryAsset.Select(r => r.ConvertToBusiness());
            return businessAsset.Select(r => r.ConvertToApi()).ToList();
        }
    }
}
