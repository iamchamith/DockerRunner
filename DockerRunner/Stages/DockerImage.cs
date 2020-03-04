using DockerRunner.Model;
using System.Collections.Generic;
namespace DockerRunner.Stages
{
    public class DockerImage: DockerState
    {
        const string createImageFromDockerFile = "docker build -t {0}{1} .";
        const string listDockerImages = "docker images";
        const string removeImage = "docker rmi {0} --force";

        public static string CreateImageFromDockerFile(string nameOfImage, string tag="")
        {
            tag = string.IsNullOrEmpty(tag) ? "" : $":{tag}";
            return string.Format(createImageFromDockerFile, nameOfImage, tag);
        }

        public static string GetImageList()
        {
            return listDockerImages;
        }
        public static string RemoveImage(string imageId) {
            return string.Format(removeImage, imageId);
        }

        public static List<Image> FilterImages(string cmdOut)
        {
            var arrayList = Helper.GetList(cmdOut, 5);
            var finalResult = new List<Image>();
            foreach (var item in arrayList)
            {
                if (item is List<string>)
                    try
                    {
                        finalResult.Add(new Image(item as List<string>));
                    }
                    catch (System.Exception)
                    {
                        continue;
                    }
            }
            return finalResult;
        }
    }
}
