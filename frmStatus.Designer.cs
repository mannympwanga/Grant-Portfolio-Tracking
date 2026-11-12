
namespace GrantPortfolioTracking
{
    partial class frmStatus
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
            lbSelectStatus = new Label();
            rdoUnallocated = new RadioButton();
            rdoUnderReview = new RadioButton();
            rdoApproved = new RadioButton();
            rdoRejected = new RadioButton();
            SuspendLayout();
            // 
            // lbSelectStatus
            // 
            lbSelectStatus.AutoSize = true;
            lbSelectStatus.Font = new Font("Sitka Text", 18F, FontStyle.Bold | FontStyle.Underline);
            lbSelectStatus.Location = new Point(581, 136);
            lbSelectStatus.Name = "lbSelectStatus";
            lbSelectStatus.Size = new Size(207, 43);
            lbSelectStatus.TabIndex = 0;
            lbSelectStatus.Text = "Select Status";
            // 
            // rdoUnallocated
            // 
            rdoUnallocated.AutoSize = true;
            rdoUnallocated.Font = new Font("Sitka Text", 13.7999992F);
            rdoUnallocated.Location = new Point(600, 224);
            rdoUnallocated.Name = "rdoUnallocated";
            rdoUnallocated.Size = new Size(163, 37);
            rdoUnallocated.TabIndex = 1;
            rdoUnallocated.Text = "Unallocated";
            rdoUnallocated.UseVisualStyleBackColor = true;
            rdoUnallocated.Click += rdoUnallocated_Click;
            // 
            // rdoUnderReview
            // 
            rdoUnderReview.AutoSize = true;
            rdoUnderReview.Font = new Font("Sitka Text", 13.7999992F);
            rdoUnderReview.Location = new Point(600, 282);
            rdoUnderReview.Name = "rdoUnderReview";
            rdoUnderReview.Size = new Size(188, 37);
            rdoUnderReview.TabIndex = 2;
            rdoUnderReview.Text = "Under Review";
            rdoUnderReview.UseVisualStyleBackColor = true;
            rdoUnderReview.Click += rdoUnderReview_Click;
            // 
            // rdoApproved
            // 
            rdoApproved.AutoSize = true;
            rdoApproved.Font = new Font("Sitka Text", 13.7999992F);
            rdoApproved.Location = new Point(600, 338);
            rdoApproved.Name = "rdoApproved";
            rdoApproved.Size = new Size(141, 37);
            rdoApproved.TabIndex = 3;
            rdoApproved.Text = "Approved";
            rdoApproved.UseVisualStyleBackColor = true;
            rdoApproved.Click += rdoApproved_Click;
            // 
            // rdoRejected
            // 
            rdoRejected.AutoSize = true;
            rdoRejected.Font = new Font("Sitka Text", 13.7999992F);
            rdoRejected.Location = new Point(600, 395);
            rdoRejected.Name = "rdoRejected";
            rdoRejected.Size = new Size(127, 37);
            rdoRejected.TabIndex = 4;
            rdoRejected.Text = "Rejected";
            rdoRejected.UseVisualStyleBackColor = true;
            rdoRejected.Click += rdoRejected_Click;
            // 
            // frmStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 881);
            Controls.Add(rdoRejected);
            Controls.Add(rdoApproved);
            Controls.Add(rdoUnderReview);
            Controls.Add(rdoUnallocated);
            Controls.Add(lbSelectStatus);
            Name = "frmStatus";
            Text = "frmStatus";
            Load += frmStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSelectStatus;
        private RadioButton rdoUnallocated;
        private RadioButton rdoUnderReview;
        private RadioButton rdoApproved;
        private RadioButton rdoRejected;
        
    }
}