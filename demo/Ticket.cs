using scriptsupport.Custom;
using scriptsupport.Request.Message;
using scriptsupport.Request.Ticket;
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
    public partial class frmTicket: Form
    {
        private readonly string ticketId;

        public frmTicket(string id = "")
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.ticketId = id;
        }

        private async void FrmTicket_Load(object sender, EventArgs e)
        {
            await LoadPrioritiesAndStatuses();
            await LoadSupportAgents();
            await LoadTicket();
        }

        private async Task LoadTicket()
        {
            if (int.TryParse(ticketId, out int id))
            {
                var service = new TicketService();
                var response = await service.GetTicketById(id);

                if (response.success && response.data != null)
                {
                    var ticket = response.data;

                    txtSubject.Text = ticket.subject;
                    cboStatus.Text = ticket.status?.name ?? "";
                    cboPriority.Text = ticket.priority?.name ?? "";
                    cboSupportAgent.Text = ticket.assigned_to?.first_name + " " + ticket.assigned_to?.last_name;
                    cboEvaluation.Text = ticket.rating.ToString();
                    txtFirstnameUser.Text = ticket.user.first_name;
                    txtLastnameUser.Text = ticket.user.last_name;
                    txtFirstnameSupport.Text = ticket.assigned_to?.first_name;
                    txtLastnameSupport.Text = ticket.assigned_to?.last_name;

                    if (ticket.status?.name == "Fermé")
                        cboStatus_SelectedIndexChanged(null, null);

                    if (ticket.messages != null)
                    {
                        foreach (var msg in ticket.messages)
                        {
                            string who = (msg.user != null && msg.user.id == ticket.user.id) ? "Utilisateur" : "Support";
                            lstMessages.Items.Add($"{who}: {msg.content}");
                        }
                        lstMessages.TopIndex = lstMessages.Items.Count - 1;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur lors du chargement du ticket.");
                    this.Close();
                }
            }
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
                this.txtSubject.Enabled = false;
                this.cboPriority.Enabled = false;
                this.cboSupportAgent.Enabled = false;
            } else
            {
                this.btnEnvoyer.Enabled = true;
                this.txtMessage.Enabled = true;
                this.txtSubject.Enabled = true;
                this.cboPriority.Enabled = true;
                this.cboSupportAgent.Enabled = true;
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

        private async void btnEnvoyer_Click(object sender, EventArgs e)
        {
            string messageContent = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(messageContent))
            {
                MessageBox.Show("Le message ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ticketId, out int id))
            {
                MessageBox.Show("ID du ticket invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var request = new MessageCreateRequest
            {
                ticket_id = id,
                message = messageContent
            };

            var service = new MessageService();
            var response = await service.CreateMessage(request);

            if (response.success)
            {
                txtMessage.Text = "";
                lstMessages.Items.Add($"Support: {messageContent}");
                lstMessages.TopIndex = lstMessages.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Erreur lors de l'envoi : " + response.message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ticketId, out int id))
            {
                MessageBox.Show("ID du ticket invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedAgent = cboSupportAgent.SelectedItem as ComboBoxItem;
            if (selectedAgent == null)
            {
                MessageBox.Show("Veuillez sélectionner un agent de support.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPriority = cboPriority.SelectedItem as ComboBoxItem;
            var selectedStatus = cboStatus.SelectedItem as ComboBoxItem;

            if (selectedPriority == null || selectedStatus == null)
            {
                MessageBox.Show("Sélectionnez une priorité et un statut.");
                return;
            }

            int priorityId = (int)selectedPriority.Value;
            int statusId = (int)selectedStatus.Value;

            var request = new TicketUpdateRequest
            {
                subject = txtSubject.Text.Trim(),
                priority_id = priorityId,
                status_id = statusId,
                assigned_to_id = selectedAgent.Value
            };

            var service = new TicketService();
            var response = await service.UpdateTicket(id, request);

            if (response.success)
            {
                MessageBox.Show("Ticket mis à jour avec succès !", "Gestion des tickets", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur : " + response.message, "Échec de la mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer ce ticket ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (!int.TryParse(ticketId, out int id))
                {
                    MessageBox.Show("ID du ticket invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var service = new TicketService();
                var response = await service.SoftDeleteTicket(id);

                if (response.success)
                {
                    MessageBox.Show("Ticket supprimé avec succès!", "Gestion ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur : " + response.message, "Échec de la suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Suppression annulée.", "Gestion ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void cboSupportAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task LoadSupportAgents()
        {
            var service = new UserService();
            var response = await service.GetAllUsers("Support");

            if (response.success && response.data != null)
            {
                cboSupportAgent.Items.Clear();
                foreach (var user in response.data)
                {
                    cboSupportAgent.Items.Add(new ComboBoxItem
                    {
                        Text = $"{user.first_name} {user.last_name}",
                        Value = user.id ?? 0
                    });
                }
            }
        }

        private async Task LoadPrioritiesAndStatuses()
        {
            var priorityService = new PriorityService();

            var priorities = await priorityService.GetAllPriorities();
            if (priorities.success)
            {
                cboPriority.Items.Clear();
                foreach (var p in priorities.data)
                {
                    cboPriority.Items.Add(new ComboBoxItem
                    {
                        Text = p.name,
                        Value = p.id
                    });
                }
            }

            var statusService = new StatusService();

            var statuses = await statusService.GetAllStatuses();
            if (statuses.success)
            {
                cboStatus.Items.Clear();
                foreach (var s in statuses.data)
                {
                    cboStatus.Items.Add(new ComboBoxItem
                    {
                        Text = s.name,
                        Value = s.id
                    });
                }
            }
        }

        private void cboEvaluation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
