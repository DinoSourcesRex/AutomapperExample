using AutoFixture;
using AutoMapper;
using FluentAssertions;
using NUnit.Framework;

namespace AutomapperUnitTesting.Converters.Automapper.AssetProfile
{
    /// <summary>
    /// This class contains two mappings.
    /// 
    /// The format is to test what maps to the model, rather than what maps from the model.
    ///     Here we are testing Api > Business and Repository > Business
    /// 
    /// It may be a better idea, if the models were larger and more complex, to split these clases even further
    ///     AssetProfileToBusinessFromApiTests
    ///     AssetProfileToBusinessFromRepositoryTests
    /// </summary>
    [TestFixture]
    public class AssetProfileToBusinessTests : AutomapperProfileTestBase<AutomapperExample.Converters.Automapper.AssetProfile>
    {
        private readonly Fixture _fixture = new Fixture();

        private IMapper _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = InitializeMapper();
        }

        [Test]
        public void WhenMappingToBusiness_FromApi_ShouldMap_Name()
        {
            var apiData = _fixture.Create<AutomapperExample.Api.Models.Asset>();

            var result = _sut.Map<AutomapperExample.Business.Models.Asset>(apiData);
            result.Name.Should().Be(apiData.Name);
        }

        [Test]
        public void WhenMappingToBusiness_FromApi_ShouldMap_Id()
        {
            var apiData = _fixture.Create<AutomapperExample.Api.Models.Asset>();

            var result = _sut.Map<AutomapperExample.Business.Models.Asset>(apiData);
            result.Id.Should().Be(apiData.Id);
        }

        [Test]
        public void WhenMappingToBusiness_FromApi_ShouldMap_TimeStamp()
        {
            var apiData = _fixture.Create<AutomapperExample.Api.Models.Asset>();

            var result = _sut.Map<AutomapperExample.Business.Models.Asset>(apiData);
            result.TimeStamp.Should().Be(apiData.TimeStamp);
        }

        [Test]
        public void WhenMappingToBusiness_FromApi_ShouldMap_CustomBusinessProperty()
        {
            var apiData = _fixture.Create<AutomapperExample.Api.Models.Asset>();

            var result = _sut.Map<AutomapperExample.Business.Models.Asset>(apiData);
            result.CustomBusinessProperty.Should().Be(apiData.CustomApiProperty);
        }

        [Test]
        public void WhenMappingToBusiness_FromRepository_ShouldMap_Name()
        {
            var repositoryData = _fixture.Create<AutomapperExample.Repository.Models.Asset>();

            var result = _sut.Map<AutomapperExample.Business.Models.Asset>(repositoryData);
            result.Name.Should().Be(repositoryData.Name);
        }

        [Test]
        public void WhenMappingToBusiness_FromRepository_ShouldMap_Id()
        {
            var repositoryData = _fixture.Create<AutomapperExample.Repository.Models.Asset>();

            var result = _sut.Map<AutomapperExample.Business.Models.Asset>(repositoryData);
            result.Id.Should().Be(repositoryData.Id);
        }

        [Test]
        public void WhenMappingToBusiness_FromRepository_ShouldMap_TimeStamp()
        {
            var repositoryData = _fixture.Create<AutomapperExample.Repository.Models.Asset>();

            var result = _sut.Map<AutomapperExample.Business.Models.Asset>(repositoryData);
            result.TimeStamp.Should().Be(repositoryData.TimeStamp);
        }

        [Test]
        public void WhenMappingToBusiness_FromRepository_ShouldMap_CustomBusinessProperty()
        {
            var repositoryData = _fixture.Create<AutomapperExample.Repository.Models.Asset>();

            var result = _sut.Map<AutomapperExample.Business.Models.Asset>(repositoryData);
            result.CustomBusinessProperty.Should().Be(repositoryData.CustomRepositoryProperty);
        }
    }
}
