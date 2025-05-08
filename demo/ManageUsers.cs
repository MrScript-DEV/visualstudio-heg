using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using scriptsupport;
using scriptsupport.services;

namespace demo
{
    public partial class frmManageUsers: Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            cboRoleFilter.Text = "Tous";
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dgvUsers.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();

                frmUserDetails detailsForm = new frmUserDetails(id, isNew: false);
                detailsForm.ShowDialog();
                await LoadUsers();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            frmUserDetails detailsForm = new frmUserDetails(isNew: true);
            detailsForm.ShowDialog();
            await LoadUsers();
        }

        private async void frmManageUsers_Load(object sender, EventArgs e)
        {
            await LoadUsers();
        }

        private async Task LoadUsers()
        {
            var service = new UserService();

            string selectedRole = cboRoleFilter.SelectedItem?.ToString();
            string roleParam = selectedRole != null && selectedRole != "Tous" ? selectedRole : null;

            var response = await service.GetAllUsers(roleParam);

            if (response.success)
            {
                dgvUsers.Rows.Clear();

                foreach (var user in response.data)
                {
                    string roleText = user.roles != null ? string.Join(", ", user.roles) : "Aucun";
                    dgvUsers.Rows.Add(user.id, user.first_name, user.last_name, user.email, roleText, user.total_tickets);
                }
            }
            else
            {
                MessageBox.Show("Erreur : " + response.message);
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void cboRoleFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            await LoadUsers();
        }
    }
}
