namespace IndependentStudyUnit4
{
    partial class TotalsForm
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.totalNoOfTeachersLabel = new System.Windows.Forms.Label();
            this.aylesburyTotalBillLabel = new System.Windows.Forms.Label();
            this.highWycombeTotalBillLabel = new System.Windows.Forms.Label();
            this.uxbridgeTotalBillLabel = new System.Windows.Forms.Label();
            this.schoolsTotalBillLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goBackButton.Location = new System.Drawing.Point(677, 455);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(98, 48);
            this.goBackButton.TabIndex = 8;
            this.goBackButton.Text = "Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.backButton);
            // 
            // totalNoOfTeachersLabel
            // 
            this.totalNoOfTeachersLabel.AutoSize = true;
            this.totalNoOfTeachersLabel.Location = new System.Drawing.Point(42, 66);
            this.totalNoOfTeachersLabel.Name = "totalNoOfTeachersLabel";
            this.totalNoOfTeachersLabel.Size = new System.Drawing.Size(212, 26);
            this.totalNoOfTeachersLabel.TabIndex = 9;
            this.totalNoOfTeachersLabel.Text = "Total No of Teachers";
            // 
            // aylesburyTotalBillLabel
            // 
            this.aylesburyTotalBillLabel.AutoSize = true;
            this.aylesburyTotalBillLabel.Location = new System.Drawing.Point(42, 214);
            this.aylesburyTotalBillLabel.Name = "aylesburyTotalBillLabel";
            this.aylesburyTotalBillLabel.Size = new System.Drawing.Size(197, 26);
            this.aylesburyTotalBillLabel.TabIndex = 13;
            this.aylesburyTotalBillLabel.Text = "Aylesbury Total Bill";
            // 
            // highWycombeTotalBillLabel
            // 
            this.highWycombeTotalBillLabel.AutoSize = true;
            this.highWycombeTotalBillLabel.Location = new System.Drawing.Point(42, 249);
            this.highWycombeTotalBillLabel.Name = "highWycombeTotalBillLabel";
            this.highWycombeTotalBillLabel.Size = new System.Drawing.Size(250, 26);
            this.highWycombeTotalBillLabel.TabIndex = 14;
            this.highWycombeTotalBillLabel.Text = "High Wycombe Total Bill";
            // 
            // uxbridgeTotalBillLabel
            // 
            this.uxbridgeTotalBillLabel.AutoSize = true;
            this.uxbridgeTotalBillLabel.Location = new System.Drawing.Point(42, 285);
            this.uxbridgeTotalBillLabel.Name = "uxbridgeTotalBillLabel";
            this.uxbridgeTotalBillLabel.Size = new System.Drawing.Size(188, 26);
            this.uxbridgeTotalBillLabel.TabIndex = 15;
            this.uxbridgeTotalBillLabel.Text = "Uxbridge Total Bill";
            // 
            // schoolsTotalBillLabel
            // 
            this.schoolsTotalBillLabel.AutoSize = true;
            this.schoolsTotalBillLabel.Location = new System.Drawing.Point(42, 141);
            this.schoolsTotalBillLabel.Name = "schoolsTotalBillLabel";
            this.schoolsTotalBillLabel.Size = new System.Drawing.Size(179, 26);
            this.schoolsTotalBillLabel.TabIndex = 16;
            this.schoolsTotalBillLabel.Text = "Schools Total Bill";
            // 
            // TotalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.goBackButton;
            this.ClientSize = new System.Drawing.Size(821, 555);
            this.Controls.Add(this.schoolsTotalBillLabel);
            this.Controls.Add(this.uxbridgeTotalBillLabel);
            this.Controls.Add(this.highWycombeTotalBillLabel);
            this.Controls.Add(this.aylesburyTotalBillLabel);
            this.Controls.Add(this.totalNoOfTeachersLabel);
            this.Controls.Add(this.goBackButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TotalsForm";
            this.Text = "Totals Form";
            this.Load += new System.EventHandler(this.TotalsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        public System.Windows.Forms.Label aylesburyTotalBillLabel;
        public System.Windows.Forms.Label highWycombeTotalBillLabel;
        public System.Windows.Forms.Label uxbridgeTotalBillLabel;
        public System.Windows.Forms.Label totalNoOfTeachersLabel;
        public System.Windows.Forms.Label schoolsTotalBillLabel;
    }
}