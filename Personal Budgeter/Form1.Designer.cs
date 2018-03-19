namespace Personal_Budgeter
{
    partial class Form1
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
            this.WeeklyRLabel = new System.Windows.Forms.Label();
            this.TotalRLabel = new System.Windows.Forms.Label();
            this.WeeklyRemNumberLabel = new System.Windows.Forms.Label();
            this.TotalRemNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VenFoodRadioButton = new System.Windows.Forms.RadioButton();
            this.ProdRadioButton = new System.Windows.Forms.RadioButton();
            this.EntRadioButton = new System.Windows.Forms.RadioButton();
            this.FoodRadioButton = new System.Windows.Forms.RadioButton();
            this.ReceiptEntryButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ReceiptEntryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CumVenFoodExpLabel = new System.Windows.Forms.Label();
            this.CumProdExpLabel = new System.Windows.Forms.Label();
            this.CumEntExpLabel = new System.Windows.Forms.Label();
            this.CumFoodExpLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeeklyRLabel
            // 
            this.WeeklyRLabel.AutoSize = true;
            this.WeeklyRLabel.Location = new System.Drawing.Point(231, 9);
            this.WeeklyRLabel.Name = "WeeklyRLabel";
            this.WeeklyRLabel.Size = new System.Drawing.Size(182, 17);
            this.WeeklyRLabel.TabIndex = 0;
            this.WeeklyRLabel.Text = "Remaining Weekly Budget: ";
            // 
            // TotalRLabel
            // 
            this.TotalRLabel.AutoSize = true;
            this.TotalRLabel.Location = new System.Drawing.Point(231, 26);
            this.TotalRLabel.Name = "TotalRLabel";
            this.TotalRLabel.Size = new System.Drawing.Size(168, 17);
            this.TotalRLabel.TabIndex = 1;
            this.TotalRLabel.Text = "Total Remaining Budget: ";
            // 
            // WeeklyRemNumberLabel
            // 
            this.WeeklyRemNumberLabel.AutoSize = true;
            this.WeeklyRemNumberLabel.Location = new System.Drawing.Point(419, 9);
            this.WeeklyRemNumberLabel.Name = "WeeklyRemNumberLabel";
            this.WeeklyRemNumberLabel.Size = new System.Drawing.Size(46, 17);
            this.WeeklyRemNumberLabel.TabIndex = 2;
            this.WeeklyRemNumberLabel.Text = "label1";
            // 
            // TotalRemNumberLabel
            // 
            this.TotalRemNumberLabel.AutoSize = true;
            this.TotalRemNumberLabel.Location = new System.Drawing.Point(419, 26);
            this.TotalRemNumberLabel.Name = "TotalRemNumberLabel";
            this.TotalRemNumberLabel.Size = new System.Drawing.Size(46, 17);
            this.TotalRemNumberLabel.TabIndex = 3;
            this.TotalRemNumberLabel.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VenFoodRadioButton);
            this.groupBox1.Controls.Add(this.ProdRadioButton);
            this.groupBox1.Controls.Add(this.EntRadioButton);
            this.groupBox1.Controls.Add(this.FoodRadioButton);
            this.groupBox1.Controls.Add(this.ReceiptEntryButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ReceiptEntryTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt Entry:";
            // 
            // VenFoodRadioButton
            // 
            this.VenFoodRadioButton.AutoSize = true;
            this.VenFoodRadioButton.Location = new System.Drawing.Point(71, 132);
            this.VenFoodRadioButton.Name = "VenFoodRadioButton";
            this.VenFoodRadioButton.Size = new System.Drawing.Size(109, 21);
            this.VenFoodRadioButton.TabIndex = 3;
            this.VenFoodRadioButton.Text = "Venmo Food";
            this.VenFoodRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProdRadioButton
            // 
            this.ProdRadioButton.AutoSize = true;
            this.ProdRadioButton.Location = new System.Drawing.Point(71, 105);
            this.ProdRadioButton.Name = "ProdRadioButton";
            this.ProdRadioButton.Size = new System.Drawing.Size(85, 21);
            this.ProdRadioButton.TabIndex = 2;
            this.ProdRadioButton.Text = "Products";
            this.ProdRadioButton.UseVisualStyleBackColor = true;
            // 
            // EntRadioButton
            // 
            this.EntRadioButton.AutoSize = true;
            this.EntRadioButton.Location = new System.Drawing.Point(71, 78);
            this.EntRadioButton.Name = "EntRadioButton";
            this.EntRadioButton.Size = new System.Drawing.Size(117, 21);
            this.EntRadioButton.TabIndex = 1;
            this.EntRadioButton.Text = "Entertainment";
            this.EntRadioButton.UseVisualStyleBackColor = true;
            // 
            // FoodRadioButton
            // 
            this.FoodRadioButton.AutoSize = true;
            this.FoodRadioButton.Checked = true;
            this.FoodRadioButton.Location = new System.Drawing.Point(71, 51);
            this.FoodRadioButton.Name = "FoodRadioButton";
            this.FoodRadioButton.Size = new System.Drawing.Size(61, 21);
            this.FoodRadioButton.TabIndex = 5;
            this.FoodRadioButton.TabStop = true;
            this.FoodRadioButton.Text = "Food";
            this.FoodRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReceiptEntryButton
            // 
            this.ReceiptEntryButton.Location = new System.Drawing.Point(42, 159);
            this.ReceiptEntryButton.Name = "ReceiptEntryButton";
            this.ReceiptEntryButton.Size = new System.Drawing.Size(75, 25);
            this.ReceiptEntryButton.TabIndex = 4;
            this.ReceiptEntryButton.Text = "Enter";
            this.ReceiptEntryButton.UseVisualStyleBackColor = true;
            this.ReceiptEntryButton.Click += new System.EventHandler(this.ReceiptEntryButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount:";
            // 
            // ReceiptEntryTextBox
            // 
            this.ReceiptEntryTextBox.Location = new System.Drawing.Point(71, 21);
            this.ReceiptEntryTextBox.Name = "ReceiptEntryTextBox";
            this.ReceiptEntryTextBox.Size = new System.Drawing.Size(118, 22);
            this.ReceiptEntryTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CumVenFoodExpLabel);
            this.groupBox2.Controls.Add(this.CumProdExpLabel);
            this.groupBox2.Controls.Add(this.CumEntExpLabel);
            this.groupBox2.Controls.Add(this.CumFoodExpLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(234, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 161);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expense by Categorry";
            // 
            // CumVenFoodExpLabel
            // 
            this.CumVenFoodExpLabel.AutoSize = true;
            this.CumVenFoodExpLabel.Location = new System.Drawing.Point(250, 124);
            this.CumVenFoodExpLabel.Name = "CumVenFoodExpLabel";
            this.CumVenFoodExpLabel.Size = new System.Drawing.Size(54, 17);
            this.CumVenFoodExpLabel.TabIndex = 9;
            this.CumVenFoodExpLabel.Text = "label11";
            // 
            // CumProdExpLabel
            // 
            this.CumProdExpLabel.AutoSize = true;
            this.CumProdExpLabel.Location = new System.Drawing.Point(250, 93);
            this.CumProdExpLabel.Name = "CumProdExpLabel";
            this.CumProdExpLabel.Size = new System.Drawing.Size(54, 17);
            this.CumProdExpLabel.TabIndex = 8;
            this.CumProdExpLabel.Text = "label10";
            // 
            // CumEntExpLabel
            // 
            this.CumEntExpLabel.AutoSize = true;
            this.CumEntExpLabel.Location = new System.Drawing.Point(250, 61);
            this.CumEntExpLabel.Name = "CumEntExpLabel";
            this.CumEntExpLabel.Size = new System.Drawing.Size(46, 17);
            this.CumEntExpLabel.TabIndex = 7;
            this.CumEntExpLabel.Text = "label9";
            // 
            // CumFoodExpLabel
            // 
            this.CumFoodExpLabel.AutoSize = true;
            this.CumFoodExpLabel.Location = new System.Drawing.Point(250, 30);
            this.CumFoodExpLabel.Name = "CumFoodExpLabel";
            this.CumFoodExpLabel.Size = new System.Drawing.Size(46, 17);
            this.CumFoodExpLabel.TabIndex = 6;
            this.CumFoodExpLabel.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cumulative Venmo Food Expense:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cumulative Products Expense:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cumulative Entertainment Expense:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cumulative Food Expense:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 212);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TotalRemNumberLabel);
            this.Controls.Add(this.WeeklyRemNumberLabel);
            this.Controls.Add(this.TotalRLabel);
            this.Controls.Add(this.WeeklyRLabel);
            this.Name = "Form1";
            this.Text = "Personal Budgeter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeeklyRLabel;
        private System.Windows.Forms.Label TotalRLabel;
        private System.Windows.Forms.Label WeeklyRemNumberLabel;
        private System.Windows.Forms.Label TotalRemNumberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReceiptEntryTextBox;
        private System.Windows.Forms.Button ReceiptEntryButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CumVenFoodExpLabel;
        private System.Windows.Forms.Label CumProdExpLabel;
        private System.Windows.Forms.Label CumEntExpLabel;
        private System.Windows.Forms.Label CumFoodExpLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton VenFoodRadioButton;
        private System.Windows.Forms.RadioButton ProdRadioButton;
        private System.Windows.Forms.RadioButton EntRadioButton;
        private System.Windows.Forms.RadioButton FoodRadioButton;
    }
}

