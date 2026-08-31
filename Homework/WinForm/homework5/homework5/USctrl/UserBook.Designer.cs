namespace homework5.USctrl
{
    partial class UserBook
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bookLab = new Label();
            authorLab = new Label();
            priceLab = new Label();
            markLab = new Label();
            borrowLab = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "书名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 57);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 0;
            label2.Text = "作者：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 98);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 0;
            label3.Text = "价格：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 136);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 0;
            label4.Text = "标签：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 177);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 0;
            label5.Text = "是否借出：";
            // 
            // bookLab
            // 
            bookLab.AutoSize = true;
            bookLab.Location = new Point(161, 19);
            bookLab.Name = "bookLab";
            bookLab.Size = new Size(0, 24);
            bookLab.TabIndex = 0;
            // 
            // authorLab
            // 
            authorLab.AutoSize = true;
            authorLab.Location = new Point(161, 57);
            authorLab.Name = "authorLab";
            authorLab.Size = new Size(0, 24);
            authorLab.TabIndex = 0;
            // 
            // priceLab
            // 
            priceLab.AutoSize = true;
            priceLab.Location = new Point(161, 98);
            priceLab.Name = "priceLab";
            priceLab.Size = new Size(0, 24);
            priceLab.TabIndex = 0;
            // 
            // markLab
            // 
            markLab.AutoSize = true;
            markLab.Location = new Point(161, 136);
            markLab.Name = "markLab";
            markLab.Size = new Size(0, 24);
            markLab.TabIndex = 0;
            // 
            // borrowLab
            // 
            borrowLab.AutoSize = true;
            borrowLab.Location = new Point(161, 177);
            borrowLab.Name = "borrowLab";
            borrowLab.Size = new Size(0, 24);
            borrowLab.TabIndex = 0;
            // 
            // UserBook
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(borrowLab);
            Controls.Add(markLab);
            Controls.Add(priceLab);
            Controls.Add(authorLab);
            Controls.Add(bookLab);
            Controls.Add(label1);
            Name = "UserBook";
            Size = new Size(500, 217);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label bookLab;
        private Label authorLab;
        private Label priceLab;
        private Label markLab;
        private Label borrowLab;
    }
}
