using SharedLibrary.Api;

namespace Client
{
    class Client : ILaunchable
    {
        public static readonly Client INSTANCE = new Client();


        public void Launch()
        {

        }

        public static Client Get()
        {
            return INSTANCE;
        }
    }
}
