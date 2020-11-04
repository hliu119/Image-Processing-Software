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
    public partial class img : Form
    {
        private Bitmap newBitmap;
        private int[, ,] newdata;
        private int rows;
        private int cols;
        private int bands;

        public img(Bitmap bitmap)
        {
            InitializeComponent();
            
            rows = bitmap.Height;
            cols = bitmap.Width;

            newdata = new int[3, rows, cols];
            int [,,] values = new int[3, rows, cols];
            List<int> listr = new List<int>();
            List<int> listg = new List<int>();
            List<int> listb = new List<int>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Color color = bitmap.GetPixel(j, i);
                    listr.Add(color.R);
                    listg.Add(color.G);
                    listb.Add(color.B);
                }
            }
            double rmax = listr.Max();
            double gmax = listg.Max();
            double bmax = listb.Max();

            double rmin = listr.Min();
            double gmin = listg.Min();
            double bmin = listb.Min();


            newBitmap = new Bitmap(cols, rows);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double r = rmin, g = gmin, b = bmin;
                    Color color = bitmap.GetPixel(j, i);
                    
                    if(rmax!=rmin)
                       r = ((double)color.R - rmin) / (rmax - rmin) * 255;
                    if(gmax!=gmin)
                       g = ((double)color.G - gmin) / (gmax - gmin) * 255;
                    if(bmax!=bmin)
                       b = ((double)color.B - bmin) / (bmax - bmin) * 255;

                    newdata[0, i, j] = (int)r;
                    newdata[1, i, j] = (int)g;
                    newdata[2, i, j] = (int)b;
                    
                    newBitmap.SetPixel(j, i, Color.FromArgb((int)r, (int)g, (int)b));   
                }
            }
            pictureBox1.Image = newBitmap.Clone() as Image;
            SetBands();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.  
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲  
            
        }

        public img(Bitmap bitmap,int ddd)
        {
            InitializeComponent();

            rows = bitmap.Height;
            cols = bitmap.Width;

            newBitmap = new Bitmap(cols, rows);
            newdata = new int[3, rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Color color = bitmap.GetPixel(j, i);
                    newdata[0, i, j] = (int)color.R;
                    newdata[1, i, j] = (int)color.G;
                    newdata[2, i, j] = (int)color.B;
                    newBitmap.SetPixel(j, i, Color.FromArgb(color.R, color.G, color.B));
                }
            }
            pictureBox1.Image = newBitmap.Clone() as Image;
            SetBands();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.  
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲  
        }

        public img(double[, ,] data, int rr, int cc)
        {
            InitializeComponent();
            rows = rr;
            cols = cc;

            int[, ,] values = new int[3, rows, cols];
            List<double> listr = new List<double>();
            List<double> listg = new List<double>();
            List<double> listb = new List<double>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    listr.Add(data[0, i, j]);
                    listg.Add(data[1, i, j]);
                    listb.Add(data[2, i, j]);
                }
            }
            double rmax = listr.Max();
            double gmax = listg.Max();
            double bmax = listb.Max();

            double rmin = listr.Min();
            double gmin = listg.Min();
            double bmin = listb.Min();

            newBitmap = new Bitmap(cols, rows);
            newdata = new int[3, rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double r = rmin, g = gmin, b = bmin;
                    if (rmax != rmin)
                        r = ((double)data[0, i, j] - rmin) / (rmax - rmin) * 255;
                    if (gmax != gmin)
                        g = ((double)data[1, i, j] - gmin) / (gmax - gmin) * 255;
                    if (bmax != bmin)
                        b = ((double)data[2, i, j] - bmin) / (bmax - bmin) * 255;

                    newdata[0, i, j] = (int)r;
                    newdata[1, i, j] = (int)g;
                    newdata[2, i, j] = (int)b;

                    newBitmap.SetPixel(j, i, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }
            pictureBox1.Image = newBitmap.Clone() as Image;
            SetBands();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.  
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲  
        }

        private void jpgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save form = new save(newBitmap,"jpg");
            form.Show();
        }

        private void bmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save form = new save(newBitmap, "bmp");
            form.Show();
        }

        private void pngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save form = new save(newBitmap, "png");
            form.Show();
        }

        private void tifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save form = new save(newBitmap, "tif");
            form.Show();
        }

        private void bsqbilbipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save form = new save(newBitmap, "hdr");
            form.Show();
        }

        private void SetBands()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((newdata[0, i, j] != newdata[1, i, j]) || (newdata[0,i,j] != newdata[2,i,j]))
                    {
                        bands = 3;
                        return;
                    }
                }
            }
            bands = 1;
        }

        private void 统计参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rows = newBitmap.Height;
            int cols = newBitmap.Width;
            stastic form2 = new stastic(newdata, rows, cols, bands);
            form2.Show();
        }

        private void 直方图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            histogram form3 = new histogram(newdata, rows, cols, bands);
            form3.Show();
        }


        public pixel3 rgb;
        public gray gg;

        double x = 0;
        double y = 0;

        bool isMove = false;
        bool change = false;


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//如果按下鼠标左键
            {
                isMove = true;
                x = Cursor.Position.X;//把移动之后的光标的位置赋给Point_XY便于下一个位置的计算
                y = Cursor.Position.Y;
            }

            //显示像素值

            if (bands == 3)
            {
                if (rgb == null)
                {
                    rgb = new pixel3();
                    int ex = e.X / pictureBox1.Width * newBitmap.Width - pictureBox1.Location.X;
                    int ey = e.Y / pictureBox1.Height * newBitmap.Height - pictureBox1.Location.X;
                    if (ex >= cols || ey >= rows || ex < 0 || ey < 0)
                    {
                        rgb.label2.Text = "error!";
                        rgb.label3.Text = "error!";
                        rgb.label5.Text = "error!";
                        return;
                    }
               
                    rgb.label2.Text = newdata[0, ey, ex].ToString();
                    rgb.label3.Text = newdata[1, ey, ex].ToString();
                    rgb.label5.Text = newdata[2, ey, ex].ToString();
                }
                else if (rgb.Visible == true)
                {
                    int ex = e.X / pictureBox1.Width * newBitmap.Width - pictureBox1.Location.X;
                    int ey = e.Y / pictureBox1.Height * newBitmap.Height - pictureBox1.Location.X;
                    if (ex >= cols || ey >= rows || ex < 0 || ey < 0)
                    {
                        rgb.label2.Text = "error!";
                        rgb.label3.Text = "error!";
                        rgb.label5.Text = "error!";
                        return;
                    }
                    rgb.label2.Text = newdata[0, ey, ex].ToString();
                    rgb.label3.Text = newdata[1, ey, ex].ToString();
                    rgb.label5.Text = newdata[2, ey, ex].ToString();
                }
            }
            if (bands == 1)
            {
                if (gg == null)
                {
                    gg = new gray();
                 
                    int ex = (int)((double)e.X / (double)pictureBox1.Width * (double)newBitmap.Width - (double)pictureBox1.Location.X);
                    int ey = (int)((double)e.Y / (double)pictureBox1.Height * (double)newBitmap.Height - (double)pictureBox1.Location.Y);
                    if (ex >= cols || ey >= rows || ex < 0 || ey < 0)
                    {
                        gg.label2.Text = "error!";
                        return;
                    } 

                    gg.label2.Text = newdata[0, ey, ex].ToString();
                }
                else if (gg.Visible == true)
                {
                    int ex = (int)((double)e.X / (double)pictureBox1.Width * (double)newBitmap.Width - (double)pictureBox1.Location.X);
                    int ey = (int)((double)e.Y / (double)pictureBox1.Height * (double)newBitmap.Height - (double)pictureBox1.Location.Y);         
                    if (ex >= cols || ey >= rows || ex < 0 || ey < 0)
                    {
                        gg.label2.Text = "error!";
                        return;
                    }

                    gg.label2.Text = newdata[0, ey, ex].ToString();
                }
            }

            if (rgb != null)
            {
                rgb.FormClosing += (ss, ee) => { func(); };
            }
            if (gg != null)
            {
                gg.FormClosing += (ss, ee) => { func(); };
            }
        }

        public void func()
        {
            rgb = null;
            gg = null;
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            double step = 1.3;//缩放的倍率
            if (e.Delta > 0) //放大图片
            {
                pictureBox1.Height = (int)(pictureBox1.Height * step);//计算图片放大之后的高度
                pictureBox1.Width = (int)(pictureBox1.Width * step);//图片放大之后的宽度
                //计算当前光标的X,Y值与控件左上角X,Y值差
                int px = Cursor.Position.X - pictureBox1.Location.X;
                int py = Cursor.Position.Y - pictureBox1.Location.Y;
                //计算控件左上角的X,Y放大后的变化量
                int px_add = (int)(px * (step - 1.0));
                int py_add = (int)(py * (step - 1.0));
                //放大后的控件左上角的X,Y值
                pictureBox1.Location = new Point(pictureBox1.Location.X - px_add,pictureBox1.Location.Y - py_add);
                Application.DoEvents();
                change = true;
            }
            else
            {  
                //计算缩小后图片的大小
                pictureBox1.Height = (int)(pictureBox1.Height / step);
                pictureBox1.Width = (int)(pictureBox1.Width / step);

                //计算当前光标的X,Y值与控件左上角X,Y值差
                int px = Cursor.Position.X - pictureBox1.Location.X;
                int py = Cursor.Position.Y - pictureBox1.Location.Y;
                //计算控件左上角的X,Y缩小后的变化量
                int px_add = (int)(px * (1.0 - 1.0 / step));
                int py_add = (int)(py * (1.0 - 1.0 / step));
                //缩小后的控件左上角的X,Y值
                pictureBox1.Location = new Point(pictureBox1.Location.X + px_add, pictureBox1.Location.Y + py_add); 
                Application.DoEvents();
                change = true;
            }
            //设置图片在窗体居中
           pictureBox1.Refresh();
        }

        private void pictureBox1_DoubleClick_1(object sender, EventArgs e)
        {
            if (change) {
                MessageBox.Show("请先缩放到原图！");
                return;
            }
            if (bands == 3)
            {
                rgb.Show();
            }
            if (bands == 1)
            {
                gg.Show();
            }

            if (rgb != null)
            {
                rgb.FormClosing += (ss, ee) => { func(); };
            }

            if (gg != null)
            {
                gg.FormClosing += (ss, ee) => { func(); };
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove)
            {
                this.pictureBox1.Left = this.pictureBox1.Left + (Cursor.Position.X - (int)x);//计算控件左边缘与其容器的工作区左边缘之间的距离
                this.pictureBox1.Top = this.pictureBox1.Top + (Cursor.Position.Y - (int)y);//计算控件上边缘与其容器的工作区上边缘之间的距离
                x = Cursor.Position.X;//把移动之后的光标的位置赋给Point_XY便于下一个位置的计算
                y = Cursor.Position.Y;
            }
  
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void 原图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(484, 436);
            pictureBox1.Location = new Point(0,0);
            pictureBox1.Refresh();
            change = false;
        }

    }
}
