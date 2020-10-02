using military_simulator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace military_simulator
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterHandler register = new RegisterHandler(txtName.Text, txtSurname.Text, txtRank.Text, txtDodId.Text, txtAffiliation.Text, txtUsername.Text,txtPassword.Text, txtCPassword.Text);
            frmBattlefieldPicker battleFieldPicker = new frmBattlefieldPicker();
            this.Hide();
            battleFieldPicker.ShowDialog();
        }
    }
}
