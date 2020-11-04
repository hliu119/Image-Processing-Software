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
    public partial class OIF : Form
    {
        //OIF计算
        public int[, ,] oifvalues; //数据values[b,i,j]中b是波段，i是行，j是列
        private int oifrows;      //数据的行数
        private int oifcols;      //数据的列数
        private int oifbands;     //数据的波段数
        private int[] oifselectband;//oif选中的三个波段 
        private double[] oifavg;//每个波段的平均值
        private double[] oifbandstdev;//每个波段的标准差
        private double[] oifconnected;//相关系数[0]=1-2;[1]=1-3;[2]=2-3

        public OIF(int r, int c, int b, int[, ,] v)
        {
            InitializeComponent();
            //传值
            oifrows = r;
            oifcols = c;
            oifbands = b;
            oifvalues = v;
            //初始化oif_cB1;oif_cB2;oif_cB3;
            if (oif_cB1.Items.Count != 0 || oif_cB2.Items.Count != 0 || oif_cB3.Items.Count != 0)
            {//初始化四个下拉菜单
                oif_cB1.Items.Clear();
                oif_cB2.Items.Clear();
                oif_cB3.Items.Clear();
            }
            for (int i = 0; i < oifbands; i++)
            {
                oif_cB1.Items.Add("band " + (i + 1).ToString());
                oif_cB2.Items.Add("band " + (i + 1).ToString());
                oif_cB3.Items.Add("band " + (i + 1).ToString());
            }
        }

        private int oif_getband()
        {

            string b1 = oif_cB1.Text.ToString();
            string b2 = oif_cB2.Text.ToString();
            string b3 = oif_cB3.Text.ToString();
            if (b1 != "" && b2 != "" && b3 != "")
            {
                oifselectband = new int[3];
                int index1 = b1[b1.Length - 1] - 49;
                int index2 = b2[b2.Length - 1] - 49;
                int index3 = b3[b3.Length - 1] - 49;
                oifselectband[0] = index1;
                oifselectband[1] = index2;
                oifselectband[2] = index3;
            }
            else
            {
                MessageBox.Show("缺少波段");
                return 0;
            }
            return 1;
        }

        private void oif_bt_Click(object sender, EventArgs e)
        {//开始计算OIF值
            double oifnum = 0;//记录OIF值
            int Bnum = 3;
            if (oif_getband() == 0)
            {//缺少某个波段
                return;
            }
            oif_getband();
            //开始计算OIF值
            //初始化标准差、相关系数、平均值
            oifbandstdev = new double[Bnum];
            oifconnected = new double[Bnum];
            oifavg = new double[Bnum];
            //开始计算标准差
            for (int i = 0; i < Bnum; i++)
            {
                oifavg[i] = 0;
                oifbandstdev[i] = 0;
                for (int x = 0; x < oifrows; x++)
                {
                    for (int y = 0; y < oifcols; y++)
                    {
                        oifavg[i] += oifvalues[oifselectband[i], x, y];
                    }
                }
                oifavg[i] = oifavg[i] / (oifrows * oifcols);
                for (int x = 0; x < oifrows; x++)
                {
                    for (int y = 0; y < oifcols; y++)
                    {
                        oifbandstdev[i] += Math.Pow((oifvalues[oifselectband[i], x, y] - oifavg[i]), 2.0);
                    }
                }
                oifbandstdev[i] = Math.Sqrt(oifbandstdev[i] / (oifrows * oifcols));
            }
            //结束标准差
            //开始相关系数
            oifconnected[0] = Math.Abs(oifeverytwo(oifselectband[0], oifselectband[1]));
            oifconnected[1] = Math.Abs(oifeverytwo(oifselectband[0], oifselectband[2]));
            oifconnected[2] = Math.Abs(oifeverytwo(oifselectband[1], oifselectband[2]));
            //结束相关系数
            oifnum = (oifbandstdev[0] + oifbandstdev[1] + oifbandstdev[2]) / (oifconnected[0] + oifconnected[1] + oifconnected[2]);
            //结束OIF
            oif_tB.Text = "";
            oif_tB.Text = oifnum.ToString();
        }

        private double oifeverytwo(int index1, int index2)
        {//计算两个波段之间的相关系数
            int totalnum = oifrows * oifcols;//记录每个波段的总像素数
            double[] stdev = new double[2];//记录标准差
            double[] avg = new double[2];//平均值
            double cc = 0;//记录协方差
            double result = 0;//记录相关系数
            //开始计算标注差
            //初始化标注差、平均值
            for (int i = 0; i < 2; i++)
            {
                stdev[i] = 0;
                avg[i] = 0;
            }
            //平均值
            for (int x = 0; x < oifrows; x++)
            {
                for (int y = 0; y < oifcols; y++)
                {
                    avg[0] += oifvalues[index1, x, y];
                    avg[1] += oifvalues[index2, x, y];
                }
            }
            avg[0] = avg[0] / totalnum;
            avg[1] = avg[1] / totalnum;
            //标准差
            for (int x = 0; x < oifrows; x++)
            {
                for (int y = 0; y < oifcols; y++)
                {
                    stdev[0] += Math.Pow((oifvalues[index1, x, y] - oifavg[0]), 2.0);
                    stdev[1] += Math.Pow((oifvalues[index2, x, y] - oifavg[1]), 2.0);
                }
            }
            stdev[0] = Math.Sqrt(stdev[0] / totalnum);
            stdev[1] = Math.Sqrt(stdev[1] / totalnum);
            //协方差
            for (int i = 0; i < oifrows; i++)
            {
                for (int j = 0; j < oifcols; j++)
                {
                    cc += (oifvalues[index1, i, j] - oifavg[0]) * (oifvalues[index2, i, j] - oifavg[1]);
                }
            }
            cc = cc / totalnum;
            result = cc / (stdev[0] * stdev[1]);

            return result;

        }

    }
}
