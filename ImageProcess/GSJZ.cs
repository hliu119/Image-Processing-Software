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
    public partial class GSJZ : Form
    {
        private int[, ,] values; //数据values[b,i,j]中b是波段，i是行，j是列
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;     //数据的波段数values, rows, cols, bands
        private int[,] graynewvalue;//记录灰度压缩后的数据
        private int selectBands;//记录选中的单波段
        private int Graylevel;//记录灰度级
        private int x_a;//记录x轴的偏移量
        private int y_b;//记录y轴的偏移量
        private int[,] resultvalue;//记录共生矩阵
        public GSJZ(int[, ,] v, int r, int c, int b)
        {
            InitializeComponent();
            values = v;
            rows = r;
            cols = c;
            bands = b;
            if (GSJZ_cB1.Items.Count != 0)
            {
                GSJZ_cB1.Items.Clear();
            }
            for (int i = 0; i < bands; i++)
            {//波段号
                GSJZ_cB1.Items.Add("band " + (i + 1).ToString());
            }
            if (GSJZ_cB2.Items.Count != 0)
            {
                GSJZ_cB2.Items.Clear();
            }
            for (int i = 0; i < 8; i++)
            {
                int a = (int)Math.Pow(2, (double)i + 1) - 1;
                GSJZ_cB2.Items.Add("0-" + a.ToString());
            }

            selectBands = -1;//-1=没有选择
            Graylevel = -1;//没有选择
            x_a = -1;//没有选择
            y_b = -1;//没有选择
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //计算共生矩阵
            getparameter();
            if (selectBands == -1 || Graylevel == -1 || x_a == -1 || y_b == -1)
            {
                MessageBox.Show("有参数没选择！");
                return;
            }
            //开始计算共生矩阵
            //先进行灰度压缩
            compressiongray();
            //开始计算
            resultvalue = new int[Graylevel, Graylevel];
            //初始化结果矩阵
            for (int i = 0; i < Graylevel; i++)
            {
                for (int j = 0; j < Graylevel; j++)
                {
                    resultvalue[i, j] = 0;
                }
            }
            int num1 = 0;//记录f1的值
            int num2 = 0;//记录f2的值
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    num1 = graynewvalue[i, j];
                    if (i + x_a >= rows || j + y_b >= cols)
                    {//如果越界就下一个
                        continue;
                    }
                    else
                    {
                        num2 = graynewvalue[i + x_a, j + y_b];
                    }
                    resultvalue[num1, num2]++;
                }
            }
            String GSJZstr = "";
            for (int i = 0; i < Graylevel; i++)
            {
                GSJZstr = GSJZstr + "\t" + i.ToString();
            }
            GSJZstr += "\n";
            for (int i = 0; i < Graylevel; i++)
            {
                GSJZstr = GSJZstr + i.ToString();
                for (int j = 0; j < Graylevel; j++)
                {
                    GSJZstr = GSJZstr + "\t" + resultvalue[i, j].ToString();
                }
                GSJZstr += "\n";
            }
            richTextBox1.Text = GSJZstr;
        }

        private void getparameter()
        {//获取参数
            //获取波段
            string b = GSJZ_cB1.Text.ToString();
            int index = b[b.Length - 1] - 49;
            if (b != "")
            {
                selectBands = index;
            }
            //获取灰度级数
            string g = GSJZ_cB2.Text.ToString();
            if (g != "")
            {
                Graylevel = (int)Math.Pow(2, (double)(GSJZ_cB2.SelectedIndex + 1));
            }
            //获取x_a,y_b
            if (GSJZ_tBx.Text != "")
            {
                x_a = Convert.ToInt32(GSJZ_tBx.Text);
            }
            if (GSJZ_tBy.Text != "")
            {
                y_b = Convert.ToInt32(GSJZ_tBy.Text);
            }
        }

        private void compressiongray()
        {//压缩灰度级
            int max = values[selectBands, 0, 0];
            int min = values[selectBands, 0, 0];//原图像灰度值的最大最小
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (max < values[selectBands, i, j])
                    {
                        max = values[selectBands, i, j];
                    }
                    if (min > values[selectBands, i, j])
                    {
                        min = values[selectBands, i, j];
                    }
                }
            }
            graynewvalue = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    graynewvalue[i, j] = (values[selectBands, i, j] - min) * (Graylevel - 1) / (max - min);
                }
            }
        }


    }
}
