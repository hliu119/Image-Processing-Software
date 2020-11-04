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
    public partial class juzhen : Form
    {
        private int[,] matrix;
        private int rows;
        private int cols;
        public juzhen(int [,]x,int r,int c)
        {
            InitializeComponent();
            matrix = x;

            rows = r;
            cols = c;
        }

        private void juzhen_Load(object sender, EventArgs e)
        {
            string temp = null, str = null;
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    temp = matrix[i, j].ToString();
                    temp = temp.PadLeft(12, ' ');
                    str += temp;   
                }
                str += "\n\n";
            }

            label1.Text = str;
        }

    }
}
