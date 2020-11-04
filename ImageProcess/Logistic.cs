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
    public partial class Logistic : Form
    {

        private int[, ,] data;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;

        public Logistic(int[, ,] d, int r, int c, int b)
        {
            InitializeComponent();
            data = d;
            rows = r;
            cols = c;
            bands = b;

            if (comboBox1.Items.Count != 0)
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
            }
            for (int i = 0; i < bands; i++)
            {
                comboBox1.Items.Add("band " + (i + 1).ToString());
                comboBox2.Items.Add("band " + (i + 1).ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index1 = comboBox1.SelectedIndex;
            int index2 = comboBox2.SelectedIndex;
            if (index1 == -1 || index2 == -1)
            {
                MessageBox.Show("请输入波段！");
                return;
            }

            double[, ,] newdata = new double[3, rows, cols];

            //大于
            if (radioButtonDayu.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (data[index1, i, j] > data[index2, i, j])
                        {
                            newdata[0, i, j] = 255;
                            newdata[1, i, j] = 255;
                            newdata[2, i, j] = 255;
                        }
                        else
                        {
                            newdata[0, i, j] = 0;
                            newdata[1, i, j] = 0;
                            newdata[2, i, j] = 0;
                        }
                       
                    }
                }
            }
            //小于
            else if (radioButtonXiaoyu.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (data[index1, i, j] < data[index2, i, j])
                        {
                            newdata[0, i, j] = 255;
                            newdata[1, i, j] = 255;
                            newdata[2, i, j] = 255;
                        }
                        else
                        {
                            newdata[0, i, j] = 0;
                            newdata[1, i, j] = 0;
                            newdata[2, i, j] = 0;
                        }

                    }
                }
            }
            //等于
            else if (radioButtonDengyu.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (data[index1, i, j] == data[index2, i, j])
                        {
                            newdata[0, i, j] = 255;
                            newdata[1, i, j] = 255;
                            newdata[2, i, j] = 255;
                        }
                        else
                        {
                            newdata[0, i, j] = 0;
                            newdata[1, i, j] = 0;
                            newdata[2, i, j] = 0;
                        }

                    }
                }
            }

            img form = new img(newdata, rows, cols);
            form.Show();
        }

        private void radioButtonDayu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDayu.Checked)
            {
                label5.Text = "大于";
            }
            if (radioButtonDengyu.Checked)
            {
                label5.Text = "等于";
            }
            if (radioButtonXiaoyu.Checked)
            {
                label5.Text = "小于";
            }
        }

        private void radioButtonXiaoyu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDayu.Checked)
            {
                label5.Text = "大于";
            }
            if (radioButtonDengyu.Checked)
            {
                label5.Text = "等于";
            }
            if (radioButtonXiaoyu.Checked)
            {
                label5.Text = "小于";
            }
        }

        private void radioButtonDengyu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDayu.Checked)
            {
                label5.Text = "大于";
            }
            if (radioButtonDengyu.Checked)
            {
                label5.Text = "等于";
            }
            if (radioButtonXiaoyu.Checked)
            {
                label5.Text = "小于";
            }
        }
    }
}
