namespace ClssProject.book
{
    partial class register
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
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            button1 = new AntdUI.Button();
            label3 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            label4 = new AntdUI.Label();
            input3 = new AntdUI.Input();
            label5 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            inputNumber1 = new AntdUI.InputNumber();
            radio1 = new AntdUI.Radio();
            panel1 = new Panel();
            radio2 = new AntdUI.Radio();
            select1 = new AntdUI.Select();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(978, 109);
            label1.TabIndex = 4;
            label1.Text = "注册";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(176, 129);
            label2.Name = "label2";
            label2.Size = new Size(173, 44);
            label2.TabIndex = 5;
            label2.Text = "用户名：";
            // 
            // input1
            // 
            input1.Location = new Point(309, 115);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入用户名";
            input1.Size = new Size(371, 71);
            input1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(389, 546);
            button1.Name = "button1";
            button1.Size = new Size(187, 86);
            button1.TabIndex = 7;
            button1.Text = "注册";
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(176, 193);
            label3.Name = "label3";
            label3.Size = new Size(173, 44);
            label3.TabIndex = 5;
            label3.Text = "密码：";
            // 
            // input2
            // 
            input2.Location = new Point(309, 179);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入密码";
            input2.Size = new Size(371, 71);
            input2.TabIndex = 6;
            // 
            // label4
            // 
            label4.Location = new Point(176, 257);
            label4.Name = "label4";
            label4.Size = new Size(173, 44);
            label4.TabIndex = 5;
            label4.Text = "确认密码：";
            // 
            // input3
            // 
            input3.Location = new Point(309, 243);
            input3.Name = "input3";
            input3.PlaceholderText = "请确认密码";
            input3.Size = new Size(371, 71);
            input3.TabIndex = 6;
            // 
            // label5
            // 
            label5.Location = new Point(176, 321);
            label5.Name = "label5";
            label5.Size = new Size(173, 44);
            label5.TabIndex = 5;
            label5.Text = "年龄：";
            // 
            // label6
            // 
            label6.Location = new Point(176, 385);
            label6.Name = "label6";
            label6.Size = new Size(173, 44);
            label6.TabIndex = 5;
            label6.Text = "性别：";
            // 
            // label7
            // 
            label7.Location = new Point(176, 449);
            label7.Name = "label7";
            label7.Size = new Size(173, 44);
            label7.TabIndex = 5;
            label7.Text = "班级：";
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(309, 308);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(371, 71);
            inputNumber1.TabIndex = 8;
            inputNumber1.Text = "0";
            // 
            // radio1
            // 
            radio1.Location = new Point(3, 21);
            radio1.Name = "radio1";
            radio1.Size = new Size(116, 32);
            radio1.TabIndex = 9;
            radio1.Text = "男";
            // 
            // panel1
            // 
            panel1.Controls.Add(radio2);
            panel1.Controls.Add(radio1);
            panel1.Location = new Point(309, 371);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 65);
            panel1.TabIndex = 10;
            // 
            // radio2
            // 
            radio2.Location = new Point(151, 21);
            radio2.Name = "radio2";
            radio2.Size = new Size(116, 32);
            radio2.TabIndex = 9;
            radio2.Text = "女";
            // 
            // select1
            // 
            select1.DropDownArrow = true;
            select1.Location = new Point(309, 430);
            select1.Name = "select1";
            select1.PlaceholderText = "请选择班级";
            select1.Size = new Size(371, 71);
            select1.TabIndex = 11;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 644);
            Controls.Add(select1);
            Controls.Add(panel1);
            Controls.Add(inputNumber1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(input3);
            Controls.Add(label4);
            Controls.Add(input2);
            Controls.Add(label3);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input input1;
        private AntdUI.Button button1;
        private AntdUI.Label label3;
        private AntdUI.Input input2;
        private AntdUI.Label label4;
        private AntdUI.Input input3;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Radio radio1;
        private Panel panel1;
        private AntdUI.Radio radio2;
        private AntdUI.Select select1;
    }
}