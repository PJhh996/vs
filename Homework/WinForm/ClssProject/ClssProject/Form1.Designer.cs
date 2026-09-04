namespace ClssProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            label2 = new AntdUI.Label();
            menuStrip1 = new MenuStrip();
            状态ToolStripMenuItem = new ToolStripMenuItem();
            登录ToolStripMenuItem = new ToolStripMenuItem();
            切换用户ToolStripMenuItem = new ToolStripMenuItem();
            退出登录ToolStripMenuItem = new ToolStripMenuItem();
            注册ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(1, 30);
            label1.Name = "label1";
            label1.Size = new Size(978, 109);
            label1.TabIndex = 0;
            label1.Text = "目录";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(29, 165);
            button1.Name = "button1";
            button1.Size = new Size(270, 89);
            button1.TabIndex = 1;
            button1.Text = "图书管理系统";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(29, 339);
            button2.Name = "button2";
            button2.Size = new Size(270, 89);
            button2.TabIndex = 1;
            button2.Text = "汽车租还系统";
            // 
            // label2
            // 
            label2.Location = new Point(305, 145);
            label2.Name = "label2";
            label2.Size = new Size(91, 36);
            label2.TabIndex = 2;
            label2.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 状态ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(978, 32);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // 状态ToolStripMenuItem
            // 
            状态ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 登录ToolStripMenuItem, 切换用户ToolStripMenuItem, 退出登录ToolStripMenuItem, 注册ToolStripMenuItem });
            状态ToolStripMenuItem.Name = "状态ToolStripMenuItem";
            状态ToolStripMenuItem.Size = new Size(62, 28);
            状态ToolStripMenuItem.Text = "状态";
            // 
            // 登录ToolStripMenuItem
            // 
            登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            登录ToolStripMenuItem.Size = new Size(270, 34);
            登录ToolStripMenuItem.Text = "登录";
            登录ToolStripMenuItem.Click += 登录ToolStripMenuItem_Click;
            // 
            // 切换用户ToolStripMenuItem
            // 
            切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem";
            切换用户ToolStripMenuItem.Size = new Size(270, 34);
            切换用户ToolStripMenuItem.Text = "切换用户";
            切换用户ToolStripMenuItem.Click += 切换用户ToolStripMenuItem_Click;
            // 
            // 退出登录ToolStripMenuItem
            // 
            退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            退出登录ToolStripMenuItem.Size = new Size(270, 34);
            退出登录ToolStripMenuItem.Text = "退出登录";
            退出登录ToolStripMenuItem.Click += 退出登录ToolStripMenuItem_Click;
            // 
            // 注册ToolStripMenuItem
            // 
            注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            注册ToolStripMenuItem.Size = new Size(270, 34);
            注册ToolStripMenuItem.Text = "注册";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 644);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 状态ToolStripMenuItem;
        private ToolStripMenuItem 登录ToolStripMenuItem;
        private ToolStripMenuItem 切换用户ToolStripMenuItem;
        private ToolStripMenuItem 退出登录ToolStripMenuItem;
        private ToolStripMenuItem 注册ToolStripMenuItem;
    }
}
