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
    public partial class frmBattlefieldPicker : Form
    {
        public frmBattlefieldPicker()
        {
            InitializeComponent();
        }
        public void map1()
        {
            frmSimulator simulator = new frmSimulator();
            this.Hide(); 
            simulator.ShowDialog();
        }
        private void pbMap1_Click(object sender, EventArgs e)
        {
            map1();
        }

        private void lblMap1Name_Click(object sender, EventArgs e)
        {
            map1();
        }
    }
}
