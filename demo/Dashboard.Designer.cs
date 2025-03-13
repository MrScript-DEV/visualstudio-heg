namespace demo
{
    partial class frmDashboard
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiManageTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblOpenTickets = new System.Windows.Forms.Label();
            this.lblClosedTickets = new System.Windows.Forms.Label();
            this.lblNbTicketsOpen = new System.Windows.Forms.Label();
            this.lblNbTicketsClose = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageTickets,
            this.tsmiManageUsers,
            this.tsmiManageRoles});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 33);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            this.msMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmiManageTickets
            // 
            this.tsmiManageTickets.Name = "tsmiManageTickets";
            this.tsmiManageTickets.Size = new System.Drawing.Size(176, 29);
            this.tsmiManageTickets.Text = "Gestion des tickets";
            this.tsmiManageTickets.Click += new System.EventHandler(this.gestionDesTicketsToolStripMenuItem_Click);
            // 
            // tsmiManageUsers
            // 
            this.tsmiManageUsers.Name = "tsmiManageUsers";
            this.tsmiManageUsers.Size = new System.Drawing.Size(210, 29);
            this.tsmiManageUsers.Text = "Gestion des utilisateurs";
            this.tsmiManageUsers.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem_Click);
            // 
            // tsmiManageRoles
            // 
            this.tsmiManageRoles.Name = "tsmiManageRoles";
            this.tsmiManageRoles.Size = new System.Drawing.Size(164, 29);
            this.tsmiManageRoles.Text = "Gestion des roles";
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblNbTicketsClose);
            this.grpStats.Controls.Add(this.lblNbTicketsOpen);
            this.grpStats.Controls.Add(this.lblClosedTickets);
            this.grpStats.Controls.Add(this.lblOpenTickets);
            this.grpStats.Location = new System.Drawing.Point(40, 54);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(360, 235);
            this.grpStats.TabIndex = 1;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Statistiques";
            this.grpStats.Enter += new System.EventHandler(this.grpStats_Enter);
            // 
            // lblOpenTickets
            // 
            this.lblOpenTickets.AutoSize = true;
            this.lblOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOpenTickets.Location = new System.Drawing.Point(25, 66);
            this.lblOpenTickets.Name = "lblOpenTickets";
            this.lblOpenTickets.Size = new System.Drawing.Size(187, 29);
            this.lblOpenTickets.TabIndex = 0;
            this.lblOpenTickets.Text = "Tickets ouverts :";
            this.lblOpenTickets.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClosedTickets
            // 
            this.lblClosedTickets.AutoSize = true;
            this.lblClosedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClosedTickets.Location = new System.Drawing.Point(25, 169);
            this.lblClosedTickets.Name = "lblClosedTickets";
            this.lblClosedTickets.Size = new System.Drawing.Size(183, 29);
            this.lblClosedTickets.TabIndex = 1;
            this.lblClosedTickets.Text = "Tickets fermés :";
            // 
            // lblNbTicketsOpen
            // 
            this.lblNbTicketsOpen.AutoSize = true;
            this.lblNbTicketsOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbTicketsOpen.Location = new System.Drawing.Point(261, 66);
            this.lblNbTicketsOpen.Name = "lblNbTicketsOpen";
            this.lblNbTicketsOpen.Size = new System.Drawing.Size(39, 29);
            this.lblNbTicketsOpen.TabIndex = 2;
            this.lblNbTicketsOpen.Text = "24";
            // 
            // lblNbTicketsClose
            // 
            this.lblNbTicketsClose.AutoSize = true;
            this.lblNbTicketsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbTicketsClose.Location = new System.Drawing.Point(261, 169);
            this.lblNbTicketsClose.Name = "lblNbTicketsClose";
            this.lblNbTicketsClose.Size = new System.Drawing.Size(52, 29);
            this.lblNbTicketsClose.TabIndex = 3;
            this.lblNbTicketsClose.Text = "240";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageTickets;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageRoles;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblOpenTickets;
        private System.Windows.Forms.Label lblClosedTickets;
        private System.Windows.Forms.Label lblNbTicketsClose;
        private System.Windows.Forms.Label lblNbTicketsOpen;
    }
}