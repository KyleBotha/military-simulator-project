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
    public partial class frmSimulator : Form
    {
        public frmSimulator()
        {
            InitializeComponent();
        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {
               ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
               Color.Black, 1, ButtonBorderStyle.Solid, // left
               Color.Black, 1, ButtonBorderStyle.Solid, // top
               Color.Black, 1, ButtonBorderStyle.Solid, // right
               Color.Black, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void pnlBottom_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
               Color.Black, 1, ButtonBorderStyle.Solid, // left
               Color.Black, 1, ButtonBorderStyle.Solid, // top
               Color.Black, 1, ButtonBorderStyle.Solid, // right
               Color.Black, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmSimulator_Load(object sender, EventArgs e)
        {
            pbArmyCamp.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            var coordinates = panel1.PointToClient(Cursor.Position);
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(50, 50),
                Location = new Point(coordinates.X - 25 , coordinates.Y - 25),
                Image = Image.FromFile(@"C:/Users/kyleb/Downloads/icons/military-17-512.png"),
            };
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(picture);
            picture.BringToFront();
        }
    }
}
