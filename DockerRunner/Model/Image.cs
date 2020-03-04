using System.Collections.Generic;
using System.IO;

namespace DockerRunner.Model
{
    public class Image: ListView
    {
        public string Repository { get; set; }
        public string Tag { get; set; }
        public string ImageId { get; set; }
        public string CreatedBy { get; set; }

        public Image(List<string> item)
        {
            if (item.Count <4)
            {
                throw new InvalidDataException();
            }
            Repository = item[0];
            Tag = item[1];
            ImageId = item[2];
            CreatedBy = item[3];
            SetKeyValue(ImageId, $"{Repository}:{Tag} ON {CreatedBy}");

        }
        public Image()
        {

        }
    }
}
