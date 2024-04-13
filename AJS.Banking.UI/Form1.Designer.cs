namespace AJS.Banking.UI
{
    partial class Form1
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
            this.lstbxCustomers = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.dgvDeposits = new System.Windows.Forms.DataGridView();
            this.dgvWithdrawals = new System.Windows.Forms.DataGridView();
            this.lblDisplayedID = new System.Windows.Forms.Label();
            this.lblDisplayedAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxCustomers
            // 
            this.lstbxCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstbxCustomers.FormattingEnabled = true;
            this.lstbxCustomers.ItemHeight = 21;
            this.lstbxCustomers.Location = new System.Drawing.Point(22, 22);
            this.lstbxCustomers.Name = "lstbxCustomers";
            this.lstbxCustomers.Size = new System.Drawing.Size(294, 256);
            this.lstbxCustomers.TabIndex = 0;
            this.lstbxCustomers.SelectedIndexChanged += new System.EventHandler(this.lstbxCustomers_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(344, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 21);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(344, 59);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 21);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(344, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 21);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSSN.Location = new System.Drawing.Point(344, 135);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(43, 21);
            this.lblSSN.TabIndex = 1;
            this.lblSSN.Text = "SSN:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.Location = new System.Drawing.Point(344, 175);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(100, 21);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(344, 215);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(40, 21);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(472, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(209, 29);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(472, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(209, 29);
            this.txtLastName.TabIndex = 2;
            // 
            // txtSSN
            // 
            this.txtSSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSSN.Location = new System.Drawing.Point(472, 135);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(209, 29);
            this.txtSSN.TabIndex = 2;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDOB.Location = new System.Drawing.Point(472, 175);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(209, 29);
            this.txtDOB.TabIndex = 2;
            // 
            // dgvDeposits
            // 
            this.dgvDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposits.Location = new System.Drawing.Point(22, 321);
            this.dgvDeposits.Name = "dgvDeposits";
            this.dgvDeposits.RowTemplate.Height = 25;
            this.dgvDeposits.Size = new System.Drawing.Size(659, 150);
            this.dgvDeposits.TabIndex = 3;
            // 
            // dgvWithdrawals
            // 
            this.dgvWithdrawals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWithdrawals.Location = new System.Drawing.Point(22, 491);
            this.dgvWithdrawals.Name = "dgvWithdrawals";
            this.dgvWithdrawals.RowTemplate.Height = 25;
            this.dgvWithdrawals.Size = new System.Drawing.Size(659, 150);
            this.dgvWithdrawals.TabIndex = 4;
            // 
            // lblDisplayedID
            // 
            this.lblDisplayedID.AutoSize = true;
            this.lblDisplayedID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayedID.Location = new System.Drawing.Point(476, 25);
            this.lblDisplayedID.Name = "lblDisplayedID";
            this.lblDisplayedID.Size = new System.Drawing.Size(25, 21);
            this.lblDisplayedID.TabIndex = 5;
            this.lblDisplayedID.Text = "ID";
            // 
            // lblDisplayedAge
            // 
            this.lblDisplayedAge.AutoSize = true;
            this.lblDisplayedAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayedAge.Location = new System.Drawing.Point(472, 215);
            this.lblDisplayedAge.Name = "lblDisplayedAge";
            this.lblDisplayedAge.Size = new System.Drawing.Size(37, 21);
            this.lblDisplayedAge.TabIndex = 5;
            this.lblDisplayedAge.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 660);
            this.Controls.Add(this.lblDisplayedAge);
            this.Controls.Add(this.lblDisplayedID);
            this.Controls.Add(this.dgvWithdrawals);
            this.Controls.Add(this.dgvDeposits);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lstbxCustomers);
            this.Name = "Form1";
            this.Text = "Banking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstbxCustomers;
        private Label lblID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblSSN;
        private Label lblDateOfBirth;
        private Label lblAge;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSSN;
        private TextBox txtDOB;
        private DataGridView dgvDeposits;
        private DataGridView dgvWithdrawals;
        private Label lblDisplayedID;
        private Label lblDisplayedAge;
    }
}