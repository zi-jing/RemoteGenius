using System;
using System.Windows.Forms;

namespace Console.Forms
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
