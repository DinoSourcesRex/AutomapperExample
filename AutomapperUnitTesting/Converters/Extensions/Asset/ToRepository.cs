using AutoFixture;
using AutomapperExample.Converters;
using FluentAssertions;
using NUnit.Framework;

namespace AutomapperUnitTesting.Converters.Extensions.Asset
{
    [TestFixture]
    public class ToRepository
    {
        private readonly Fixture _fixture = new Fixture();

        private AutomapperExample.Business.Models.Asset _businessData;

        [SetUp]
        public void SetUp()
        {
            _businessData = _fixture.Create<AutomapperExample.Business.Models.Asset>();
        }

        [Test]
        public void WhenMappingToRepository_FromBusiness_ShouldMap_Name()
        {
            _businessData.ConvertToRepository().Name.Should().Be(_businessData.Name);
        }

        [Test]
        public void WhenMappingToRepository_FromBusiness_ShouldMap_Id()
        {
            _businessData.ConvertToRepository().Id.Should().Be(_businessData.Id);
        }

        [Test]
        public void WhenMappingToRepository_FromBusiness_ShouldMap_TimeStamp()
        {
            _businessData.ConvertToRepository().TimeStamp.Should().Be(_businessData.TimeStamp);
        }

        [Test]
        public void WhenMappingToRepository_FromBusiness_ShouldMap_CustomRepositoryProperty()
        {
            _businessData.ConvertToRepository().CustomRepositoryProperty.Should().Be(_businessData.CustomBusinessProperty);
        }
    }
}
