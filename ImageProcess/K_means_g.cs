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
    public partial class K_means_g : Form
    {
        //葛婧琳的K-means,有与form1相同的数据名=g数据名
        public int[, ,] gvalues; //数据values[b,i,j]中b是波段，i是行，j是列
        private int grows;      //数据的行数
        private int gcols;      //数据的列数
        private int gbands;     //数据的波段数
        public int[] g_selectband;//记录选中的波段
        private bool g_rgb;     //是否是rgb的
        private double[,] g_tzvalue;//类中心的特征值（多个波段的值）
        private double[,] g_ftz;//记录上次的中心特征值
        private int[,] g_centerxy;//记录初始坐标的x.y
        private int[,] g_Kvalues;//记录分类的值
        private int[] Snum;//记录分类的数量
        private int g_N;//记录有几个随机值
        private double g_zthreshold = 1;//记录类中心允许的差值
        private int[,] typecolor;//记录随机颜色 

        public K_means_g(int[, ,] v, int r, int c, int b)
        {//由Form1传到K-means-g的窗口
            InitializeComponent();
            gvalues = v;
            grows = r;
            gcols = c;
            gbands = b;

            if (g_cB1.Items.Count != 0)
            {//初始化四个下拉菜单
                g_cB1.Items.Clear();
                g_cB2.Items.Clear();
                g_cB3.Items.Clear();
                g_cB4.Items.Clear();
            }
            for (int i = 0; i < gbands; i++)
            {
                g_cB1.Items.Add("band " + (i + 1).ToString());
                g_cB2.Items.Add("band " + (i + 1).ToString());
                g_cB3.Items.Add("band " + (i + 1).ToString());
                g_cB4.Items.Add("band " + (i + 1).ToString());
            }
        }

        public void g_GetBands()
        {//选择单波段or多波段
            if (g_rb1.Checked)
            {//单波段
                g_rgb = false;
                string b = g_cB4.Text.ToString();
                int index = b[b.Length - 1] - 49;
                if (b != "")
                {
                    g_selectband = new int[1];
                    g_selectband[0] = index;
                }
            }

            if (g_rb2.Checked)
            {//多波段
                g_rgb = true;
                string b1 = g_cB1.Text.ToString();
                string b2 = g_cB2.Text.ToString();
                string b3 = g_cB3.Text.ToString();
                if (b1 != "" && b2 != "" && b3 != "")
                {
                    g_selectband = new int[3];
                    int index1 = b1[b1.Length - 1] - 49;
                    int index2 = b2[b2.Length - 1] - 49;
                    int index3 = b3[b3.Length - 1] - 49;
                    g_selectband[0] = index1;
                    g_selectband[1] = index2;
                    g_selectband[2] = index3;
                }
            }
        }

        private void g_b_showcolor_Click(object sender, EventArgs e)
        {
            //显示图像
            g_GetBands();//读取具体波段
            //显示图像
            var bitmap = new Bitmap(gcols, grows);
            for (int i = 0; i < grows; i++)
            {
                for (int j = 0; j < gcols; j++)
                {
                    if (g_rgb)
                    {
                        int r = gvalues[g_selectband[0], i, j];
                        int g = gvalues[g_selectband[1], i, j];
                        int b = gvalues[g_selectband[2], i, j];
                        bitmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                    else
                    {
                        int r = gvalues[g_selectband[0], i, j];
                        bitmap.SetPixel(i, j, Color.FromArgb(r, r, r));
                    }
                }
            }

            img imgform = new img(bitmap);
            imgform.Show();
        }


        private void g_rb1_CheckedChanged(object sender, EventArgs e)
        {//显示or隐藏g_p1=单波段，g_p2=多波段
            if (g_rb1.Checked)
            {//单波段
                g_p2.Visible = false;
                g_p1.Visible = true;

                if (g_cB4.Items.Count != 0)
                {
                    g_cB4.Items.Clear();
                }
                for (int i = 0; i < gbands; i++)
                {
                    g_cB4.Items.Add("band " + (i + 1).ToString());
                }
                g_rgb = false;
            }
            if (g_rb2.Checked)
            {//多波段
                g_p2.Visible = true;
                g_p1.Visible = false;

                if (g_cB1.Items.Count != 0 || g_cB2.Items.Count != 0 || g_cB3.Items.Count != 0)
                {
                    g_cB1.Items.Clear();
                    g_cB2.Items.Clear();
                    g_cB3.Items.Clear();
                }
                for (int i = 0; i < gbands; i++)
                {
                    g_cB1.Items.Add("band " + (i + 1).ToString());
                    g_cB2.Items.Add("band " + (i + 1).ToString());
                    g_cB3.Items.Add("band " + (i + 1).ToString());
                }
                g_rgb = true;
            }
        }

        private void g_b_Kmean_Click(object sender, EventArgs e)
        {

            g_GetBands();
            //开始计算K均值
            getNnum();//获得分类数g_N,初始化g_centerxy 、g_tzvalue、g_Kvalues、g_ftz
            Snum = new int[g_N];//Snum记录每一类有多少个点
            if (g_rgb == true)
            {//重复K均值计算
                KmeanCalculate(3);
                showKvalue(3);
            }
            else
            {
                KmeanCalculate(1);
                showKvalue(1);
            }
            MessageBox.Show("K-均值分类结束");
        }

        private int KmeanCalculate(int g_Bnum)
        { //迭代计算K均值
            //g_Bnum=波段数
            /*if (Checkkmeanend() == 1)
            {//检验是否在阈值范围内
                return 1;
            }*/
            //将上次的分类数清空
            for (int i = 0; i < g_N; i++)
            {
                Snum[i] = 0;
            }
            //将上次的中心tz值复制
            for (int i = 0; i < g_N; i++)
            {
                for (int j = 0; j < g_Bnum; j++)
                {
                    g_ftz[i, j] = g_tzvalue[i, j];
                }
            }
            //开始分类
            for (int i = 0; i < grows; i++)
            {
                for (int j = 0; j < gcols; j++)
                {//比较【i，j】
                    g_Kvalues[i, j] = g_N;//先将类别分为g_N
                    double minvalue = 0;//记录最小距离
                    double[] edcenter = new double[g_N];
                    for (int n = 0; n < g_N; n++)
                    {//n个类中心
                        edcenter[n] = 0;
                        for (int k = 0; k < g_Bnum; k++)
                        {//k个波段
                            edcenter[n] += Math.Pow(gvalues[g_selectband[k], i, j] - g_tzvalue[n, k], 2.0);
                        }
                        minvalue = edcenter[n];//最终记录了edcenter[g_N]的距离值
                    }
                    for (int n = 0; n < g_N; n++)
                    {//找最小距离
                        if (edcenter[n] <= minvalue)
                        {
                            minvalue = edcenter[n];
                            g_Kvalues[i, j] = n;
                        }
                    }
                    //分类结束，找到新的类中心tz值
                    Snum[g_Kvalues[i, j]]++;
                    //对g_Kvalues[i, j]的新中心
                    for (int k = 0; k < g_Bnum; k++)
                    {//（之前的值之和+该点的值）/总数=Snum[g_Kvalues[i, j]]+1
                        //初始的特征值也算做一个
                        g_tzvalue[g_Kvalues[i, j], k] = (g_tzvalue[g_Kvalues[i, j], k] * Snum[g_Kvalues[i, j]] + gvalues[g_selectband[k], i, j]) / (Snum[g_Kvalues[i, j]] + 1);
                    }
                }
            }

            if (Checkkmeanend() == 1)
            {//检验是否在阈值范围内
                return 1;
            }
            else
            {

                KmeanCalculate(g_Bnum);
            }
            return 0;
        }

        private int Checkkmeanend()
        {//检验K-mean的结束条件
            int checknum = 0;
            if (g_rgb == false)
            {//单波段
                for (int i = 0; i < g_N; i++)
                {
                    if (Math.Abs(g_tzvalue[i, 0] - g_ftz[i, 0]) < g_zthreshold)
                    {
                        checknum++;
                    }
                }
                if (checknum == g_N)
                {
                    return 1;
                }
            }
            else
            {//多波段
                for (int i = 0; i < g_N; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Math.Abs(g_tzvalue[i, j] - g_ftz[i, j]) < g_zthreshold)
                        {
                            checknum++;
                        }
                    }
                }
                if (checknum == g_N * 3)
                {
                    return 1;
                }
            }
            //判断几个特征中心没有变化、或者变化很小
            //否=0，是=1
            return 0;

        }

        private void getNnum()
        {//获得N个随机的坐标
            //得到分类数g_N
            switch (g_cB_kindnum.SelectedIndex)
            {
                case 0:
                    g_N = 2;
                    break;
                case 1:
                    g_N = 3;
                    break;
                case 2:
                    g_N = 4;
                    break;
                case 3:
                    g_N = 5;
                    break;
                case 4:
                    g_N = 6;
                    break;
                case 5:
                    g_N = 7;
                    break;
                case 6:
                    g_N = 8;
                    break;
                case 7:
                    g_N = 9;
                    break;
                case 8:
                    g_N = 10;
                    break;
                default:
                    break;
            }
            //初始化存储的初始坐标的x.y
            g_centerxy = new int[g_N, 2];//[i,0]=x,[i,1]=y
            typecolor = new int[g_N, 3];//记录颜色
            for (int i = 0; i < g_N; i++)
            {//随机得到x，y坐标
                //行
                g_centerxy[i, 0] = g_getRandom(0, grows - 1, g_N);
                //列
                g_centerxy[i, 1] = g_getRandom(0, gcols - 1, g_N);
                //R
                typecolor[i, 0] = g_getRandom(0, 255, g_N);
                //G
                typecolor[i, 1] = g_getRandom(0, 255, g_N);
                //B
                typecolor[i, 2] = g_getRandom(0, 255, g_N);
            }
            //初始化类中心的特征值
            if (g_rgb == false)
            {//单波段图像
                g_tzvalue = new double[g_N, 1];
                g_ftz = new double[g_N, 1];
                for (int i = 0; i < g_N; i++)
                {
                    g_tzvalue[i, 0] = gvalues[g_selectband[0], g_centerxy[i, 0], g_centerxy[i, 1]];
                    g_ftz[i, 0] = gvalues[g_selectband[0], g_centerxy[i, 0], g_centerxy[i, 1]];
                }
            }
            else
            {//多波段图像
                g_tzvalue = new double[g_N, 3];
                g_ftz = new double[g_N, 3];
                for (int i = 0; i < g_N; i++)
                {
                    g_tzvalue[i, 0] = gvalues[g_selectband[0], g_centerxy[i, 0], g_centerxy[i, 1]];
                    g_tzvalue[i, 1] = gvalues[g_selectband[1], g_centerxy[i, 0], g_centerxy[i, 1]];
                    g_tzvalue[i, 2] = gvalues[g_selectband[2], g_centerxy[i, 0], g_centerxy[i, 1]];
                    g_ftz[i, 0] = gvalues[g_selectband[0], g_centerxy[i, 0], g_centerxy[i, 1]];
                    g_ftz[i, 1] = gvalues[g_selectband[1], g_centerxy[i, 0], g_centerxy[i, 1]];
                    g_ftz[i, 2] = gvalues[g_selectband[2], g_centerxy[i, 0], g_centerxy[i, 1]];
                }
            }
            //初始化分类的值
            g_Kvalues = new int[grows, gcols];
            for (int i = 0; i < grows; i++)
            {
                for (int j = 0; j < gcols; j++)
                {
                    g_Kvalues[i, j] = 255;
                }
            }
            //获取阈值
            String s = g_tB1.Text;
            g_zthreshold = System.Convert.ToDouble(s);

        }

        private int g_getRandom(int minValue, int maxValue, int count)
        {//得到一个伪随机数
            int[] result = new int[count];
            //初始化result
            for (int i = 0; i < count; i++)
            {
                result[i] = -1;
            }
            for (int i = 0; i < count; i++)
            {
                if (result[count - 1] != -1)
                {
                    break;
                }
                Random rnd = new Random();
                int rr = rnd.Next(minValue, maxValue);
                for (int j = 0; j <= i; j++)
                { //比较该数重复出现
                    if (rr == result[j])
                    {
                        break;
                    }
                    else if (j == i)
                    {
                        result[j] = rr;
                    }
                }
                if (result[i] == -1)
                {
                    i--;
                }
            }
            return result[0];
        }

        private void showKvalue(int Bnum)
        {//显示K均值分类结果
            String str = "";
            for (int i = 0; i < g_N; i++)
            {
                str += "第" + (i + 1) + "个类中心:";
                for (int j = 0; j < Bnum; j++)
                {
                    str += g_tzvalue[i, j].ToString() + " ";
                }
                str += "\r\n";
            }
            textBox1.Text = str;
           
            //显示图像
            var gbitmap = new Bitmap(gcols, grows);
            for (int i = 0; i < grows; i++)
            {
                for (int j = 0; j < gcols; j++)
                {
                    int r = typecolor[g_Kvalues[i, j], 0];
                    int g = typecolor[g_Kvalues[i, j], 1];
                    int b = typecolor[g_Kvalues[i, j], 2];
                    gbitmap.SetPixel(j, i, Color.FromArgb(r, g, b));
                }
            }
            img gimgform = new img(gbitmap);
            gimgform.Show();
        }

        private void g_b_showcolor_Click_1(object sender, EventArgs e)
        {
            //显示图像
            g_GetBands();//读取具体波段
            //显示图像
            var bitmap = new Bitmap(gcols, grows);
            for (int i = 0; i < grows; i++)
            {
                for (int j = 0; j < gcols; j++)
                {
                    if (g_rgb)
                    {
                        int r = gvalues[g_selectband[0], i, j];
                        int g = gvalues[g_selectband[1], i, j];
                        int b = gvalues[g_selectband[2], i, j];
                        bitmap.SetPixel(j, i, Color.FromArgb(r, g, b));
                    }
                    else
                    {
                        int r = gvalues[g_selectband[0], i, j];
                        bitmap.SetPixel(i, j, Color.FromArgb(r, r, r));
                    }
                }
            }

            img imgform = new img(bitmap);
            imgform.Show();
        }

        private void K_means_g_Load(object sender, EventArgs e)
        {

        }

    }
}
