using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算图像
{
    public partial class KT_Bright : Form
    {
        public KT_Bright(double[, ,] data, int rows, int cols)
        {
            InitializeComponent();

            int[, ,] values = new int[3, rows, cols];
            List<double> listr = new List<double>();
            List<double> listg = new List<double>();
            List<double> listb = new List<double>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    listr.Add(data[0, i, j]);
                    listg.Add(data[1, i, j]);
                    listb.Add(data[2, i, j]);
                }
            }
            double rmax = listr.Max();
            double gmax = listg.Max();
            double bmax = listb.Max();

            double rmin = listr.Min();
            double gmin = listg.Min();
            double bmin = listb.Min();


            Bitmap newBitmap = new Bitmap(cols, rows);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double r = rmin, g = gmin, b = bmin;
                    if (rmax != rmin)
                        r = ((double)data[0,i,j] - rmin) / (rmax - rmin) * 255;
                    if (gmax != gmin)
                        g = ((double)data[1, i, j] - gmin) / (gmax - gmin) * 255;
                    if (bmax != bmin)
                        b = ((double)data[2, i, j] - bmin) / (bmax - bmin) * 255;

                    newBitmap.SetPixel(j, i, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }
            pictureBox1.Image = newBitmap.Clone() as Image;
        }

    }
}


