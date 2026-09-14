namespace kaoshi2.CarManager
{
    partial class UserAdd
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
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(242, 537);
            button1.Name = "button1";
            button1.Size = new Size(178, 95);
            button1.TabIndex = 12;
            button1.Text = "新增";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 30);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 30);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 30);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 269);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 6;
            label4.Text = "性别：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 176);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 7;
            label3.Text = "身份证：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 111);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 8;
            label2.Text = "姓名：";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(678, 71);
            label1.TabIndex = 5;
            label1.Text = "新增用户";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 359);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 6;
            label5.Text = "手机号：";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 356);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(252, 30);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 444);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 6;
            label6.Text = "座右铭：";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(211, 441);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(252, 30);
            textBox5.TabIndex = 9;
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 644);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserAdd";
            Text = "UserAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
    }
}