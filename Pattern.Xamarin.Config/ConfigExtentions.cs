using Pattern.Core.Interfaces;

namespace Pattern.Xamarin.Config
{
    public static class ConfigExtentions
    {
        public static IKernel LoadConfig<TConfig, T>(this IKernel kernel, TConfig config)
            where TConfig : AbstractConfigReader<T>
        {
            kernel.Bind(typeof(T), config);
            return kernel;
        }
    }
}