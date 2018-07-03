using System.IO;
using Android.Content;

namespace Pattern.Xamarin.Config.platform.android
{
    public class ConfigReader<T> : AbstractConfigReader<T>
    {        
        private readonly Context _context;

        public ConfigReader(Context context)
        {
            _context = context;
        }

        protected override StreamReader GetStream(string filename)
        {
            var assets = _context.Assets;
            return new StreamReader(assets.Open(filename));
        }
    }
}
