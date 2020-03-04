using System.Collections.Generic;
using System.IO;

namespace DockerRunner.Model
{
    public class Container: ListView
    {
        public string ContainerId { get; set; }
        public string ImageId { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public bool IsLive { get; set; }
        public string Port { get; set; }

        public Container(List<string> item)
        {
            if (item.Count < 6)
            {
                throw new InvalidDataException();
            }
            ContainerId = item[0];
            ImageId = item[1];
            Name = item[6];
            CreatedBy = item[3];
            IsLive = item[4].StartsWith("Exited") ? false : true;
            SetKeyValue(ContainerId, $"{Name}({(IsLive ? "Live" : "Not Live")}) ON {CreatedBy}");

        }
        public Container()
        {
        }
    }
}
