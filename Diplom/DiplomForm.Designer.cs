namespace Diplom
{
    partial class DiplomForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            labelCol3 = new Label();
            labelCol2 = new Label();
            labelCol1 = new Label();
            dataGridViewNumberEntry = new DataGridView();
            dataGridViewStudentEntry = new DataGridView();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumberEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentEntry).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(74, 103);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(337, 103);
            label4.TabIndex = 5;
            label4.Text = "Ф.И.О. студента";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 8F);
            label3.Location = new Point(5, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 103);
            label3.TabIndex = 4;
            label3.Text = "№\r\nп/п";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(759, 2);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(340, 48);
            label1.TabIndex = 2;
            label1.Text = "УЧЕБНЫЕ ДИСЦИПЛИНЫ,";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBox1, 3);
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(2, 2);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(754, 50);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBox2, 2);
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(417, 53);
            textBox2.Margin = new Padding(1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(682, 47);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            tableLayoutPanel.SetColumnSpan(label2, 2);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 8F);
            label2.Location = new Point(2, 53);
            label2.Margin = new Padding(1);
            label2.Name = "label2";
            label2.Size = new Size(412, 48);
            label2.TabIndex = 3;
            label2.Text = "Дисциплина, междисциплинарный курс";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 341F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 342F));
            tableLayoutPanel.Controls.Add(labelCol3, 2, 3);
            tableLayoutPanel.Controls.Add(labelCol2, 1, 3);
            tableLayoutPanel.Controls.Add(labelCol1, 0, 3);
            tableLayoutPanel.Controls.Add(label2, 0, 1);
            tableLayoutPanel.Controls.Add(textBox2, 2, 1);
            tableLayoutPanel.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel.Controls.Add(label1, 2, 0);
            tableLayoutPanel.Controls.Add(label3, 0, 2);
            tableLayoutPanel.Controls.Add(label4, 1, 2);
            tableLayoutPanel.Controls.Add(dataGridViewNumberEntry, 2, 2);
            tableLayoutPanel.Controls.Add(dataGridViewStudentEntry, 0, 4);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(14, 14);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1101, 1389);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelCol3
            // 
            labelCol3.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(labelCol3, 2);
            labelCol3.Dock = DockStyle.Fill;
            labelCol3.Font = new Font("Segoe UI", 11F);
            labelCol3.Location = new Point(420, 207);
            labelCol3.Margin = new Padding(4, 0, 4, 0);
            labelCol3.Name = "labelCol3";
            labelCol3.Size = new Size(676, 54);
            labelCol3.TabIndex = 9;
            labelCol3.Text = "3";
            labelCol3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCol2
            // 
            labelCol2.AutoSize = true;
            labelCol2.Dock = DockStyle.Fill;
            labelCol2.Font = new Font("Segoe UI", 11F);
            labelCol2.Location = new Point(74, 207);
            labelCol2.Margin = new Padding(4, 0, 4, 0);
            labelCol2.Name = "labelCol2";
            labelCol2.Size = new Size(337, 54);
            labelCol2.TabIndex = 8;
            labelCol2.Text = "2";
            labelCol2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCol1
            // 
            labelCol1.AutoSize = true;
            labelCol1.Dock = DockStyle.Fill;
            labelCol1.Font = new Font("Segoe UI", 11F);
            labelCol1.Location = new Point(5, 207);
            labelCol1.Margin = new Padding(4, 0, 4, 0);
            labelCol1.Name = "labelCol1";
            labelCol1.Size = new Size(60, 54);
            labelCol1.TabIndex = 7;
            labelCol1.Text = "1";
            labelCol1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewNumberEntry
            // 
            dataGridViewNumberEntry.AllowUserToAddRows = false;
            dataGridViewNumberEntry.AllowUserToDeleteRows = false;
            dataGridViewNumberEntry.AllowUserToResizeColumns = false;
            dataGridViewNumberEntry.AllowUserToResizeRows = false;
            dataGridViewNumberEntry.BackgroundColor = SystemColors.Window;
            dataGridViewNumberEntry.BorderStyle = BorderStyle.None;
            dataGridViewNumberEntry.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewNumberEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNumberEntry.ColumnHeadersVisible = false;
            tableLayoutPanel.SetColumnSpan(dataGridViewNumberEntry, 2);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewNumberEntry.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewNumberEntry.Dock = DockStyle.Fill;
            dataGridViewNumberEntry.Location = new Point(416, 103);
            dataGridViewNumberEntry.Margin = new Padding(0);
            dataGridViewNumberEntry.Name = "dataGridViewNumberEntry";
            dataGridViewNumberEntry.RowHeadersVisible = false;
            dataGridViewNumberEntry.RowHeadersWidth = 62;
            dataGridViewNumberEntry.Size = new Size(684, 103);
            dataGridViewNumberEntry.TabIndex = 6;
            // 
            // dataGridViewStudentEntry
            // 
            dataGridViewStudentEntry.BackgroundColor = SystemColors.Window;
            dataGridViewStudentEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentEntry.ColumnHeadersVisible = false;
            tableLayoutPanel.SetColumnSpan(dataGridViewStudentEntry, 4);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewStudentEntry.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewStudentEntry.Dock = DockStyle.Fill;
            dataGridViewStudentEntry.Location = new Point(1, 262);
            dataGridViewStudentEntry.Margin = new Padding(0);
            dataGridViewStudentEntry.Name = "dataGridViewStudentEntry";
            dataGridViewStudentEntry.RowHeadersWidth = 30;
            dataGridViewStudentEntry.ScrollBars = ScrollBars.Vertical;
            dataGridViewStudentEntry.Size = new Size(1099, 1126);
            dataGridViewStudentEntry.TabIndex = 6;
            // 
            // DiplomForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 1417);
            Controls.Add(tableLayoutPanel);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(4);
            Name = "DiplomForm";
            Padding = new Padding(14);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DIPLOM";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumberEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentEntry).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridViewNumberEntry;
        private DataGridView dataGridViewStudentEntry;
        private Label labelCol3;
        private Label labelCol2;
        private Label labelCol1;
    }
}
