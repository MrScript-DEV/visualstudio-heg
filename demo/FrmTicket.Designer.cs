namespace demo
{
    partial class frmTicket
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
            this.grpTicketInfo = new System.Windows.Forms.GroupBox();
            this.grpSupportInfo = new System.Windows.Forms.GroupBox();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.lblSupportFirstname = new System.Windows.Forms.Label();
            this.lblLastnameSupport = new System.Windows.Forms.Label();
            this.lblFirstnameUser = new System.Windows.Forms.Label();
            this.lblLastnameUser = new System.Windows.Forms.Label();
            this.txtFirstnameUser = new System.Windows.Forms.TextBox();
            this.txtLastnameUser = new System.Windows.Forms.TextBox();
            this.txtLastnameSupport = new System.Windows.Forms.TextBox();
            this.txtFirstnameSupport = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpMessages = new System.Windows.Forms.GroupBox();
            this.cboSupportAgent = new System.Windows.Forms.ComboBox();
            this.lblChangeSupport = new System.Windows.Forms.Label();
            this.grpTicketInfo.SuspendLayout();
            this.grpSupportInfo.SuspendLayout();
            this.grpUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTicketInfo
            // 
            this.grpTicketInfo.Controls.Add(this.btnDelete);
            this.grpTicketInfo.Controls.Add(this.cboStatus);
            this.grpTicketInfo.Controls.Add(this.btnUpdate);
            this.grpTicketInfo.Controls.Add(this.cboPriority);
            this.grpTicketInfo.Controls.Add(this.txtSubject);
            this.grpTicketInfo.Controls.Add(this.lblStatus);
            this.grpTicketInfo.Controls.Add(this.lblPriority);
            this.grpTicketInfo.Controls.Add(this.lblSubject);
            this.grpTicketInfo.Controls.Add(this.grpUser);
            this.grpTicketInfo.Controls.Add(this.grpSupportInfo);
            this.grpTicketInfo.Location = new System.Drawing.Point(12, 12);
            this.grpTicketInfo.Name = "grpTicketInfo";
            this.grpTicketInfo.Size = new System.Drawing.Size(834, 286);
            this.grpTicketInfo.TabIndex = 0;
            this.grpTicketInfo.TabStop = false;
            this.grpTicketInfo.Text = "Informations";
            this.grpTicketInfo.Enter += new System.EventHandler(this.grpTicketInfo_Enter);
            // 
            // grpSupportInfo
            // 
            this.grpSupportInfo.Controls.Add(this.lblChangeSupport);
            this.grpSupportInfo.Controls.Add(this.cboSupportAgent);
            this.grpSupportInfo.Controls.Add(this.txtLastnameSupport);
            this.grpSupportInfo.Controls.Add(this.lblLastnameSupport);
            this.grpSupportInfo.Controls.Add(this.txtFirstnameSupport);
            this.grpSupportInfo.Controls.Add(this.lblSupportFirstname);
            this.grpSupportInfo.Location = new System.Drawing.Point(18, 87);
            this.grpSupportInfo.Name = "grpSupportInfo";
            this.grpSupportInfo.Size = new System.Drawing.Size(378, 162);
            this.grpSupportInfo.TabIndex = 0;
            this.grpSupportInfo.TabStop = false;
            this.grpSupportInfo.Text = "Support";
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.txtLastnameUser);
            this.grpUser.Controls.Add(this.txtFirstnameUser);
            this.grpUser.Controls.Add(this.lblLastnameUser);
            this.grpUser.Controls.Add(this.lblFirstnameUser);
            this.grpUser.Location = new System.Drawing.Point(438, 126);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(381, 123);
            this.grpUser.TabIndex = 1;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Utilisateur";
            // 
            // lblSupportFirstname
            // 
            this.lblSupportFirstname.AutoSize = true;
            this.lblSupportFirstname.Location = new System.Drawing.Point(15, 82);
            this.lblSupportFirstname.Name = "lblSupportFirstname";
            this.lblSupportFirstname.Size = new System.Drawing.Size(64, 20);
            this.lblSupportFirstname.TabIndex = 0;
            this.lblSupportFirstname.Text = "Prénom";
            // 
            // lblLastnameSupport
            // 
            this.lblLastnameSupport.AutoSize = true;
            this.lblLastnameSupport.Location = new System.Drawing.Point(15, 123);
            this.lblLastnameSupport.Name = "lblLastnameSupport";
            this.lblLastnameSupport.Size = new System.Drawing.Size(42, 20);
            this.lblLastnameSupport.TabIndex = 1;
            this.lblLastnameSupport.Text = "Nom";
            // 
            // lblFirstnameUser
            // 
            this.lblFirstnameUser.AutoSize = true;
            this.lblFirstnameUser.Location = new System.Drawing.Point(25, 43);
            this.lblFirstnameUser.Name = "lblFirstnameUser";
            this.lblFirstnameUser.Size = new System.Drawing.Size(64, 20);
            this.lblFirstnameUser.TabIndex = 2;
            this.lblFirstnameUser.Text = "Prénom";
            // 
            // lblLastnameUser
            // 
            this.lblLastnameUser.AutoSize = true;
            this.lblLastnameUser.Location = new System.Drawing.Point(25, 84);
            this.lblLastnameUser.Name = "lblLastnameUser";
            this.lblLastnameUser.Size = new System.Drawing.Size(42, 20);
            this.lblLastnameUser.TabIndex = 2;
            this.lblLastnameUser.Text = "Nom";
            // 
            // txtFirstnameUser
            // 
            this.txtFirstnameUser.Location = new System.Drawing.Point(123, 43);
            this.txtFirstnameUser.Name = "txtFirstnameUser";
            this.txtFirstnameUser.ReadOnly = true;
            this.txtFirstnameUser.Size = new System.Drawing.Size(237, 26);
            this.txtFirstnameUser.TabIndex = 4;
            this.txtFirstnameUser.Text = "Paul";
            // 
            // txtLastnameUser
            // 
            this.txtLastnameUser.Location = new System.Drawing.Point(123, 78);
            this.txtLastnameUser.Name = "txtLastnameUser";
            this.txtLastnameUser.ReadOnly = true;
            this.txtLastnameUser.Size = new System.Drawing.Size(237, 26);
            this.txtLastnameUser.TabIndex = 5;
            this.txtLastnameUser.Text = "Blade";
            // 
            // txtLastnameSupport
            // 
            this.txtLastnameSupport.Location = new System.Drawing.Point(110, 117);
            this.txtLastnameSupport.Name = "txtLastnameSupport";
            this.txtLastnameSupport.ReadOnly = true;
            this.txtLastnameSupport.Size = new System.Drawing.Size(237, 26);
            this.txtLastnameSupport.TabIndex = 7;
            this.txtLastnameSupport.Text = "Evans";
            // 
            // txtFirstnameSupport
            // 
            this.txtFirstnameSupport.Location = new System.Drawing.Point(110, 82);
            this.txtFirstnameSupport.Name = "txtFirstnameSupport";
            this.txtFirstnameSupport.ReadOnly = true;
            this.txtFirstnameSupport.Size = new System.Drawing.Size(237, 26);
            this.txtFirstnameSupport.TabIndex = 6;
            this.txtFirstnameSupport.Text = "Mark";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(24, 43);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 20);
            this.lblSubject.TabIndex = 8;
            this.lblSubject.Text = "Sujet";
            this.lblSubject.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(434, 43);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(58, 20);
            this.lblPriority.TabIndex = 9;
            this.lblPriority.Text = "Priorité";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(643, 43);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Statut";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(87, 40);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(309, 26);
            this.txtSubject.TabIndex = 8;
            // 
            // cboPriority
            // 
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Items.AddRange(new object[] {
            "Faible",
            "Moyenne",
            "Élevé"});
            this.cboPriority.Location = new System.Drawing.Point(498, 38);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(139, 28);
            this.cboPriority.TabIndex = 11;
            this.cboPriority.SelectedIndexChanged += new System.EventHandler(this.cboPriority_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "En attente",
            "Ouvert",
            "Fermé"});
            this.cboStatus.Location = new System.Drawing.Point(701, 38);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(127, 28);
            this.cboStatus.TabIndex = 12;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(438, 87);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Mettre à jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(635, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grpMessages
            // 
            this.grpMessages.Location = new System.Drawing.Point(12, 313);
            this.grpMessages.Name = "grpMessages";
            this.grpMessages.Size = new System.Drawing.Size(834, 283);
            this.grpMessages.TabIndex = 1;
            this.grpMessages.TabStop = false;
            this.grpMessages.Text = "Messages";
            this.grpMessages.Enter += new System.EventHandler(this.grpMessages_Enter);
            // 
            // cboSupportAgent
            // 
            this.cboSupportAgent.FormattingEnabled = true;
            this.cboSupportAgent.Items.AddRange(new object[] {
            "Mark Evans",
            "Martin Lupin",
            "Samir Henry"});
            this.cboSupportAgent.Location = new System.Drawing.Point(110, 39);
            this.cboSupportAgent.Name = "cboSupportAgent";
            this.cboSupportAgent.Size = new System.Drawing.Size(237, 28);
            this.cboSupportAgent.TabIndex = 14;
            // 
            // lblChangeSupport
            // 
            this.lblChangeSupport.AutoSize = true;
            this.lblChangeSupport.Location = new System.Drawing.Point(15, 42);
            this.lblChangeSupport.Name = "lblChangeSupport";
            this.lblChangeSupport.Size = new System.Drawing.Size(65, 20);
            this.lblChangeSupport.TabIndex = 15;
            this.lblChangeSupport.Text = "Attribué";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(864, 621);
            this.Controls.Add(this.grpMessages);
            this.Controls.Add(this.grpTicketInfo);
            this.Name = "frmTicket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            this.grpTicketInfo.ResumeLayout(false);
            this.grpTicketInfo.PerformLayout();
            this.grpSupportInfo.ResumeLayout(false);
            this.grpSupportInfo.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTicketInfo;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.GroupBox grpSupportInfo;
        private System.Windows.Forms.Label lblLastnameUser;
        private System.Windows.Forms.Label lblFirstnameUser;
        private System.Windows.Forms.Label lblLastnameSupport;
        private System.Windows.Forms.Label lblSupportFirstname;
        private System.Windows.Forms.TextBox txtLastnameUser;
        private System.Windows.Forms.TextBox txtFirstnameUser;
        private System.Windows.Forms.TextBox txtLastnameSupport;
        private System.Windows.Forms.TextBox txtFirstnameSupport;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpMessages;
        private System.Windows.Forms.Label lblChangeSupport;
        private System.Windows.Forms.ComboBox cboSupportAgent;
    }
}