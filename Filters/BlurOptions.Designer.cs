﻿namespace FilterGenerator.Filters
{
    partial class BlurOptions
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
            highBlurRadio = new RadioButton();
            middleBlurRadio = new RadioButton();
            button1 = new Button();
            lowBlurRadio = new RadioButton();
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
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки размытия";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4950047F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.0594559F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4455471F));
            tableLayoutPanel1.Controls.Add(highBlurRadio, 0, 2);
            tableLayoutPanel1.Controls.Add(middleBlurRadio, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 2);
            tableLayoutPanel1.Controls.Add(lowBlurRadio, 0, 0);
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
            // highBlurRadio
            // 
            highBlurRadio.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(highBlurRadio, 2);
            highBlurRadio.Dock = DockStyle.Fill;
            highBlurRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            highBlurRadio.Location = new Point(15, 159);
            highBlurRadio.Margin = new Padding(15, 3, 3, 3);
            highBlurRadio.Name = "highBlurRadio";
            highBlurRadio.Size = new Size(390, 75);
            highBlurRadio.TabIndex = 11;
            highBlurRadio.Text = "Сильное размытие";
            highBlurRadio.UseVisualStyleBackColor = true;
            // 
            // middleBlurRadio
            // 
            middleBlurRadio.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(middleBlurRadio, 2);
            middleBlurRadio.Dock = DockStyle.Fill;
            middleBlurRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            middleBlurRadio.Location = new Point(15, 81);
            middleBlurRadio.Margin = new Padding(15, 3, 3, 3);
            middleBlurRadio.Name = "middleBlurRadio";
            middleBlurRadio.Size = new Size(390, 72);
            middleBlurRadio.TabIndex = 10;
            middleBlurRadio.Text = "Среднее размытие";
            middleBlurRadio.UseVisualStyleBackColor = true;
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
            // lowBlurRadio
            // 
            lowBlurRadio.AutoSize = true;
            lowBlurRadio.Checked = true;
            tableLayoutPanel1.SetColumnSpan(lowBlurRadio, 2);
            lowBlurRadio.Dock = DockStyle.Fill;
            lowBlurRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lowBlurRadio.Location = new Point(15, 3);
            lowBlurRadio.Margin = new Padding(15, 3, 3, 3);
            lowBlurRadio.Name = "lowBlurRadio";
            lowBlurRadio.Size = new Size(390, 72);
            lowBlurRadio.TabIndex = 9;
            lowBlurRadio.TabStop = true;
            lowBlurRadio.Text = "Слабое размытие";
            lowBlurRadio.UseVisualStyleBackColor = true;
            // 
            // BlurOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(groupBox1);
            Name = "BlurOptions";
            Text = "BlurOptions";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton highBlurRadio;
        private RadioButton middleBlurRadio;
        private Button button1;
        private RadioButton lowBlurRadio;
    }
}