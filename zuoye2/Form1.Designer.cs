namespace zuoye2
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            Column1 = new DataGridViewButtonColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "POST", "A", "B", "C" });
            comboBox1.Location = new Point(12, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 32);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "POST";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(596, 30);
            textBox1.TabIndex = 1;
            textBox1.Text = "http://localhost/api/mgr/signin";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(802, 28);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "发送";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(200, 110);
            button2.Name = "button2";
            button2.Size = new Size(112, 52);
            button2.TabIndex = 3;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 128);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 4;
            label1.Text = "消息头";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(51, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.Size = new Size(398, 223);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(328, 109);
            button3.Name = "button3";
            button3.Size = new Size(121, 55);
            button3.TabIndex = 6;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(660, 128);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 7;
            label2.Text = "消息体";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(474, 212);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(416, 223);
            textBox2.TabIndex = 8;
            textBox2.Text = "username=byhy&password=88888888";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "名称";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "值";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 500);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "接口测试工具";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private DataGridViewButtonColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
