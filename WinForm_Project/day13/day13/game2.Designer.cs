namespace day13
{
    partial class game2
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(426, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 863);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(67, 27);
            button1.Name = "button1";
            button1.Size = new Size(221, 106);
            button1.TabIndex = 1;
            button1.Text = "开始游戏";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 172);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 2;
            label1.Text = "得分：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 172);
            label2.Name = "label2";
            label2.Size = new Size(21, 24);
            label2.TabIndex = 3;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 219);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 4;
            label3.Text = "速度：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 219);
            label4.Name = "label4";
            label4.Size = new Size(21, 24);
            label4.TabIndex = 5;
            label4.Text = "0";
            // 
            // game2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 900);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "game2";
            Text = "game2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}