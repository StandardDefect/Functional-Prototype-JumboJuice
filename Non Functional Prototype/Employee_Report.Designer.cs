namespace Working_Prototype
{
    partial class Employee_Report
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
            this.EmployeeProfilesLabel = new System.Windows.Forms.Label();
            this.EmployeeProfileDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProfileDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeProfilesLabel
            // 
            this.EmployeeProfilesLabel.AutoSize = true;
            this.EmployeeProfilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeProfilesLabel.Location = new System.Drawing.Point(236, 47);
            this.EmployeeProfilesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EmployeeProfilesLabel.Name = "EmployeeProfilesLabel";
            this.EmployeeProfilesLabel.Size = new System.Drawing.Size(727, 73);
            this.EmployeeProfilesLabel.TabIndex = 2;
            this.EmployeeProfilesLabel.Text = "View Employee Profiles";
            // 
            // EmployeeProfileDataGrid
            // 
            this.EmployeeProfileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeProfileDataGrid.Location = new System.Drawing.Point(105, 158);
            this.EmployeeProfileDataGrid.Name = "EmployeeProfileDataGrid";
            this.EmployeeProfileDataGrid.RowTemplate.Height = 33;
            this.EmployeeProfileDataGrid.Size = new System.Drawing.Size(994, 500);
            this.EmployeeProfileDataGrid.TabIndex = 3;
            // 
            // Employee_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1216, 819);
            this.Controls.Add(this.EmployeeProfileDataGrid);
            this.Controls.Add(this.EmployeeProfilesLabel);
            this.Name = "Employee_Report";
            this.Text = "Employee_Report";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProfileDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeProfilesLabel;
        private System.Windows.Forms.DataGridView EmployeeProfileDataGrid;
    }
}