namespace day05
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
            shiCb = new ComboBox();
            SuspendLayout();
            // 
            // shengfenCb
            // 
            shengfenCb.FormattingEnabled = true;
            shengfenCb.Location = new Point(78, 125);
            shengfenCb.Name = "shengfenCb";
            shengfenCb.Size = new Size(205, 32);
            shengfenCb.TabIndex = 0;
            shengfenCb.Text = "请选择省份";
            // 
            // shiCb
            // 
            shiCb.FormattingEnabled = true;
            shiCb.Location = new Point(301, 125);
            shiCb.Name = "shiCb";
            shiCb.Size = new Size(205, 32);
            shiCb.TabIndex = 0;
            shiCb.Text = "请选择城市";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(shiCb);
            Controls.Add(shengfenCb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox shengfenCb;
        private ComboBox shiCb;
    }
}
