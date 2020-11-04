using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace 计算图像
{
    public partial class maxlikehood : Form
    {
        int[, ,] data;
        int rows;
        int cols;
        int bands;
        string path;

        public maxlikehood(int [,,]d,int r,int c,int b)
        {
            InitializeComponent();
            data = d;
            rows = r;
            cols = c;
            bands = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sd = new OpenFileDialog();
            sd.Title = "打开文件";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                path = sd.FileName;
                textBox1.Text = path;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            ROI roi = new ROI(path);
            int n = 8;
            int i = 0;
            int [][]samples=new int[8][];
            samples[0] = new int[291];
            samples[1] = new int[76];
            samples[2] = new int[547];
            samples[3] = new int[221];
            samples[4] = new int[67];
            samples[5] = new int[30];
            samples[6] = new int[562];
            samples[7] = new int[460];
            double[] means = new double[8];
            double[] var2s = new double[8];

            double[,,] newdata = new double[3, rows, cols];

            for(int p=1;p<9;p++){
                int t = 0;
            for (int m = 0; m < rows; m++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (roi.type[m, k] == p)
                    {
                        samples[p-1][t++] = roi.data[m, k];
                    }
                }
                   
                }
            }
                for (i = 0; i < n; i++)
                {
                    means[i] = roi.cal_mean(samples[i], roi.kinds[i]);
                    var2s[i] = roi.cal_var2(samples[i], roi.kinds[i], means[i]);
                }

                int [,] color = new int[9, 3];
                color[0, 0] = 0;
                color[0, 1] = 0;
                color[0, 2] = 255;

                color[1, 0] = 0;
                color[1, 1] = 255;
                color[1, 2] = 255;

                color[2, 0] = 0;
                color[2, 1] = 255;
                color[2, 2] = 0;

                color[3, 0] = 0;
                color[3, 1] = 139;
                color[3, 2] = 139;

                color[4, 0] = 255;
                color[4, 1] = 0;
                color[4, 2] = 0;

                color[5, 0] = 255;
                color[5, 1] = 255;
                color[5, 2] = 255;

                color[6, 0] = 176;
                color[6, 1] = 48;
                color[6, 2] = 96;

                color[7, 0] = 0;
                color[7, 1] = 139;
                color[7, 1] = 0;



            for (int m = 0; m < rows; m++)
            {
                for (int k = 0; k < cols; k++)
                {
                    double max_score = 0;
                    int max_lable = 0;
                    for (i = 0; i < n; i++)
                    {
                        double the_houyan = roi.houyan(means[i], var2s[i], data[0,m,k]);
                        the_houyan = the_houyan * (1.0 / n) / (1.0 / 256);

                        if (the_houyan > max_score)
                        {
                            max_score = the_houyan;
                            max_lable = i;
                        }
                    }
                    data[0, m, k] = color[max_lable, 0];
                    data[1, m, k] = color[max_lable, 1];
                    data[2, m, k] = color[max_lable, 2];

                    newdata[0, m, k] = color[max_lable, 0];
                    newdata[1, m, k] = color[max_lable, 1];
                    newdata[2, m, k] = color[max_lable, 2];
                    
                }
            }
            img form = new img(newdata, rows, cols);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }





    }


    class ROI
    {
        public int[,] data;
        public int[,] type;
        public int rows = 800;
        public int cols = 660;
         public int[] kinds = {291,76,547,221,67,30,562,460};
      
        public ROI(string path)
        {
            int z = 0;
            data = new int[rows, cols];
            type = new int[rows, cols];
            StreamReader read = new StreamReader(path);
            string nextLine = null;
            int count = 0;
            int typevalue = 1;
            
            while ((nextLine = read.ReadLine()) != null)
            {
                if (count < 36)
                {
                    count++;
                    continue;
                }
                if (nextLine != "")
                {
                    string[] array = nextLine.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int x = Convert.ToInt32(array[1]);
                    int y = Convert.ToInt32(array[2]);
                    int value1 = Convert.ToInt32(array[5]);
                    data[y, x] = value1;
                    type[y, x] = typevalue;
                }
                else
                {
                    typevalue++;
                    z = 0;
                }
                

            }
            read.Close();
        }
       public  double cal_mean(int[] a, int n)
        {
            int i = 0;
            int j = 0;
            double sum = 0;
            for (i = 0; i < n; i++)
            {
                    sum += a[i];
            }
            return sum / n;
        }

       public  double cal_var2(int[] a, int n, double mean)
        {
            int i = 0;
            double sum = 0;
            for (i = 0; i < n; i++)
            {
                sum += (a[i] - mean) * (a[i] - mean);
            }
            return sum / (n - 1);
        }

       public  double houyan(double mean, double var2, double xi)
        {
            double zhishu = -0.5 * (xi - mean) * (xi - mean) / var2;
            return 1.0 / (Math.Sqrt(2 * 3.14159 * var2)) * Math.Exp(zhishu);
        }

       


    }
}
