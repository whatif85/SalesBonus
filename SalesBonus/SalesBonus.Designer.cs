namespace SalesBonus
{
    partial class SalesBonusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonusForm));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.ItalianRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesLabel = new System.Windows.Forms.Label();
            this.TotalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SelectLanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.SpanishRadioButton = new System.Windows.Forms.RadioButton();
            this.GermanRadioButton = new System.Windows.Forms.RadioButton();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SelectLanguageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(13, 13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 200);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(62, 30);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(75, 21);
            this.EnglishRadioButton.TabIndex = 1;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // ItalianRadioButton
            // 
            this.ItalianRadioButton.AutoSize = true;
            this.ItalianRadioButton.Location = new System.Drawing.Point(62, 84);
            this.ItalianRadioButton.Name = "ItalianRadioButton";
            this.ItalianRadioButton.Size = new System.Drawing.Size(74, 21);
            this.ItalianRadioButton.TabIndex = 3;
            this.ItalianRadioButton.TabStop = true;
            this.ItalianRadioButton.Text = "Italiano";
            this.ItalianRadioButton.UseVisualStyleBackColor = true;
            this.ItalianRadioButton.CheckedChanged += new System.EventHandler(this.ItalianRadioButton_CheckedChanged);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(27, 242);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeNameLabel.Size = new System.Drawing.Size(121, 17);
            this.EmployeeNameLabel.TabIndex = 13;
            this.EmployeeNameLabel.Text = "Employee\'s Name";
            this.EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(204, 237);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(252, 22);
            this.EmployeeNameTextBox.TabIndex = 4;
            this.EmployeeNameTextBox.TabStop = false;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(204, 267);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(252, 22);
            this.EmployeeIDTextBox.TabIndex = 5;
            this.EmployeeIDTextBox.TabStop = false;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(27, 272);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeIDLabel.Size = new System.Drawing.Size(87, 17);
            this.EmployeeIDLabel.TabIndex = 5;
            this.EmployeeIDLabel.Text = "Employee ID";
            this.EmployeeIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(27, 314);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HoursWorkedLabel.Size = new System.Drawing.Size(99, 17);
            this.HoursWorkedLabel.TabIndex = 6;
            this.HoursWorkedLabel.Text = "Hours Worked";
            this.HoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(204, 309);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(252, 22);
            this.HoursWorkedTextBox.TabIndex = 6;
            this.HoursWorkedTextBox.TabStop = false;
            // 
            // TotalMonthlySalesLabel
            // 
            this.TotalMonthlySalesLabel.AutoSize = true;
            this.TotalMonthlySalesLabel.Location = new System.Drawing.Point(27, 342);
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            this.TotalMonthlySalesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalMonthlySalesLabel.Size = new System.Drawing.Size(132, 17);
            this.TotalMonthlySalesLabel.TabIndex = 6;
            this.TotalMonthlySalesLabel.Text = "Total Monthly Sales";
            this.TotalMonthlySalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalMonthlySalesLabel.Click += new System.EventHandler(this.HoursWorkedLabel_Click);
            // 
            // TotalMonthlySalesTextBox
            // 
            this.TotalMonthlySalesTextBox.Location = new System.Drawing.Point(204, 337);
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            this.TotalMonthlySalesTextBox.Size = new System.Drawing.Size(252, 22);
            this.TotalMonthlySalesTextBox.TabIndex = 7;
            this.TotalMonthlySalesTextBox.TabStop = false;
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(204, 365);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(252, 22);
            this.SalesBonusTextBox.TabIndex = 6;
            this.SalesBonusTextBox.TabStop = false;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(27, 370);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SalesBonusLabel.Size = new System.Drawing.Size(87, 17);
            this.SalesBonusLabel.TabIndex = 8;
            this.SalesBonusLabel.Text = "Sales Bonus";
            this.SalesBonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(141, 444);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(92, 37);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(31, 444);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(92, 37);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(254, 444);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(92, 37);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(364, 444);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 37);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SelectLanguageGroupBox
            // 
            this.SelectLanguageGroupBox.Controls.Add(this.SpanishRadioButton);
            this.SelectLanguageGroupBox.Controls.Add(this.GermanRadioButton);
            this.SelectLanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.SelectLanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.SelectLanguageGroupBox.Controls.Add(this.ItalianRadioButton);
            this.SelectLanguageGroupBox.Location = new System.Drawing.Point(243, 24);
            this.SelectLanguageGroupBox.Name = "SelectLanguageGroupBox";
            this.SelectLanguageGroupBox.Size = new System.Drawing.Size(213, 189);
            this.SelectLanguageGroupBox.TabIndex = 1;
            this.SelectLanguageGroupBox.TabStop = false;
            this.SelectLanguageGroupBox.Text = "Select Language";
            // 
            // SpanishRadioButton
            // 
            this.SpanishRadioButton.AutoSize = true;
            this.SpanishRadioButton.Location = new System.Drawing.Point(62, 138);
            this.SpanishRadioButton.Name = "SpanishRadioButton";
            this.SpanishRadioButton.Size = new System.Drawing.Size(80, 21);
            this.SpanishRadioButton.TabIndex = 2;
            this.SpanishRadioButton.TabStop = true;
            this.SpanishRadioButton.Text = "Español";
            this.SpanishRadioButton.UseVisualStyleBackColor = true;
            this.SpanishRadioButton.CheckedChanged += new System.EventHandler(this.SpanishRadioButton_CheckedChanged);
            // 
            // GermanRadioButton
            // 
            this.GermanRadioButton.AutoSize = true;
            this.GermanRadioButton.Location = new System.Drawing.Point(62, 111);
            this.GermanRadioButton.Name = "GermanRadioButton";
            this.GermanRadioButton.Size = new System.Drawing.Size(81, 21);
            this.GermanRadioButton.TabIndex = 2;
            this.GermanRadioButton.TabStop = true;
            this.GermanRadioButton.Text = "Deutsch";
            this.GermanRadioButton.UseVisualStyleBackColor = true;
            this.GermanRadioButton.CheckedChanged += new System.EventHandler(this.GermanRadioButton_CheckedChanged);
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(62, 57);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(83, 21);
            this.FrenchRadioButton.TabIndex = 2;
            this.FrenchRadioButton.TabStop = true;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // SalesBonusForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(482, 513);
            this.Controls.Add(this.SelectLanguageGroupBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalMonthlySalesTextBox);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.TotalMonthlySalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesBonusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.SelectLanguageGroupBox.ResumeLayout(false);
            this.SelectLanguageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton ItalianRadioButton;
        private System.Windows.Forms.RadioButton GermanRadioButton;
        private System.Windows.Forms.RadioButton SpanishRadioButton;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.Label TotalMonthlySalesLabel;
        private System.Windows.Forms.TextBox TotalMonthlySalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox SelectLanguageGroupBox;
    }
}

