namespace homework6
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
            addbtn = new AntdUI.Button();
            edibtn = new AntdUI.Button();
            lookbtn = new AntdUI.Button();
            SuspendLayout();
            // 
            // addbtn
            // 
            addbtn.Location = new Point(12, 12);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(295, 114);
            addbtn.TabIndex = 0;
            addbtn.Text = "新增图书";
            addbtn.Click += Addbtn_Click;
            // 
            // edibtn
            // 
            edibtn.Location = new Point(12, 132);
            edibtn.Name = "edibtn";
            edibtn.Size = new Size(295, 114);
            edibtn.TabIndex = 0;
            edibtn.Text = "编辑图书";
            edibtn.Click += Edibtn_Click;
            // 
            // lookbtn
            // 
            lookbtn.Location = new Point(12, 252);
            lookbtn.Name = "lookbtn";
            lookbtn.Size = new Size(295, 114);
            lookbtn.TabIndex = 0;
            lookbtn.Text = "查看图书";
            lookbtn.Click += Lookbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 470);
            Controls.Add(lookbtn);
            Controls.Add(edibtn);
            Controls.Add(addbtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button addbtn;
        private AntdUI.Button edibtn;
        private AntdUI.Button lookbtn;
    }
}
