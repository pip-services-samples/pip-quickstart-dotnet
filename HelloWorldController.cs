using System.Threading.Tasks;

using PipServices3.Commons.Config;

namespace HelloWorld
{
    public class HelloWorldController : IConfigurable
    {
        private string _defaultName = null;

        public void Configure(ConfigParams config)
        {
            _defaultName = config.GetAsStringWithDefault("default_name", null);
        }

        public async Task<string> GreetingAsync(string name)
        {
            return await Task.FromResult($"Hello {name ?? _defaultName}!");
        }
    }
}
