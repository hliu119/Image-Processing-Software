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
    public partial class jicha : Form
    {
        private int[, ,] data;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;
        private int index;

        public jicha(int[,,]d,int r,int c,int b)
        {
            InitializeComponent();
            data = d;
            rows = r;
            cols = c;
            bands = b;
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

            Bitmap bitmap = new Bitmap(cols, rows); //初始化bitmap

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int rgbNumber = calculateRange(i, j, index);
                    bitmap.SetPixel(j, i, Color.FromArgb(rgbNumber, rgbNumber, rgbNumber));
                }
            }
            img imgform = new img(bitmap);
            imgform.Show();
        }


        public int calculateRange(int x, int y,int index)
        {
            List<int> list = new List<int>();

            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if ((i >= 0 && i <= rows - 1) && (j >= 0 && j <= cols - 1))
                    {
                        list.Add(data[index, i, j]);
                    }
                }
            }

            return list.Max() - list.Min();
        }

    }
}
