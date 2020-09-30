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
    public partial class frmBattlefield : Form
    {
        //public Grid nodeGrid { get; private set; }
        public Grid nodeGrid;
        public frmBattlefield()
        {
            InitializeComponent();
        }

        private void frmBattlefield_Load(object sender, EventArgs e)
        {
            nodeGrid = new Grid(800, 800, 50, 50);

            nodeGrid.make_grid();

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Controls.Add(nodeGrid.grid[i, j]);
                }
            }
        }
        public void get_path()
        {
            nodeGrid.update_neighbors();
            nodeGrid.astar();
        }
    }
}
