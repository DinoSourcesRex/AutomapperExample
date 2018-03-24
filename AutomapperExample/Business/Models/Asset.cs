using System;

namespace AutomapperExample.Business.Models
{
    public class Asset
    {
        public string Name { get; set; }
        public uint Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string CustomBusinessProperty { get; set; }
    }
}
