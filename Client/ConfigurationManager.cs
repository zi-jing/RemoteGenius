using Newtonsoft.Json;
using SharedLibrary;
using System;
using System.IO;
using System.Windows.Forms;

namespace Client
{
    class ConfigurationManager
    {
        public static readonly string CONFIG_FILE = Util.GetFile("config.json");
        private static Configuration config = new Configuration();

        public void CreateDefaultConfig()
        {
            if (!File.Exists(CONFIG_FILE)) File.Create(CONFIG_FILE);
        }
        public void Load()
        {
            if (!File.Exists(CONFIG_FILE))
            {
                Util.Dialog("错误", "配置文件意外丢失，请尝试重新安装程序。", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateDefaultConfig();
            }
            try
            {
                JsonReader jsonReader = Util.ReadJson(CONFIG_FILE);
            }
            catch (Exception e)
            {

            }
        }
    }
}
