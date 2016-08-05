namespace COMP123_S2016_Assignment_6
{
    partial class BMIForm
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
            this.UnitsGroupBox = new System.Windows.Forms.GroupBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightWeightGroupBox = new System.Windows.Forms.GroupBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ObeseLabel = new System.Windows.Forms.Label();
            this.OverweightLabel = new System.Windows.Forms.Label();
            this.NormalLabel = new System.Windows.Forms.Label();
            this.UnderweightLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultBMILabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultInfoTextBox = new System.Windows.Forms.TextBox();
            this.UnitsGroupBox.SuspendLayout();
            this.HeightWeightGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitsGroupBox
            // 
            this.UnitsGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UnitsGroupBox.Controls.Add(this.MetricRadioButton);
            this.UnitsGroupBox.Controls.Add(this.ImperialRadioButton);
            this.UnitsGroupBox.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsGroupBox.Location = new System.Drawing.Point(19, 22);
            this.UnitsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnitsGroupBox.Name = "UnitsGroupBox";
            this.UnitsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.UnitsGroupBox.Size = new System.Drawing.Size(184, 124);
            this.UnitsGroupBox.TabIndex = 0;
            this.UnitsGroupBox.TabStop = false;
            this.UnitsGroupBox.Text = "UNITS";
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(11, 79);
            this.MetricRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(97, 25);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(11, 37);
            this.ImperialRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(119, 25);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(10, 101);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(76, 21);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "HEIGHT";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(10, 149);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(76, 21);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "WEIGHT";
            // 
            // HeightWeightGroupBox
            // 
            this.HeightWeightGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeightWeightGroupBox.Controls.Add(this.WeightTextBox);
            this.HeightWeightGroupBox.Controls.Add(this.HeightTextBox);
            this.HeightWeightGroupBox.Controls.Add(this.HeightLabel);
            this.HeightWeightGroupBox.Controls.Add(this.WeightLabel);
            this.HeightWeightGroupBox.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightWeightGroupBox.Location = new System.Drawing.Point(19, 163);
            this.HeightWeightGroupBox.Name = "HeightWeightGroupBox";
            this.HeightWeightGroupBox.Size = new System.Drawing.Size(184, 189);
            this.HeightWeightGroupBox.TabIndex = 3;
            this.HeightWeightGroupBox.TabStop = false;
            this.HeightWeightGroupBox.Text = "Enter your height(m or inch) and weight(kg or lb)";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(93, 149);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(85, 28);
            this.WeightTextBox.TabIndex = 4;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(92, 94);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(86, 28);
            this.HeightTextBox.TabIndex = 3;
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InfoGroupBox.Controls.Add(this.ObeseLabel);
            this.InfoGroupBox.Controls.Add(this.OverweightLabel);
            this.InfoGroupBox.Controls.Add(this.NormalLabel);
            this.InfoGroupBox.Controls.Add(this.UnderweightLabel);
            this.InfoGroupBox.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoGroupBox.Location = new System.Drawing.Point(219, 22);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(236, 124);
            this.InfoGroupBox.TabIndex = 4;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // ObeseLabel
            // 
            this.ObeseLabel.AutoSize = true;
            this.ObeseLabel.Location = new System.Drawing.Point(7, 91);
            this.ObeseLabel.Name = "ObeseLabel";
            this.ObeseLabel.Size = new System.Drawing.Size(274, 21);
            this.ObeseLabel.TabIndex = 3;
            this.ObeseLabel.Text = "Obese:             >= 30";
            // 
            // OverweightLabel
            // 
            this.OverweightLabel.AutoSize = true;
            this.OverweightLabel.Location = new System.Drawing.Point(6, 70);
            this.OverweightLabel.Name = "OverweightLabel";
            this.OverweightLabel.Size = new System.Drawing.Size(285, 21);
            this.OverweightLabel.TabIndex = 2;
            this.OverweightLabel.Text = "Overweight:    25 - 29.9 ";
            // 
            // NormalLabel
            // 
            this.NormalLabel.AutoSize = true;
            this.NormalLabel.Location = new System.Drawing.Point(6, 49);
            this.NormalLabel.Name = "NormalLabel";
            this.NormalLabel.Size = new System.Drawing.Size(274, 21);
            this.NormalLabel.TabIndex = 1;
            this.NormalLabel.Text = "Normal:      18.5 - 24.9";
            // 
            // UnderweightLabel
            // 
            this.UnderweightLabel.AutoSize = true;
            this.UnderweightLabel.Location = new System.Drawing.Point(7, 28);
            this.UnderweightLabel.Name = "UnderweightLabel";
            this.UnderweightLabel.Size = new System.Drawing.Size(274, 21);
            this.UnderweightLabel.TabIndex = 0;
            this.UnderweightLabel.Text = "Underweight:     <= 18.5";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(229, 306);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(106, 36);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(358, 306);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 36);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ResultBMILabel
            // 
            this.ResultBMILabel.AutoSize = true;
            this.ResultBMILabel.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBMILabel.Location = new System.Drawing.Point(225, 178);
            this.ResultBMILabel.Name = "ResultBMILabel";
            this.ResultBMILabel.Size = new System.Drawing.Size(138, 27);
            this.ResultBMILabel.TabIndex = 7;
            this.ResultBMILabel.Text = "Your BMI:";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.Turquoise;
            this.ResultTextBox.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(230, 208);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(225, 38);
            this.ResultTextBox.TabIndex = 8;
            // 
            // ResultInfoTextBox
            // 
            this.ResultInfoTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ResultInfoTextBox.Enabled = false;
            this.ResultInfoTextBox.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultInfoTextBox.Location = new System.Drawing.Point(229, 249);
            this.ResultInfoTextBox.Name = "ResultInfoTextBox";
            this.ResultInfoTextBox.Size = new System.Drawing.Size(226, 34);
            this.ResultInfoTextBox.TabIndex = 9;
            // 
            // BMIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(477, 517);
            this.Controls.Add(this.ResultInfoTextBox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultBMILabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.HeightWeightGroupBox);
            this.Controls.Add(this.UnitsGroupBox);
            this.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BMIForm";
            this.Text = "BMI Calculator";
            this.UnitsGroupBox.ResumeLayout(false);
            this.UnitsGroupBox.PerformLayout();
            this.HeightWeightGroupBox.ResumeLayout(false);
            this.HeightWeightGroupBox.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UnitsGroupBox;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.GroupBox HeightWeightGroupBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Label ObeseLabel;
        private System.Windows.Forms.Label OverweightLabel;
        private System.Windows.Forms.Label NormalLabel;
        private System.Windows.Forms.Label UnderweightLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ResultBMILabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox ResultInfoTextBox;
    }
}

