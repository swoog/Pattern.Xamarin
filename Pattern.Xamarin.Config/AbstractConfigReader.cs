using System.IO;
using Newtonsoft.Json;
using Pattern.Core.Interfaces;

namespace Pattern.Xamarin.Config
{
    public abstract class AbstractConfigReader : IFactory
    {
        public string Filename { get; set; }
        
        public object Create(CallContext callContext)
        {
            using (var streamReader = GetStream(this.Filename))
            {
                var configFileString = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject(configFileString, callContext.InstanciatedType);
            }            
        }
        
        protected abstract StreamReader GetStream(string filename);
    }
}