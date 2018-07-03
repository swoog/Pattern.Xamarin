using System.IO;

namespace Pattern.Xamarin.Config.platform.ios
{
    public class ConfigReader<T> : AbstractConfigReader<T>
    {
        protected override StreamReader GetStream(string filename)
        {
            return new StreamReader($"Assets/{filename}");
        }
    }
}