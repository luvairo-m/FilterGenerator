namespace FilterGenerator
{
    partial class NegativeOptions
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            blueCheck = new CheckBox();
            redCheck = new CheckBox();
            greenCheck = new CheckBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 261);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки инверсии цветов";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(blueCheck, 0, 2);
            tableLayoutPanel1.Controls.Add(redCheck, 0, 0);
            tableLayoutPanel1.Controls.Add(greenCheck, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(478, 237);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // blueCheck
            // 
            blueCheck.AutoSize = true;
            blueCheck.Checked = true;
            blueCheck.CheckState = CheckState.Checked;
            blueCheck.Dock = DockStyle.Fill;
            blueCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            blueCheck.Location = new Point(15, 159);
            blueCheck.Margin = new Padding(15, 3, 3, 3);
            blueCheck.Name = "blueCheck";
            blueCheck.Size = new Size(460, 75);
            blueCheck.TabIndex = 6;
            blueCheck.Text = "Инвертировать синий";
            blueCheck.UseVisualStyleBackColor = true;
            // 
            // redCheck
            // 
            redCheck.AutoSize = true;
            redCheck.Checked = true;
            redCheck.CheckState = CheckState.Checked;
            redCheck.Dock = DockStyle.Fill;
            redCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            redCheck.Location = new Point(15, 3);
            redCheck.Margin = new Padding(15, 3, 3, 3);
            redCheck.Name = "redCheck";
            redCheck.Size = new Size(460, 72);
            redCheck.TabIndex = 5;
            redCheck.Text = "Инвертировать красный";
            redCheck.UseVisualStyleBackColor = true;
            // 
            // greenCheck
            // 
            greenCheck.AutoSize = true;
            greenCheck.Checked = true;
            greenCheck.CheckState = CheckState.Checked;
            greenCheck.Dock = DockStyle.Fill;
            greenCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            greenCheck.Location = new Point(15, 81);
            greenCheck.Margin = new Padding(15, 3, 3, 3);
            greenCheck.Name = "greenCheck";
            greenCheck.Size = new Size(460, 72);
            greenCheck.TabIndex = 7;
            greenCheck.Text = "Инвертировать зелёный";
            greenCheck.UseVisualStyleBackColor = true;
            // 
            // NegativeOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(groupBox1);
            Name = "NegativeOptions";
            Text = "NegativeOptions";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox redCheck;
        private CheckBox blueCheck;
        private CheckBox greenCheck;
    }
}