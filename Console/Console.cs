using SharedLibrary.Api;
using System.Windows.Forms;

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
