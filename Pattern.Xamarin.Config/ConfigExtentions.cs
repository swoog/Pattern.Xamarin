using Pattern.Core.Interfaces;

namespace Pattern.Xamarin.Config
{
    public static class ConfigExtentions
    {
        public static IKernel LoadConfig<TConfig, T>(this IKernel kernel, TConfig config)
            where TConfig : AbstractConfigReader
        {
            kernel.Bind(typeof(T), config);
            return kernel;
        }
    }
}