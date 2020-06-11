using PipServices3.Commons.Refer;
using PipServices3.Components.Build;

namespace HelloWorld
{
    public class HelloWorldServiceFactory : Factory
    {
        public static Descriptor Descriptor = new Descriptor("hello-world", "factory", "service", "default", "1.0");
        public static Descriptor ControllerDescriptor = new Descriptor("hello-world", "controller", "default", "*", "1.0");
        public static Descriptor RestServiceDescriptor = new Descriptor("hello-world", "service", "http", "*", "1.0");

        public HelloWorldServiceFactory()
        {
            RegisterAsType(ControllerDescriptor, typeof(HelloWorldController));
            RegisterAsType(RestServiceDescriptor, typeof(HelloWorldRestService));
        }
    }
}
