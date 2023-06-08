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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
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
            panel1 = new Panel();
            progressBar = new ProgressBar();
            pictureBox = new PictureBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
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
            label1.Text = "Выберите фильтр:";
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
            comboBox1.Items.AddRange(new object[] { "Яркость", "Размытие", "Контрастность", "Оттенки серого", "Инверсия цветов", "Прозрачность", "Повышение качества" });
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
            button2.Text = "Применить";
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
            fileToolStripMenuItem.Image = Properties.Resources.file_operations_image;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(75, 25);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // openNewToolStripMenuItem
            // 
            openNewToolStripMenuItem.Image = Properties.Resources.open_image;
            openNewToolStripMenuItem.Name = "openNewToolStripMenuItem";
            openNewToolStripMenuItem.Size = new Size(208, 26);
            openNewToolStripMenuItem.Text = "Открыть";
            openNewToolStripMenuItem.Click += OpenMenuItemClicked;
            // 
            // saveCurrentToolStripMenuItem
            // 
            saveCurrentToolStripMenuItem.Image = Properties.Resources.save_as_image;
            saveCurrentToolStripMenuItem.Name = "saveCurrentToolStripMenuItem";
            saveCurrentToolStripMenuItem.Size = new Size(208, 26);
            saveCurrentToolStripMenuItem.Text = "Сохранить";
            saveCurrentToolStripMenuItem.Click += SaveMenuItemClicked;
            // 
            // clearSpaceToolStripMenuItem
            // 
            clearSpaceToolStripMenuItem.Image = Properties.Resources.clear_image;
            clearSpaceToolStripMenuItem.Name = "clearSpaceToolStripMenuItem";
            clearSpaceToolStripMenuItem.Size = new Size(208, 26);
            clearSpaceToolStripMenuItem.Text = "Очистить область";
            clearSpaceToolStripMenuItem.Click += ClearMenuItemClicked;
            // 
            // sizeModToolStripMenuItem
            // 
            sizeModToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stretchToolStripMenuItem, zoomToolStripMenuItem });
            sizeModToolStripMenuItem.Image = Properties.Resources.size_image;
            sizeModToolStripMenuItem.Name = "sizeModToolStripMenuItem";
            sizeModToolStripMenuItem.Size = new Size(173, 25);
            sizeModToolStripMenuItem.Text = "Машстабирование";
            // 
            // stretchToolStripMenuItem
            // 
            stretchToolStripMenuItem.Image = Properties.Resources.fit_image;
            stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            stretchToolStripMenuItem.Size = new Size(215, 26);
            stretchToolStripMenuItem.Text = "Вытягивание";
            stretchToolStripMenuItem.Click += StretchMenuItemClicked;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Image = Properties.Resources.zoom_image;
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(215, 26);
            zoomToolStripMenuItem.Text = "Пропорционально";
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
            label2.Location = new Point(264, 160);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(430, 18);
            label2.TabIndex = 0;
            label2.Text = "*Важно: откройте изображение перед тем, как применять фильтр";
            // 
            // optionsPanel
            // 
            optionsPanel.Dock = DockStyle.Fill;
            optionsPanel.Location = new Point(6, 6);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(685, 148);
            optionsPanel.TabIndex = 1;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(pictureBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(18, 55);
            panel1.Margin = new Padding(15);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 454);
            panel1.TabIndex = 4;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(282, 195);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(370, 39);
            progressBar.Step = 1;
            progressBar.TabIndex = 2;
            progressBar.Visible = false;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Properties.Resources.alpha;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(20);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(948, 454);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Tag = "default";
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter Generator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
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
        private Panel panel1;
        private PictureBox pictureBox;
        private ProgressBar progressBar;
    }
}