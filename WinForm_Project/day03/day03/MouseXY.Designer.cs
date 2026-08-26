namespace day03
{
    partial class MouseXY
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
            labX = new Label();
            labY = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            lab2 = new Label();
            lab1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 0;
            label1.Text = "光标X轴坐标：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 63);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 0;
            label2.Text = "光标Y轴坐标：";
            // 
            // labX
            // 
            labX.AutoSize = true;
            labX.Location = new Point(159, 25);
            labX.Name = "labX";
            labX.Size = new Size(0, 24);
            labX.TabIndex = 0;
            // 
            // labY
            // 
            labY.AutoSize = true;
            labY.Location = new Point(159, 63);
            labY.Name = "labY";
            labY.Size = new Size(0, 24);
            labY.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 128);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 1;
            label3.Text = "手机号：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 30);
            textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(30, 187);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(235, 125);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // lab2
            // 
            lab2.AutoSize = true;
            lab2.ForeColor = Color.Red;
            lab2.Location = new Point(304, 129);
            lab2.Name = "lab2";
            lab2.Size = new Size(82, 24);
            lab2.TabIndex = 4;
            lab2.Text = "不通过 ×";
            lab2.Visible = false;
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.BackColor = SystemColors.Control;
            lab1.ForeColor = Color.LawnGreen;
            lab1.Location = new Point(304, 131);
            lab1.Name = "lab1";
            lab1.Size = new Size(64, 24);
            lab1.TabIndex = 4;
            lab1.Text = "通过 √";
            lab1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(480, 131);
            button1.Name = "button1";
            button1.Size = new Size(161, 40);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(480, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 30);
            textBox2.TabIndex = 6;
            // 
            // MouseXY
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 591);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(lab1);
            Controls.Add(lab2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labY);
            Controls.Add(labX);
            Controls.Add(label1);
            Name = "MouseXY";
            Text = "MouseXY";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labX;
        private Label labY;
        private Label label3;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label lab2;
        private Label lab1;
        private Button button1;
        private TextBox textBox2;
    }
}