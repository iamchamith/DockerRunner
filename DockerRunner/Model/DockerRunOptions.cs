namespace DockerRunner.Model
{
    public class DockerRunOptions
    {
        public bool NeedConsoleLog { get; set; }

        public DockerRunOptions()
        {
        }
        public DockerRunOptions(bool needConsoleLog)
        {
            NeedConsoleLog = needConsoleLog;
        }
    }
}
