namespace zuoye3
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(21, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(873, 111);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column1.FillWeight = 186.2069F;
            Column1.HeaderText = "编号";
            Column1.MinimumWidth = 100;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column2.FillWeight = 82.75861F;
            Column2.HeaderText = "菜品名称";
            Column2.MinimumWidth = 100;
            Column2.Name = "Column2";
            Column2.Width = 118;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column3.FillWeight = 82.75861F;
            Column3.HeaderText = "菜品类型";
            Column3.MinimumWidth = 100;
            Column3.Name = "Column3";
            Column3.Width = 118;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column4.FillWeight = 82.75861F;
            Column4.HeaderText = "哪桌用户";
            Column4.MinimumWidth = 100;
            Column4.Name = "Column4";
            Column4.Width = 118;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column5.HeaderText = "联系电话";
            Column5.MinimumWidth = 100;
            Column5.Name = "Column5";
            Column5.Width = 118;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column6.FillWeight = 82.75861F;
            Column6.HeaderText = "哪一包间";
            Column6.MinimumWidth = 100;
            Column6.Name = "Column6";
            Column6.Width = 118;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column7.FillWeight = 82.75861F;
            Column7.HeaderText = "订单状态";
            Column7.MinimumWidth = 100;
            Column7.Name = "Column7";
            Column7.Width = 118;
            // 
            // button1
            // 
            button1.Location = new Point(21, 13);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "删除选中的";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 695);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button button1;
    }
}
