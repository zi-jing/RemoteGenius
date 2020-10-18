using System.Windows.Forms;

namespace Console
{
    class WindowsController
    {
        public readonly WindowMain windowMain;
        public WindowsController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            windowMain = new WindowMain();
        }
    }
}
