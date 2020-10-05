namespace SharedLibrary
{
    public class Configuration
    {
        private readonly bool isClient;
        private string host;
        private int port;
        private string updateURL;
        private bool checkUpdate;
        private int maxUploadThreads;
        private bool runOnOSStartup;

        public bool IsClient => isClient;

        public string Host { get => host; set => host = value; }
        public int Port { get => port; set => port = value; }
        public string UpdateURL { get => updateURL; set => updateURL = value; }
        public bool CheckUpdate { get => checkUpdate; set => checkUpdate = value; }
        public int MaxUploadThreads { get => maxUploadThreads; set => maxUploadThreads = value; }
        public bool RunOnOSStartup { get => runOnOSStartup; set => runOnOSStartup = value; }
    }
}
