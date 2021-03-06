﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace military_simulator.Classes
{
    public class Node : Panel, IComparable<Node>
    {
        public int id;
        public int f;
        public int g;
        public int h;
        public int last;
        public int row;
        public int col;
        public string exePath;
        public int x;
        public int y;
        public Point coords;
        public List<Node> neighbors;
        public int total_rows;
        public int type;
        public int priority;
        public Node(int id, int f, int g, int h, int last, int type, int row, int col, int width, int total_rows)
        {
            this.row = row;
            this.col = col;
            this.id = id;
            this.last = last;
            this.x = row * width;
            this.y = col * width;
            this.coords = new Point(x, y);
            this.neighbors = new List<Node>();
            this.BackColor = Color.White;
            this.total_rows = total_rows;
            this.type = type;
            this.Height = width;
            this.Width = width;
            this.f = f;
            this.g = g;
            this.h = h;
            this.priority = f;
            string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        }
        public int CompareTo(Node other)
        {
            this.priority = f;
            if (this.priority < other.priority) return -1;
            else if (this.priority > other.priority) return 1;
            else return 0;
        }
        public Point get_pos_grid()
        {
            return new Point(this.row, this.col);
        }
        public Point get_pos_pixel()
        {
            return new Point(this.x, this.y);
        }
        public bool is_closed()
        {
            return this.type == 4;
        }
        public bool is_open()
        {
            return this.type == 5;
        }
        public bool is_obstacle()
        {
            return this.type == 3;
        }
        public bool is_start()
        {
            return this.type == 1;
        }
        public bool is_end()
        {
            return this.type == 2;
        }
        public void reset()
        {
            this.type = 0;
            this.BackColor = Color.White;
        }
        public void make_closed()
        {
            this.type = 4;
            //this.BackColor = Color.Red;
        }
        public void make_open()
        {
            this.type = 5;
            //this.BackColor = Color.Green;
        }
        public void make_obstacle()
        {
            this.type = 3;
            this.BackColor = Color.Black;
        }
        public void make_danger()
        {
            this.type = 3;
            this.BackColor = Color.FromArgb(100, Color.Red);
        }
        public void make_end()
        {
            this.type = 2;
            this.BackColor = Color.Transparent;
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(32, 32),
                //Location = new Point(coordinates.X - 25, coordinates.Y - 25),
                Image = Image.FromFile(exePath + @"../../Assets/end.png"
                ),
            };
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(picture);
        }
        public void make_path()
        {
            this.BackColor = Color.Purple;
        }
        public void make_start()
        {
            this.type = 1;
            this.BackColor = Color.Transparent;
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(30, 30),
                //Location = new Point(coordinates.X - 25, coordinates.Y - 25),
                Image = Image.FromFile(exePath + @"../../Assets/start.png"),
            };
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(picture);
        }
        public void make_default()
        {
            this.type = 0;
            this.BackColor = Color.Transparent;
            foreach (Control item in this.Controls.OfType<PictureBox>())
            {
                this.Controls.Remove(item);
            }
        }
        public void make_visited()
        {
            this.type = 0;
            this.BackColor = Color.FromArgb(170, Color.Green);
            foreach (Control item in this.Controls.OfType<PictureBox>())
            {
                this.Controls.Remove(item);
            }
        }
        public void make_border()
        {
            this.BackColor = Color.FromArgb(90, Color.Black);
            this.type = 20;
        }
        public void make_cloud()
        {
            this.BackColor = Color.FromArgb(170, Color.LightGray);

        }
        public void make_barrack()
        {
            this.type = 11;
            this.BackColor = Color.Transparent;

            //var coordinates = pnlMain.PointToClient(Cursor.Position);
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(32, 32),
                //Location = new Point(coordinates.X - 25, coordinates.Y - 25),
                Image = Image.FromFile(exePath + @"../../Assets/camp.png"),
            };
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(picture);
        }
        public void make_true()
        {
            if (this.type == 3)
            {
                this.BackColor = Color.FromArgb(100, Color.Red);
            }
            if (this.type == 11)
            {
                this.BackColor = Color.FromArgb(100, Color.Red);
                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(32, 32),
                    //Location = new Point(coordinates.X - 25, coordinates.Y - 25),
                    Image = Image.FromFile(exePath + @"../../Assets/camp.png"),
                };
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(picture);
            }
            if(this.type == 0 || this.type == 5 || this.type == 4 )
            {
                this.BackColor = Color.Transparent;
            }
        }
        public void make_mortar()
        {
            this.type = 3;
            this.BackColor = Color.Transparent;
            
            //var coordinates = pnlMain.PointToClient(Cursor.Position);
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(32, 32),
                //Location = new Point(coordinates.X - 25, coordinates.Y - 25),
                Image = Image.FromFile(exePath + @"../../Assets/mortar.png"),
            };
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(picture);
        }
        public void make_plane()
        {
            this.BackColor = Color.Transparent;
            //var coordinates = pnlMain.PointToClient(Cursor.Position);
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(32, 32),
                //Location = new Point(coordinates.X - 25, coordinates.Y - 25),
                Image = Image.FromFile(exePath + @"../../Assets/Plane.png"),
            };
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(picture);
        }
        
    }
}
