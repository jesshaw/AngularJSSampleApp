using AngularJSWebApp1.ServiceModel;
using ServiceStack;

namespace MovielApp.ServiceInterface
{
    public class MyService : BaseService
    {
        public object Any(Hello request)
        {
            return new HelloResponse {Result = "Hello, {0}!".Fmt(request.Name)};
        }
    }
}