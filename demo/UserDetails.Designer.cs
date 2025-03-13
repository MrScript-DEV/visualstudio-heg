namespace demo
{
    partial class frmUserDetails
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
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpUsersDetails = new System.Windows.Forms.GroupBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpUsersDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(186, 43);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(227, 26);
            this.txtFirstname.TabIndex = 0;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(186, 104);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(227, 26);
            this.txtLastname.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // grpUsersDetails
            // 
            this.grpUsersDetails.Controls.Add(this.btnCreate);
            this.grpUsersDetails.Controls.Add(this.btnDelete);
            this.grpUsersDetails.Controls.Add(this.cboRole);
            this.grpUsersDetails.Controls.Add(this.btnUpdate);
            this.grpUsersDetails.Controls.Add(this.lblRole);
            this.grpUsersDetails.Controls.Add(this.lblEmail);
            this.grpUsersDetails.Controls.Add(this.lblLastname);
            this.grpUsersDetails.Controls.Add(this.lblFirstname);
            this.grpUsersDetails.Controls.Add(this.txtFirstname);
            this.grpUsersDetails.Controls.Add(this.txtLastname);
            this.grpUsersDetails.Controls.Add(this.txtEmail);
            this.grpUsersDetails.Location = new System.Drawing.Point(44, 30);
            this.grpUsersDetails.Name = "grpUsersDetails";
            this.grpUsersDetails.Size = new System.Drawing.Size(436, 386);
            this.grpUsersDetails.TabIndex = 4;
            this.grpUsersDetails.TabStop = false;
            this.grpUsersDetails.Text = "Informations";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(54, 231);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 20);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Rôle";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(54, 172);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(54, 107);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(42, 20);
            this.lblLastname.TabIndex = 5;
            this.lblLastname.Text = "Nom";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(54, 46);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(64, 20);
            this.lblFirstname.TabIndex = 4;
            this.lblFirstname.Text = "Prénom";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(24, 306);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 52);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Mettre à jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Admin",
            "Support",
            "Utilisateur"});
            this.cboRole.Location = new System.Drawing.Point(186, 228);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(227, 28);
            this.cboRole.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 52);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(133, 306);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(178, 52);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Créer";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.grpUsersDetails);
            this.Name = "frmUserDetails";
            this.Text = "Détails de l\'utilisateur";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.grpUsersDetails.ResumeLayout(false);
            this.grpUsersDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpUsersDetails;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
    }
}