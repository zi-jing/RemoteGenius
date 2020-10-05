using SharedLibrary;
using System.Windows.Forms;

namespace Client
{
    public partial class SetupWindow : Form
    {
        public SetupWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Util.Dialog("希沃阴间小助手", "你确定你马呢？傻逼！", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            Util.Dialog("希沃阴间小助手", "你点哪呢？傻逼！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetupWindow_Load(object sender, System.EventArgs e)
        {

        }
    }
}
