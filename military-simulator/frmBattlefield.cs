using military_simulator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace military_simulator
{
    
    public partial class frmBattlefield : Form
    {
        //public Grid nodeGrid { get; private set; }

        string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public Grid nodeGrid;
        public int fuellevel = 100;
        public Form frmgauges;
        
        public frmBattlefield(int map)
        {
            InitializeComponent();
            if (map == 1)
            {
                string relative = exePath + @"/../../Assets/";
                string absolute = Path.GetFullPath(relative);
               this.BackgroundImage = Image.FromFile(absolute + "Map1.jpg");
            }
            if (map == 2)
            {
                string relative = exePath + @"/../../Assets/";
                string absolute = Path.GetFullPath(relative);
                this.BackgroundImage = Image.FromFile(absolute + "Map2.jpeg");
            }
            if (map == 3)
            {
                string relative = exePath + @"/../../Assets/";
                string absolute = Path.GetFullPath(relative);
                this.BackgroundImage = Image.FromFile(absolute + "Map3.jpeg");
            }
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
        public void make_clouds()
        {
            for (int i = 0; i < nodeGrid.numOfRows; i++)
            {
                for (int j = 0; j < nodeGrid.numOfCols; j++)
                {
                    nodeGrid.grid[i, j].make_cloud();
                    foreach (Control item in nodeGrid.grid[i, j].Controls.OfType<PictureBox>())
                    {
                        nodeGrid.grid[i, j].Controls.Remove(item);
                    }
                }
            }
            
        }
        public void make_border()
        {
            for (int i = 0; i < nodeGrid.numOfRows; i++)
            {
                for (int j = 0; j < nodeGrid.numOfCols; j++)
                {
                    if (i < 3 || j < 3)
                    {
                        nodeGrid.grid[i, j].make_border();
                       

                    }
                    if (i > 21|| j > 21)
                    {
                        nodeGrid.grid[i, j].make_border();
                    }
                }
            }
        }
        public int get_Fuel()
        {
            return fuellevel;
        }
        
        public async void show_path()
        {
            List<Node> path = nodeGrid.get_route();
            List<Node> reverse_path = nodeGrid.get_route();
            path.Reverse();
            foreach(Node node in path)
            {   

                node.make_plane();
                await Task.Delay(30);
                int xcoord = node.row;
                int ycoord = node.col;
                nodeGrid.grid[xcoord + 1, ycoord].make_true();
                nodeGrid.grid[xcoord + 2, ycoord].make_true();
                nodeGrid.grid[xcoord - 1, ycoord].make_true();
                nodeGrid.grid[xcoord - 2, ycoord].make_true();
                await Task.Delay(30);

                nodeGrid.grid[xcoord, ycoord + 1].make_true();
                nodeGrid.grid[xcoord, ycoord + 2].make_true();
                nodeGrid.grid[xcoord, ycoord - 1].make_true();
                nodeGrid.grid[xcoord, ycoord - 2].make_true();
                await Task.Delay(30);

                nodeGrid.grid[xcoord + 1, ycoord + 1].make_true();
                nodeGrid.grid[xcoord - 1, ycoord + 1].make_true();
                nodeGrid.grid[xcoord - 1, ycoord - 1].make_true();
                nodeGrid.grid[xcoord + 1, ycoord - 1].make_true();

                await Task.Delay(30);

                nodeGrid.grid[xcoord + 1, ycoord + 2].make_true();
                nodeGrid.grid[xcoord - 1, ycoord + 2].make_true();
                nodeGrid.grid[xcoord - 1, ycoord - 2].make_true();
                nodeGrid.grid[xcoord + 1, ycoord - 2].make_true();

                await Task.Delay(30);

                nodeGrid.grid[xcoord + 2, ycoord + 1].make_true();
                nodeGrid.grid[xcoord - 2, ycoord + 1].make_true();
                nodeGrid.grid[xcoord - 2, ycoord - 1].make_true();
                nodeGrid.grid[xcoord + 2, ycoord - 1].make_true();

                await Task.Delay(30);

                nodeGrid.grid[xcoord + 2, ycoord + 2].make_true();
                nodeGrid.grid[xcoord - 2, ycoord + 2].make_true();
                nodeGrid.grid[xcoord - 2, ycoord - 2].make_true();
                nodeGrid.grid[xcoord + 2, ycoord - 2].make_true();

                await Task.Delay(30);

                nodeGrid.grid[xcoord + 3, ycoord].make_true();
                nodeGrid.grid[xcoord - 3, ycoord].make_true();
                nodeGrid.grid[xcoord, ycoord + 3].make_true();
                nodeGrid.grid[xcoord, ycoord - 3].make_true();
                node.make_default();
                await Task.Delay(30);
                fuellevel -= 1;
                
                

            }
            reverse_path.Reverse();
            foreach (Node node in reverse_path)
            {     
                node.make_plane();
                await Task.Delay(80);
                node.make_visited();
                fuellevel -= 1;
               

            }

            
        }
    }
}
