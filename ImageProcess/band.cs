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
    public partial class band : Form
    {
        private byte[,,] data;
        private int rows;      //数据的行数
        private int cols;      //数据的列数
        private int bands;
        public int[] selectBands;
        private bool isrgb;

        public band(string filename,int r,int c,int b, byte[, ,] d)
        {
            InitializeComponent();
            rows = r;
            cols = c;
            bands = b;
            data = d;
            listBox1.Items.Add(filename);
            if (grayband.Items.Count != 0)
            {
                grayband.Items.Clear();
            }
            for (int i = 0; i < bands; i++)
            {
                grayband.Items.Add("band " + (i + 1).ToString());
            }
            selectBands = null;
        }

        public void GetBands()
        {
            if (grayband.SelectedIndex == -1 
               && rband.SelectedIndex==-1
               && gband.SelectedIndex == -1
               && gband.SelectedIndex == -1)
            {
                MessageBox.Show("请输入波段！");
                return;
            }

            if (setgray.Checked)
            {
                string b = grayband.Text.ToString();
                int index = b[b.Length - 1] - 49;
                if (b != "")
                {
                    selectBands = new int[1];
                    selectBands[0] = index;
                }
            }

            if (setrgb.Checked)
            {
                string b1 = rband.Text.ToString();
                string b2 = gband.Text.ToString();
                string b3 = bband.Text.ToString();
                if (b1 != "" && b2 != "" && b3 != "")
                {
                    selectBands = new int[3];
                    int index1 = b1[b1.Length - 1] - 49;
                    int index2 = b2[b2.Length - 1] - 49;
                    int index3 = b3[b3.Length - 1] - 49;
                    selectBands[0] = index1;
                    selectBands[1] = index2;
                    selectBands[2] = index3;
                }
            }
        }

        private void setgray_CheckedChanged(object sender, EventArgs e)
        {
            if (setgray.Checked)
            { 
                rgb.Visible = false;
                gray.Visible = true;
                gray.BringToFront();
                if (grayband.Items.Count != 0)
                {
                        grayband.Items.Clear();            
                }
                for(int i=0;i<bands;i++){
                    grayband.Items.Add("band " + (i+1).ToString());
                }
                isrgb = false;
            }
            if(setrgb.Checked)
            {
                rgb.Visible = true;
                gray.Visible = false;
                rgb.BringToFront();
                for (int i = 0; i < bands; i++)
                {
                    rband.Items.Add("band " + (i + 1).ToString());
                    gband.Items.Add("band " + (i + 1).ToString());
                    bband.Items.Add("band " + (i + 1).ToString());
                }
                isrgb = true;
            }
        }

        private void showimg_Click(object sender, EventArgs e)
        {
            GetBands();
            if (selectBands.Length == 0)
            {
                MessageBox.Show("请输入波段！");
                return;
            }
            var bitmap = new Bitmap(cols, rows);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (isrgb)
                    {
                        int r = data[selectBands[0], i, j];
                        int g = data[selectBands[1], i, j];
                        int b = data[selectBands[2], i, j];
                        bitmap.SetPixel(j, i, Color.FromArgb(r, g, b));
                    }
                    else
                    {
                        int r = data[selectBands[0], i, j];
                        bitmap.SetPixel(j, i, Color.FromArgb(r, r, r));
                    }
                }
            }

            img imgform = new img(bitmap);
            imgform.Show();
        }
    }
}
