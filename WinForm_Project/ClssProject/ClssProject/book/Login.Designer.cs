namespace ClssProject.book
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            label2 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            label3 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(978, 109);
            label1.TabIndex = 3;
            label1.Text = "登录";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(339, 523);
            button1.Name = "button1";
            button1.Size = new Size(303, 108);
            button1.TabIndex = 4;
            button1.Text = "登录";
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(155, 152);
            label2.Name = "label2";
            label2.Size = new Size(115, 100);
            label2.TabIndex = 5;
            label2.Text = "用户名：";
            // 
            // input1
            // 
            input1.Location = new Point(276, 152);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入用户名";
            input1.Size = new Size(423, 100);
            input1.TabIndex = 6;
            // 
            // label3
            // 
            label3.Location = new Point(155, 314);
            label3.Name = "label3";
            label3.Size = new Size(115, 100);
            label3.TabIndex = 5;
            label3.Text = "密码：";
            // 
            // input2
            // 
            input2.Location = new Point(276, 314);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入密码";
            input2.Size = new Size(423, 100);
            input2.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 644);
            Controls.Add(input2);
            Controls.Add(label3);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Label label2;
        private AntdUI.Input input1;
        private AntdUI.Label label3;
        private AntdUI.Input input2;
    }
}