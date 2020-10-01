using System.IO;
using System.Windows.Forms;

namespace SharedLibrary
{
    public class Util
    {
        public static void Dialog(string title, string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(text, title, buttons, icon);
        }

        public static string GetFile(string relativePath)
        {
            string exePath = Application.ExecutablePath;
            return Path.Combine(exePath.Substring(0, exePath.LastIndexOf("\\") + 1), relativePath);
        }
    }
}
