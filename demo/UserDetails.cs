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
    public partial class frmUserDetails: Form
    {
        private bool isNew;


        public frmUserDetails(string id = "", string firstname = "", string lastname = "", string email = "", string role = "Utilisateur", bool isNew = true)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.isNew = isNew;

            txtFirstname.Text = firstname;
            txtLastname.Text = lastname;
            txtEmail.Text = email;
            cboRole.Text = role;

            grpUserTickets.Visible = !isNew;
            dgvUserTickets.Visible = !isNew;
            btnCreate.Visible = isNew;
            btnUpdate.Visible = !isNew;
            btnDelete.Visible = !isNew;

            if (!isNew)
            {

                string[] row = { "1", "Problème de connexion", "Moyenne", "5", "Fermé", "3" };

                dgvUserTickets.Rows.Add(row);
            }
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilisateur créé avec succès!", "Gestion utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilisateur modifié avec succès!", "Gestion utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Utilisateur supprimé avec succès!", "Gestion utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Suppression annulée.", "Gestion utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvUserTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dgvUserTickets.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                frmTicket ticket = new frmTicket(id);
                ticket.ShowDialog();
            }
        }
    }
}