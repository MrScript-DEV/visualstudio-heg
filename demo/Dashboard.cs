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
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers manageUsers = new frmManageUsers();
            this.Hide();
            manageUsers.ShowDialog();
            this.Show();
        }

        private void gestionDesTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTicket manageTickets = new frmManageTicket();
            this.Hide();
            manageTickets.ShowDialog();
            this.Show();
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
    }
}
