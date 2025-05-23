﻿using scriptsupport.api;
using scriptsupport.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class frmDashboard: Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private async void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers manageUsers = new frmManageUsers();
            this.Hide();
            manageUsers.ShowDialog();
            this.Show();
            await LoadDashboardStats();
        }

        private async void gestionDesTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTicket manageTickets = new frmManageTicket();
            this.Hide();
            manageTickets.ShowDialog();
            this.Show();
            await LoadDashboardStats();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grpStats_Enter(object sender, EventArgs e)
        {

        }

        private async void frmDashboard_Load(object sender, EventArgs e)
        {
            if (!SessionManager.CurrentUser.IsAdmin)
            {
                tsmiManageUsers.Visible = false;
            }

            if (!SessionManager.CurrentUser.IsAdmin && !SessionManager.CurrentUser.IsSupport)
            {
                tsmiManageTickets.Visible = false;
            }

            await LoadDashboardStats();
        }

        private async void tsmiLogout_Click(object sender, EventArgs e)
        {
            var auth = new AuthService();
            var (success, msg) = await auth.Logout();

            if (success)
            {
                this.Hide();
            }
        }

        private async Task LoadDashboardStats()
        {
            var ticketService = new TicketService();
            var userService = new UserService();

            var ticketsResponse = await ticketService.GetAllTickets();
            var usersResponse = await userService.GetAllUsers();

            if (ticketsResponse.success && usersResponse.success)
            {
                var tickets = ticketsResponse.data;
                var users = usersResponse.data;

                int totalOuverts = tickets.Count(t => t.status?.name == "Ouvert");
                int totalFermes = tickets.Count(t => t.status?.name == "Fermé");
                int totalEnAttente = tickets.Count(t => t.status?.name == "En attente");

                int totalAdmins = users.Count(u => u.roles != null && u.roles.Any(r => r == "Admin"));
                int totalSupports = users.Count(u => u.roles != null && u.roles.Any(r => r == "Support"));
                int totalUsers = users.Count(u => u.roles != null && u.roles.Any(r => r == "User"));

                lblNbOpenTickets.Text = totalOuverts.ToString();
                lblNbCloseTickets.Text = totalFermes.ToString();
                lblNbPendingTickets.Text = totalEnAttente.ToString();

                lblNbAdmin.Text = totalAdmins.ToString();
                lblNbSupport.Text = totalSupports.ToString();
                lblNbUsers.Text = totalUsers.ToString();
            }
            else
            {
                MessageBox.Show("Erreur lors du chargement des statistiques.");
            }
        }
    }
}
