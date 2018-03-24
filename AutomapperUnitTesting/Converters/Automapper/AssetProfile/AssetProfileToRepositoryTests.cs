using AutoFixture;
using AutoMapper;
using FluentAssertions;
using NUnit.Framework;

namespace AutomapperUnitTesting.Converters.Automapper.AssetProfile
{
    [TestFixture]
    public class AssetProfileToRepositoryTests : AutomapperProfileTestBase<AutomapperExample.Converters.Automapper.AssetProfile>
    {
        private readonly Fixture _fixture = new Fixture();

        private AutomapperExample.Business.Models.Asset _businessData;

        private IMapper _sut;

        [SetUp]
        public void SetUp()
        {
            _businessData = _fixture.Create<AutomapperExample.Business.Models.Asset>();

            _sut = InitializeMapper();
        }

        [Test]
        public void WhenMappingToRepository_FromBusiness_ShouldMap_Name()
        {
            var result = _sut.Map<AutomapperExample.Repository.Models.Asset>(_businessData);
            result.Name.Should().Be(_businessData.Name);
        }

        [Test]
        public void WhenMappingToRepository_FromBusiness_ShouldMap_Id()
        {
            var result = _sut.Map<AutomapperExample.Repository.Models.Asset>(_businessData);
            result.Id.Should().Be(_businessData.Id);
        }

        [Test]
        public void WhenMappingToRepository_FromBusiness_ShouldMap_TimeStamp()
        {
            var result = _sut.Map<AutomapperExample.Repository.Models.Asset>(_businessData);
            result.TimeStamp.Should().Be(_businessData.TimeStamp);
        }

        [Test]
        public void WhenMappingToRepository_FromBusiness_ShouldMap_CustomRepositoryProperty()
        {
            var result = _sut.Map<AutomapperExample.Repository.Models.Asset>(_businessData);
            result.CustomRepositoryProperty.Should().Be(_businessData.CustomBusinessProperty);
        }
    }
}
