namespace homework5
{
    partial class AddForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bNameTb = new TextBox();
            auNameTb = new TextBox();
            priceTb = new TextBox();
            markTb = new TextBox();
            addBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 0;
            label1.Text = "新增图书";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 60);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 0;
            label2.Text = "图书名称：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 117);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 0;
            label3.Text = "作者：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 176);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 0;
            label4.Text = "价格：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 238);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 0;
            label5.Text = "标签：";
            // 
            // bNameTb
            // 
            bNameTb.Location = new Point(297, 54);
            bNameTb.Name = "bNameTb";
            bNameTb.Size = new Size(256, 30);
            bNameTb.TabIndex = 1;
            // 
            // auNameTb
            // 
            auNameTb.Location = new Point(297, 111);
            auNameTb.Name = "auNameTb";
            auNameTb.Size = new Size(256, 30);
            auNameTb.TabIndex = 1;
            // 
            // priceTb
            // 
            priceTb.Location = new Point(297, 170);
            priceTb.Name = "priceTb";
            priceTb.Size = new Size(256, 30);
            priceTb.TabIndex = 1;
            // 
            // markTb
            // 
            markTb.Location = new Point(297, 232);
            markTb.Name = "markTb";
            markTb.Size = new Size(256, 30);
            markTb.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(297, 334);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(210, 83);
            addBtn.TabIndex = 2;
            addBtn.Text = "新增";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addBtn);
            Controls.Add(markTb);
            Controls.Add(priceTb);
            Controls.Add(auNameTb);
            Controls.Add(bNameTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox bNameTb;
        private TextBox auNameTb;
        private TextBox priceTb;
        private TextBox markTb;
        private Button addBtn;
    }
}