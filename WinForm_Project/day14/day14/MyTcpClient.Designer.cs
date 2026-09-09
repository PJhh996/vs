namespace day14
{
    partial class MyTcpClient
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-46, 267);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 5;
            label2.Text = "消息：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-46, 95);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 6;
            label1.Text = "端口：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(678, 72);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 14;
            label3.Text = "收到消息：";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(803, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 756);
            panel1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(251, 426);
            button2.Name = "button2";
            button2.Size = new Size(116, 46);
            button2.TabIndex = 11;
            button2.Text = "发送";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(251, 245);
            button1.Name = "button1";
            button1.Size = new Size(128, 46);
            button1.TabIndex = 12;
            button1.Text = "连接Tcp服务";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 371);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 30);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 374);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 7;
            label4.Text = "消息：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 30);
            textBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 202);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 8;
            label5.Text = "端口：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 134);
            label6.Name = "label6";
            label6.Size = new Size(44, 24);
            label6.TabIndex = 8;
            label6.Text = "IP：";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(251, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 30);
            textBox3.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(393, 245);
            button3.Name = "button3";
            button3.Size = new Size(128, 46);
            button3.TabIndex = 12;
            button3.Text = "断开连接";
            button3.UseVisualStyleBackColor = true;
            // 
            // MyTcpClient
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 862);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MyTcpClient";
            Text = "MyTcpClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Button button3;
    }
}