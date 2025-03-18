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
    public partial class frmManageUsers: Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            string[] row = { "1", "John", "Doe", "johndoe@example.com", "Admin" };

            dgvUsers.Rows.Add(row);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dgvUsers.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string firstname = row.Cells["firstname"].Value.ToString();
                string lastname = row.Cells["lastname"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                string role = row.Cells["role"].Value.ToString();

                frmUserDetails detailsForm = new frmUserDetails(id, firstname, lastname, email, role, isNew: false);
                detailsForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUserDetails detailsForm = new frmUserDetails(isNew: true);
            detailsForm.ShowDialog();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
