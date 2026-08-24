namespace day01
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(274, 390);
            button1.Name = "button1";
            button1.Size = new Size(191, 56);
            button1.TabIndex = 0;
            button1.Text = "提交";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(332, 30);
            label1.Name = "label1";
            label1.Size = new Size(82, 41);
            label1.TabIndex = 1;
            label1.Text = "注册";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 115);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 1;
            label2.Text = "用户名";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 157);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 1;
            label3.Text = "密码";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 199);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 1;
            label4.Text = "确认密码";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 30);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 30);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(276, 30);
            textBox3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 258);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 1;
            label5.Text = "性别";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 318);
            label6.Name = "label6";
            label6.Size = new Size(46, 24);
            label6.TabIndex = 1;
            label6.Text = "爱好";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(240, 256);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 28);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(314, 256);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 28);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(389, 256);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(71, 28);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "你猜";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(240, 318);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 28);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "唱";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(314, 318);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(54, 28);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "跳";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(389, 317);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(65, 28);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "rap";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(472, 318);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 28);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "篮球";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 545);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}
