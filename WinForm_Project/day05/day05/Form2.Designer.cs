namespace day05
{
    partial class Form2
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
            priceCb = new ComboBox();
            timeCb = new ComboBox();
            SuspendLayout();
            // 
            // priceCb
            // 
            priceCb.FormattingEnabled = true;
            priceCb.Items.AddRange(new object[] { "升序", "降序" });
            priceCb.Location = new Point(59, 87);
            priceCb.Name = "priceCb";
            priceCb.Size = new Size(192, 32);
            priceCb.TabIndex = 0;
            priceCb.Text = "按价格排序";
            // 
            // timeCb
            // 
            timeCb.FormattingEnabled = true;
            timeCb.Items.AddRange(new object[] { "升序", "降序" });
            timeCb.Location = new Point(288, 87);
            timeCb.Name = "timeCb";
            timeCb.Size = new Size(192, 32);
            timeCb.TabIndex = 0;
            timeCb.Text = "按上架时间排序";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timeCb);
            Controls.Add(priceCb);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox priceCb;
        private ComboBox timeCb;
    }
}