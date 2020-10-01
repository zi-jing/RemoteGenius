﻿using SharedLibrary;
using System;
using System.IO;
using System.Windows.Forms;

namespace Client
{
    static class ClientMain
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // string firstStartMarkPath = Path.Combine(System.Environment.CurrentDirectory, "FirstRun");
            string firstStartMarkPath = Util.GetFile("FirstRun");
            if (!File.Exists(firstStartMarkPath))
            {
                Util.Dialog("希沃白板小助手", "如果您看到这条信息，则表明希沃白板小助手安装成功。\n\n单击\"确定\"关闭并不再显示此信息。", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Create(firstStartMarkPath);
            }

            SetupWindow setupWindow = new SetupWindow();
            setupWindow.ShowDialog();
        }
    }
}
