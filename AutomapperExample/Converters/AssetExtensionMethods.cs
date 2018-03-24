namespace AutomapperExample.Converters
{
    public static class AssetExtensionMethods
    {
        public static Api.Models.Asset ConvertToApi(this Business.Models.Asset asset)
        {
            return new Api.Models.Asset
            {
                Name = asset.Name,
                Id = asset.Id,
                TimeStamp = asset.TimeStamp,
                CustomApiProperty = asset.CustomBusinessProperty
            };
        }

        public static Business.Models.Asset ConvertToBusiness(this Api.Models.Asset asset)
        {
            return new Business.Models.Asset
            {
                Name = asset.Name,
                Id = asset.Id,
                TimeStamp = asset.TimeStamp,
                CustomBusinessProperty = asset.CustomApiProperty
            };
        }

        public static Business.Models.Asset ConvertToBusiness(this Repository.Models.Asset asset)
        {
            return new Business.Models.Asset
            {
                Name = asset.Name,
                Id = asset.Id,
                TimeStamp = asset.TimeStamp,
                CustomBusinessProperty = asset.CustomRepositoryProperty
            };
        }

        public static Repository.Models.Asset ConvertToRepository(this Business.Models.Asset asset)
        {
            return new Repository.Models.Asset
            {
                Name = asset.Name,
                Id = asset.Id,
                TimeStamp = asset.TimeStamp,
                CustomRepositoryProperty = asset.CustomBusinessProperty
            };
        }
    }
}
