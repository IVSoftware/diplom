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
            label4.Font = new Font("Segoe UI", 7F);
            label4.Location = new Point(55, 83);
            label4.Name = "label4";
            label4.Size = new Size(247, 76);
            label4.TabIndex = 5;
            label4.Text = "Ф.И.О. студента";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 5F);
            label3.Location = new Point(4, 83);
            label3.Name = "label3";
            label3.Size = new Size(44, 76);
            label3.TabIndex = 4;
            label3.Text = "№\r\nп/п";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(558, 2);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 2;
            label1.Text = "УЧЕБНЫЕ ДИСЦИПЛИНЫ,";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBox1, 3);
            textBox1.Location = new Point(2, 4);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(553, 34);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBox2, 2);
            textBox2.Location = new Point(307, 45);
            textBox2.Margin = new Padding(1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(499, 34);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            tableLayoutPanel.SetColumnSpan(label2, 2);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 7F);
            label2.Location = new Point(2, 43);
            label2.Margin = new Padding(1);
            label2.Name = "label2";
            label2.Size = new Size(302, 38);
            label2.TabIndex = 3;
            label2.Text = "Дисциплина, междисциплинарный курс";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
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
            tableLayoutPanel.Location = new Point(10, 10);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(808, 1024);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelCol3
            // 
            labelCol3.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(labelCol3, 2);
            labelCol3.Dock = DockStyle.Fill;
            labelCol3.Font = new Font("Segoe UI", 7F);
            labelCol3.Location = new Point(309, 160);
            labelCol3.Name = "labelCol3";
            labelCol3.Size = new Size(495, 40);
            labelCol3.TabIndex = 9;
            labelCol3.Text = "3";
            labelCol3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCol2
            // 
            labelCol2.AutoSize = true;
            labelCol2.Dock = DockStyle.Fill;
            labelCol2.Font = new Font("Segoe UI", 7F);
            labelCol2.Location = new Point(55, 160);
            labelCol2.Name = "labelCol2";
            labelCol2.Size = new Size(247, 40);
            labelCol2.TabIndex = 8;
            labelCol2.Text = "2";
            labelCol2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCol1
            // 
            labelCol1.AutoSize = true;
            labelCol1.Dock = DockStyle.Fill;
            labelCol1.Font = new Font("Segoe UI", 7F);
            labelCol1.Location = new Point(4, 160);
            labelCol1.Name = "labelCol1";
            labelCol1.Size = new Size(44, 40);
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
            dataGridViewNumberEntry.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewNumberEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNumberEntry.ColumnHeadersVisible = false;
            tableLayoutPanel.SetColumnSpan(dataGridViewNumberEntry, 2);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 6F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewNumberEntry.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewNumberEntry.Dock = DockStyle.Fill;
            dataGridViewNumberEntry.Location = new Point(306, 83);
            dataGridViewNumberEntry.Margin = new Padding(0);
            dataGridViewNumberEntry.Name = "dataGridViewNumberEntry";
            dataGridViewNumberEntry.RowHeadersVisible = false;
            dataGridViewNumberEntry.RowHeadersWidth = 62;
            dataGridViewNumberEntry.Size = new Size(501, 76);
            dataGridViewNumberEntry.TabIndex = 6;
            // 
            // dataGridViewStudentEntry
            // 
            dataGridViewStudentEntry.BackgroundColor = SystemColors.Window;
            dataGridViewStudentEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentEntry.ColumnHeadersVisible = false;
            tableLayoutPanel.SetColumnSpan(dataGridViewStudentEntry, 4);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewStudentEntry.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewStudentEntry.Dock = DockStyle.Fill;
            dataGridViewStudentEntry.Location = new Point(1, 201);
            dataGridViewStudentEntry.Margin = new Padding(0);
            dataGridViewStudentEntry.Name = "dataGridViewStudentEntry";
            dataGridViewStudentEntry.RowHeadersWidth = 30;
            dataGridViewStudentEntry.Size = new Size(806, 822);
            dataGridViewStudentEntry.TabIndex = 6;
            // 
            // DiplomForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 1044);
            Controls.Add(tableLayoutPanel);
            Font = new Font("Segoe UI", 10F);
            Name = "DiplomForm";
            Padding = new Padding(10);
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
