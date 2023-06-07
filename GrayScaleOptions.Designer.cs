namespace FilterGenerator
{
    partial class GrayScaleOptions
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            redWeight = new TextBox();
            greenWeight = new TextBox();
            blueWeight = new TextBox();
            redErrorProvider = new ErrorProvider(components);
            greenErrorProvider = new ErrorProvider(components);
            blueErrorProvider = new ErrorProvider(components);
            redToolTip = new ToolTip(components);
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)redErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueErrorProvider).BeginInit();
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
            groupBox1.Text = "Настройки оттенков серого";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0965652F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.9034348F));
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(redWeight, 1, 0);
            tableLayoutPanel1.Controls.Add(greenWeight, 1, 1);
            tableLayoutPanel1.Controls.Add(blueWeight, 1, 2);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 156);
            label5.Margin = new Padding(15, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 81);
            label5.TabIndex = 4;
            label5.Text = "Вес синего:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 78);
            label3.Margin = new Padding(15, 0, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 78);
            label3.TabIndex = 2;
            label3.Text = "Вес зелёного:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 0);
            label1.Margin = new Padding(15, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 78);
            label1.TabIndex = 0;
            label1.Text = "Вес красного:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // redWeight
            // 
            redWeight.Dock = DockStyle.Left;
            redWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            redWeight.Location = new Point(99, 8);
            redWeight.Margin = new Padding(3, 8, 3, 3);
            redWeight.MaxLength = 10;
            redWeight.Name = "redWeight";
            redWeight.Size = new Size(100, 29);
            redWeight.TabIndex = 5;
            redWeight.Text = "0,2126";
            redWeight.TextAlign = HorizontalAlignment.Center;
            redToolTip.SetToolTip(redWeight, "default value: 0,2126");
            redWeight.TextChanged += RedWeightTextBoxChanged;
            // 
            // greenWeight
            // 
            greenWeight.Dock = DockStyle.Left;
            greenWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            greenWeight.Location = new Point(99, 86);
            greenWeight.Margin = new Padding(3, 8, 3, 3);
            greenWeight.MaxLength = 10;
            greenWeight.Name = "greenWeight";
            greenWeight.Size = new Size(100, 29);
            greenWeight.TabIndex = 6;
            greenWeight.Text = "0,7152";
            greenWeight.TextAlign = HorizontalAlignment.Center;
            redToolTip.SetToolTip(greenWeight, "default value: 0,7152");
            greenWeight.TextChanged += GreenWeightTextBoxChanged;
            // 
            // blueWeight
            // 
            blueWeight.BackColor = SystemColors.Window;
            blueWeight.Dock = DockStyle.Left;
            blueWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            blueWeight.Location = new Point(99, 164);
            blueWeight.Margin = new Padding(3, 8, 3, 3);
            blueWeight.MaxLength = 10;
            blueWeight.Name = "blueWeight";
            blueWeight.Size = new Size(100, 29);
            blueWeight.TabIndex = 7;
            blueWeight.Text = "0,0722";
            blueWeight.TextAlign = HorizontalAlignment.Center;
            redToolTip.SetToolTip(blueWeight, "default value: 0,0722");
            blueWeight.TextChanged += BlueWeightTextBoxChanged;
            // 
            // redErrorProvider
            // 
            redErrorProvider.BlinkRate = 800;
            redErrorProvider.ContainerControl = this;
            // 
            // greenErrorProvider
            // 
            greenErrorProvider.BlinkRate = 800;
            greenErrorProvider.ContainerControl = this;
            // 
            // blueErrorProvider
            // 
            blueErrorProvider.BlinkRate = 800;
            blueErrorProvider.ContainerControl = this;
            // 
            // redToolTip
            // 
            redToolTip.AutomaticDelay = 100;
            // 
            // GrayScaleOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(groupBox1);
            Name = "GrayScaleOptions";
            Text = "GrayScaleOptions";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)redErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox redWeight;
        private TextBox greenWeight;
        private TextBox blueWeight;
        private ErrorProvider redErrorProvider;
        private ErrorProvider greenErrorProvider;
        private ErrorProvider blueErrorProvider;
        private ToolTip redToolTip;
    }
}