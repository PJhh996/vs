namespace day05
{
    partial class Form4
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
            allBox = new CheckBox();
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // allBox
            // 
            allBox.AutoSize = true;
            allBox.Location = new Point(115, 69);
            allBox.Name = "allBox";
            allBox.Size = new Size(72, 28);
            allBox.TabIndex = 0;
            allBox.Text = "全选";
            allBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox7);
            panel1.Controls.Add(checkBox6);
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Location = new Point(125, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 322);
            panel1.TabIndex = 1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(72, 28);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "西瓜";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(3, 37);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(72, 28);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "香蕉";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(3, 71);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 28);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "苹果";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(3, 105);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(72, 28);
            checkBox5.TabIndex = 0;
            checkBox5.Text = "橘子";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(3, 139);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(72, 28);
            checkBox6.TabIndex = 0;
            checkBox6.Text = "火车";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(3, 173);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(90, 28);
            checkBox7.TabIndex = 0;
            checkBox7.Text = "摩托车";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(panel1);
            Controls.Add(allBox);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox allBox;
        private Panel panel1;
        private CheckBox checkBox2;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
    }
}