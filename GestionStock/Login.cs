using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!(txtLogin.Text.Equals("Pralifino")) || !(txtPassword.Text.Equals("Admin")) ){

                MessageBox.Show("Verifier utilisateur et mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Menu form1 = new Menu();
                form1.FormClosed += (s, eventArgs) => this.Close(); // Show the first form when the second form is closed
                this.Hide(); // Hide the first form
                form1.ShowDialog(); // Show the second form
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
