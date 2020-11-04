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
    public partial class stretch : Form
    {
        private int[] countPixel;
        private int[, ,] values;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;
        private bool draw;
        public int[,] results1;   //结果的存储
        public stretch(int[, ,] v, int r, int c, int b)
        {
            InitializeComponent();
            values = v;
            countPixel = new int[256];
            rows = r;
            cols = c;
            bands = b;
            draw = false;
            results1 = new int[rows, cols];
            if (combo1.Items.Count != 0)
            {
                combo1.Items.Clear();
            }
            for (int i = 0; i < bands; i++)
            {
                combo1.Items.Add("band " + (i + 1).ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = combo1.Text.ToString();
            int index = b[b.Length - 1] - 49;
            // byte m = 0,n=255;
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double max = (byte)x;
            double min = (byte)y;

            if (x < 0 || y > 255)
            {
                MessageBox.Show("请输入0~255范围内的值");
                return;
            }


            //计算最小灰度级
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (min > values[index, i, j])
                        min = values[index, i, j];
                    if (max < values[index, i, j])
                        max = values[index, i, j];
                }
            }

            double p;//得到斜率
            p = (y - x) / (max - min);
            //灰度拉伸
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    results1[i, j] = (int)((p * (values[index, i, j] - min)) + x + 0.5);
                }
            }
            draw = true;
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (draw == false)
            {
                return;
            }

            var bitmap1 = new Bitmap(cols, rows);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    int r = results1[i, j];
                    int gg = results1[i, j];
                    int b = results1[i, j];
                    bitmap1.SetPixel(j, i, Color.FromArgb(r, gg, b));
                }

            img imgform = new img(bitmap1,1);
            imgform.Show();

            string bb = combo1.Text.ToString();
            int index = bb[bb.Length - 1] - 49;

            byte temp = 0;
            int maxPixel = 0;
            Array.Clear(countPixel, 0, 256);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    temp = (byte)results1[i, j];
                    countPixel[temp]++;
                    if (countPixel[temp] > maxPixel)
                    {
                        maxPixel = countPixel[temp];
                    }
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

            double temp2 = 0;
            for (int i = 0; i < 256; i++)
            {
                temp2 = 200.0 * countPixel[i] / maxPixel;
                g.DrawLine(curPen, 50 + i, 240, 50 + i, 240 - (int)temp2);
            }

            curPen.Dispose();

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
