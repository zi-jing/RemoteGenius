using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace SharedLibrary
{
    /// <summary>
    /// 配置设置的实例类
    /// </summary>
    public class Configuration
    {
        private int configType;
        private bool isClient;
        private string host;
        private int port;
        private string updateURL;
        private bool checkUpdate;
        private int maxUploadThreads;
        private bool runOnOSStartup;

        public bool IsClient => configType == 0;

        public bool IsConsole => configType == 1;

        public string Host { get => host; set => host = value; }
        public int Port { get => port; set => port = value; }
        public string UpdateURL { get => updateURL; set => updateURL = value; }
        public bool CheckUpdate { get => checkUpdate; set => checkUpdate = value; }
        public int MaxUploadThreads { get => maxUploadThreads; set => maxUploadThreads = value; }
        public bool RunOnOSStartup { get => runOnOSStartup; set => runOnOSStartup = value; }

        /// <summary>
        /// 从一个文件中载入配置
        /// </summary>
        /// <param name="configFile">配置文件的绝对路径</param>
        public void Load(string configFile)
        {
            JsonReader reader = Util.ReadJson(configFile);
            while (reader.Read())
            {
                if (reader.Value != null)   // 普通的键值对
                {
                    if (reader.TokenType == JsonToken.PropertyName)
                    {
                        switch (reader.Value.ToString())
                        {
                            case "configType":
                                this.configType = (int)reader.ReadAsInt32();
                                break;
                            case "host":
                                this.host = reader.ReadAsString();
                                break;
                            case "port":
                                this.port = (int)reader.ReadAsInt32();
                                break;
                            case "updateURL":
                                this.updateURL = reader.ReadAsString();
                                break;
                            case "checkUpdate":
                                this.checkUpdate = (bool)reader.ReadAsBoolean();
                                break;
                            case "maxUploadThreads":
                                this.maxUploadThreads = (int)reader.ReadAsInt32(); ;
                                break;
                            case "runOnOSStartup":
                                this.runOnOSStartup = (bool)reader.ReadAsBoolean();
                                break;
                            default:
                                // invalid token
                                Util.Dialog("调试信息", reader.TokenType.ToString() + reader.Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }

                }
                else
                {   // 标记起始结束等

                }
            }
        }
    }
}
