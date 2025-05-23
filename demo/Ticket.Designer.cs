﻿namespace demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicket));
            this.grpTicketInfo = new System.Windows.Forms.GroupBox();
            this.cboEvaluation = new System.Windows.Forms.ComboBox();
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.txtLastnameUser = new System.Windows.Forms.TextBox();
            this.txtFirstnameUser = new System.Windows.Forms.TextBox();
            this.lblLastnameUser = new System.Windows.Forms.Label();
            this.lblFirstnameUser = new System.Windows.Forms.Label();
            this.grpSupportInfo = new System.Windows.Forms.GroupBox();
            this.lblChangeSupportAgent = new System.Windows.Forms.Label();
            this.cboSupportAgent = new System.Windows.Forms.ComboBox();
            this.txtLastnameSupport = new System.Windows.Forms.TextBox();
            this.lblLastnameSupport = new System.Windows.Forms.Label();
            this.txtFirstnameSupport = new System.Windows.Forms.TextBox();
            this.lblSupportFirstname = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpMessages = new System.Windows.Forms.GroupBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.grpTicketInfo.SuspendLayout();
            this.grpUser.SuspendLayout();
            this.grpSupportInfo.SuspendLayout();
            this.grpMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTicketInfo
            // 
            this.grpTicketInfo.Controls.Add(this.cboEvaluation);
            this.grpTicketInfo.Controls.Add(this.lblEvaluation);
            this.grpTicketInfo.Controls.Add(this.cboStatus);
            this.grpTicketInfo.Controls.Add(this.btnUpdate);
            this.grpTicketInfo.Controls.Add(this.cboPriority);
            this.grpTicketInfo.Controls.Add(this.txtSubject);
            this.grpTicketInfo.Controls.Add(this.lblStatus);
            this.grpTicketInfo.Controls.Add(this.lblPriority);
            this.grpTicketInfo.Controls.Add(this.lblSubject);
            this.grpTicketInfo.Controls.Add(this.grpUser);
            this.grpTicketInfo.Controls.Add(this.grpSupportInfo);
            this.grpTicketInfo.Location = new System.Drawing.Point(12, 46);
            this.grpTicketInfo.Name = "grpTicketInfo";
            this.grpTicketInfo.Size = new System.Drawing.Size(834, 346);
            this.grpTicketInfo.TabIndex = 0;
            this.grpTicketInfo.TabStop = false;
            this.grpTicketInfo.Text = "Informations";
            this.grpTicketInfo.Enter += new System.EventHandler(this.grpTicketInfo_Enter);
            // 
            // cboEvaluation
            // 
            this.cboEvaluation.Enabled = false;
            this.cboEvaluation.FormattingEnabled = true;
            this.cboEvaluation.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboEvaluation.Location = new System.Drawing.Point(677, 80);
            this.cboEvaluation.Name = "cboEvaluation";
            this.cboEvaluation.Size = new System.Drawing.Size(139, 28);
            this.cboEvaluation.TabIndex = 9;
            this.cboEvaluation.SelectedIndexChanged += new System.EventHandler(this.cboEvaluation_SelectedIndexChanged);
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Location = new System.Drawing.Point(588, 84);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(83, 20);
            this.lblEvaluation.TabIndex = 8;
            this.lblEvaluation.Text = "Evaluation";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "En attente",
            "Ouvert",
            "Fermé"});
            this.cboStatus.Location = new System.Drawing.Point(388, 80);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(127, 28);
            this.cboStatus.TabIndex = 7;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(654, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Mettre à jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboPriority
            // 
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Items.AddRange(new object[] {
            "Faible",
            "Moyenne",
            "Élevé"});
            this.cboPriority.Location = new System.Drawing.Point(87, 80);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(139, 28);
            this.cboPriority.TabIndex = 5;
            this.cboPriority.SelectedIndexChanged += new System.EventHandler(this.cboPriority_SelectedIndexChanged);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(87, 37);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(557, 26);
            this.txtSubject.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(329, 84);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Statut";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(24, 84);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(58, 20);
            this.lblPriority.TabIndex = 4;
            this.lblPriority.Text = "Priorité";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(24, 40);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 20);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Sujet";
            this.lblSubject.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.txtLastnameUser);
            this.grpUser.Controls.Add(this.txtFirstnameUser);
            this.grpUser.Controls.Add(this.lblLastnameUser);
            this.grpUser.Controls.Add(this.lblFirstnameUser);
            this.grpUser.Location = new System.Drawing.Point(438, 150);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(381, 162);
            this.grpUser.TabIndex = 18;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Utilisateur";
            // 
            // txtLastnameUser
            // 
            this.txtLastnameUser.Location = new System.Drawing.Point(123, 78);
            this.txtLastnameUser.Name = "txtLastnameUser";
            this.txtLastnameUser.ReadOnly = true;
            this.txtLastnameUser.Size = new System.Drawing.Size(237, 26);
            this.txtLastnameUser.TabIndex = 22;
            // 
            // txtFirstnameUser
            // 
            this.txtFirstnameUser.Location = new System.Drawing.Point(123, 39);
            this.txtFirstnameUser.Name = "txtFirstnameUser";
            this.txtFirstnameUser.ReadOnly = true;
            this.txtFirstnameUser.Size = new System.Drawing.Size(237, 26);
            this.txtFirstnameUser.TabIndex = 20;
            // 
            // lblLastnameUser
            // 
            this.lblLastnameUser.AutoSize = true;
            this.lblLastnameUser.Location = new System.Drawing.Point(25, 81);
            this.lblLastnameUser.Name = "lblLastnameUser";
            this.lblLastnameUser.Size = new System.Drawing.Size(42, 20);
            this.lblLastnameUser.TabIndex = 21;
            this.lblLastnameUser.Text = "Nom";
            // 
            // lblFirstnameUser
            // 
            this.lblFirstnameUser.AutoSize = true;
            this.lblFirstnameUser.Location = new System.Drawing.Point(25, 42);
            this.lblFirstnameUser.Name = "lblFirstnameUser";
            this.lblFirstnameUser.Size = new System.Drawing.Size(64, 20);
            this.lblFirstnameUser.TabIndex = 19;
            this.lblFirstnameUser.Text = "Prénom";
            // 
            // grpSupportInfo
            // 
            this.grpSupportInfo.Controls.Add(this.lblChangeSupportAgent);
            this.grpSupportInfo.Controls.Add(this.cboSupportAgent);
            this.grpSupportInfo.Controls.Add(this.txtLastnameSupport);
            this.grpSupportInfo.Controls.Add(this.lblLastnameSupport);
            this.grpSupportInfo.Controls.Add(this.txtFirstnameSupport);
            this.grpSupportInfo.Controls.Add(this.lblSupportFirstname);
            this.grpSupportInfo.Location = new System.Drawing.Point(18, 150);
            this.grpSupportInfo.Name = "grpSupportInfo";
            this.grpSupportInfo.Size = new System.Drawing.Size(378, 162);
            this.grpSupportInfo.TabIndex = 10;
            this.grpSupportInfo.TabStop = false;
            this.grpSupportInfo.Text = "Support";
            // 
            // lblChangeSupportAgent
            // 
            this.lblChangeSupportAgent.AutoSize = true;
            this.lblChangeSupportAgent.Location = new System.Drawing.Point(15, 42);
            this.lblChangeSupportAgent.Name = "lblChangeSupportAgent";
            this.lblChangeSupportAgent.Size = new System.Drawing.Size(65, 20);
            this.lblChangeSupportAgent.TabIndex = 11;
            this.lblChangeSupportAgent.Text = "Attribué";
            // 
            // cboSupportAgent
            // 
            this.cboSupportAgent.FormattingEnabled = true;
            this.cboSupportAgent.Location = new System.Drawing.Point(110, 38);
            this.cboSupportAgent.Name = "cboSupportAgent";
            this.cboSupportAgent.Size = new System.Drawing.Size(237, 28);
            this.cboSupportAgent.TabIndex = 12;
            this.cboSupportAgent.SelectedIndexChanged += new System.EventHandler(this.cboSupportAgent_SelectedIndexChanged);
            // 
            // txtLastnameSupport
            // 
            this.txtLastnameSupport.Location = new System.Drawing.Point(110, 117);
            this.txtLastnameSupport.Name = "txtLastnameSupport";
            this.txtLastnameSupport.ReadOnly = true;
            this.txtLastnameSupport.Size = new System.Drawing.Size(237, 26);
            this.txtLastnameSupport.TabIndex = 16;
            // 
            // lblLastnameSupport
            // 
            this.lblLastnameSupport.AutoSize = true;
            this.lblLastnameSupport.Location = new System.Drawing.Point(15, 120);
            this.lblLastnameSupport.Name = "lblLastnameSupport";
            this.lblLastnameSupport.Size = new System.Drawing.Size(42, 20);
            this.lblLastnameSupport.TabIndex = 15;
            this.lblLastnameSupport.Text = "Nom";
            // 
            // txtFirstnameSupport
            // 
            this.txtFirstnameSupport.Location = new System.Drawing.Point(110, 78);
            this.txtFirstnameSupport.Name = "txtFirstnameSupport";
            this.txtFirstnameSupport.ReadOnly = true;
            this.txtFirstnameSupport.Size = new System.Drawing.Size(237, 26);
            this.txtFirstnameSupport.TabIndex = 14;
            // 
            // lblSupportFirstname
            // 
            this.lblSupportFirstname.AutoSize = true;
            this.lblSupportFirstname.Location = new System.Drawing.Point(15, 81);
            this.lblSupportFirstname.Name = "lblSupportFirstname";
            this.lblSupportFirstname.Size = new System.Drawing.Size(64, 20);
            this.lblSupportFirstname.TabIndex = 13;
            this.lblSupportFirstname.Text = "Prénom";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(662, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 31);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "&Supprimer le ticket";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpMessages
            // 
            this.grpMessages.Controls.Add(this.btnEnvoyer);
            this.grpMessages.Controls.Add(this.txtMessage);
            this.grpMessages.Controls.Add(this.lblMessage);
            this.grpMessages.Controls.Add(this.lstMessages);
            this.grpMessages.Location = new System.Drawing.Point(12, 427);
            this.grpMessages.Name = "grpMessages";
            this.grpMessages.Size = new System.Drawing.Size(834, 362);
            this.grpMessages.TabIndex = 23;
            this.grpMessages.TabStop = false;
            this.grpMessages.Text = "Messages";
            this.grpMessages.Enter += new System.EventHandler(this.grpMessages_Enter);
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(677, 299);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(145, 31);
            this.btnEnvoyer.TabIndex = 27;
            this.btnEnvoyer.Text = "&Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(98, 301);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(577, 26);
            this.txtMessage.TabIndex = 26;
            this.txtMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(18, 304);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(74, 20);
            this.lblMessage.TabIndex = 25;
            this.lblMessage.Text = "Message";
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 20;
            this.lstMessages.Location = new System.Drawing.Point(18, 39);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(801, 224);
            this.lstMessages.TabIndex = 24;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(885, 809);
            this.Controls.Add(this.grpMessages);
            this.Controls.Add(this.grpTicketInfo);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTicket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            this.grpTicketInfo.ResumeLayout(false);
            this.grpTicketInfo.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grpSupportInfo.ResumeLayout(false);
            this.grpSupportInfo.PerformLayout();
            this.grpMessages.ResumeLayout(false);
            this.grpMessages.PerformLayout();
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
        private System.Windows.Forms.Label lblChangeSupportAgent;
        private System.Windows.Forms.ComboBox cboSupportAgent;
        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.ComboBox cboEvaluation;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnEnvoyer;
    }
}