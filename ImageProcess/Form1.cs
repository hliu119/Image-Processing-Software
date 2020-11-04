using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 计算图像
{

    public partial class Form1 : Form
    {

        private Bitmap bitmap; //图像
        public int[,,] values; //数据values[b,i,j]中b是波段，i是行，j是列
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;     //数据的波段数

        public Form1()
        {
            InitializeComponent();
        }

        private void 打开jpg图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            values = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "打开文件";
            openFileDialog1.Filter = "JPG文件|*.jpg|PNG文件|*.png|BMP文件|*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                bitmap = (Bitmap)Image.FromFile(path);
                img f = new img(bitmap);
                f.Show();
                string[] name = path.Split('\\');
                string file = name[name.Length - 1];

                rows = bitmap.Height;
                cols = bitmap.Width;
                bands = 3;
                values = new int[3, rows, cols];
                byte [,,] tempdata = new byte[3,rows,cols];
                for (int b = 0; b < bands; b++)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Color color = bitmap.GetPixel(j, i);
                            values[0, i, j] = color.R;
                            values[1, i, j] = color.G;
                            values[2, i, j] = color.B;
                            tempdata[0, i, j] = color.R;
                            tempdata[1, i, j] = color.G;
                            tempdata[2, i, j] = color.B;
                        }
                    }
                }

                
            }
        }


        private void 直方图ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (values.Length > 0)
            {
                histogram h = new histogram(values, rows, cols, bands);
                h.Show();
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            values = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "打开文件";
            openFileDialog1.Filter = "HDR文件|*.hdr";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                string[] name = path.Split('\\');
                string file = name[name.Length - 1];

                //value中的data数组是数据
                HDRdata value = new HDRdata(path);
                rows = value.lines;
                cols = value.samples;
                bands = value.bands;

                values = new int[bands, rows, cols];
                for (int b = 0; b < bands; b++)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            values[b, i, j] = value.data[b, i, j];
                        }
                    }
                }

                //这个窗口是显示波段的窗口
                band bandselectform = new band(file, rows, cols, bands, value.data);
                bandselectform.Show();
            }
        }

        private void 均值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stastic form1 = new stastic(values, rows, cols, bands);
            form1.Show();
        }


        private void 相关系数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            covariation form3 = new covariation(values, rows, cols, bands);
            form3.Show();
        }

        private void rGBHSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rgb2hsi form4 = new rgb2hsi(values, rows, cols, bands);
            form4.Show();
        }

        private void 极差纹理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jicha form2 = new jicha(values, rows, cols, bands);
            form2.Show();
        }

        private void kMeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //传参+显示窗口
            //调试阶段没有判断是否读数据
            K_means_g g = new K_means_g(values, rows, cols, bands);
            g.Show();
        }

        private void oIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OIF计算
            OIF o_g = new OIF(rows, cols, bands, values);
            o_g.Show();
        }

        private void 代数运算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caculate form3 = new caculate(values, rows, cols, bands);
            form3.Show();
        }

        private void 植被指数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vegetion form4 = new vegetion(values, rows, cols, bands);
            form4.Show();
        }

        private void 逻辑运算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logistic form5 = new Logistic(values, rows, cols, bands);
            form5.Show();
        }

        private void 均值滤波ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvbo form6 = new lvbo(values, rows, cols, bands);
            form6.Show();
        }

        private void 累计直方图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cumulative_histogram g_ch = new Cumulative_histogram(rows, cols, bands, values);
            g_ch.Show();
        }

        private void kT变换ToolStripMenuItem_Click(object sender, EventArgs e)
        {//K-T变换-葛婧琳
            //img(double[, ,] data, int rows, int cols)
            if (bands != 7)
            {
                MessageBox.Show("错误！");
                return;
            }
            double[, ,] KTvalue = new double[4, rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    KTvalue[0, i, j] = 0.2909 * values[0, i, j] + 0.2493 * values[1, i, j] + 0.4806 * values[2, i, j] + 0.5568 * values[3, i, j] + 0.4438 * values[4, i, j] + 0.1706 * values[6, i, j] + 10.3695;
                    KTvalue[1, i, j] = (-0.2728) * values[0, i, j] - 0.2174 * values[1, i, j] - 0.5508 * values[2, i, j] + 0.7221 * values[3, i, j] + 0.0733 * values[4, i, j] - 0.1648 * values[6, i, j] - 0.7310;
                    KTvalue[2, i, j] = 0.1446 * values[0, i, j] + 0.1761 * values[1, i, j] + 0.3322 * values[2, i, j] + 0.3396 * values[3, i, j] - 0.6210 * values[4, i, j] - 0.4186 * values[6, i, j] - 3.3828;
                    KTvalue[3, i, j] = 0.8461 * values[0, i, j] - 0.0731 * values[1, i, j] - 0.4640 * values[2, i, j] - 0.0032 * values[3, i, j] - 0.0492 * values[4, i, j] + 0.0119 * values[6, i, j] + 0.7879;
                }
            }

            double[, ,] Brightness = new double[3, rows, cols];//亮度
            double[, ,] Greenness = new double[3, rows, cols];//绿度
            double[, ,] Wetness = new double[3, rows, cols];//湿度
            double[, ,] Hazeness = new double[3, rows, cols];//霾

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    //亮度
                    Brightness[0, i, j] = KTvalue[0, i, j];
                    Brightness[1, i, j] = KTvalue[0, i, j];
                    Brightness[2, i, j] = KTvalue[0, i, j];
                    //绿度
                    Greenness[0, i, j] = KTvalue[1, i, j];
                    Greenness[1, i, j] = KTvalue[1, i, j];
                    Greenness[2, i, j] = KTvalue[1, i, j];
                    //湿度
                    Wetness[0, i, j] = KTvalue[2, i, j];
                    Wetness[1, i, j] = KTvalue[2, i, j];
                    Wetness[2, i, j] = KTvalue[2, i, j];
                    //霾
                    Hazeness[0, i, j] = KTvalue[3, i, j];
                    Hazeness[1, i, j] = KTvalue[3, i, j];
                    Hazeness[2, i, j] = KTvalue[3, i, j];
                }
            }

            KT_Bright kt_B = new KT_Bright(Brightness, rows, cols);
            kt_B.Show();
            KT_Green kt_G = new KT_Green(Greenness, rows, cols);
            kt_G.Show();
            KT_Wet kt_W = new KT_Wet(Wetness, rows, cols);
            kt_W.Show();
            KT_haze kt_H = new KT_haze(Hazeness, rows, cols);
            kt_H.Show();
            img kt = new img(KTvalue, rows, cols);
            kt.Show();
        }

        private void 直方图均衡化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (values.Length > 0)
            {
                equalization a = new equalization(values, rows, cols, bands);
                a.Show();
            }
        }

        private void 线性拉伸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (values.Length > 0)
            {
                stretch s = new stretch(values, rows, cols, bands);
                s.Show();
            }
        }

        private void 共生矩阵ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (values.Length > 0)
            {
                GSJZ gsjz = new GSJZ(values, rows, cols, bands);
                gsjz.Show();
            }
        }

        private void 直方图规定化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (values.Length > 0)
            {
                specification ZFTGDH = new specification(values, rows, cols, bands);
                ZFTGDH.Show();
            }
        }

        private void 协方差ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            covariation form3 = new covariation(values, rows, cols, bands);
            form3.Show();
        }

        private void sobel算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 最大似然法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (values.Length > 0)
            {
                maxlikehood mlh = new maxlikehood(values, rows, cols, bands);
                mlh.Show();
            }
        }




    }

    public class HDRdata
    {
        public int samples;
        public int lines;
        public int bands;
        public string interleave;
        public byte [,,] data;		

        public HDRdata(string path)
        {
            StreamReader  sr = new StreamReader (path);
            string str = null;
            string []words = null;
          
            while ((str = sr.ReadLine()) != null) 
            {
                words = str.Split(' ');
                if(words[0]=="samples")
                    samples = Convert.ToInt32(words[words.Length-1]);
                if(words[0]=="lines")
                    lines = Convert.ToInt32(words[words.Length - 1]);
                if(words[0]=="bands")
                    bands = Convert.ToInt32(words[words.Length - 1]);
                if(words[0]=="interleave")
                {
                    interleave = words[words.Length - 1];
                    break;
                }
            }
            sr.Close();

            string newpath = path.Substring(0, path.Length - 4);

            BinaryReader br = new BinaryReader(File.Open(newpath, FileMode.Open));

            //波段，行，列
            data = new byte[bands,lines,samples];
            int s = 0, l = 0, b = 0;
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                if (s == samples)
                {
                    s = 0;
                    l++;
                    if (l == lines)
                    {
                        l = 0;
                        b++;
                    }
                }
                data[b,l,s] = br.ReadByte();
                s++;
            }
        }
    }
}
