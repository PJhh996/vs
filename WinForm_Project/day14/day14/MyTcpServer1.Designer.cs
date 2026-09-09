namespace day14
{
    partial class MyTcpServer1
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 120);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "端口：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 30);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 292);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 0;
            label2.Text = "消息：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 289);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 30);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(182, 163);
            button1.Name = "button1";
            button1.Size = new Size(177, 46);
            button1.TabIndex = 2;
            button1.Text = "创建服务器";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(182, 344);
            button2.Name = "button2";
            button2.Size = new Size(116, 46);
            button2.TabIndex = 2;
            button2.Text = "发送";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(745, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 756);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(620, 36);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 4;
            label3.Text = "收到消息：";
            // 
            // MyTcpServer1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 804);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MyTcpServer1";
            Text = "MyTcpServer1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label3;
    }
}