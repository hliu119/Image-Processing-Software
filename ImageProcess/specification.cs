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
    public partial class specification : Form
    {
        private int[] countPixel;
        private int[, ,] values;
        private int[, ,] values1;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands1;
        private int bands2;
        public int[,] results1;   //结果的存储
        private bool draw;
        private int[] resultZFT;//规定化后的直方图
        public specification(int[, ,] v, int r, int c, int b)
        {
            InitializeComponent();
            values = v;
            values1 = v;
            countPixel = new int[256];
            rows = r;
            cols = c;
            bands1 = b;
            bands2 = b;
            results1 = new int[rows, cols];
            if (combo3.Items.Count != 0)
            {
                combo3.Items.Clear();
            }
            for (int i = 0; i < bands1; i++)
            {
                combo3.Items.Add("band " + (i + 1).ToString());
            }

            if (combo4.Items.Count != 0)
            {
                combo4.Items.Clear();
            }
            for (int i = 0; i < bands2; i++)
            {
                combo4.Items.Add("band " + (i + 1).ToString());
            }
            draw = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = combo3.Text.ToString();
            int index = b[b.Length - 1] - 49;
            string c = combo4.Text.ToString();
            int index1 = c[c.Length - 1] - 49;
            int[] pre = new int[256]; // 原来的直方图
            int[] cur = new int[256];//规定化的直方图
            int[] predistribution = new int[256]; //离散的概率的分布函数
            int[] curdistribution = new int[256];//规范化函数的分布函数
            int[,] Min = new int[256, 256];  //插的最小值
            int[] result = new int[256]; //映射后的结果
            double temp1 = 0, temp2 = 0;
            //统计直方图
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    pre[values[index, i, j]]++;
                }
            }
            //规规定化的函数
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    cur[values1[index1, i, j]]++;
                }
            }
            //计算拉伸后的离散的概率分布函数
            for (int i = 0; i < 256; i++)
            {
                temp1 += (double)pre[i] / (double)(rows * cols); //概率
                predistribution[i] = (int)(255 * temp1 + 0.5); //拉伸到0~255上

                temp2 += (double)cur[i] / (double)((0 + 255) * 255 / 2); //概率
                curdistribution[i] = (int)(255 * temp2 + 0.5);//拉伸到0~255上
            }
            //计算差值，确定关系
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    Min[i, j] = System.Math.Abs(predistribution[i] - curdistribution[j]);
                }
            }
            //差值最小的地方建立映射关系
            for (int i = 0; i < 256; i++)
            {
                int min = Min[i, 0];
                int m = 0;
                for (int j = 1; j < 256; j++)
                {
                    if (Min[i, j] < min)
                    {
                        min = Min[i, j];
                        m = j;
                    }
                }
                result[i] = m;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    values[index, i, j] = result[values[index, i, j]];
            }
            //输出图像
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    results1[i, j] = values[index, i, j];
                }
            }
            var bitmap1 = new Bitmap(cols, rows);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    int r = results1[i, j];
                    int g = results1[i, j];
                    int k = results1[i, j];
                    bitmap1.SetPixel(j, i, Color.FromArgb(r, g, k));
                }

            img imgform = new img(bitmap1);
            imgform.Show();
            //统计规定化后的直方图
            resultZFT = new int[256];
            for (int i = 0; i < 256; i++)
            {
                resultZFT[i] = 0;
            }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        resultZFT[results1[i, j]]++;
                    }
                }
                //绘制直方图
                draw = true;
                panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (draw == false)
            {
                return;
            }
            int maxPixel = 0;
            for (int i = 0; i < 256; i++)
            {
                    if (maxPixel < resultZFT[i])
                    {
                        maxPixel = resultZFT[i];
                    }
            }

            //画出坐标系
            Graphics g = e.Graphics;
            Pen curPen = new Pen(Brushes.Black, 1);

            g.DrawLine(curPen, 50, 240, 320, 240);
            g.DrawLine(curPen, 50, 240, 50, 30);
            g.DrawLine(curPen, 100, 240, 100, 242);
            g.DrawLine(curPen, 150, 240, 150, 242);
            g.DrawLine(curPen, 200, 240, 200, 242);
            g.DrawLine(curPen, 250, 240, 250, 242);
            g.DrawLine(curPen, 300, 240, 300, 242);
            g.DrawString("0", new Font("New Timer", 8), Brushes.Black, new PointF(46, 242));
            g.DrawString("50", new Font("New Timer", 8), Brushes.Black, new PointF(92, 242));
            g.DrawString("100", new Font("New Timer", 8), Brushes.Black, new PointF(139, 242));
            g.DrawString("150", new Font("New Timer", 8), Brushes.Black, new PointF(189, 242));
            g.DrawString("200", new Font("New Timer", 8), Brushes.Black, new PointF(239, 242));
            g.DrawString("250", new Font("New Timer", 8), Brushes.Black, new PointF(289, 242));
            g.DrawLine(curPen, 48, 40, 50, 40);
            g.DrawString("0", new Font("New Timer", 8), Brushes.Black, new PointF(34, 234));
            g.DrawString(maxPixel.ToString(), new Font("New Timer", 8), Brushes.Black, new PointF(18, 34));

            double temp = 0;
            for (int i = 0; i < 256; i++)
            {
                temp = 200.0 * resultZFT[i] / maxPixel;
                g.DrawLine(curPen, 50 + i, 240, 50 + i, 240 - (int)temp);
            }

            curPen.Dispose();
        }
    }
}
