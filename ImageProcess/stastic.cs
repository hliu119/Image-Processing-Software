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
    public partial class stastic : Form
    {
        private int[, ,] values;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;
        private int index;

        public stastic(int[,,] v,int r,int c,int b)
        {
            InitializeComponent();
            values = v;
            rows = r;
            cols = c;
            bands = b;
            if (sbands.Items.Count != 0)
            {
                sbands.Items.Clear();
            }
            for (int i = 0; i < bands; i++)
            {
                sbands.Items.Add("band " + (i + 1).ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = sbands.Text.ToString();
            index = b[b.Length - 1] - 49;

            double average1 = 0;
            double variance1 = 0;
            double comp1 = 0;
            double maxv1 = 0;
            double minv1 = 255;
            double maxmin1 = 0;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    average1 += ((double)values[index, i, j] / (double)rows / (double)cols);
                    if (values[index, i, j] < minv1)
                    {
                        minv1 = values[index, i, j];
                    }
                    if (values[index, i, j] > maxv1)
                    {
                        maxv1 = values[index, i, j]; 
                    }
                }
            }

            double sum=0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += (values[index, i, j] - average1)*(values[index, i, j] - average1);
                }
            }

            variance1 = sum/(double)rows/(double)cols;
            comp1 = (maxv1 - minv1) / (maxv1 + minv1);
            maxmin1 = maxv1 - minv1;

            average1 = Math.Round(average1, 2);
            variance1 = Math.Round(variance1, 2);
            comp1 = Math.Round(comp1, 2);
            maxv1 = Math.Round(maxv1, 2);
            minv1 = Math.Round(minv1, 2);
            maxmin1 = Math.Round(maxmin1, 2);

            average.Visible = true;
            variance.Visible = true;
            comp.Visible = true;
            maxv.Visible = true;
            minv.Visible = true;
            maxmin.Visible = true;

            average.Text = average1.ToString();
            variance.Text = variance1.ToString();
            comp.Text = comp1.ToString();
            maxv.Text = maxv1.ToString();
            minv.Text = minv1.ToString();
            maxmin.Text = maxmin1.ToString();

        }
    }
}
