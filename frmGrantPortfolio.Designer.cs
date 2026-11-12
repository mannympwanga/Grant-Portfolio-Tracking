namespace GrantPortfolioTracking
{
    partial class frmGrantPortfolio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lstPortfolios = new ListBox();
            grpPortfolios = new Label();
            grpSelectedPortfolio = new Label();
            lblDepartment = new Label();
            txtDepartment = new TextBox();
            txtEquipment = new TextBox();
            lblEquipment = new Label();
            txtTravel = new TextBox();
            lblTravel = new Label();
            txtPersonnel = new TextBox();
            lblPersonnel = new Label();
            txtSupplies = new TextBox();
            lblSupplies = new Label();
            txtPublications = new TextBox();
            lblPublications = new Label();
            txtSubContracts = new TextBox();
            lblSubContracts = new Label();
            btnSummary = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Algerian", 48F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(151, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1194, 87);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GRANT PORTFOLIO TRACKING";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstPortfolios
            // 
            lstPortfolios.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPortfolios.FormattingEnabled = true;
            lstPortfolios.ItemHeight = 33;
            lstPortfolios.Items.AddRange(new object[] { "Department 1: . . . . . .", "Department 2: . . . . . .", "Department 3: . . . . . .", "Department 4: . . . . . .", "Department 5: . . . . . .", "Department 6: . . . . . .", "Department 7: . . . . . .", "Department 8: . . . . . .", "Department 9: . . . . . .", "Department 10: . . . . . .", "Department 11: . . . . . .", "Department 12: . . . . . .", "Department 13: . . . . . .", "Department 14: . . . . . .", "Department 15: . . . . . ." });
            lstPortfolios.Location = new Point(193, 197);
            lstPortfolios.Name = "lstPortfolios";
            lstPortfolios.Size = new Size(335, 499);
            lstPortfolios.TabIndex = 1;
            lstPortfolios.SelectedIndexChanged += lstPortfolios_SelectedIndexChanged;
            // 
            // grpPortfolios
            // 
            grpPortfolios.AutoSize = true;
            grpPortfolios.Font = new Font("Sitka Text", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpPortfolios.Location = new Point(177, 140);
            grpPortfolios.Name = "grpPortfolios";
            grpPortfolios.Size = new Size(351, 43);
            grpPortfolios.TabIndex = 2;
            grpPortfolios.Text = "Department Portfolios";
            // 
            // grpSelectedPortfolio
            // 
            grpSelectedPortfolio.AutoSize = true;
            grpSelectedPortfolio.Font = new Font("Sitka Text", 18F, FontStyle.Bold | FontStyle.Underline);
            grpSelectedPortfolio.Location = new Point(905, 140);
            grpSelectedPortfolio.Name = "grpSelectedPortfolio";
            grpSelectedPortfolio.Size = new Size(281, 43);
            grpSelectedPortfolio.TabIndex = 3;
            grpSelectedPortfolio.Text = "Selected Portfolio";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Sitka Text", 13.7999992F);
            lblDepartment.Location = new Point(819, 197);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(263, 33);
            lblDepartment.TabIndex = 4;
            lblDepartment.Text = "Department Number : ";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Sitka Text", 13.7999992F);
            txtDepartment.Location = new Point(1075, 197);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(204, 36);
            txtDepartment.TabIndex = 5;
            txtDepartment.Text = ".";
            txtDepartment.TextAlign = HorizontalAlignment.Center;
            txtDepartment.Click += lstPortfolios_SelectedIndexChanged;
            // 
            // txtEquipment
            // 
            txtEquipment.Font = new Font("Sitka Text", 13.7999992F);
            txtEquipment.Location = new Point(1075, 262);
            txtEquipment.Name = "txtEquipment";
            txtEquipment.ReadOnly = true;
            txtEquipment.Size = new Size(204, 36);
            txtEquipment.TabIndex = 7;
            txtEquipment.Text = ".";
            txtEquipment.TextAlign = HorizontalAlignment.Center;
            txtEquipment.Click += txtEquipment_Click;
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Font = new Font("Sitka Text", 13.7999992F);
            lblEquipment.Location = new Point(819, 262);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(156, 33);
            lblEquipment.TabIndex = 6;
            lblEquipment.Text = "Equipment : ";
            // 
            // txtTravel
            // 
            txtTravel.Font = new Font("Sitka Text", 13.7999992F);
            txtTravel.Location = new Point(1075, 328);
            txtTravel.Name = "txtTravel";
            txtTravel.ReadOnly = true;
            txtTravel.Size = new Size(204, 36);
            txtTravel.TabIndex = 9;
            txtTravel.Text = ".";
            txtTravel.TextAlign = HorizontalAlignment.Center;
            txtTravel.Click += txtTravel_Click;
            // 
            // lblTravel
            // 
            lblTravel.AutoSize = true;
            lblTravel.Font = new Font("Sitka Text", 13.7999992F);
            lblTravel.Location = new Point(819, 328);
            lblTravel.Name = "lblTravel";
            lblTravel.Size = new Size(105, 33);
            lblTravel.TabIndex = 8;
            lblTravel.Text = "Travel : ";
            // 
            // txtPersonnel
            // 
            txtPersonnel.Font = new Font("Sitka Text", 13.7999992F);
            txtPersonnel.Location = new Point(1075, 387);
            txtPersonnel.Name = "txtPersonnel";
            txtPersonnel.ReadOnly = true;
            txtPersonnel.Size = new Size(204, 36);
            txtPersonnel.TabIndex = 11;
            txtPersonnel.Text = ".";
            txtPersonnel.TextAlign = HorizontalAlignment.Center;
            txtPersonnel.Click += txtPersonnel_Click;
            // 
            // lblPersonnel
            // 
            lblPersonnel.AutoSize = true;
            lblPersonnel.Font = new Font("Sitka Text", 13.7999992F);
            lblPersonnel.Location = new Point(819, 387);
            lblPersonnel.Name = "lblPersonnel";
            lblPersonnel.Size = new Size(144, 33);
            lblPersonnel.TabIndex = 10;
            lblPersonnel.Text = "Personnel : ";
            // 
            // txtSupplies
            // 
            txtSupplies.Font = new Font("Sitka Text", 13.7999992F);
            txtSupplies.Location = new Point(1075, 442);
            txtSupplies.Name = "txtSupplies";
            txtSupplies.ReadOnly = true;
            txtSupplies.Size = new Size(204, 36);
            txtSupplies.TabIndex = 13;
            txtSupplies.Text = ".";
            txtSupplies.TextAlign = HorizontalAlignment.Center;
            txtSupplies.Click += txtSupplies_Click;
            // 
            // lblSupplies
            // 
            lblSupplies.AutoSize = true;
            lblSupplies.Font = new Font("Sitka Text", 13.7999992F);
            lblSupplies.Location = new Point(819, 442);
            lblSupplies.Name = "lblSupplies";
            lblSupplies.Size = new Size(129, 33);
            lblSupplies.TabIndex = 12;
            lblSupplies.Text = "Supplies : ";
            // 
            // txtPublications
            // 
            txtPublications.Font = new Font("Sitka Text", 13.7999992F);
            txtPublications.Location = new Point(1075, 492);
            txtPublications.Name = "txtPublications";
            txtPublications.ReadOnly = true;
            txtPublications.Size = new Size(204, 36);
            txtPublications.TabIndex = 15;
            txtPublications.Text = ".";
            txtPublications.TextAlign = HorizontalAlignment.Center;
            txtPublications.Click += txtPublications_Click;
            // 
            // lblPublications
            // 
            lblPublications.AutoSize = true;
            lblPublications.Font = new Font("Sitka Text", 13.7999992F);
            lblPublications.Location = new Point(819, 492);
            lblPublications.Name = "lblPublications";
            lblPublications.Size = new Size(168, 33);
            lblPublications.TabIndex = 14;
            lblPublications.Text = "Publications : ";
            // 
            // txtSubContracts
            // 
            txtSubContracts.Font = new Font("Sitka Text", 13.7999992F);
            txtSubContracts.Location = new Point(1075, 548);
            txtSubContracts.Name = "txtSubContracts";
            txtSubContracts.ReadOnly = true;
            txtSubContracts.Size = new Size(204, 36);
            txtSubContracts.TabIndex = 17;
            txtSubContracts.Text = ".";
            txtSubContracts.TextAlign = HorizontalAlignment.Center;
            txtSubContracts.Click += txtSubContracts_Click;
            // 
            // lblSubContracts
            // 
            lblSubContracts.AutoSize = true;
            lblSubContracts.Font = new Font("Sitka Text", 13.7999992F);
            lblSubContracts.Location = new Point(819, 551);
            lblSubContracts.Name = "lblSubContracts";
            lblSubContracts.Size = new Size(187, 33);
            lblSubContracts.TabIndex = 16;
            lblSubContracts.Text = "Sub-contracts : ";
            // 
            // btnSummary
            // 
            btnSummary.BackColor = Color.Lime;
            btnSummary.Font = new Font("Sitka Text", 18F, FontStyle.Bold | FontStyle.Underline);
            btnSummary.Location = new Point(631, 722);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(252, 60);
            btnSummary.TabIndex = 18;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = false;
            btnSummary.Click += btnSummary_Click;
            // 
            // frmGrantPortfolio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 881);
            Controls.Add(btnSummary);
            Controls.Add(txtSubContracts);
            Controls.Add(lblSubContracts);
            Controls.Add(txtPublications);
            Controls.Add(lblPublications);
            Controls.Add(txtSupplies);
            Controls.Add(lblSupplies);
            Controls.Add(txtPersonnel);
            Controls.Add(lblPersonnel);
            Controls.Add(txtTravel);
            Controls.Add(lblTravel);
            Controls.Add(txtEquipment);
            Controls.Add(lblEquipment);
            Controls.Add(txtDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(grpSelectedPortfolio);
            Controls.Add(grpPortfolios);
            Controls.Add(lstPortfolios);
            Controls.Add(lblTitle);
            Name = "frmGrantPortfolio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGrantPortfolio";
            Load += frmGrantPortfolio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstPortfolios;
        private Label grpPortfolios;
        private Label grpSelectedPortfolio;
        private Label lblDepartment;
        private TextBox txtDepartment;
        private TextBox txtEquipment;
        private Label lblEquipment;
        private TextBox txtTravel;
        private Label lblTravel;
        private TextBox txtPersonnel;
        private Label lblPersonnel;
        private TextBox txtSupplies;
        private Label lblSupplies;
        private TextBox txtPublications;
        private Label lblPublications;
        private TextBox txtSubContracts;
        private Label lblSubContracts;
        private Button btnSummary;
    }
}
