using System;
using System.Windows.Forms;

namespace IndependentStudyUnit4
{
    public partial class TotalsForm : Form
    {
        /// <summary>
        /// This method initializes the form.
        /// </summary>
        public TotalsForm()
        {
            InitializeComponent();
        }
        
        private void TotalsForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method will close the TotalsForm.
        /// </summary>
        private void backButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
