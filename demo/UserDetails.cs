using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using scriptsupport.services;
using scriptsupport;
using scriptsupport.Request.User;

namespace demo
{
    public partial class frmUserDetails: Form
    {
        private bool isNew;
        private string userId;


        public frmUserDetails(string id = "", bool isNew = true)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.isNew = isNew;
            this.userId = id;

            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            cboRole.Text = "User";

            txtPassword.Visible = isNew;
            txtPasswordConfirm.Visible = isNew;
            lblPassword.Visible = isNew;
            lblPasswordConfirm.Visible = isNew;

            grpUserTickets.Visible = !isNew;
            dgvUserTickets.Visible = !isNew;
            btnCreate.Visible = isNew;
            btnUpdate.Visible = !isNew;
            btnDelete.Visible = !isNew;

            txtFirstname.TextChanged += new EventHandler(InputFieldsChanged);
            txtLastname.TextChanged += new EventHandler(InputFieldsChanged);
            txtEmail.TextChanged += new EventHandler(InputFieldsChanged);
            cboRole.SelectedIndexChanged += new EventHandler(InputFieldsChanged);

            checkDataIsValid();
        }

        private void InputFieldsChanged(object sender, EventArgs e)
        {
            checkDataIsValid();
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            if (!isNew)
            {
                var service = new UserService();
                if (int.TryParse(userId, out int id))
                {
                    var response = await service.GetUserById(id);

                    if (response.success && response.data != null)
                    {
                        var user = response.data;

                        txtFirstname.Text = user.first_name;
                        txtLastname.Text = user.last_name;
                        txtEmail.Text = user.email;

                        cboRole.Text = user.roles?.FirstOrDefault() ?? "";

                        dgvUserTickets.Rows.Clear();
                        if (user.tickets != null)
                        {
                            foreach (var ticket in user.tickets)
                            {
                                dgvUserTickets.Rows.Add(
                                    ticket.id.ToString(),
                                    ticket.subject,
                                    ticket.priority?.name ?? "",
                                    ticket.priority?.level.ToString() ?? "",
                                    ticket.status?.name ?? "",
                                    ticket.rating.ToString()
                                );
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors du chargement de l'utilisateur : " + response.message);
                        this.Close();
                    }
                }
            }

            checkDataIsValid();
        }

        private void checkDataIsValid()
        {
            if (txtFirstname.Text == "" || txtLastname.Text == "" || txtEmail.Text == "" || cboRole.Text == "")
            {
                btnCreate.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnCreate.Enabled = true;
                btnUpdate.Enabled = true;
            }

            if(isNew)
            {
                if (txtPassword.Text == "" || txtPasswordConfirm.Text == "")
                {
                    btnCreate.Enabled = false;
                }
                else
                {
                    btnCreate.Enabled = true;
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(userId, out int id))
            {
                MessageBox.Show("ID utilisateur invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updateRequest = new UserUpdateRequest
            {
                first_name = txtFirstname.Text.Trim(),
                last_name = txtLastname.Text.Trim(),
                email = txtEmail.Text.Trim(),
                role = cboRole.Text.Trim()
            };

            var service = new UserService();
            var response = await service.UpdateUser(id, updateRequest);

            if (response.success)
            {
                MessageBox.Show("Utilisateur modifié avec succès !", "Gestion utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur : " + response.message, "Échec de la modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer cet utilisateur ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (!int.TryParse(userId, out int id))
                {
                    MessageBox.Show("ID utilisateur invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var service = new UserService();
                var response = await service.SoftDeleteUser(id);

                if (response.success)
                {
                    MessageBox.Show("Utilisateur supprimé avec succès !", "Gestion utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur : " + response.message, "Échec de la suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private async void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var request = new UserCreateRequest
            {
                first_name = txtFirstname.Text.Trim(),
                last_name = txtLastname.Text.Trim(),
                email = txtEmail.Text.Trim(),
                role = cboRole.Text.Trim(),
                password = txtPassword.Text,
                password_confirmation = txtPasswordConfirm.Text
            };

            var service = new UserService();
            var response = await service.CreateUser(request);

            if (response.success)
            {
                MessageBox.Show("Utilisateur créé avec succès!", "Gestion utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur : " + response.message, "Échec de la création", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}