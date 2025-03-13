using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Veuillez remplir tous les champs.";
                lblError.Visible = true;
            }
            else
            {
                frmDashboard dashboard = new frmDashboard();
                this.Hide();
                lblError.Visible = false;
                txtEmail.Text = "";
                txtPassword.Text = "";
                dashboard.ShowDialog();
                this.Show();
            }
        }
    }
}