namespace Working_Prototype
{
    partial class Customer_Profiles
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
            this.CustomerProfilesLabel = new System.Windows.Forms.Label();
            this.CustomerProfilesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerProfilesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerProfilesLabel
            // 
            this.CustomerProfilesLabel.AutoSize = true;
            this.CustomerProfilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerProfilesLabel.Location = new System.Drawing.Point(306, 56);
            this.CustomerProfilesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustomerProfilesLabel.Name = "CustomerProfilesLabel";
            this.CustomerProfilesLabel.Size = new System.Drawing.Size(594, 61);
            this.CustomerProfilesLabel.TabIndex = 3;
            this.CustomerProfilesLabel.Text = "View Customer Profiles";
            // 
            // CustomerProfilesDataGrid
            // 
            this.CustomerProfilesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerProfilesDataGrid.Location = new System.Drawing.Point(103, 144);
            this.CustomerProfilesDataGrid.Name = "CustomerProfilesDataGrid";
            this.CustomerProfilesDataGrid.RowTemplate.Height = 33;
            this.CustomerProfilesDataGrid.Size = new System.Drawing.Size(994, 500);
            this.CustomerProfilesDataGrid.TabIndex = 4;
            // 
            // Customer_Profiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1216, 819);
            this.Controls.Add(this.CustomerProfilesDataGrid);
            this.Controls.Add(this.CustomerProfilesLabel);
            this.Name = "Customer_Profiles";
            this.Text = "Customer_Profiles";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerProfilesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerProfilesLabel;
        private System.Windows.Forms.DataGridView CustomerProfilesDataGrid;
    }
}