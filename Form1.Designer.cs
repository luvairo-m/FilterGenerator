namespace FilterGenerator
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openNewToolStripMenuItem = new ToolStripMenuItem();
            saveCurrentToolStripMenuItem = new ToolStripMenuItem();
            clearSpaceToolStripMenuItem = new ToolStripMenuItem();
            sizeModToolStripMenuItem = new ToolStripMenuItem();
            stretchToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            optionsPanel = new Panel();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel1.Controls.Add(pictureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.91172647F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.3367157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7515526F));
            tableLayoutPanel1.Size = new Size(984, 711);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(pictureBox, 2);
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Properties.Resources.alpha;
            pictureBox.Location = new Point(23, 60);
            pictureBox.Margin = new Padding(20);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(938, 444);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Tag = "default";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 530);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(272, 175);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(260, 55);
            label1.TabIndex = 0;
            label1.Text = "Select filter type:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 64);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(260, 105);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Brightness", "Blur", "Contrast", "GrayScale", "Saturation" });
            comboBox1.Location = new Point(5, 7);
            comboBox1.Margin = new Padding(5, 7, 5, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += ComboboxSelectionChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(3, 52);
            button2.Margin = new Padding(3, 0, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(254, 50);
            button2.TabIndex = 1;
            button2.Text = "Accept filter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AcceptFilterButtonClicked;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, sizeModToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(278, 29);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openNewToolStripMenuItem, saveCurrentToolStripMenuItem, clearSpaceToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(124, 25);
            fileToolStripMenuItem.Text = "File operations";
            // 
            // openNewToolStripMenuItem
            // 
            openNewToolStripMenuItem.Name = "openNewToolStripMenuItem";
            openNewToolStripMenuItem.Size = new Size(167, 26);
            openNewToolStripMenuItem.Text = "Open new";
            openNewToolStripMenuItem.Click += OpenMenuItemClicked;
            // 
            // saveCurrentToolStripMenuItem
            // 
            saveCurrentToolStripMenuItem.Name = "saveCurrentToolStripMenuItem";
            saveCurrentToolStripMenuItem.Size = new Size(167, 26);
            saveCurrentToolStripMenuItem.Text = "Save current";
            saveCurrentToolStripMenuItem.Click += SaveMenuItemClicked;
            // 
            // clearSpaceToolStripMenuItem
            // 
            clearSpaceToolStripMenuItem.Name = "clearSpaceToolStripMenuItem";
            clearSpaceToolStripMenuItem.Size = new Size(167, 26);
            clearSpaceToolStripMenuItem.Text = "Clear space";
            clearSpaceToolStripMenuItem.Click += ClearMenuItemClicked;
            // 
            // sizeModToolStripMenuItem
            // 
            sizeModToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stretchToolStripMenuItem, zoomToolStripMenuItem });
            sizeModToolStripMenuItem.Name = "sizeModToolStripMenuItem";
            sizeModToolStripMenuItem.Size = new Size(86, 25);
            sizeModToolStripMenuItem.Text = "Size mod";
            // 
            // stretchToolStripMenuItem
            // 
            stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            stretchToolStripMenuItem.Size = new Size(128, 26);
            stretchToolStripMenuItem.Text = "Stretch";
            stretchToolStripMenuItem.Click += StretchMenuItemClicked;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(128, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            zoomToolStripMenuItem.Click += ZoomMenuItemClicked;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label2, 0, 1);
            tableLayoutPanel4.Controls.Add(optionsPanel, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(284, 527);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 89.89502F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1049843F));
            tableLayoutPanel4.Size = new Size(697, 181);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(316, 160);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(378, 18);
            label2.TabIndex = 0;
            label2.Text = "*Note: don't forget to open image before accepting the filter";
            // 
            // optionsPanel
            // 
            optionsPanel.Dock = DockStyle.Fill;
            optionsPanel.Location = new Point(6, 6);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(685, 148);
            optionsPanel.TabIndex = 1;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 711);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter Generator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox comboBox1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openNewToolStripMenuItem;
        private ToolStripMenuItem saveCurrentToolStripMenuItem;
        private ToolStripMenuItem clearSpaceToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private Panel optionsPanel;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem sizeModToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem stretchToolStripMenuItem;
    }
}