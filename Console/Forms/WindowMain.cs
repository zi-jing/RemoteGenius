using Console.Forms;
using System;
using System.Windows.Forms;

namespace Console
{
    public partial class WindowMain : Form
    {
        public WindowMain()
        {
            InitializeComponent();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutWindow().Show();
        }
    }
}
