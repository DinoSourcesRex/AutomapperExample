using System;

namespace AutomapperExample.Repository.Models
{
    public class Asset
    {
        public string Name { get; set; }
        public uint Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string CustomRepositoryProperty { get; set; }
    }
}
