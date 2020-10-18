using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using SharedLibrary.Api;

namespace Console
{
    class Console : ILaunchable
    {
        private static readonly Console INSTANCE = new Console();

        private WindowsController windowsController;

        public void Launch()
        {
            this.windowsController = new WindowsController();
            ShowWindow(windowsController.windowMain);
        }

        public static Console Get()
        {
            return INSTANCE;
        }

        private static void ShowWindow(Form form)
        {
            Application.Run(form);
        }
    }
}
