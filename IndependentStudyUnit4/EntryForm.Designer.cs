namespace IndependentStudyUnit4
{
    partial class EntryForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.schoolLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.dinnerLabel = new System.Windows.Forms.Label();
            this.lunchLabel = new System.Windows.Forms.Label();
            this.dinnerCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.lunchCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.seeBillButton = new System.Windows.Forms.Button();
            this.quitEntryButton = new System.Windows.Forms.Button();
            this.totalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 48);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 26);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // schoolLabel
            // 
            this.schoolLabel.AutoSize = true;
            this.schoolLabel.Location = new System.Drawing.Point(40, 114);
            this.schoolLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(79, 26);
            this.schoolLabel.TabIndex = 1;
            this.schoolLabel.Text = "School";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(177, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(318, 32);
            this.nameTextBox.TabIndex = 2;
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Items.AddRange(new object[] {
            "BNU Aylesbury",
            "BNU High Wycombe",
            "BNU Uxbridge"});
            this.schoolComboBox.Location = new System.Drawing.Point(177, 114);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(318, 33);
            this.schoolComboBox.TabIndex = 3;
            // 
            // dinnerLabel
            // 
            this.dinnerLabel.AutoSize = true;
            this.dinnerLabel.Location = new System.Drawing.Point(407, 201);
            this.dinnerLabel.Name = "dinnerLabel";
            this.dinnerLabel.Size = new System.Drawing.Size(76, 26);
            this.dinnerLabel.TabIndex = 3;
            this.dinnerLabel.Text = "Dinner";
            // 
            // lunchLabel
            // 
            this.lunchLabel.AutoSize = true;
            this.lunchLabel.Location = new System.Drawing.Point(46, 201);
            this.lunchLabel.Name = "lunchLabel";
            this.lunchLabel.Size = new System.Drawing.Size(71, 26);
            this.lunchLabel.TabIndex = 2;
            this.lunchLabel.Text = "Lunch";
            // 
            // dinnerCheckedListBox
            // 
            this.dinnerCheckedListBox.CheckOnClick = true;
            this.dinnerCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerCheckedListBox.FormattingEnabled = true;
            this.dinnerCheckedListBox.Items.AddRange(new object[] {
            "CHICKEN-FRIED STEAK",
            "POT ROAST",
            "SLOW ROASTED TURKEY",
            "LEMON ARTICHOKE CHICKEN",
            "FISH AND CHIPS",
            "CHICKEN POT PIE",
            "CHICKEN TENDERS"});
            this.dinnerCheckedListBox.Location = new System.Drawing.Point(412, 240);
            this.dinnerCheckedListBox.Name = "dinnerCheckedListBox";
            this.dinnerCheckedListBox.Size = new System.Drawing.Size(360, 137);
            this.dinnerCheckedListBox.TabIndex = 1;
            // 
            // lunchCheckedListBox
            // 
            this.lunchCheckedListBox.CheckOnClick = true;
            this.lunchCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchCheckedListBox.FormattingEnabled = true;
            this.lunchCheckedListBox.Items.AddRange(new object[] {
            "AUBERGINE COCONUT CURRY",
            "KING PRAWN, CRAB, CHORIZO LINGUINE",
            "STIR-FRIED BEEF FILLET SALAD",
            "CHICKEN, BACON, AVOCADO SALAD",
            "MARGHERITA PIZZA",
            "AMERICANO PIZZA",
            "HAWAIIAN PIZZA"});
            this.lunchCheckedListBox.Location = new System.Drawing.Point(51, 240);
            this.lunchCheckedListBox.Name = "lunchCheckedListBox";
            this.lunchCheckedListBox.Size = new System.Drawing.Size(355, 137);
            this.lunchCheckedListBox.TabIndex = 0;
            // 
            // seeBillButton
            // 
            this.seeBillButton.Location = new System.Drawing.Point(308, 467);
            this.seeBillButton.Name = "seeBillButton";
            this.seeBillButton.Size = new System.Drawing.Size(98, 48);
            this.seeBillButton.TabIndex = 5;
            this.seeBillButton.Text = "See Bill";
            this.seeBillButton.UseVisualStyleBackColor = true;
            this.seeBillButton.Click += new System.EventHandler(this.SeeBill);
            // 
            // quitEntryButton
            // 
            this.quitEntryButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitEntryButton.Location = new System.Drawing.Point(674, 467);
            this.quitEntryButton.Name = "quitEntryButton";
            this.quitEntryButton.Size = new System.Drawing.Size(98, 48);
            this.quitEntryButton.TabIndex = 6;
            this.quitEntryButton.Text = "Quit";
            this.quitEntryButton.UseVisualStyleBackColor = true;
            this.quitEntryButton.Click += new System.EventHandler(this.quitEntryFormButton);
            // 
            // totalsButton
            // 
            this.totalsButton.Location = new System.Drawing.Point(412, 467);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(98, 48);
            this.totalsButton.TabIndex = 7;
            this.totalsButton.Text = "Totals";
            this.totalsButton.UseVisualStyleBackColor = true;
            this.totalsButton.Click += new System.EventHandler(this.totalsButton_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.quitEntryButton;
            this.ClientSize = new System.Drawing.Size(821, 555);
            this.Controls.Add(this.lunchLabel);
            this.Controls.Add(this.dinnerLabel);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.quitEntryButton);
            this.Controls.Add(this.dinnerCheckedListBox);
            this.Controls.Add(this.seeBillButton);
            this.Controls.Add(this.lunchCheckedListBox);
            this.Controls.Add(this.schoolComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.schoolLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.Text = "Data Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.Label dinnerLabel;
        private System.Windows.Forms.Label lunchLabel;
        private System.Windows.Forms.CheckedListBox dinnerCheckedListBox;
        private System.Windows.Forms.CheckedListBox lunchCheckedListBox;
        private System.Windows.Forms.Button seeBillButton;
        private System.Windows.Forms.Button quitEntryButton;
        private System.Windows.Forms.Button totalsButton;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.ComboBox schoolComboBox;
    }
}