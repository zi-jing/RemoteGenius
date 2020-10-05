using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace SharedLibrary
{
    public class Util
    {
        /// <summary>
        /// 显示一个基本对话框
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="text">内容</param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        public static void Dialog(string title, string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(text, title, buttons, icon);
        }

        /// <summary>
        /// 使用相对路径获取程序安装目录下文件的完整路径
        /// </summary>
        /// <param name="relativePath">相对路径</param>
        /// <returns></returns>
        public static string GetFile(string relativePath)
        {
            string exePath = Application.ExecutablePath;
            return Path.Combine(exePath.Substring(0, exePath.LastIndexOf("\\") + 1), relativePath);
        }

        /// <summary>
        /// 使用完整路径获取一个Json文件的JsonReader
        /// </summary>
        /// <param name="absolutePath">完整路径</param>
        /// <returns></returns>
        public static JsonReader ReadJson(string absolutePath)
        {
            string jsonData = File.ReadAllText(GetFile(absolutePath));
            return new JsonTextReader(new StringReader(jsonData));
        }
    }
}
