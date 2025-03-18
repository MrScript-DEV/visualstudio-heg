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
            this.lblNbPendingTickets = new System.Windows.Forms.Label();
            this.lblPendingTickets = new System.Windows.Forms.Label();
            this.lblNbCloseTickets = new System.Windows.Forms.Label();
            this.lblNbOpenTickets = new System.Windows.Forms.Label();
            this.lblClosedTickets = new System.Windows.Forms.Label();
            this.lblOpenTickets = new System.Windows.Forms.Label();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.lblNbSupport = new System.Windows.Forms.Label();
            this.lblSupport = new System.Windows.Forms.Label();
            this.lblNbUsers = new System.Windows.Forms.Label();
            this.lblNbAdmin = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.msMenu.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.grpUsers.SuspendLayout();
            this.tlpDashboard.SuspendLayout();
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
            this.msMenu.Size = new System.Drawing.Size(800, 36);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            this.msMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmiManageTickets
            // 
            this.tsmiManageTickets.Name = "tsmiManageTickets";
            this.tsmiManageTickets.Size = new System.Drawing.Size(176, 30);
            this.tsmiManageTickets.Text = "Gestion des tickets";
            this.tsmiManageTickets.Click += new System.EventHandler(this.gestionDesTicketsToolStripMenuItem_Click);
            // 
            // tsmiManageUsers
            // 
            this.tsmiManageUsers.Name = "tsmiManageUsers";
            this.tsmiManageUsers.Size = new System.Drawing.Size(210, 30);
            this.tsmiManageUsers.Text = "Gestion des utilisateurs";
            this.tsmiManageUsers.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem_Click);
            // 
            // tsmiManageRoles
            // 
            this.tsmiManageRoles.Name = "tsmiManageRoles";
            this.tsmiManageRoles.Size = new System.Drawing.Size(164, 30);
            this.tsmiManageRoles.Text = "Gestion des roles";
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblNbPendingTickets);
            this.grpStats.Controls.Add(this.lblPendingTickets);
            this.grpStats.Controls.Add(this.lblNbCloseTickets);
            this.grpStats.Controls.Add(this.lblNbOpenTickets);
            this.grpStats.Controls.Add(this.lblClosedTickets);
            this.grpStats.Controls.Add(this.lblOpenTickets);
            this.grpStats.Location = new System.Drawing.Point(3, 3);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(360, 235);
            this.grpStats.TabIndex = 1;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Statistiques";
            this.grpStats.Enter += new System.EventHandler(this.grpStats_Enter);
            // 
            // lblNbPendingTickets
            // 
            this.lblNbPendingTickets.AutoSize = true;
            this.lblNbPendingTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbPendingTickets.Location = new System.Drawing.Point(261, 121);
            this.lblNbPendingTickets.Name = "lblNbPendingTickets";
            this.lblNbPendingTickets.Size = new System.Drawing.Size(39, 29);
            this.lblNbPendingTickets.TabIndex = 5;
            this.lblNbPendingTickets.Text = "24";
            // 
            // lblPendingTickets
            // 
            this.lblPendingTickets.AutoSize = true;
            this.lblPendingTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPendingTickets.Location = new System.Drawing.Point(25, 121);
            this.lblPendingTickets.Name = "lblPendingTickets";
            this.lblPendingTickets.Size = new System.Drawing.Size(214, 29);
            this.lblPendingTickets.TabIndex = 4;
            this.lblPendingTickets.Text = "Tickets en attente :";
            // 
            // lblNbCloseTickets
            // 
            this.lblNbCloseTickets.AutoSize = true;
            this.lblNbCloseTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbCloseTickets.Location = new System.Drawing.Point(261, 169);
            this.lblNbCloseTickets.Name = "lblNbCloseTickets";
            this.lblNbCloseTickets.Size = new System.Drawing.Size(52, 29);
            this.lblNbCloseTickets.TabIndex = 3;
            this.lblNbCloseTickets.Text = "240";
            // 
            // lblNbOpenTickets
            // 
            this.lblNbOpenTickets.AutoSize = true;
            this.lblNbOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbOpenTickets.Location = new System.Drawing.Point(261, 66);
            this.lblNbOpenTickets.Name = "lblNbOpenTickets";
            this.lblNbOpenTickets.Size = new System.Drawing.Size(39, 29);
            this.lblNbOpenTickets.TabIndex = 2;
            this.lblNbOpenTickets.Text = "24";
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
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.lblNbSupport);
            this.grpUsers.Controls.Add(this.lblSupport);
            this.grpUsers.Controls.Add(this.lblNbUsers);
            this.grpUsers.Controls.Add(this.lblNbAdmin);
            this.grpUsers.Controls.Add(this.lblUsers);
            this.grpUsers.Controls.Add(this.lblAdmin);
            this.grpUsers.Location = new System.Drawing.Point(397, 3);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(360, 235);
            this.grpUsers.TabIndex = 6;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Utilisateurs";
            // 
            // lblNbSupport
            // 
            this.lblNbSupport.AutoSize = true;
            this.lblNbSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbSupport.Location = new System.Drawing.Point(261, 121);
            this.lblNbSupport.Name = "lblNbSupport";
            this.lblNbSupport.Size = new System.Drawing.Size(39, 29);
            this.lblNbSupport.TabIndex = 5;
            this.lblNbSupport.Text = "10";
            // 
            // lblSupport
            // 
            this.lblSupport.AutoSize = true;
            this.lblSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSupport.Location = new System.Drawing.Point(25, 121);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(142, 29);
            this.lblSupport.TabIndex = 4;
            this.lblSupport.Text = "Nb. Support";
            // 
            // lblNbUsers
            // 
            this.lblNbUsers.AutoSize = true;
            this.lblNbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbUsers.Location = new System.Drawing.Point(261, 169);
            this.lblNbUsers.Name = "lblNbUsers";
            this.lblNbUsers.Size = new System.Drawing.Size(52, 29);
            this.lblNbUsers.TabIndex = 3;
            this.lblNbUsers.Text = "340";
            // 
            // lblNbAdmin
            // 
            this.lblNbAdmin.AutoSize = true;
            this.lblNbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbAdmin.Location = new System.Drawing.Point(261, 66);
            this.lblNbAdmin.Name = "lblNbAdmin";
            this.lblNbAdmin.Size = new System.Drawing.Size(26, 29);
            this.lblNbAdmin.TabIndex = 2;
            this.lblNbAdmin.Text = "2";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsers.Location = new System.Drawing.Point(25, 169);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(176, 29);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Nb. Utilisateurs";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdmin.Location = new System.Drawing.Point(25, 66);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(125, 29);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Nb. Admin";
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpDashboard.ColumnCount = 2;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.Controls.Add(this.grpStats, 0, 0);
            this.tlpDashboard.Controls.Add(this.grpUsers, 1, 0);
            this.tlpDashboard.Location = new System.Drawing.Point(12, 58);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.RowCount = 1;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.Size = new System.Drawing.Size(788, 253);
            this.tlpDashboard.TabIndex = 7;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.tlpDashboard);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmDashboard";
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpUsers.ResumeLayout(false);
            this.grpUsers.PerformLayout();
            this.tlpDashboard.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblNbCloseTickets;
        private System.Windows.Forms.Label lblNbOpenTickets;
        private System.Windows.Forms.Label lblNbPendingTickets;
        private System.Windows.Forms.Label lblPendingTickets;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.Label lblNbSupport;
        private System.Windows.Forms.Label lblSupport;
        private System.Windows.Forms.Label lblNbUsers;
        private System.Windows.Forms.Label lblNbAdmin;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
    }
}