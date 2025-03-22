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
            this.cboStatus.Text = "Fermé";
            this.cboPriority.Text = "Moyenne";
            this.cboSupportAgent.Text = "Mark Evans";
            this.cboEvaluation.Text = "3";
            this.lstMessages.Items.Add("Utilisateur: Bonjour, j'ai un problème de connexion");
            this.lstMessages.Items.Add("Support: Avez-vous essayé de redémarrer votre ordinateur?");
            this.lstMessages.Items.Add("Utilisateur: Oui, mais ça ne fonctionne toujours pas");
            this.lstMessages.Items.Add("Support: Je vais vous envoyer un technicien pour vérifier votre connexion");


        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStatus.Text == "Fermé")
            {
                this.btnEnvoyer.Enabled = false;
                this.txtMessage.Enabled = false;
                this.btnUpdateSubject.Enabled = false;
                this.txtSubject.Enabled = false;
                this.cboPriority.Enabled = false;
                this.cboSupportAgent.Enabled = false;
                this.cboEvaluation.Enabled = false;
            } else
            {
                this.btnEnvoyer.Enabled = true;
                this.txtMessage.Enabled = true;
                this.btnUpdateSubject.Enabled = true;
                this.txtSubject.Enabled = true;
                this.cboPriority.Enabled = true;
                this.cboSupportAgent.Enabled = true;
                this.cboEvaluation.Enabled = true;
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                lstMessages.Items.Add("Support: " + txtMessage.Text);
                txtMessage.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sujet modifié avec succès!", "Gestion tickets", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce ticket ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Ticket supprimé avec succès!", "Gestion ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Suppression annulée.", "Gestion ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
