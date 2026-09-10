namespace MyTcpClient2
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
            panel1 = new Panel();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(469, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 524);
            panel1.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 30);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 38);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 6;
            label4.Text = "聊天框";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 308);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 7;
            label3.Text = "消息：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 30);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 128);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 8;
            label2.Text = "端口：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 30);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 72);
            label1.Name = "label1";
            label1.Size = new Size(44, 24);
            label1.TabIndex = 9;
            label1.Text = "IP：";
            // 
            // button2
            // 
            button2.Location = new Point(117, 361);
            button2.Name = "button2";
            button2.Size = new Size(102, 45);
            button2.TabIndex = 4;
            button2.Text = "发送";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(117, 192);
            button1.Name = "button1";
            button1.Size = new Size(102, 45);
            button1.TabIndex = 5;
            button1.Text = "连接";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 628);
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
            Text = "TcpClient2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}
