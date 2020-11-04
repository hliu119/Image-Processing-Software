﻿using System;
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
    public partial class histogram : Form
    {
        private int[] countPixel;
        private int maxPixel;
        private int[,,] values;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;
        private bool draw;

        public histogram(int[,,] v,int r,int c,int b)
        {
            InitializeComponent();
            values = v;
            countPixel = new int[256];
            rows = r;
            cols = c;
            bands = b;
            draw = false;
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
            int index = b[b.Length - 1] - 49;
            //统计直方图信息
            byte temp = 0;
            maxPixel = 0;
            Array.Clear(countPixel, 0, 256);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    temp = (byte)values[index, i, j];
                    countPixel[temp]++;
                    if (countPixel[temp] > maxPixel)
                    {
                        maxPixel = countPixel[temp];
                    }
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
                temp = 200.0 * countPixel[i] / maxPixel;
                g.DrawLine(curPen, 50 + i, 240, 50 + i, 240 - (int)temp);
            }

            curPen.Dispose();
        }

    }
}
