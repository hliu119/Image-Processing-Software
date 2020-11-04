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
    public partial class Cumulative_histogram : Form
    {
        public int[, ,] chvalues; //数据values[b,i,j]中b是波段，i是行，j是列
        private int chrows;      //数据的行数
        private int chcols;      //数据的列数
        private int chbands;     //数据的波段数
        private int[,] dnum;//记录结果的累积数 
        private double[,] chhz;//记录绘制的数值
        private int chdnum = 0;//记录有多少个不同的数值
        private int chindex;//记录选中的波段
        private bool draw;

        public Cumulative_histogram(int r, int c, int b, int[, ,] v)
        {
            InitializeComponent();
            chrows = r;
            chcols = c;
            chbands = b;
            chvalues = v;
            draw = false;
            //ch_cB初始化
            if (ch_cB.Items.Count != 0)
            {
                ch_cB.Items.Clear();
            }
            for (int i = 0; i < chbands; i++)
            {
                ch_cB.Items.Add("band " + (i + 1).ToString());
            }
        }

        private void ch_bt_Click(object sender, EventArgs e)
        {//显示累计直方图
            chdnum = 0;
            GetBands();
            chphoto();
            draw = true;
            ch_panel.Refresh();
        }

        public void GetBands()
        {//选择波段
            string b = ch_cB.Text.ToString();
            int index = b[b.Length - 1] - 49;
            if (b != "")
            {
                chindex = index;
            }
        }
        private void chphoto()
        {//计算累计直方图
            int totalnum = chrows * chcols;
            dnum = new int[chrows * chcols, 2];//[0]记录数值；[1]记录有几个数
            int[] temporarily = new int[256];
            //初始化dnum
            for (int i = 0; i < chrows * chcols; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    dnum[i, j] = 0;
                }
            }
            //无序排列所有的值以及出现的数量
            for (int i = 0; i < chrows; i++)
            {
                for (int j = 0; j < chcols; j++)
                {

                    for (int k = 0; k <= chdnum; k++)
                    {
                        if (k == chdnum)
                        {//没有存储过的值
                            dnum[k, 0] = chvalues[chindex, i, j];
                            dnum[k, 1]++;
                            chdnum++;
                            break;
                        }
                        if (chvalues[chindex, i, j] == dnum[k, 0])
                        {//存储过的值
                            dnum[k, 1]++;
                            break;
                        }

                    }
                }
            }

            //绘制数值
            chhz = new double[256, 2];
            for (int i = 0; i < 256; i++)
            {
                temporarily[i] = 0;
                chhz[i, 0] = i;
                chhz[i, 1] = 0;
            }
            for (int i = 0; i < chdnum; i++)
            {
                int k = dnum[i, 0];
                temporarily[k] = dnum[i, 1];
            }
            double chn = 0;
            for (int i = 0; i < 256; i++)
            {//大于有效值的部分
                chn = 0;
                for (int j = 0; j <= i; j++)
                {
                    chn += temporarily[j];
                }
                chhz[i, 1] = chn / totalnum;
            }
        }

        private int checkOrdered()
        {//检查是否有序
            int checknum = 0;
            for (int i = 0; i < chdnum - 1; i++)
            {
                if (dnum[i, 0] < dnum[i + 1, 0])
                {
                    checknum++;
                }
            }
            if (checknum == chdnum - 1)
            {
                return 1;
            }
            return 0;
        }

        private void ch_panel_Paint(object sender, PaintEventArgs e)
        {
            if (draw == false)
            {
                return;
            }

            //画出坐标系
            Graphics g = e.Graphics;
            Pen curPen = new Pen(Brushes.Black, 1);
            //x轴的坐标差
            double px = (chhz[chdnum - 1, 0] - chhz[0, 0]) / 5;
            double dx = (chdnum / 5);

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
            g.DrawString("1", new Font("New Timer", 8), Brushes.Black, new PointF(18, 34));

            double temp = 0;
            double x1 = 0;
            for (int i = 0; i < 256; i++)
            {
                temp = 200.0 * chhz[i, 1];
                x1 = 50 + i;
                g.DrawLine(curPen, (int)x1, 240, (int)x1, 240 - (int)temp);
            }

            curPen.Dispose();
        }
    }
}
