using Newtonsoft.Json;
using SharedLibrary;
using SharedLibrary.Exception;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Console.Config
{
    class ConsoleConfigObject
    {
        private int[] version;
        private int configType;
        private bool checkUpdate;
        private string versionManifest;
        private int maxUploadThreads;
        private int maxDownloadThreads;
        private bool autoLogon;
        private string downloadPath;

        public int[] Version { get => version; set => version = value; }
        public int ConfigType { get => configType; set => configType = value; }
        public bool CheckUpdate { get => checkUpdate; set => checkUpdate = value; }
        public string VersionManifest { get => versionManifest; set => versionManifest = value; }
        public int MaxUploadThreads { get => maxUploadThreads; set => maxUploadThreads = value; }
        public int MaxDownloadThreads { get => maxDownloadThreads; set => maxDownloadThreads = value; }
        public bool AutoLogon { get => autoLogon; set => autoLogon = value; }
        public string DownloadPath { get => downloadPath; set => downloadPath = value; }
    }

    static class ConsoleConfig
    {
        public static readonly string CONFIG_FILE = Util.GetFile("config.json");
        private static ConsoleConfigObject configObject = null;

        public static void CreateDefaultConfig()
        {
            if (!File.Exists(CONFIG_FILE))
            {
                try
                {
                    File.Create(CONFIG_FILE);
                }
                catch(Exception e)
                {
                    Util.ShowDetailedExceptionInfo(e, "创建配置文件时出错。");
                    throw new ReportedException("创建配置文件时出错。", e);
                }
            }
            
        }
        public static void Load()
        {
            if (!File.Exists(CONFIG_FILE))
            {
                DialogResult result = Util.Dialog("RemoteGuard 控制台", "找不到配置文件。\n\n是否重新生成配置文件？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CreateDefaultConfig();
                }
                else
                {
                    Util.Dialog("RemoteGuard 控制台", "您选择了\"不生成配置文件\", 程序即将退出。", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw new ReportedException("无法载入配置文件: 用户取消了默认配置文件的生成。");
                }
            }
            try
            {
                configObject = JsonConvert.DeserializeObject<ConsoleConfigObject>(File.ReadAllText(CONFIG_FILE, Encoding.UTF8));
                File.WriteAllText(Util.GetFile("loaded.json"), JsonConvert.SerializeObject(configObject), Encoding.UTF8);
            }
            catch (Exception e)
            {
                Util.ShowDetailedExceptionInfo(e, "载入配置文件时发生致命错误。");
                throw new ReportedException("载入配置文件时发生致命错误。", e);
            }
        }
    }
}
