namespace demo
{
    partial class frmManageTicket
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
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Utilisateur,
            this.subject,
            this.priority,
            this.nbMessages,
            this.status});
            this.dgvTickets.Location = new System.Drawing.Point(12, 12);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersWidth = 62;
            this.dgvTickets.RowTemplate.Height = 28;
            this.dgvTickets.Size = new System.Drawing.Size(1331, 506);
            this.dgvTickets.TabIndex = 1;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // Utilisateur
            // 
            this.Utilisateur.HeaderText = "user";
            this.Utilisateur.MinimumWidth = 8;
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.ReadOnly = true;
            this.Utilisateur.Width = 150;
            // 
            // subject
            // 
            this.subject.HeaderText = "Sujet";
            this.subject.MinimumWidth = 8;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Width = 150;
            // 
            // priority
            // 
            this.priority.HeaderText = "Priorité";
            this.priority.MinimumWidth = 8;
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            this.priority.Width = 150;
            // 
            // nbMessages
            // 
            this.nbMessages.HeaderText = "Nb. Messages";
            this.nbMessages.MinimumWidth = 8;
            this.nbMessages.Name = "nbMessages";
            this.nbMessages.ReadOnly = true;
            this.nbMessages.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Statut";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 150;
            // 
            // frmManageTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1365, 532);
            this.Controls.Add(this.dgvTickets);
            this.Name = "frmManageTicket";
            this.Text = "Gestion des tickets";
            this.Load += new System.EventHandler(this.frmManageTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}