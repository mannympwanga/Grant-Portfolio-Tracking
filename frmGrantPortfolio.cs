using System;
using System.Windows.Forms;

namespace GrantPortfolioTracking
{
    public partial class frmGrantPortfolio : Form
    {
        // 15 departments x 6 budget categories
        private string[,] portfolioStatus = new string[15, 6];

        // Stores the currently selected department
        private int selectedDepartment = -1;

        // Stores the category whose TextBox was clicked
        private int selectedCategory = -1;

        public frmGrantPortfolio()
        {
            InitializeComponent();
        }

        private void frmGrantPortfolio_Load(object sender, EventArgs e)
        {
            // Initialize or load portfolios when the form loads
            InitialisePortfolios();
            LoadPortfolios();
        }

        private void InitialisePortfolios()
        {
            // All allocations start as Unallocated.
            // Unallocated is represented by a period (.).

            for (int department = 0; department < 15; department++)
            {
                for (int category = 0; category < 6; category++)
                {
                    portfolioStatus[department, category] = ".";
                }
            }
        }

        private void LoadPortfolios()
        {
            lstPortfolios.Items.Clear();
            
            for (int department = 0; department < 15; department++)
            {
                string portfolio = "Department "
                                   + (department + 1)
                                   + ": ";

                for (int category = 0; category < 6; category++)
                {
                    portfolio += portfolioStatus[department, category];

                    if (category < 5)
                    {
                        portfolio += " ";
                    }
                }

                lstPortfolios.Items.Add(portfolio);
            }
        }

        private void lstPortfolios_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (lstPortfolios.SelectedIndex == -1)
            {
                return;
            }

            selectedDepartment = lstPortfolios.SelectedIndex;

            DisplaySelectedDepartment();
        }
      
        private void DisplaySelectedDepartment()
        {
            txtDepartment.Text = (selectedDepartment + 1).ToString();

            txtEquipment.Text =
                portfolioStatus[selectedDepartment, 0];

            txtTravel.Text =
                portfolioStatus[selectedDepartment, 1];

            txtPersonnel.Text =
                portfolioStatus[selectedDepartment, 2];

            txtSupplies.Text =
                portfolioStatus[selectedDepartment, 3];

            txtPublications.Text =
                portfolioStatus[selectedDepartment, 4];

            txtSubContracts.Text =
                portfolioStatus[selectedDepartment, 5];
        }

        private void txtEquipment_Click(object sender, EventArgs e)
        {
            OpenStatusForm(0);
        }

        private void txtTravel_Click(object sender, EventArgs e)
        {
            OpenStatusForm(1);
        }

        private void txtPersonnel_Click(object sender, EventArgs e)
        {
            OpenStatusForm(2);
        }

        private void txtSupplies_Click(object sender, EventArgs e)
        {
            OpenStatusForm(3);
        }

        private void txtPublications_Click(object sender, EventArgs e)
        {
            OpenStatusForm(4);
        }

        private void txtSubContracts_Click(object sender, EventArgs e)
        {
   
            OpenStatusForm(5);
        }

        private void OpenStatusForm(int category)
        {
            //error messsage if deparment not selected
            if (selectedDepartment == -1)
            {
       
                MessageBox.Show(
                    "Please select a department first.",
                    "Grant Portfolio Tracking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            selectedCategory = category;

            frmStatus statusForm = new frmStatus(this);
            statusForm.ShowDialog();
        }

        public void UpdateStatus(string statusCode)
        {
            // Update the status of the selected category for the selected department
            if (selectedDepartment == -1 ||
                selectedCategory == -1)
            {
                return;
            }

            portfolioStatus[
                selectedDepartment,
                selectedCategory] = statusCode;

            DisplaySelectedDepartment();

            LoadPortfolios();

            // Keep the current department selected
            lstPortfolios.SelectedIndex = selectedDepartment;

            selectedCategory = -1;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            // Calculate the number of categories under review and approved
            int underReview = 0;
            int approved = 0;

            for (int department = 0; department < 15; department++)
            {
                for (int category = 0; category < 6; category++)
                {
                    if (portfolioStatus[department, category] == "U")
                    {
                        underReview++;
                    }

                    if (portfolioStatus[department, category] == "A")
                    {
                        approved++;
                    }
                }
            }

            MessageBox.Show(
                "Grant Portfolio Summary\n\n" +
                "Categories Under Review: "
                + underReview
                + "\n\n" +
                "Categories Approved: "
                + approved,
                "University Grant Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}