using AutoFixture;
using AutomapperExample.Converters;
using FluentAssertions;
using NUnit.Framework;

namespace AutomapperUnitTesting.Converters.Extensions.Asset
{
    [TestFixture]
    public class ToBusiness
    {
        private readonly Fixture _fixture = new Fixture();

        [Test]
        public void WhenMappingToBusiness_FromApi_ShouldMap_Name()
        {
            var apiData = _fixture.Create<AutomapperExample.Api.Models.Asset>();
            
            apiData.ConvertToBusiness().Name.Should().Be(apiData.Name);
        }

        [Test]
        public void WhenMappingToBusiness_FromApi_ShouldMap_Id()
        {
            var apiData = _fixture.Create<AutomapperExample.Api.Models.Asset>();

            apiData.ConvertToBusiness().Id.Should().Be(apiData.Id);
        }

        [Test]
        public void WhenMappingToBusiness_FromApi_ShouldMap_TimeStamp()
        {
            var apiData = _fixture.Create<AutomapperExample.Api.Models.Asset>();

            apiData.ConvertToBusiness().TimeStamp.Should().Be(apiData.TimeStamp);
        }

        [Test]
        public void WhenMappingToBusiness_FromApi_ShouldMap_CustomBusinessProperty()
        {
            var apiData = _fixture.Create<AutomapperExample.Api.Models.Asset>();

            apiData.ConvertToBusiness().CustomBusinessProperty.Should().Be(apiData.CustomApiProperty);
        }

        [Test]
        public void WhenMappingToBusiness_FromRepository_ShouldMap_Name()
        {
            var repositoryData = _fixture.Create<AutomapperExample.Repository.Models.Asset>();

            repositoryData.ConvertToBusiness().Name.Should().Be(repositoryData.Name);
        }

        [Test]
        public void WhenMappingToBusiness_FromRepository_ShouldMap_Id()
        {
            var repositoryData = _fixture.Create<AutomapperExample.Repository.Models.Asset>();

            repositoryData.ConvertToBusiness().Id.Should().Be(repositoryData.Id);
        }

        [Test]
        public void WhenMappingToBusiness_FromRepository_ShouldMap_TimeStamp()
        {
            var repositoryData = _fixture.Create<AutomapperExample.Repository.Models.Asset>();

            repositoryData.ConvertToBusiness().TimeStamp.Should().Be(repositoryData.TimeStamp);
        }

        [Test]
        public void WhenMappingToBusiness_FromRepository_ShouldMap_CustomBusinessProperty()
        {
            var repositoryData = _fixture.Create<AutomapperExample.Repository.Models.Asset>();

            repositoryData.ConvertToBusiness().CustomBusinessProperty.Should().Be(repositoryData.CustomRepositoryProperty);
        }
    }
}
