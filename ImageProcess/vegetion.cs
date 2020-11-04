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
    public partial class vegetion : Form
    {
        private int[, ,] data;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;

        public vegetion(int[, ,] d, int r, int c, int b)
        {
            InitializeComponent();
            data = d;
            rows = r;
            cols = c;
            bands = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double[, ,] newdata = new double[3, rows, cols];

            if (radioButtonNDVI.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        newdata[0, i, j] = ((double)data[3, i, j] - (double)data[2, i, j]) / ((double)data[3, i, j] + (double)data[2, i, j]);
                        newdata[1, i, j] = ((double)data[3, i, j] - (double)data[2, i, j]) / ((double)data[3, i, j] + (double)data[2, i, j]);
                        newdata[2, i, j] = ((double)data[3, i, j] - (double)data[2, i, j]) / ((double)data[3, i, j] + (double)data[2, i, j]);
                    }
                }  
            }
            else if (radioButtonRVI.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (data[3, i, j] != 0)
                        {
                            newdata[0, i, j] = ((double)data[3, i, j] / (double)data[2, i, j]);
                            newdata[1, i, j] = ((double)data[3, i, j] / (double)data[2, i, j]);
                            newdata[2, i, j] = ((double)data[3, i, j] / (double)data[2, i, j]);
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
            else if (radioButtonDVI.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        newdata[0, i, j] = ((double)data[3, i, j] - (double)data[2, i, j]);
                        newdata[1, i, j] = ((double)data[3, i, j] - (double)data[2, i, j]);
                        newdata[2, i, j] = ((double)data[3, i, j] - (double)data[2, i, j]);
                    }
                }
            }
            else if (radioButtonNDWI.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        newdata[0, i, j] = ((double)data[1, i, j] - (double)data[3, i, j]) / ((double)data[3, i, j] + (double)data[1, i, j]);
                        newdata[1, i, j] = ((double)data[1, i, j] - (double)data[3, i, j]) / ((double)data[3, i, j] + (double)data[1, i, j]);
                        newdata[2, i, j] = ((double)data[1, i, j] - (double)data[3, i, j]) / ((double)data[3, i, j] + (double)data[1, i, j]);
                    }
                }
            }
            else if (radioButtonNDBI.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        newdata[0, i, j] = ((double)data[4, i, j] - (double)data[3, i, j]) / ((double)data[3, i, j] + (double)data[4, i, j]);
                        newdata[1, i, j] = ((double)data[4, i, j] - (double)data[3, i, j]) / ((double)data[3, i, j] + (double)data[4, i, j]);
                        newdata[2, i, j] = ((double)data[4, i, j] - (double)data[3, i, j]) / ((double)data[3, i, j] + (double)data[4, i, j]);
                    }
                }
            }
            img form = new img(newdata, rows, cols);
            form.Show();
        }
    }
}
