namespace homework5
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            userBook1 = new homework5.USctrl.UserBook();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(18, 16);
            button1.Name = "button1";
            button1.Size = new Size(243, 41);
            button1.TabIndex = 0;
            button1.Text = "新增图书";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(18, 63);
            button2.Name = "button2";
            button2.Size = new Size(243, 41);
            button2.TabIndex = 0;
            button2.Text = "删除图书";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(18, 110);
            button3.Name = "button3";
            button3.Size = new Size(243, 41);
            button3.TabIndex = 0;
            button3.Text = "编辑图书";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(18, 157);
            button4.Name = "button4";
            button4.Size = new Size(243, 41);
            button4.TabIndex = 0;
            button4.Text = "查询所有图书";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(18, 204);
            button5.Name = "button5";
            button5.Size = new Size(243, 41);
            button5.TabIndex = 0;
            button5.Text = "查询单个图书";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(18, 251);
            button6.Name = "button6";
            button6.Size = new Size(243, 41);
            button6.TabIndex = 0;
            button6.Text = "借阅图书";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(18, 298);
            button7.Name = "button7";
            button7.Size = new Size(243, 41);
            button7.TabIndex = 0;
            button7.Text = "归还图书";
            button7.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(userBook1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(277, 8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(511, 430);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // userBook1
            // 
            userBook1.AutoScroll = true;
            userBook1.Location = new Point(3, 3);
            userBook1.Name = "userBook1";
            userBook1.Size = new Size(507, 202);
            userBook1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private FlowLayoutPanel flowLayoutPanel1;
        private USctrl.UserBook userBook1;
    }
}
