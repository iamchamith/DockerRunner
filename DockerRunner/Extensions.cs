using System;
namespace DockerRunner
{
    public static class Extensions
    {
        public static string ToCommandTemplate(this string param)
        {
            return $"#{param}#";
        }
        public static int ToInt(this decimal val)
        {
            return Convert.ToInt32(val);
        }
    }
}
