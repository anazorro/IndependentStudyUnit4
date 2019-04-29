using System;
using System.Windows.Forms;

namespace IndependentStudyUnit4
{
    public partial class EntryForm : Form
    {
        private const decimal ATTENDANCE_COST = 50;
        private decimal bill = 0;
        private decimal totalBill = 0;

        private int listNumber;
        
        private string name;
        private string school;
        private string chosenLunch;
        private string chosenDinner;

        private BillForm billForm = new BillForm();
        private TotalsForm totalsForm = new TotalsForm();

        /// <summary>
        /// This method initializes the form.
        /// </summary>
        public EntryForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This method will display the name of the teacher, the school name,
        /// the choices made and the total bill when the seeBillButton is clicked.
        /// </summary>
        private void SeeBill(object sender, EventArgs e)
        {
            DisplayName();
            DisplaySchoolName();

            TakeOrders();
            DisplayOrder();

            CalculateBill();               
        }

        /// <summary>
        /// This method will display the name in the BillForm displayNameLabel.
        /// </summary>
        private void DisplayName()
        {
            name = nameTextBox.Text;
            billForm.displayNameLabel.Text = "Teacher: " + name;
            billForm.name = name;
            
            foreach(Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        /// <summary>
        /// This method will get the name of the school in the BillForm
        /// displaySchoolLabel.
        /// </summary>
        private void DisplaySchoolName()
        {
            school = schoolComboBox.SelectedItem.ToString();
            billForm.displaySchoolLabel.Text = "School: " + school;
            billForm.school = school;

            foreach (Control c in Controls)
            {
                if (c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }

        /// <summary>
        /// This method will take and display the lunch and dinner orders.
        /// </summary>
        private void TakeOrders()
        {
            // Determine if there are any lunch options checked.  
            if (lunchCheckedListBox.CheckedItems.Count != 0)
            {
                chosenLunch = "Lunch order:\n";
                for (listNumber = 0; listNumber <= (lunchCheckedListBox.Items.Count - 1); listNumber++)
                {
                    if (lunchCheckedListBox.GetItemChecked(listNumber))
                    {
                        chosenLunch = chosenLunch + lunchCheckedListBox.Items[listNumber].ToString() + "\n";
                        bill = bill + 10;
                    }
                }
            }
            else
            {
                chosenLunch = "Not having lunch\n\n";
            }

            // Determine if there are any dinner options checked.  
            if (dinnerCheckedListBox.CheckedItems.Count != 0)
            {
                chosenDinner = "Dinner order:\n";
                for (listNumber = 0; listNumber <= (dinnerCheckedListBox.Items.Count - 1); listNumber++)
                {
                    if (dinnerCheckedListBox.GetItemChecked(listNumber))
                    {
                        chosenDinner = chosenDinner + dinnerCheckedListBox.Items[listNumber].ToString() + "\n";
                        bill = bill + 15;
                    }
                }
            }
            else
            {
                chosenDinner = "\nNot having dinner\n\n";
            }
        }

        /// <summary>
        /// This method will display the order in the BillForm choicesLabel.
        /// </summary>
        private void DisplayOrder()
        {
            billForm.choicesLabel.Text = chosenLunch + chosenDinner;
        }

        /// <summary>
        /// This method will calculate the bill.
        /// </summary>
        private void CalculateBill()
        {
            totalBill = bill + ATTENDANCE_COST;
            billForm.bill = bill;
            billForm.totalBill = totalBill;

            billForm.billLabel.Text = name + "'s total cost: " + totalBill.ToString("c");
            billForm.Show();
        }
        
        /// <summary>
        /// This method will close the EntryForm.
        /// </summary>
        private void quitEntryFormButton(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method will load the totalsForm when to totalsbutton is clicked.
        /// </summary>
        private void totalsButton_Click(object sender, EventArgs e)
        {
            totalsForm.Show();
        }
    }
}