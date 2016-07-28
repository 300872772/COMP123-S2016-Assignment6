namespace BMI_CALCULATOR
{
    partial class BMICalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculator));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.MyWightLabel = new System.Windows.Forms.Label();
            this.HeightInputTextBox = new System.Windows.Forms.TextBox();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.WeightInputTextBox = new System.Windows.Forms.TextBox();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.BMIOutputTextBox = new System.Windows.Forms.TextBox();
            this.BMIScaleLabel = new System.Windows.Forms.Label();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.05611F));
            this.tableLayoutPanel1.Controls.Add(this.ResultLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.MyWightLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.HeightInputTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MyHeightLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.WeightInputTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BMIResultTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BMIOutputTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.BMIScaleLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ResultLabel.Location = new System.Drawing.Point(3, 308);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ResultLabel.Size = new System.Drawing.Size(62, 54);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Result";
            // 
            // MyWightLabel
            // 
            this.MyWightLabel.AutoSize = true;
            this.MyWightLabel.BackColor = System.Drawing.Color.Transparent;
            this.MyWightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWightLabel.ForeColor = System.Drawing.Color.Aqua;
            this.MyWightLabel.Location = new System.Drawing.Point(3, 160);
            this.MyWightLabel.Name = "MyWightLabel";
            this.MyWightLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.MyWightLabel.Size = new System.Drawing.Size(104, 56);
            this.MyWightLabel.TabIndex = 6;
            this.MyWightLabel.Text = "My Weight kg";
            // 
            // HeightInputTextBox
            // 
            this.HeightInputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HeightInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightInputTextBox.Location = new System.Drawing.Point(120, 88);
            this.HeightInputTextBox.Name = "HeightInputTextBox";
            this.HeightInputTextBox.Size = new System.Drawing.Size(180, 31);
            this.HeightInputTextBox.TabIndex = 0;
            this.HeightInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightInputTextBox_KeyPress);
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.ForeColor = System.Drawing.Color.Aqua;
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 85);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.MyHeightLabel.Size = new System.Drawing.Size(100, 56);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height cm";
            // 
            // WeightInputTextBox
            // 
            this.WeightInputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WeightInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightInputTextBox.Location = new System.Drawing.Point(120, 163);
            this.WeightInputTextBox.Name = "WeightInputTextBox";
            this.WeightInputTextBox.Size = new System.Drawing.Size(180, 31);
            this.WeightInputTextBox.TabIndex = 1;
            this.WeightInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightInputTextBox_KeyPress);
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BMIResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMIResultTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BMIResultTextBox.Location = new System.Drawing.Point(120, 311);
            this.BMIResultTextBox.Multiline = true;
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.ReadOnly = true;
            this.BMIResultTextBox.Size = new System.Drawing.Size(180, 91);
            this.BMIResultTextBox.TabIndex = 7;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 43);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(94, 28);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = false;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // BMIOutputTextBox
            // 
            this.BMIOutputTextBox.BackColor = System.Drawing.Color.Gray;
            this.BMIOutputTextBox.Enabled = false;
            this.BMIOutputTextBox.ForeColor = System.Drawing.Color.Lime;
            this.BMIOutputTextBox.Location = new System.Drawing.Point(120, 263);
            this.BMIOutputTextBox.Name = "BMIOutputTextBox";
            this.BMIOutputTextBox.Size = new System.Drawing.Size(180, 38);
            this.BMIOutputTextBox.TabIndex = 10;
            // 
            // BMIScaleLabel
            // 
            this.BMIScaleLabel.AutoSize = true;
            this.BMIScaleLabel.BackColor = System.Drawing.Color.Transparent;
            this.BMIScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIScaleLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.BMIScaleLabel.Location = new System.Drawing.Point(3, 260);
            this.BMIScaleLabel.Name = "BMIScaleLabel";
            this.BMIScaleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.BMIScaleLabel.Size = new System.Drawing.Size(94, 32);
            this.BMIScaleLabel.TabIndex = 11;
            this.BMIScaleLabel.Text = "BMI Scale";
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MetricRadioButton.Location = new System.Drawing.Point(3, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.MetricRadioButton.Size = new System.Drawing.Size(79, 34);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = false;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIButton.Location = new System.Drawing.Point(120, 222);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(180, 35);
            this.CalculateBMIButton.TabIndex = 2;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox HeightInputTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Label MyWightLabel;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox WeightInputTextBox;
        private System.Windows.Forms.TextBox BMIOutputTextBox;
        private System.Windows.Forms.Label BMIScaleLabel;
    }
}

