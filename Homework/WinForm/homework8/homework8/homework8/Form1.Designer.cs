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
            closeBtn = new Button();
            connectBtn = new Button();
            label2 = new Label();
            panel2 = new Panel();
            settempLab = new Label();
            tempLab = new Label();
            panel8 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            inpSetTempTb = new TextBox();
            label4 = new Label();
            setTempBtn = new Button();
            stopBtn = new Button();
            startBtn = new Button();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            panel4 = new Panel();
            panel7 = new Panel();
            label5 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(550, 9);
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
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(connectBtn);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 263);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(72, 149);
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
            label7.Location = new Point(16, 17);
            label7.Name = "label7";
            label7.Size = new Size(154, 24);
            label7.TabIndex = 0;
            label7.Text = "当前状态：未连接";
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.PaleGreen;
            closeBtn.Location = new Point(183, 63);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(137, 49);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "断开PLC";
            closeBtn.UseVisualStyleBackColor = false;
            // 
            // connectBtn
            // 
            connectBtn.BackColor = Color.PaleGreen;
            connectBtn.ForeColor = SystemColors.ControlText;
            connectBtn.Location = new Point(43, 63);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(136, 49);
            connectBtn.TabIndex = 1;
            connectBtn.Text = "连接PLC";
            connectBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(398, 45);
            label2.TabIndex = 0;
            label2.Text = "连接控制区";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(settempLab);
            panel2.Controls.Add(tempLab);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(417, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 263);
            panel2.TabIndex = 1;
            // 
            // settempLab
            // 
            settempLab.AutoSize = true;
            settempLab.Location = new Point(287, 221);
            settempLab.Name = "settempLab";
            settempLab.Size = new Size(118, 24);
            settempLab.TabIndex = 2;
            settempLab.Text = "设定温度：℃";
            // 
            // tempLab
            // 
            tempLab.AutoSize = true;
            tempLab.Location = new Point(56, 221);
            tempLab.Name = "tempLab";
            tempLab.Size = new Size(118, 24);
            tempLab.TabIndex = 2;
            tempLab.Text = "实时温度：℃";
            // 
            // panel8
            // 
            panel8.Location = new Point(84, 56);
            panel8.Name = "panel8";
            panel8.Size = new Size(344, 162);
            panel8.TabIndex = 1;
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
            panel3.Controls.Add(inpSetTempTb);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(setTempBtn);
            panel3.Controls.Add(stopBtn);
            panel3.Controls.Add(startBtn);
            panel3.Location = new Point(872, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 263);
            panel3.TabIndex = 1;
            // 
            // inpSetTempTb
            // 
            inpSetTempTb.Location = new Point(59, 128);
            inpSetTempTb.Name = "inpSetTempTb";
            inpSetTempTb.PlaceholderText = "请输入设定温度";
            inpSetTempTb.Size = new Size(274, 30);
            inpSetTempTb.TabIndex = 2;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(398, 45);
            label4.TabIndex = 0;
            label4.Text = "设备控制区";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // setTempBtn
            // 
            setTempBtn.BackColor = Color.PaleGreen;
            setTempBtn.Location = new Point(201, 185);
            setTempBtn.Name = "setTempBtn";
            setTempBtn.Size = new Size(136, 49);
            setTempBtn.TabIndex = 1;
            setTempBtn.Text = "设定温度";
            setTempBtn.UseVisualStyleBackColor = false;
            // 
            // stopBtn
            // 
            stopBtn.BackColor = Color.PaleGreen;
            stopBtn.Location = new Point(201, 63);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(136, 49);
            stopBtn.TabIndex = 1;
            stopBtn.Text = "停止";
            stopBtn.UseVisualStyleBackColor = false;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.PaleGreen;
            startBtn.Location = new Point(59, 63);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(136, 49);
            startBtn.TabIndex = 1;
            startBtn.Text = "启动";
            startBtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(flowLayoutPanel1);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(652, 348);
            panel5.Name = "panel5";
            panel5.Size = new Size(620, 356);
            panel5.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(620, 320);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(620, 36);
            label6.TabIndex = 0;
            label6.Text = "日志输出区";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(11, 348);
            panel4.Name = "panel4";
            panel4.Size = new Size(635, 356);
            panel4.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(label5);
            panel7.Controls.Add(button1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(635, 36);
            panel7.TabIndex = 5;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(504, 36);
            label5.TabIndex = 0;
            label5.Text = "数据记录区";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(504, 0);
            button1.Name = "button1";
            button1.Size = new Size(131, 36);
            button1.TabIndex = 4;
            button1.Text = "查看历史记录";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(635, 320);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 730);
            Controls.Add(panel4);
            Controls.Add(panel5);
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
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button closeBtn;
        private Button connectBtn;
        private TextBox inpSetTempTb;
        private Button setTempBtn;
        private Button stopBtn;
        private Button startBtn;
        private Panel panel5;
        private Label label6;
        private Panel panel6;
        private Label label8;
        private Label label7;
        private Panel panel4;
        private Label label5;
        private DataGridView dataGridView1;
        private Panel panel7;
        private Button button1;
        private Label settempLab;
        private Label tempLab;
        private Panel panel8;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
