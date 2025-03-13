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
    public partial class frmApp: Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frmManageUsers = new frmManageUsers();
            frmManageUsers.MdiParent = this;
            frmManageUsers.Show();
        }

        private void gestionTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTicket frmManageTicket = new frmManageTicket();
            frmManageTicket.MdiParent = this;
            frmManageTicket.Show();
        }

        private void frmApp_Load(object sender, EventArgs e)
        {

        }
    }
}
