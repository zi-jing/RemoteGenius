using Newtonsoft.Json;
using SharedLibrary;
using SharedLibrary.Api.Config;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Client.Config
{
    class ClientConfigObject
    {
        private int[] version;
        private int configType = ConfigTypes.CONFIG_CONTROLLED_END;
        private string host;
        private int port;
        private bool configSync;
        private string configURL;
        private bool checkUpdate;
        private string versionManifest;
        private int maxUploadThreads;
        private int maxDownloadThreads;
        private bool runOnOSStartUp;

        public int[] Version { get => version; set => version = value; }
        public int ConfigType { get => configType; set => configType = value; }
        public string Host { get => host; set => host = value; }
        public int Port { get => port; set => port = value; }
        public bool ConfigSync { get => configSync; set => configSync = value; }
        public string ConfigURL { get => configURL; set => configURL = value; }
        public bool CheckUpdate { get => checkUpdate; set => checkUpdate = value; }
        public string VersionManifest { get => versionManifest; set => versionManifest = value; }
        public int MaxUploadThreads { get => maxUploadThreads; set => maxUploadThreads = value; }
        public int MaxDownloadThreads { get => maxDownloadThreads; set => maxDownloadThreads = value; }
        public bool RunOnOSStartUp { get => runOnOSStartUp; set => runOnOSStartUp = value; }
    }

    static class ClientConfig
    {
        public static readonly string CONFIG_FILE = Util.GetFile("config.json");
        private static ClientConfigObject configObject = null;

        public static void CreateDefaultConfig()
        {
            // if (!File.Exists(CONFIG_FILE)) File.Create(CONFIG_FILE);
        }
        public static void Load()
        {
            if (!File.Exists(CONFIG_FILE))
            {
                Util.Dialog("错误", "配置文件意外丢失，请尝试重新安装程序。", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
            try
            {
                configObject = JsonConvert.DeserializeObject<ClientConfigObject>(File.ReadAllText(CONFIG_FILE, Encoding.UTF8));
                File.WriteAllText(Util.GetFile("loaded.json"), JsonConvert.SerializeObject(configObject), Encoding.UTF8);
            }
            catch (Exception e)
            {
                Util.ShowBriefExceptionInfo(e, "载入配置文件时发生致命错误。");
            }
        }
    }
}
