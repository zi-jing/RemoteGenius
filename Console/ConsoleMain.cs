using System;
using System.Windows.Forms;

namespace Console
{
    static class ConsoleMain
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Get().Launch();
        }
    }
}
