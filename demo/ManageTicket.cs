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
    public partial class frmManageTicket: Form
    {
        public frmManageTicket()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private async void frmManageTicket_Load(object sender, EventArgs e)
        {
            await LoadTickets();
        }

        private async void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dgvTickets.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                frmTicket ticket = new frmTicket(id);
                ticket.ShowDialog();
                await LoadTickets();
            }
        }

        private async Task LoadTickets()
        {
            var service = new TicketService();
            var response = await service.GetAllTickets();

            if (response.success)
            {
                dgvTickets.Rows.Clear();

                foreach (var ticket in response.data)
                {
                    dgvTickets.Rows.Add(
                        ticket.id.ToString(),
                        ticket.user.first_name + ' ' + ticket.user.last_name,
                        ticket.subject,
                        ticket.priority?.name ?? "",
                        ticket.status?.name ?? "",
                        ticket.rating.ToString()
                    );
                }
            }
            else
            {
                MessageBox.Show("Erreur : " + response.message);
            }
        }
    }
}
