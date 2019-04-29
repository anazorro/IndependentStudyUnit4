namespace IndependentStudyUnit4
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.quitBillButton = new System.Windows.Forms.Button();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.displaySchoolLabel = new System.Windows.Forms.Label();
            this.choicesLabel = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.acceptBillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitBillButton
            // 
            this.quitBillButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitBillButton.Location = new System.Drawing.Point(681, 467);
            this.quitBillButton.Name = "quitBillButton";
            this.quitBillButton.Size = new System.Drawing.Size(98, 48);
            this.quitBillButton.TabIndex = 7;
            this.quitBillButton.Text = "Quit";
            this.quitBillButton.UseVisualStyleBackColor = true;
            this.quitBillButton.Click += new System.EventHandler(this.quitBillFormButton);
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.BackColor = System.Drawing.Color.White;
            this.displayNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNameLabel.ForeColor = System.Drawing.Color.Black;
            this.displayNameLabel.Location = new System.Drawing.Point(85, 32);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(306, 55);
            this.displayNameLabel.TabIndex = 8;
            this.displayNameLabel.Text = "Name:";
            // 
            // displaySchoolLabel
            // 
            this.displaySchoolLabel.BackColor = System.Drawing.Color.White;
            this.displaySchoolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySchoolLabel.ForeColor = System.Drawing.Color.Black;
            this.displaySchoolLabel.Location = new System.Drawing.Point(435, 32);
            this.displaySchoolLabel.Name = "displaySchoolLabel";
            this.displaySchoolLabel.Size = new System.Drawing.Size(306, 55);
            this.displaySchoolLabel.TabIndex = 9;
            this.displaySchoolLabel.Text = "School:";
            // 
            // choicesLabel
            // 
            this.choicesLabel.Location = new System.Drawing.Point(85, 163);
            this.choicesLabel.Name = "choicesLabel";
            this.choicesLabel.Size = new System.Drawing.Size(306, 253);
            this.choicesLabel.TabIndex = 12;
            this.choicesLabel.Text = "Choices";
            // 
            // billLabel
            // 
            this.billLabel.Location = new System.Drawing.Point(435, 163);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(306, 253);
            this.billLabel.TabIndex = 13;
            this.billLabel.Text = "Bill";
            // 
            // acceptBillButton
            // 
            this.acceptBillButton.Location = new System.Drawing.Point(324, 467);
            this.acceptBillButton.Name = "acceptBillButton";
            this.acceptBillButton.Size = new System.Drawing.Size(175, 48);
            this.acceptBillButton.TabIndex = 14;
            this.acceptBillButton.Text = "Accept Bill";
            this.acceptBillButton.UseVisualStyleBackColor = true;
            this.acceptBillButton.Click += new System.EventHandler(this.acceptBillButton_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.quitBillButton;
            this.ClientSize = new System.Drawing.Size(821, 555);
            this.Controls.Add(this.acceptBillButton);
            this.Controls.Add(this.billLabel);
            this.Controls.Add(this.choicesLabel);
            this.Controls.Add(this.displaySchoolLabel);
            this.Controls.Add(this.displayNameLabel);
            this.Controls.Add(this.quitBillButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillForm";
            this.Text = "Bill Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitBillButton;
        public System.Windows.Forms.Label displayNameLabel;
        public System.Windows.Forms.Label displaySchoolLabel;
        public System.Windows.Forms.Label choicesLabel;
        public System.Windows.Forms.Label billLabel;
        public System.Windows.Forms.Button acceptBillButton;
    }
}