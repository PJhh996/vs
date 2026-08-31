namespace homework6
{
    partial class BookAdd
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
            UserControl = new UserBookControl1("新增");
            SuspendLayout();
            // 
            // UserControl
            // 
            UserControl.Location = new Point(111, 3);
            UserControl.Name = "UserControl";
            UserControl.Size = new Size(814, 688);
            UserControl.TabIndex = 0;
            // 
            // BookAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 703);
            Controls.Add(UserControl);
            Name = "BookAdd";
            Text = "BookAdd";
            ResumeLayout(false);
        }

        #endregion

        private UserBookControl1 UserControl;
    }
}