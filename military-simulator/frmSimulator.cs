﻿using military_simulator.Classes;
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
    public partial class frmSimulator : Form
    {
        string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public frmSimulator()
        {
            InitializeComponent();
        }
        frmBattlefield battlefield = new frmBattlefield();
        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {
               ControlPaint.DrawBorder(e.Graphics, pnlMain.ClientRectangle,
               Color.Black, 1, ButtonBorderStyle.Solid, // left
               Color.Black, 1, ButtonBorderStyle.Solid, // top
               Color.Black, 1, ButtonBorderStyle.Solid, // right
               Color.Black, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void pnlBottom_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlMain.ClientRectangle,
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
            string relative = exePath + @"/../../Assets/";
            string absolute = Path.GetFullPath(relative); 
            pbEnd.Image = Image.FromFile(absolute + "end.png"); 
            pbStart.Image = Image.FromFile(absolute + "start.png"); 
            pbArmyCamp.Image = Image.FromFile(absolute + "camp.png"); 
            pbMortar.Image = Image.FromFile(absolute + "mortar.png"); 
           


            battlefield.TopLevel = false;
            battlefield.AutoScroll = true;
            battlefield.FormBorderStyle = FormBorderStyle.None;
            battlefield.Size = new Size(800, 800); 
            
            this.pnlMain.Controls.Add(battlefield);
            battlefield.Show();
            pbArmyCamp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStart.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMortar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEnd.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            var coordinates = pnlMain.PointToClient(Cursor.Position);
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

        private void btnSumulate_Click(object sender, EventArgs e)
        {
            battlefield.get_path();
        }

        private void pbArmyCamp_Click(object sender, EventArgs e)
        {
            State.item = 1;
            pbStart.BackColor = Color.DimGray;
            pbEnd.BackColor = Color.DimGray;
            pbArmyCamp.BackColor = Color.LightGray;
            pbMortar.BackColor = Color.DimGray;
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            State.item = 0;
            pbStart.BackColor = Color.LightGray;
            pbEnd.BackColor = Color.DimGray;
            pbArmyCamp.BackColor = Color.DimGray;
            pbMortar.BackColor = Color.DimGray;
        }

        private void pbMortar_Click(object sender, EventArgs e)
        {
            State.item = 2;
            pbStart.BackColor = Color.DimGray;
            pbEnd.BackColor = Color.DimGray;
            pbArmyCamp.BackColor = Color.DimGray;
            pbMortar.BackColor = Color.LightGray;
        }

        private void pbEnd_Click(object sender, EventArgs e)
        {
            State.item = 9;
            pbStart.BackColor = Color.DimGray;
            pbEnd.BackColor = Color.LightGray;
            pbArmyCamp.BackColor = Color.DimGray;
            pbMortar.BackColor = Color.DimGray;
        }
    }
}
