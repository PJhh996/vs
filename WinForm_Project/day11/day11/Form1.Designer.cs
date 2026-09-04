namespace day11
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkBox1 = new CheckBox();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 30);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(24, 77);
            button1.Name = "button1";
            button1.Size = new Size(206, 76);
            button1.TabIndex = 1;
            button1.Text = "查看图书";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 184);
            button2.Name = "button2";
            button2.Size = new Size(206, 76);
            button2.TabIndex = 1;
            button2.Text = "更改图书";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 15);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(319, 77);
            button3.Name = "button3";
            button3.Size = new Size(206, 76);
            button3.TabIndex = 1;
            button3.Text = "查看id";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(319, 184);
            button4.Name = "button4";
            button4.Size = new Size(206, 76);
            button4.TabIndex = 1;
            button4.Text = "改变id";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(319, 291);
            button5.Name = "button5";
            button5.Size = new Size(206, 76);
            button5.TabIndex = 1;
            button5.Text = "修改label";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(729, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 28);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(725, 91);
            button6.Name = "button6";
            button6.Size = new Size(156, 79);
            button6.TabIndex = 4;
            button6.Text = "查看bool";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(725, 208);
            button7.Name = "button7";
            button7.Size = new Size(156, 79);
            button7.TabIndex = 4;
            button7.Text = "改变bool";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 702);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
        private Button button6;
        private Button button7;
    }
}
