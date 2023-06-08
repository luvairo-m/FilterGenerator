namespace FilterGenerator.Filters
{
    partial class EmbossOptions
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
            bothRadio = new RadioButton();
            horizontalRadio = new RadioButton();
            button1 = new Button();
            verticalRadio = new RadioButton();
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
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки тиснения";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4950047F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.0594559F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4455471F));
            tableLayoutPanel1.Controls.Add(bothRadio, 0, 2);
            tableLayoutPanel1.Controls.Add(horizontalRadio, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 2);
            tableLayoutPanel1.Controls.Add(verticalRadio, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(478, 237);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // bothRadio
            // 
            bothRadio.AutoSize = true;
            bothRadio.Checked = true;
            tableLayoutPanel1.SetColumnSpan(bothRadio, 2);
            bothRadio.Dock = DockStyle.Fill;
            bothRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bothRadio.Location = new Point(15, 159);
            bothRadio.Margin = new Padding(15, 3, 3, 3);
            bothRadio.Name = "bothRadio";
            bothRadio.Size = new Size(390, 75);
            bothRadio.TabIndex = 11;
            bothRadio.TabStop = true;
            bothRadio.Text = "Оба направления";
            bothRadio.UseVisualStyleBackColor = true;
            // 
            // horizontalRadio
            // 
            horizontalRadio.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(horizontalRadio, 2);
            horizontalRadio.Dock = DockStyle.Fill;
            horizontalRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            horizontalRadio.Location = new Point(15, 81);
            horizontalRadio.Margin = new Padding(15, 3, 3, 3);
            horizontalRadio.Name = "horizontalRadio";
            horizontalRadio.Size = new Size(390, 72);
            horizontalRadio.TabIndex = 10;
            horizontalRadio.Text = "Горизонтальное направление";
            horizontalRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(411, 159);
            button1.Name = "button1";
            button1.Size = new Size(64, 75);
            button1.TabIndex = 8;
            button1.Text = "Отменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BackButtonClicked;
            // 
            // verticalRadio
            // 
            verticalRadio.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(verticalRadio, 2);
            verticalRadio.Dock = DockStyle.Fill;
            verticalRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            verticalRadio.Location = new Point(15, 3);
            verticalRadio.Margin = new Padding(15, 3, 3, 3);
            verticalRadio.Name = "verticalRadio";
            verticalRadio.Size = new Size(390, 72);
            verticalRadio.TabIndex = 9;
            verticalRadio.Text = "Вертикальное направление";
            verticalRadio.UseVisualStyleBackColor = true;
            // 
            // EmbossOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(groupBox1);
            Name = "EmbossOptions";
            Text = "EmbossOptions";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private RadioButton bothRadio;
        private RadioButton horizontalRadio;
        private RadioButton verticalRadio;
    }
}