using System;
using System.Windows.Forms;

namespace IndependentStudyUnit4
{
    public partial class BillForm : Form
    {
        public string name;
        public string school;
        public decimal bill;
        public decimal totalBill;


        private TotalsForm totalsForm = new TotalsForm();

        /// <summary>
        /// This method initializes the form.
        /// </summary>
        public BillForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will close the billForm.
        /// </summary>
        private void quitBillFormButton(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method will ask the user to accept the bill. If yes,
        /// it will display a message and continue to TotalsForms if
        /// not, a message is displayed and the form will be closed.
        /// </summary>
        private void acceptBillButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(name + ", are you happy with your choices?", "Accept Bill", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Great, bon appetit!");
                totalsForm.schoolsTotalBillLabel.Text = "Schools Total Bill = " + totalBill.ToString("c");
                totalsForm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("No problem, your order will be cancelled!");
                Close();
            }
        }
    }
}