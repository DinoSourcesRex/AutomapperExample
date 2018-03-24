using AutoFixture;
using AutomapperExample.Converters;
using FluentAssertions;
using NUnit.Framework;

namespace AutomapperUnitTesting.Converters.Extensions.Asset
{
    [TestFixture]
    public class ToApi
    {
        private readonly Fixture _fixture = new Fixture();

        private AutomapperExample.Business.Models.Asset _businessData;

        [SetUp]
        public void SetUp()
        {
            _businessData = _fixture.Create<AutomapperExample.Business.Models.Asset>();
        }

        [Test]
        public void WhenMappingToApi_FromBusiness_ShouldMap_Name()
        {
            _businessData.ConvertToApi().Name.Should().Be(_businessData.Name);
        }

        [Test]
        public void WhenMappingToApi_FromBusiness_ShouldMap_Id()
        {
            _businessData.ConvertToApi().Id.Should().Be(_businessData.Id);
        }

        [Test]
        public void WhenMappingToApi_FromBusiness_ShouldMap_TimeStamp()
        {
            _businessData.ConvertToApi().TimeStamp.Should().Be(_businessData.TimeStamp);
        }

        [Test]
        public void WhenMappingToApi_FromBusiness_ShouldMap_CustomApiProperty()
        {
            _businessData.ConvertToApi().CustomApiProperty.Should().Be(_businessData.CustomBusinessProperty);
        }
    }
}
