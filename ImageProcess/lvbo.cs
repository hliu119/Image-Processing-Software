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
    public partial class lvbo : Form
    {

        private int[, ,] data;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;

        public lvbo(int[, ,] d, int r, int c, int b)
        {
            InitializeComponent();
            data = d;
            rows = r;
            cols = c;
            bands = b;

            if (comboBox1.Items.Count != 0)
            {
                comboBox1.Items.Clear();
            }
            for (int i = 0; i < bands; i++)
            {
                comboBox1.Items.Add("band " + (i + 1).ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            int size = Convert.ToInt32(textBox1.Text);//窗口大小
            int off = size / 2;

            if (index == -1)
            {
                MessageBox.Show("请输入波段！");
                return;
            }

            double[, ,] newdata = new double[3, rows, cols];

            if (radioButtonMean.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        List<double> res = new List<double>();
                        for (int a = -off; a <= off; a++)
                        {
                            if (i + a < 0 || i + a >= rows)
                                continue;
                            for (int b = -off; b <= off; b++)
                            {
                                if (j + b < 0 || j + b >= cols)
                                    continue;
                                res.Add(data[index, i + a, j + b]);
                            }
                        }
                        double r = res.Sum()/res.Count;
                        newdata[0, i, j] = r;
                        newdata[1, i, j] = r;
                        newdata[2, i, j] = r;
                    }                  
                }
            }
            else if(radioButtonMax.Checked){
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        List<double> res = new List<double>();
                        for (int a = -off; a <= off; a++)
                        {
                            if (i + a < 0 || i + a >= rows)
                                continue;
                            for (int b = -off; b <= off; b++)
                            {
                                if (j + b < 0 || j + b >= cols)
                                    continue;
                                res.Add(data[index, i + a, j + b]);
                            }
                        }
                        double r = res.Max();
                        newdata[0, i, j] = r;
                        newdata[1, i, j] = r;
                        newdata[2, i, j] = r;
                    }                  
                }
            }
            else if (radioButtonMin.Checked)
            {

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        List<double> res = new List<double>();
                        for (int a = -off; a <= off; a++)
                        {
                            if (i + a < 0 || i + a >= rows)
                                continue;
                            for (int b = -off; b <= off; b++)
                            {
                                if (j + b < 0 || j + b >= cols)
                                    continue;
                                res.Add(data[index, i + a, j + b]);
                            }
                        }
                        double r = res.Min();
                        newdata[0, i, j] = r;
                        newdata[1, i, j] = r;
                        newdata[2, i, j] = r;
                    }
                }
            }
            else if (radioButtonMedian.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        List<double> res = new List<double>();
                        for (int a = -off; a <= off; a++)
                        {
                            if (i + a < 0 || i + a >= rows)
                                continue;
                            for (int b = -off; b <= off; b++)
                            {
                                if (j + b < 0 || j + b >= cols)
                                    continue;
                                res.Add(data[index, i + a, j + b]);
                            }
                        }
                        double r = res[res.Count / 2];
                        newdata[0, i, j] = r;
                        newdata[1, i, j] = r;
                        newdata[2, i, j] = r;
                    }
                }
            }
            else if (radioButtonTIDU.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        List<double> res = new List<double>();
                        for (int a = -off; a <= off; a++)
                        {
                            if (i + a < 0 || i + a >= rows)
                                continue;
                            for (int b = -off; b <= off; b++)
                            {
                                if (j + b < 0 || j + b >= cols)
                                    continue;
                                if (a == 0 && b == 0)
                                    continue;
                                if(data[index, i, j] == data[index, i + a, j + b])
                                    continue;
                                res.Add(1.0/Math.Abs(((double)data[index, i, j] - (double)data[index, i + a, j + b])));
                            }
                        }

                        double c = 2*res.Sum();
                        double r = 0;
                        int x = 0;
                        for (int a = -off; a <= off; a++)
                        {
                            if (i + a < 0 || i + a >= rows)
                                continue;
                            for (int b = -off; b <= off; b++)
                            {
                                if (j + b < 0 || j + b >= cols)
                                    continue;
                                if (a == 0 && b == 0)
                                    continue;
                                if (data[index, i, j] == data[index, i + a, j + b])
                                    continue;
                                r += (double)data[index, i + a, j + b] * res[x] / c;
                                x++;
                            }
                        }
                        r += (double)data[index, i, j] * 0.5;
                      
                        newdata[0, i, j] = r;
                        newdata[1, i, j] = r;
                        newdata[2, i, j] = r;
                    }
                }
            }

            img form = new img(newdata, rows, cols);
            form.Show();
        }

     
    }
}
