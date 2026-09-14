namespace kaoshi2.CarManager
{
    partial class CarAdd
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(678, 71);
            label1.TabIndex = 1;
            label1.Text = "新增车辆";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 173);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 2;
            label2.Text = "车牌号：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 266);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 2;
            label3.Text = "车辆类型：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 359);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 2;
            label4.Text = "车辆时费：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 170);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "请输入车牌号";
            textBox1.Size = new Size(252, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 263);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "请输入车辆类型";
            textBox2.Size = new Size(252, 30);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(221, 356);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 30);
            textBox3.TabIndex = 3;
            textBox3.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(247, 461);
            button1.Name = "button1";
            button1.Size = new Size(178, 95);
            button1.TabIndex = 4;
            button1.Text = "新增";
            button1.UseVisualStyleBackColor = true;
            // 
            // CarAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 644);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CarAdd";
            Text = "CarAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}