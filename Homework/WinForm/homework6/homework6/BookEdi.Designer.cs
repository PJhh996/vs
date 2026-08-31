namespace homework6
{
    partial class BookEdi
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
            userBookControl11 = new UserBookControl1("编辑");
            SuspendLayout();
            // 
            // userBookControl11
            // 
            userBookControl11.Location = new Point(71, 12);
            userBookControl11.Name = "userBookControl11";
            userBookControl11.Size = new Size(738, 734);
            userBookControl11.TabIndex = 0;
            // 
            // BookEdi
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 783);
            Controls.Add(userBookControl11);
            Name = "BookEdi";
            Text = "BookEdi";
            ResumeLayout(false);
        }

        #endregion

        private UserBookControl1 userBookControl11;
    }
}