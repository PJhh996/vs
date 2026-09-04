namespace ClssProject.book
{
    partial class BookAddAndEdit
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
            inputNumber1 = new AntdUI.InputNumber();
            button1 = new AntdUI.Button();
            label3 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            input4 = new AntdUI.Input();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(978, 109);
            label1.TabIndex = 2;
            label1.Text = "";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(199, 139);
            label2.Name = "label2";
            label2.Size = new Size(74, 52);
            label2.TabIndex = 3;
            label2.Text = "书名：";
            // 
            // input1
            // 
            input1.Location = new Point(279, 115);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入书名";
            input1.Size = new Size(422, 91);
            input1.TabIndex = 4;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(279, 309);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(422, 91);
            inputNumber1.TabIndex = 5;
            inputNumber1.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(355, 558);
            button1.Name = "button1";
            button1.Size = new Size(276, 74);
            button1.TabIndex = 6;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(199, 236);
            label3.Name = "label3";
            label3.Size = new Size(74, 52);
            label3.TabIndex = 3;
            label3.Text = "作者：";
            // 
            // input2
            // 
            input2.Location = new Point(279, 212);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入作者";
            input2.Size = new Size(422, 91);
            input2.TabIndex = 4;
            // 
            // label4
            // 
            label4.Location = new Point(199, 333);
            label4.Name = "label4";
            label4.Size = new Size(74, 52);
            label4.TabIndex = 3;
            label4.Text = "价格：";
            // 
            // label5
            // 
            label5.Location = new Point(199, 430);
            label5.Name = "label5";
            label5.Size = new Size(74, 52);
            label5.TabIndex = 3;
            label5.Text = "标签：";
            // 
            // input4
            // 
            input4.Location = new Point(279, 406);
            input4.Multiline = true;
            input4.Name = "input4";
            input4.PlaceholderText = "请输入标签（一行一个）";
            input4.Size = new Size(422, 146);
            input4.TabIndex = 4;
            // 
            // BookAddAndEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 644);
            Controls.Add(button1);
            Controls.Add(inputNumber1);
            Controls.Add(input4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(input2);
            Controls.Add(label3);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookAddAndEdit";
            Text = "BookAddAndEdit";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input input1;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Button button1;
        private AntdUI.Label label3;
        private AntdUI.Input input2;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Input input4;
    }
}