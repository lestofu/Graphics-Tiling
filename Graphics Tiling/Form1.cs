using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Graphics_Tiling
{
    public partial class frmTiling1 : Form
    {
        public frmTiling1()
        {
            InitializeComponent();
        }
        Graphics G;
        int tileSize = 32;
        int newX;
        int newY;

        int[,] mCord = new int[12,12];
        int xCord;
        int yCord;

        Bitmap bmpGrass;
        Bitmap bmpWater;

        // Draws a bunch of black tiles in every single square.
        private void btnDrawTiles_Click(object sender, EventArgs e)
        {
            G = this.CreateGraphics();
            for(int x = 0; x < this.Width; x += tileSize)
            {
                for (int y = 0; y < this.Height; y += tileSize)
                {
                    G.FillRectangle(Brushes.Black, x, y, tileSize, tileSize);
                    G.DrawRectangle(Pens.PaleVioletRed, x, y, tileSize, tileSize);;
                }
            }
            G.Dispose();
        }

        private void frmTiling1_Load(object sender, EventArgs e)
        {
            bmpGrass = new Bitmap(Gras.Image);
            bmpWater = new Bitmap(Walter.Image);
            Gras.Hide();
            Walter.Hide();
        }

        private void frmTiling1_MouseMove(object sender, MouseEventArgs e)
        {
            G = this.CreateGraphics();
            newX = e.X - e.X % tileSize;
            newY = e.Y - e.Y % tileSize;

            xCord = newX / tileSize;
            yCord = newY / tileSize;

            if (e.Button == MouseButtons.Right)
            {
                G.DrawImage(bmpGrass, newX, newY, tileSize, tileSize);
                mCord[xCord, yCord] = 1;

            }
            else if (e.Button == MouseButtons.Left)
            {
                G.DrawImage(bmpWater, newX, newY, tileSize, tileSize);
                mCord[xCord, yCord] = 2;
            }
           
            G.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath + "\\Map.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter myFile = new StreamWriter(fs);

            for (int x = 0; x < mCord.GetLength(0); x++)
            {
                for (int y = 0; y < mCord.GetLength(1); y++)
                {
                    myFile.WriteLine(mCord[x, y]);
                }
            }
            myFile.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath + "\\Map.txt";
            FileStream fs = new FileStream(filepath, FileMode.Open);
            StreamReader myFile = new StreamReader(fs);

            for (int x = 0; x < mCord.GetLength(0); x++)
            {
                for (int y = 0; y < mCord.GetLength(1); y++)
                {
                    G = this.CreateGraphics();
                    int line = int.Parse(myFile.ReadLine());

                    if (line == 1)
                    {
                        G.DrawImage(bmpGrass, x * tileSize, y * tileSize);
                    }

                    else if (line == 2)
                    {
                        G.DrawImage(bmpWater, x * tileSize, y * tileSize);
                    }
                    else
                    {
                        G.FillRectangle(Brushes.Black, x*tileSize, y*tileSize, tileSize, tileSize);
                        G.DrawRectangle(Pens.PaleVioletRed, x*tileSize, y*tileSize, tileSize, tileSize);
                    }
                }
            }
            myFile.Close();
        }
    }
}
