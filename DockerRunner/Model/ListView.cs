namespace DockerRunner.Model
{
    public class ListView
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public void SetKeyValue(string key,string value)
        {
            Key = key;
            Value = value;
        }
    }
}
