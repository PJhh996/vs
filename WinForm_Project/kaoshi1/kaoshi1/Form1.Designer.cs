namespace kaoshi1
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            checkBox1 = new CheckBox();
            groupBox3 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            Nametab = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox4 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(Nametab);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(66, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "设备参数";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 332);
            label4.Name = "label4";
            label4.Size = new Size(28, 24);
            label4.TabIndex = 7;
            label4.Text = "℃";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(146, 330);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(227, 30);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 332);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 5;
            label3.Text = "温度上限：";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(146, 272);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(144, 28);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "启用温度报警";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(51, 174);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(353, 80);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "运行模式";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(190, 29);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 28);
            radioButton2.TabIndex = 0;
            radioButton2.Text = "手动模式";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(35, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 28);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "自动模式";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "刻蚀设备", "类型1设备", "类型2设备" });
            comboBox1.Location = new Point(146, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 32);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "刻蚀设备";
            // 
            // Nametab
            // 
            Nametab.Location = new Point(146, 57);
            Nametab.Name = "Nametab";
            Nametab.Size = new Size(227, 30);
            Nametab.TabIndex = 1;
            Nametab.Text = "ETCH-01";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 117);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 0;
            label2.Text = "设备类型：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 60);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "设备名称：";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(610, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 408);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "设备状态";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 260);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 0;
            label7.Text = "报警状态：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 174);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 0;
            label6.Text = "连接状态：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(243, 260);
            label10.Name = "label10";
            label10.Size = new Size(46, 24);
            label10.TabIndex = 0;
            label10.Text = "正常";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(243, 174);
            label9.Name = "label9";
            label9.Size = new Size(64, 24);
            label9.TabIndex = 0;
            label9.Text = "未连接";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 85);
            label8.Name = "label8";
            label8.Size = new Size(64, 24);
            label8.TabIndex = 0;
            label8.Text = "未运行";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 85);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 0;
            label5.Text = "当前状态：";
            // 
            // button1
            // 
            button1.Location = new Point(236, 501);
            button1.Name = "button1";
            button1.Size = new Size(178, 54);
            button1.TabIndex = 1;
            button1.Text = "应用参数";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(502, 501);
            button2.Name = "button2";
            button2.Size = new Size(178, 54);
            button2.TabIndex = 1;
            button2.Text = "启动设备";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(757, 501);
            button3.Name = "button3";
            button3.Size = new Size(178, 54);
            button3.TabIndex = 1;
            button3.Text = "停止设备";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flowLayoutPanel1);
            groupBox4.Location = new Point(66, 561);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1051, 260);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "运行日志";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1045, 231);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 875);
            Controls.Add(groupBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "设备参数调试面板";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private TextBox Nametab;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private CheckBox checkBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
