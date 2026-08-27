namespace day04
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
            lab = new Label();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 21);
            button1.Name = "button1";
            button1.Size = new Size(115, 70);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 44);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 1;
            label1.Text = "键盘按下时长：";
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Location = new Point(457, 67);
            lab.Name = "lab";
            lab.Size = new Size(0, 24);
            lab.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "香蕉", "苹果", "西瓜", "西瓜保熟吗" });
            comboBox1.Location = new Point(475, 227);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 32);
            comboBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(475, 292);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(236, 86);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 30);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(lab);
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
        private Label lab;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
    }
}
