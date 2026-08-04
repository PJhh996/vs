namespace WinFormsApp1
{
    partial class Names
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
            lstNames = new ListBox();
            Name = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 24;
            lstNames.Location = new Point(12, 27);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(120, 76);
            lstNames.TabIndex = 1;
            lstNames.SelectedIndexChanged += lstNames_SelectedIndexChanged;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(12, 9);
            Name.Name = "Name";
            Name.Size = new Size(70, 24);
            Name.TabIndex = 2;
            Name.Text = "Names";
            Name.Click += Name_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 30);
            txtName.TabIndex = 3;
            txtName.TextChanged += this.txtName_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 25);
            btnAdd.TabIndex = 4;
            btnAdd.Text = " Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Names
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 124);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(Name);
            Controls.Add(lstNames);
            Name = "Names";
            Text = " Names";
            Load += Names_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNames;
        private Label Name;
        private TextBox txtName;
        private Button btnAdd;
    }
}
