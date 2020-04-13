namespace Working_Prototype
{
    partial class Sales_Report
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
            this.SalesReportLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalesReportLabel
            // 
            this.SalesReportLabel.AutoSize = true;
            this.SalesReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReportLabel.Location = new System.Drawing.Point(401, 33);
            this.SalesReportLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SalesReportLabel.Name = "SalesReportLabel";
            this.SalesReportLabel.Size = new System.Drawing.Size(415, 73);
            this.SalesReportLabel.TabIndex = 1;
            this.SalesReportLabel.Text = "Sales Report";
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1216, 819);
            this.Controls.Add(this.SalesReportLabel);
            this.Name = "Sales_Report";
            this.Text = "Sales_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalesReportLabel;
    }
}