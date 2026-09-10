namespace homework8
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
            label1 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            label7 = new Label();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            userControl11 = new WinFormsControlLibrary1.UserControl1();
            label3 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            button1 = new Button();
            label5 = new Label();
            panel5 = new Panel();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(441, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 45);
            label1.TabIndex = 0;
            label1.Text = "温控设备监控主界面";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 263);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(32, 149);
            panel6.Name = "panel6";
            panel6.Size = new Size(213, 61);
            panel6.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 17);
            label8.Name = "label8";
            label8.Size = new Size(0, 24);
            label8.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 17);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 0;
            label7.Text = "当前状态：";
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.Location = new Point(145, 63);
            button3.Name = "button3";
            button3.Size = new Size(137, 49);
            button3.TabIndex = 1;
            button3.Text = "断开PLC";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(3, 63);
            button2.Name = "button2";
            button2.Size = new Size(136, 49);
            button2.TabIndex = 1;
            button2.Text = "连接PLC";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(285, 45);
            label2.TabIndex = 0;
            label2.Text = "连接控制区";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(userControl11);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(309, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 263);
            panel2.TabIndex = 1;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(73, 48);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(313, 171);
            userControl11.TabIndex = 1;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(447, 45);
            label3.TabIndex = 0;
            label3.Text = "监控画面";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(764, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(287, 263);
            panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 128);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "请输入设定温度";
            textBox1.Size = new Size(274, 30);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(285, 45);
            label4.TabIndex = 0;
            label4.Text = "设备控制区";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleGreen;
            button6.Location = new Point(145, 185);
            button6.Name = "button6";
            button6.Size = new Size(136, 49);
            button6.TabIndex = 1;
            button6.Text = "设定温度";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGreen;
            button5.Location = new Point(145, 63);
            button5.Name = "button5";
            button5.Size = new Size(136, 49);
            button5.TabIndex = 1;
            button5.Text = "停止";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleGreen;
            button4.Location = new Point(3, 63);
            button4.Name = "button4";
            button4.Size = new Size(136, 49);
            button4.TabIndex = 1;
            button4.Text = "启动";
            button4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 348);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(518, 302);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel4
            // 
            tableLayoutPanel1.SetColumnSpan(panel4, 4);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(510, 43);
            panel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(367, 2);
            button1.Name = "button1";
            button1.Size = new Size(140, 41);
            button1.TabIndex = 3;
            button1.Text = "查看历史数据";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(510, 43);
            label5.TabIndex = 0;
            label5.Text = "数据记录区";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(richTextBox1);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(536, 348);
            panel5.Name = "panel5";
            panel5.Size = new Size(515, 302);
            panel5.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(515, 266);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(515, 36);
            label6.TabIndex = 0;
            label6.Text = "日志输出区";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 741);
            Controls.Add(panel5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Button button1;
        private Label label5;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Panel panel5;
        private RichTextBox richTextBox1;
        private Label label6;
        private Panel panel6;
        private Label label8;
        private Label label7;
        private WinFormsControlLibrary1.UserControl1 userControl11;
    }
}
