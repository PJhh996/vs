namespace homework2
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnUp2 = new Button();
            btnUp1 = new Button();
            btnSub2 = new Button();
            btnSub1 = new Button();
            label3 = new Label();
            label2 = new Label();
            sumLab = new Label();
            label8 = new Label();
            lab2 = new Label();
            label7 = new Label();
            lab1 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(434, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 30);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 30);
            textBox1.TabIndex = 17;
            // 
            // btnUp2
            // 
            btnUp2.Location = new Point(590, 226);
            btnUp2.Name = "btnUp2";
            btnUp2.Size = new Size(66, 32);
            btnUp2.TabIndex = 12;
            btnUp2.Text = "+";
            btnUp2.UseVisualStyleBackColor = true;
            // 
            // btnUp1
            // 
            btnUp1.Location = new Point(590, 168);
            btnUp1.Name = "btnUp1";
            btnUp1.Size = new Size(66, 32);
            btnUp1.TabIndex = 13;
            btnUp1.Text = "+";
            btnUp1.UseVisualStyleBackColor = true;
            // 
            // btnSub2
            // 
            btnSub2.Location = new Point(353, 226);
            btnSub2.Name = "btnSub2";
            btnSub2.Size = new Size(66, 32);
            btnSub2.TabIndex = 14;
            btnSub2.Text = "-";
            btnSub2.UseVisualStyleBackColor = true;
            // 
            // btnSub1
            // 
            btnSub1.Location = new Point(353, 168);
            btnSub1.Name = "btnSub1";
            btnSub1.Size = new Size(66, 32);
            btnSub1.TabIndex = 15;
            btnSub1.Text = "-";
            btnSub1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 234);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 3;
            label3.Text = "鸡蛋";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 168);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 4;
            label2.Text = "西红柿";
            // 
            // sumLab
            // 
            sumLab.AutoSize = true;
            sumLab.Location = new Point(239, 322);
            sumLab.Name = "sumLab";
            sumLab.Size = new Size(0, 24);
            sumLab.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(162, 322);
            label8.Name = "label8";
            label8.Size = new Size(46, 24);
            label8.TabIndex = 6;
            label8.Text = "总计";
            // 
            // lab2
            // 
            lab2.AutoSize = true;
            lab2.Location = new Point(249, 234);
            lab2.Name = "lab2";
            lab2.Size = new Size(21, 24);
            lab2.TabIndex = 7;
            lab2.Text = "5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 104);
            label7.Name = "label7";
            label7.Size = new Size(46, 24);
            label7.TabIndex = 8;
            label7.Text = "数量";
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Location = new Point(249, 168);
            lab1.Name = "lab1";
            lab1.Size = new Size(21, 24);
            lab1.TabIndex = 9;
            lab1.Text = "3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 104);
            label4.Name = "label4";
            label4.Size = new Size(46, 24);
            label4.TabIndex = 10;
            label4.Text = "单价";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 104);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 11;
            label1.Text = "商品价格";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnUp2);
            Controls.Add(btnUp1);
            Controls.Add(btnSub2);
            Controls.Add(btnSub1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sumLab);
            Controls.Add(label8);
            Controls.Add(lab2);
            Controls.Add(label7);
            Controls.Add(lab1);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnUp2;
        private Button btnUp1;
        private Button btnSub2;
        private Button btnSub1;
        private Label label3;
        private Label label2;
        private Label sumLab;
        private Label label8;
        private Label lab2;
        private Label label7;
        private Label lab1;
        private Label label4;
        private Label label1;
    }
}
