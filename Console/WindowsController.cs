using System.Windows.Forms;

namespace Console
{
    class WindowsController
    {
        public static readonly WindowsController INSTANCE = new WindowsController();
        public readonly WindowMain windowMain;
        public WindowsController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            windowMain = new WindowMain();
        }
    }
}
