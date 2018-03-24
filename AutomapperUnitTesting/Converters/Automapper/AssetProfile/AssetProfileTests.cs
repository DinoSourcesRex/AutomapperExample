using AutoMapper;
using FluentAssertions;
using NUnit.Framework;

namespace AutomapperUnitTesting.Converters.Automapper.AssetProfile
{
    [TestFixture]
    public class AssetProfileTests : AutomapperProfileTestBase<AutomapperExample.Converters.Automapper.AssetProfile>
    {
        private IMapper _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = InitializeMapper();
        }

        /// <summary>
        /// This test makes sure that every mapping is valid.
        /// 
        /// If you want to make this test fail go to the AssetProfile and delete one of the ".ForMember" configurations.
        /// </summary>
        [Test]
        public void ConfigurationProvider_WhenProfileLoaded_ShouldHaveNoErrors()
        {
            _sut.ConfigurationProvider.AssertConfigurationIsValid();
            _sut.ConfigurationProvider.GetAllTypeMaps().Should().NotBeEmpty();
        }
    }
}
