using SharedLibrary.Api;
using System;
using System.Collections.Generic;
using System.Text;

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
