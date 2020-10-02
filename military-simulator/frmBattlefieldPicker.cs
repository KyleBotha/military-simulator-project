using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace military_simulator
{
    public partial class frmBattlefieldPicker : Form
    {
        string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public frmBattlefieldPicker()
        {
            InitializeComponent();
        }
        public void map1()
        {
            frmSimulator simulator = new frmSimulator(1);
            this.Hide(); 
            simulator.Show();
        }
        public void map2()
        {
            frmSimulator simulator = new frmSimulator(2);
            this.Hide();
            simulator.Show();
        }
        public void map3()
        {
            frmSimulator simulator = new frmSimulator(3);
            this.Hide();
            simulator.Show();
        }
        private void pbMap1_Click(object sender, EventArgs e)
        {
            map1();
        }

        private void lblMap1Name_Click(object sender, EventArgs e)
        {
            map1();
        }

        private void frmBattlefieldPicker_Load(object sender, EventArgs e)
        {
            string relative = exePath + @"/../../Assets/";
            string absolute = Path.GetFullPath(relative);
            pbMap1.Image = Image.FromFile(absolute + "Map1.jpg");
            pbMap1.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMap2.Image = Image.FromFile(absolute + "Map2.jpeg");
            pbMap2.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMap3.Image = Image.FromFile(absolute + "Map3.jpeg");
            pbMap3.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            map2();
        }

        private void pbMap2_Click(object sender, EventArgs e)
        {
            map2();
        }

        private void pbMap3_Click(object sender, EventArgs e)
        {
            map3();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            map3();
        }
    }
}
