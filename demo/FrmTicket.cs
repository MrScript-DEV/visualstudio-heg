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
    public partial class frmTicket: Form
    {
        public frmTicket(string id = "")
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.txtSubject.Text = "Problème de connexion";
            this.cboStatus.Text = "Ouvert";
            this.cboPriority.Text = "Moyenne";
            this.cboSupportAgent.Text = "Mark Evans";

        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void grpTicketInfo_Enter(object sender, EventArgs e)
        {

        }

        private void cboPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void grpMessages_Enter(object sender, EventArgs e)
        {

        }
    }
}
