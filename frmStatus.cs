using System;
using System.Windows.Forms;

namespace GrantPortfolioTracking
{
    public partial class frmStatus : Form
    {
        private frmGrantPortfolio mainForm;

        public frmStatus(frmGrantPortfolio form)
        {
            InitializeComponent();

            mainForm = form;
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            
        }

        private void rdoUnallocated_Click(object sender, EventArgs e)
        {

            // Update the status in the main form to "Unallocated" (represented by a period)
            mainForm.UpdateStatus(".");

           
            this.Close();
        }

        private void rdoUnderReview_Click(object sender, EventArgs e)
        {

            // Update the status in the main form to "Under Review" (represented by "U")
            mainForm.UpdateStatus("U");

            
             this.Close();
        }

        private void rdoApproved_Click(object sender, EventArgs e)
        {

            // Update the status in the main form to "Approved" (represented by "A")
            mainForm.UpdateStatus("A");

           
            this.Close();
        }

        private void rdoRejected_Click(object sender, EventArgs e)
        {

            // Update the status in the main form to "Rejected" (represented by "R")
            mainForm.UpdateStatus("R");

            
             this.Close();
        }
    }
}