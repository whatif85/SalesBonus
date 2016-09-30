namespace SalesBonus
{
    partial class PrintMessageForm
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
            this.PrintMessageLabel = new System.Windows.Forms.Label();
            this.OKPrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrintMessageLabel
            // 
            this.PrintMessageLabel.AutoSize = true;
            this.PrintMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintMessageLabel.Location = new System.Drawing.Point(34, 35);
            this.PrintMessageLabel.Name = "PrintMessageLabel";
            this.PrintMessageLabel.Size = new System.Drawing.Size(338, 25);
            this.PrintMessageLabel.TabIndex = 0;
            this.PrintMessageLabel.Text = "Your Form Is Being Sent to the Printer";
            this.PrintMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKPrintButton
            // 
            this.OKPrintButton.Location = new System.Drawing.Point(147, 81);
            this.OKPrintButton.Name = "OKPrintButton";
            this.OKPrintButton.Size = new System.Drawing.Size(111, 44);
            this.OKPrintButton.TabIndex = 1;
            this.OKPrintButton.Text = "Thank you!";
            this.OKPrintButton.UseVisualStyleBackColor = true;
            this.OKPrintButton.Click += new System.EventHandler(this.OKPrintButton_Click);
            // 
            // PrintMessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(404, 147);
            this.Controls.Add(this.OKPrintButton);
            this.Controls.Add(this.PrintMessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print in Progress...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrintMessageLabel;
        private System.Windows.Forms.Button OKPrintButton;
    }
}