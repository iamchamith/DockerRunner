using DockerRunner.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DockerRunner.Stages
{
    public class DockerContainer : DockerState
    {
        const string dockerRun = "docker run {0} -p {1}:{2} --name {3} {4}";
        const string listContainers = "docker ps {0}";
        const string stopContainer = "docker container stop {0}";
        const string killContainer = "docker container kill {0}";
        public static string RunImage(string imageId, string containerName, int inPort, int outPort, DockerRunOptions options)
        {
            var opt = new StringBuilder();
            if (options != null)
            {
                opt.Append(options.NeedConsoleLog ? "-d" : "");
            }
            return string.Format(dockerRun, opt.ToString(), outPort, inPort, containerName, imageId);
        }

        public static string ListAllContainers(bool isAll = false)
        {
            return string.Format(listContainers, isAll ? "-a" : "");
        }

        public static string StopContainer(string containerName)
        {
            return string.Format(stopContainer, containerName);
        }

        public static string GetContainerList(bool showAll = false)
        {
            var apend = new StringBuilder();
            apend.Append(showAll ? "-a" : "");
            return string.Format(listContainers, apend.ToString());
        }

        public static object FilterContainers(string cmdOut)
        {
            var arrayList = Helper.GetList(cmdOut, 5);
            var finalResult = new List<Container>();
            foreach (var item in arrayList)
            {
                if (item is List<string>)
                    try
                    {
                        finalResult.Add(new Container(item as List<string>));
                    }
                    catch (System.Exception e)
                    {
                        continue;
                    }
            }
            return finalResult;
        }

        public static string KillContainer(string containerName)
        {
            return string.Format(killContainer, containerName);
        }
    }
}
