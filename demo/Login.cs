using Newtonsoft.Json;
using scriptsupport.services;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Veuillez remplir tous les champs.";
                lblError.Visible = true;
                return;
            }

            btnLogin.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                var auth = new AuthService();
                var (success, message) = await auth.Login(email, password);

                if (success)
                {
                    frmDashboard dashboard = new frmDashboard();
                    this.Hide();
                    lblError.Visible = false;
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    dashboard.ShowDialog();
                    this.Show();
                }
                else
                {
                    lblError.Text = message;
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Erreur inattendue : " + ex.Message;
                lblError.Visible = true;
            }
            finally
            {
                btnLogin.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}