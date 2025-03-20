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

            string[] row = { "1", "John Doe", "Problème de connexion", "Moyenne", "5", "Fermé", "3"};

            dgvTickets.Rows.Add(row);

        }

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dgvTickets.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                frmTicket ticket = new frmTicket(id);
                ticket.ShowDialog();
            }
        }

        private void frmManageTicket_Load(object sender, EventArgs e)
        {

        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dgvTickets.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                frmTicket ticket = new frmTicket(id);
                ticket.ShowDialog();
            }
        }
    }
}
