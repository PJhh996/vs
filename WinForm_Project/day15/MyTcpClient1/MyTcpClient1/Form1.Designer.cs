namespace MyTcpClient1
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 184);
            button1.Name = "button1";
            button1.Size = new Size(102, 45);
            button1.TabIndex = 0;
            button1.Text = "连接";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 64);
            label1.Name = "label1";
            label1.Size = new Size(44, 24);
            label1.TabIndex = 1;
            label1.Text = "IP：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 30);
            textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(454, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 524);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 120);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 1;
            label2.Text = "端口：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 30);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 300);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 1;
            label3.Text = "消息：";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 297);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 30);
            textBox3.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(102, 353);
            button2.Name = "button2";
            button2.Size = new Size(102, 45);
            button2.TabIndex = 0;
            button2.Text = "发送";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 30);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 1;
            label4.Text = "聊天框";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 564);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "MyTcpClient1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button2;
        private Label label4;
    }
}
