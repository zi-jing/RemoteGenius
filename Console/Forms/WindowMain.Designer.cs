namespace Console
{
    partial class WindowMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConnectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.断开连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接到服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接到上次的服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除历史记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionMenuItem,
            this.OperationMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConnectionMenuItem
            // 
            this.ConnectionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.断开连接ToolStripMenuItem,
            this.连接到服务器ToolStripMenuItem,
            this.连接到上次的服务器ToolStripMenuItem,
            this.历史连接ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.ConnectionMenuItem.Name = "ConnectionMenuItem";
            this.ConnectionMenuItem.Size = new System.Drawing.Size(44, 21);
            this.ConnectionMenuItem.Text = "连接";
            // 
            // 断开连接ToolStripMenuItem
            // 
            this.断开连接ToolStripMenuItem.Name = "断开连接ToolStripMenuItem";
            this.断开连接ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.断开连接ToolStripMenuItem.Text = "断开连接";
            // 
            // 连接到服务器ToolStripMenuItem
            // 
            this.连接到服务器ToolStripMenuItem.Name = "连接到服务器ToolStripMenuItem";
            this.连接到服务器ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.连接到服务器ToolStripMenuItem.Text = "连接到服务器...";
            // 
            // 连接到上次的服务器ToolStripMenuItem
            // 
            this.连接到上次的服务器ToolStripMenuItem.Name = "连接到上次的服务器ToolStripMenuItem";
            this.连接到上次的服务器ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.连接到上次的服务器ToolStripMenuItem.Text = "连接到上次的服务器";
            // 
            // 历史连接ToolStripMenuItem
            // 
            this.历史连接ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除历史记录ToolStripMenuItem});
            this.历史连接ToolStripMenuItem.Name = "历史连接ToolStripMenuItem";
            this.历史连接ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.历史连接ToolStripMenuItem.Text = "历史连接";
            // 
            // 清除历史记录ToolStripMenuItem
            // 
            this.清除历史记录ToolStripMenuItem.Name = "清除历史记录ToolStripMenuItem";
            this.清除历史记录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清除历史记录ToolStripMenuItem.Text = "清除历史记录";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // OperationMenuItem
            // 
            this.OperationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件操作ToolStripMenuItem});
            this.OperationMenuItem.Name = "OperationMenuItem";
            this.OperationMenuItem.Size = new System.Drawing.Size(44, 21);
            this.OperationMenuItem.Text = "操作";
            // 
            // 文件操作ToolStripMenuItem
            // 
            this.文件操作ToolStripMenuItem.Name = "文件操作ToolStripMenuItem";
            this.文件操作ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.文件操作ToolStripMenuItem.Text = "文件操作";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 21);
            this.HelpMenuItem.Text = "帮助";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(109, 22);
            this.AboutMenuItem.Text = "关于...";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ConnectionStatusLabel);
            this.panel1.Location = new System.Drawing.Point(155, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 23);
            this.panel1.TabIndex = 2;
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(3, 6);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(89, 12);
            this.ConnectionStatusLabel.TabIndex = 0;
            this.ConnectionStatusLabel.Text = "未连接到服务器";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "|";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(495, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.WordWrap = false;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(945, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WindowMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制台";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConnectionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 断开连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接到服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接到上次的服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除历史记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConnectionStatusLabel;
    }
}

