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
    public partial class covariation : Form
    {
        private int[, ,] data;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;

        public covariation(int[, ,] d, int r, int c, int b)
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
            }
            for (int i = 0; i < bands; i++)
            {
                sband1.Items.Add("band " + (i + 1).ToString());
                sband2.Items.Add("band " + (i + 1).ToString());
            }
        }

        private void CovVar(int index1, int index2, out double cov, out double covvar)
        {
            //计算两个波段之间的相关系数
            int totalnum = rows * cols;  //记录每个波段的总像素数

            double stdev1 = 0;   //方差
            double stdev2 = 0;   //方差
            double cc = 0;//记录协方差
            double avg1 = 0;//每个波段的平均值
            double avg2 = 0;//每个波段的平均值

            //均值
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    avg1 += (double)data[index1, i, j] / (double)rows / (double)cols;
                    avg2 += (double)data[index2, i, j] / (double)rows / (double)cols;
                }
            }

            //标准差
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    stdev1 += Math.Pow((data[index1, x, y] - avg1), 2.0);
                    stdev2 += Math.Pow((data[index2, x, y] - avg2), 2.0);
                }
            }
            stdev1 = Math.Sqrt(stdev1 / totalnum);
            stdev2 = Math.Sqrt(stdev2 / totalnum);

            //协方差
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    cc += (data[index1, i, j] - avg1) * (data[index2, i, j] - avg2);
                }
            }
            cc = cc / totalnum;
            cov = cc;
            covvar = cov / stdev1 / stdev2;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int index1 = sband1.SelectedIndex;
            int index2 = sband2.SelectedIndex;
            double cov, covvar;
            CovVar(index1, index2, out cov, out covvar);
            xiefangcha.Text = Math.Round(cov,8).ToString();
            xiangguan.Text = Math.Round(covvar,8).ToString();
        }
    }
}
