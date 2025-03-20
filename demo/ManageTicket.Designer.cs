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
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.user,
            this.subject,
            this.priority,
            this.nbMessages,
            this.status,
            this.evaluation});
            this.dgvTickets.Location = new System.Drawing.Point(12, 12);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersWidth = 62;
            this.dgvTickets.RowTemplate.Height = 28;
            this.dgvTickets.Size = new System.Drawing.Size(921, 656);
            this.dgvTickets.TabIndex = 1;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 59;
            // 
            // user
            // 
            this.user.HeaderText = "Utilisateur";
            this.user.MinimumWidth = 8;
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 116;
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
            this.nbMessages.HeaderText = "Nb. Messages";
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
            // frmManageTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(955, 682);
            this.Controls.Add(this.dgvTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmManageTicket";
            this.Text = "Gestion des tickets";
            this.Load += new System.EventHandler(this.frmManageTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluation;
    }
}