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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDetails));
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpUsersDetails = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dgvUserTickets = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpUserTickets = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.grpUsersDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTickets)).BeginInit();
            this.grpUserTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(186, 43);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(227, 26);
            this.txtFirstname.TabIndex = 2;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(186, 104);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(227, 26);
            this.txtLastname.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // grpUsersDetails
            // 
            this.grpUsersDetails.Controls.Add(this.lblPasswordConfirm);
            this.grpUsersDetails.Controls.Add(this.txtPasswordConfirm);
            this.grpUsersDetails.Controls.Add(this.lblPassword);
            this.grpUsersDetails.Controls.Add(this.txtPassword);
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
            this.grpUsersDetails.Location = new System.Drawing.Point(12, 21);
            this.grpUsersDetails.Name = "grpUsersDetails";
            this.grpUsersDetails.Size = new System.Drawing.Size(436, 523);
            this.grpUsersDetails.TabIndex = 0;
            this.grpUsersDetails.TabStop = false;
            this.grpUsersDetails.Text = "Informations";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(128, 440);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(178, 52);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "&Créer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 440);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 52);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Admin",
            "Support",
            "User"});
            this.cboRole.Location = new System.Drawing.Point(186, 228);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(227, 28);
            this.cboRole.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(19, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 52);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Mettre à jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(54, 232);
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
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(54, 107);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(42, 20);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Nom";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(54, 46);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(64, 20);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Prénom";
            // 
            // dgvUserTickets
            // 
            this.dgvUserTickets.AllowUserToAddRows = false;
            this.dgvUserTickets.AllowUserToDeleteRows = false;
            this.dgvUserTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUserTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subject,
            this.priority,
            this.nbMessages,
            this.status,
            this.evaluation});
            this.dgvUserTickets.Location = new System.Drawing.Point(16, 22);
            this.dgvUserTickets.Name = "dgvUserTickets";
            this.dgvUserTickets.ReadOnly = true;
            this.dgvUserTickets.RowHeadersWidth = 62;
            this.dgvUserTickets.RowTemplate.Height = 28;
            this.dgvUserTickets.Size = new System.Drawing.Size(815, 483);
            this.dgvUserTickets.TabIndex = 17;
            this.dgvUserTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserTickets_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 59;
            // 
            // subject
            // 
            this.subject.HeaderText = "Sujet";
            this.subject.MinimumWidth = 8;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Width = 82;
            // 
            // priority
            // 
            this.priority.HeaderText = "Priorité";
            this.priority.MinimumWidth = 8;
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            this.priority.Width = 94;
            // 
            // nbMessages
            // 
            this.nbMessages.HeaderText = "Nb. messages";
            this.nbMessages.MinimumWidth = 8;
            this.nbMessages.Name = "nbMessages";
            this.nbMessages.ReadOnly = true;
            this.nbMessages.Width = 146;
            // 
            // status
            // 
            this.status.HeaderText = "Statut";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 89;
            // 
            // evaluation
            // 
            this.evaluation.HeaderText = "Evaluation";
            this.evaluation.MinimumWidth = 8;
            this.evaluation.Name = "evaluation";
            this.evaluation.ReadOnly = true;
            this.evaluation.Width = 119;
            // 
            // grpUserTickets
            // 
            this.grpUserTickets.Controls.Add(this.dgvUserTickets);
            this.grpUserTickets.Location = new System.Drawing.Point(464, 21);
            this.grpUserTickets.Name = "grpUserTickets";
            this.grpUserTickets.Size = new System.Drawing.Size(852, 523);
            this.grpUserTickets.TabIndex = 16;
            this.grpUserTickets.TabStop = false;
            this.grpUserTickets.Text = "Tickets";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(54, 291);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Mot de passe";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(186, 288);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 26);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(54, 345);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(99, 20);
            this.lblPasswordConfirm.TabIndex = 11;
            this.lblPasswordConfirm.Text = "Confirmation";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(186, 342);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(227, 26);
            this.txtPasswordConfirm.TabIndex = 12;
            this.txtPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1334, 556);
            this.Controls.Add(this.grpUserTickets);
            this.Controls.Add(this.grpUsersDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserDetails";
            this.Text = "Détails de l\'utilisateur";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.grpUsersDetails.ResumeLayout(false);
            this.grpUsersDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTickets)).EndInit();
            this.grpUserTickets.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvUserTickets;
        private System.Windows.Forms.GroupBox grpUserTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluation;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}