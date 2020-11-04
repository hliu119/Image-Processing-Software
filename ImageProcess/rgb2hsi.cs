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
    public partial class rgb2hsi : Form
    {
        private int[, ,] data;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;

        public rgb2hsi(int[, ,] d, int r, int c, int b)
        {
            InitializeComponent();
            data = d;
            rows = r;
            cols = c;
            bands = b;
            if (sband1.Items.Count != 0)
            {
                sband1.Items.Clear();
                sband2.Items.Clear();
                sband3.Items.Clear();
            }
            for (int i = 0; i < bands; i++)
            {
                sband1.Items.Add("band " + (i + 1).ToString());
                sband2.Items.Add("band " + (i + 1).ToString());
                sband3.Items.Add("band " + (i + 1).ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double H, S;
            Bitmap bitmap = new Bitmap(cols, rows);
            var b1 = sband1.SelectedIndex;
            var b2 = sband2.SelectedIndex;
            var b3 = sband3.SelectedIndex;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double r = (data[b1,i, j]);
                    double g = (data[b2,i, j]);
                    double b = (data[b3,i, j]);

                    double num = 0.5 * ((r - g) + (r - b));
                    double den1 = Math.Sqrt((r - g) * (r - g) + (r - b) * (g - b));
                    if (den1 == 0)
                        H = 0;
                    else
                    {
                        double theta = Math.Acos(num / den1);
                        if (b > g)
                            H = (2 * Math.PI - theta) / (2 * Math.PI);
                        else
                            H = theta / (2 * Math.PI);
                    }
                    double min = (b > g) ? g : b;
                    min = (min > r) ? r : min;
                    double den2 = r + g + b;
                    if (den2 == 0)
                        S = 0;
                    else
                        S = 1 - 3 * min / den2;
                    double intensity = (r + g + b) / 3;

                    Color tmp = Color.FromArgb((int)(H * 255), (int)(S * 255), (int)(intensity));
                    bitmap.SetPixel(j, i, tmp);
                }
            }

            img m = new img(bitmap);
            m.Show();
        }
    }
}
