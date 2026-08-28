namespace homework3
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
            shengfenCb = new ComboBox();
            chengshiCb = new ComboBox();
            SuspendLayout();
            // 
            // shengfenCb
            // 
            shengfenCb.FormattingEnabled = true;
            shengfenCb.Location = new Point(62, 81);
            shengfenCb.Name = "shengfenCb";
            shengfenCb.Size = new Size(251, 32);
            shengfenCb.TabIndex = 0;
            shengfenCb.Text = "请输入省份";
            // 
            // chengshiCb
            // 
            chengshiCb.FormattingEnabled = true;
            chengshiCb.Location = new Point(338, 81);
            chengshiCb.Name = "chengshiCb";
            chengshiCb.Size = new Size(251, 32);
            chengshiCb.TabIndex = 0;
            chengshiCb.Text = "请输入城市";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chengshiCb);
            Controls.Add(shengfenCb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox shengfenCb;
        private ComboBox chengshiCb;
    }
}
