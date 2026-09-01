namespace homework6
{
    partial class UserBookControl1
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
            booktip = new AntdUI.Label();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            nameInp = new AntdUI.Input();
            authorInp = new AntdUI.Input();
            markInp = new AntdUI.Input();
            priceInp = new AntdUI.InputNumber();
            btn = new AntdUI.Button();
            SuspendLayout();
            // 
            // booktip
            // 
            booktip.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            booktip.Location = new Point(276, 0);
            booktip.Name = "booktip";
            booktip.Size = new Size(267, 74);
            booktip.TabIndex = 0;
            booktip.Text = "";
            booktip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(99, 80);
            label1.Name = "label1";
            label1.Size = new Size(117, 91);
            label1.TabIndex = 1;
            label1.Text = "书名：";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(99, 177);
            label2.Name = "label2";
            label2.Size = new Size(117, 91);
            label2.TabIndex = 1;
            label2.Text = "作者：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(99, 274);
            label3.Name = "label3";
            label3.Size = new Size(117, 91);
            label3.TabIndex = 1;
            label3.Text = "价格：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(99, 371);
            label4.Name = "label4";
            label4.Size = new Size(117, 91);
            label4.TabIndex = 1;
            label4.Text = "标签：";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameInp
            // 
            nameInp.Location = new Point(222, 80);
            nameInp.Name = "nameInp";
            nameInp.PlaceholderText = "请输入书名";
            nameInp.PrefixText = "";
            nameInp.Size = new Size(378, 91);
            nameInp.TabIndex = 2;
            // 
            // authorInp
            // 
            authorInp.Location = new Point(222, 177);
            authorInp.Name = "authorInp";
            authorInp.PlaceholderText = "请输入作者";
            authorInp.Size = new Size(378, 91);
            authorInp.SuffixText = "";
            authorInp.TabIndex = 2;
            // 
            // markInp
            // 
            markInp.Location = new Point(222, 371);
            markInp.Multiline = true;
            markInp.Name = "markInp";
            markInp.PlaceholderText = "请输入标签";
            markInp.Size = new Size(378, 173);
            markInp.TabIndex = 2;
            // 
            // priceInp
            // 
            priceInp.Location = new Point(222, 274);
            priceInp.Name = "priceInp";
            priceInp.Size = new Size(378, 91);
            priceInp.TabIndex = 3;
            priceInp.Text = "0";
            // 
            // btn
            // 
            btn.Location = new Point(319, 550);
            btn.Name = "btn";
            btn.Size = new Size(180, 94);
            btn.TabIndex = 4;
            // 
            // UserBookControl1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn);
            Controls.Add(priceInp);
            Controls.Add(markInp);
            Controls.Add(authorInp);
            Controls.Add(nameInp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(booktip);
            Name = "UserBookControl1";
            Size = new Size(770, 690);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label booktip;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Input nameInp;
        private AntdUI.Input authorInp;
        private AntdUI.Input markInp;
        private AntdUI.InputNumber priceInp;
        private AntdUI.Button btn;
    }
}
