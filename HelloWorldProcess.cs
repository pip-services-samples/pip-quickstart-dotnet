using PipServices3.Container;
using PipServices3.Rpc.Build;

namespace HelloWorld
{
    public class HelloWorldProcess : ProcessContainer
    {
        public HelloWorldProcess()
            : base("hello_world", "Hello world microservice")
        {
            _configPath = "config.yml";

            _factories.Add(new DefaultRpcFactory());
            _factories.Add(new HelloWorldServiceFactory());
        }
    }
}
