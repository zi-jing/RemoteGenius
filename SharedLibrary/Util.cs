using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace SharedLibrary
{
    public static class Util
    {
        /// <summary>
        /// 显示一个基本对话框
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="text">内容</param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        public static DialogResult Dialog(string title, string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(text, title, buttons, icon);
        }

        /// <summary>
        /// 显示一个仅包含一条消息和异常类型名称的错误提示。
        /// </summary>
        /// <param name="e">异常</param>
        /// <param name="message">消息</param>
        /// <seealso cref="ShowDetailedExceptionInfo(System.Exception, string)"/>
        public static void ShowBriefExceptionInfo(System.Exception e, string message)
        {
            _ = MessageBox.Show(message + "\n" + e.GetType().Name + "\n\n有关详细信息，请查看日志文件。",
                "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 显示一个包含一条消息和异常详细信息的错误提示
        /// </summary>
        /// <param name="e"></param>
        /// <param name="message"></param>
        /// <seealso cref="ShowBriefExceptionInfo(System.Exception, string)"/>
        public static void ShowDetailedExceptionInfo(System.Exception e, string message)
        {
            _ = MessageBox.Show(message + "\n" + "异常类型: " + e.GetType().FullName + "\n" +
                "异常信息: " + e.Message + "\n" +
                "异常来源: " + e.Source + "\n" +
                "运行时堆栈详细信息:\n" + e.StackTrace + "\n" +
                "错误原因:\n" + (e.InnerException == null ? "无" : e.InnerException.ToString()) +
                "\n\n有关详细信息，请查看日志文件。",
                "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
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
