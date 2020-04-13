namespace Working_Prototype
{
    partial class View_Cart
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
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.ShoppingCartLabel = new System.Windows.Forms.Label();
            this.CartSubtotalButton = new System.Windows.Forms.Label();
            this.CartTotalButton = new System.Windows.Forms.Label();
            this.CartSubtotalTextBox = new System.Windows.Forms.TextBox();
            this.CartTotalTextBox = new System.Windows.Forms.TextBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.ExpDateLabel = new System.Windows.Forms.Label();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.ExpDateTextBox = new System.Windows.Forms.TextBox();
            this.CVVTextBox = new System.Windows.Forms.TextBox();
            this.CartCheckoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 25;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(70, 167);
            this.ShoppingCartListBox.Margin = new System.Windows.Forms.Padding(6);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(460, 354);
            this.ShoppingCartListBox.TabIndex = 0;
            // 
            // ShoppingCartLabel
            // 
            this.ShoppingCartLabel.AutoSize = true;
            this.ShoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartLabel.Location = new System.Drawing.Point(102, 81);
            this.ShoppingCartLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ShoppingCartLabel.Name = "ShoppingCartLabel";
            this.ShoppingCartLabel.Size = new System.Drawing.Size(390, 61);
            this.ShoppingCartLabel.TabIndex = 1;
            this.ShoppingCartLabel.Text = "Shopping Cart:";
            // 
            // CartSubtotalButton
            // 
            this.CartSubtotalButton.AutoSize = true;
            this.CartSubtotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSubtotalButton.Location = new System.Drawing.Point(284, 550);
            this.CartSubtotalButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CartSubtotalButton.Name = "CartSubtotalButton";
            this.CartSubtotalButton.Size = new System.Drawing.Size(122, 30);
            this.CartSubtotalButton.TabIndex = 2;
            this.CartSubtotalButton.Text = "Subtotal:";
            // 
            // CartTotalButton
            // 
            this.CartTotalButton.AutoSize = true;
            this.CartTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartTotalButton.Location = new System.Drawing.Point(326, 600);
            this.CartTotalButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CartTotalButton.Name = "CartTotalButton";
            this.CartTotalButton.Size = new System.Drawing.Size(83, 30);
            this.CartTotalButton.TabIndex = 3;
            this.CartTotalButton.Text = "Total:";
            // 
            // CartSubtotalTextBox
            // 
            this.CartSubtotalTextBox.Location = new System.Drawing.Point(434, 548);
            this.CartSubtotalTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CartSubtotalTextBox.Name = "CartSubtotalTextBox";
            this.CartSubtotalTextBox.Size = new System.Drawing.Size(96, 31);
            this.CartSubtotalTextBox.TabIndex = 4;
            // 
            // CartTotalTextBox
            // 
            this.CartTotalTextBox.Location = new System.Drawing.Point(434, 598);
            this.CartTotalTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CartTotalTextBox.Name = "CartTotalTextBox";
            this.CartTotalTextBox.Size = new System.Drawing.Size(96, 31);
            this.CartTotalTextBox.TabIndex = 5;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.Location = new System.Drawing.Point(672, 197);
            this.PaymentMethodLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(458, 42);
            this.PaymentMethodLabel.TabIndex = 6;
            this.PaymentMethodLabel.Text = "Enter a payment method:";
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.AutoSize = true;
            this.CardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNameLabel.Location = new System.Drawing.Point(640, 279);
            this.CardNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(173, 26);
            this.CardNameLabel.TabIndex = 7;
            this.CardNameLabel.Text = "Name on Card:";
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberLabel.Location = new System.Drawing.Point(654, 335);
            this.CardNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(161, 26);
            this.CardNumberLabel.TabIndex = 8;
            this.CardNumberLabel.Text = "Card Number:";
            // 
            // ExpDateLabel
            // 
            this.ExpDateLabel.AutoSize = true;
            this.ExpDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDateLabel.Location = new System.Drawing.Point(691, 395);
            this.ExpDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ExpDateLabel.Name = "ExpDateLabel";
            this.ExpDateLabel.Size = new System.Drawing.Size(124, 26);
            this.ExpDateLabel.TabIndex = 9;
            this.ExpDateLabel.Text = "Exp. Date:";
            // 
            // CVVLabel
            // 
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVLabel.Location = new System.Drawing.Point(747, 452);
            this.CVVLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(68, 26);
            this.CVVLabel.TabIndex = 10;
            this.CVVLabel.Text = "CVV:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(834, 273);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(316, 31);
            this.textBox3.TabIndex = 11;
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Location = new System.Drawing.Point(834, 329);
            this.CardNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(316, 31);
            this.CardNumberTextBox.TabIndex = 12;
            // 
            // ExpDateTextBox
            // 
            this.ExpDateTextBox.Location = new System.Drawing.Point(834, 390);
            this.ExpDateTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ExpDateTextBox.Name = "ExpDateTextBox";
            this.ExpDateTextBox.Size = new System.Drawing.Size(144, 31);
            this.ExpDateTextBox.TabIndex = 13;
            // 
            // CVVTextBox
            // 
            this.CVVTextBox.Location = new System.Drawing.Point(834, 450);
            this.CVVTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CVVTextBox.Name = "CVVTextBox";
            this.CVVTextBox.Size = new System.Drawing.Size(102, 31);
            this.CVVTextBox.TabIndex = 14;
            // 
            // CartCheckoutButton
            // 
            this.CartCheckoutButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CartCheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartCheckoutButton.Location = new System.Drawing.Point(752, 526);
            this.CartCheckoutButton.Margin = new System.Windows.Forms.Padding(6);
            this.CartCheckoutButton.Name = "CartCheckoutButton";
            this.CartCheckoutButton.Size = new System.Drawing.Size(280, 71);
            this.CartCheckoutButton.TabIndex = 15;
            this.CartCheckoutButton.Text = "Checkout";
            this.CartCheckoutButton.UseVisualStyleBackColor = false;
            // 
            // View_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1216, 819);
            this.Controls.Add(this.CartCheckoutButton);
            this.Controls.Add(this.CVVTextBox);
            this.Controls.Add(this.ExpDateTextBox);
            this.Controls.Add(this.CardNumberTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CVVLabel);
            this.Controls.Add(this.ExpDateLabel);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.CardNameLabel);
            this.Controls.Add(this.PaymentMethodLabel);
            this.Controls.Add(this.CartTotalTextBox);
            this.Controls.Add(this.CartSubtotalTextBox);
            this.Controls.Add(this.CartTotalButton);
            this.Controls.Add(this.CartSubtotalButton);
            this.Controls.Add(this.ShoppingCartLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "View_Cart";
            this.Text = "View_Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Label ShoppingCartLabel;
        private System.Windows.Forms.Label CartSubtotalButton;
        private System.Windows.Forms.Label CartTotalButton;
        private System.Windows.Forms.TextBox CartSubtotalTextBox;
        private System.Windows.Forms.TextBox CartTotalTextBox;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.Label CardNameLabel;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Label ExpDateLabel;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.TextBox ExpDateTextBox;
        private System.Windows.Forms.TextBox CVVTextBox;
        private System.Windows.Forms.Button CartCheckoutButton;
    }
}