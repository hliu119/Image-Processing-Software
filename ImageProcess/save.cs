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
    public partial class save : Form
    {
        Bitmap newBitmap;
        string path;
        string type;
        bool isHdr;

        public save(Bitmap bit,string t)
        {
            InitializeComponent();
            newBitmap = bit;
            type = t;
            isHdr = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "保存文件";
            switch (type)
            {
                case "jpg":
                    sd.Filter = "JPG文件|*.jpg";
                    break;
                case "bmp":
                    sd.Filter = "BMP文件|*.bmp";
                    break;
                case "png":
                    sd.Filter = "PNG文件|*.png";
                    break;
                case "tif":
                    sd.Filter = "TIFF文件|*.tif";
                    break;
                case "hdr":
                    sd.Filter = "HDR文件|*.hdr";
                    isHdr = true;
                    break;
            }

            if (sd.ShowDialog() == DialogResult.OK)
            {
                path = sd.FileName;
                textBox1.Text = path;   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isHdr)
            {
                newBitmap.Save(path);
            }
            else
            {
                StreamWriter srhdr = new StreamWriter(path);

                srhdr.WriteLine("ENVI");
                srhdr.WriteLine("description = {");
                srhdr.WriteLine("  Create New File Result [Tue Feb 18 22:10:34 2003]}");
                srhdr.WriteLine("samples = " + newBitmap.Width.ToString());
                srhdr.WriteLine("lines   = " + newBitmap.Height.ToString());
                srhdr.WriteLine("bands   = 3");
                srhdr.WriteLine("header offset = 0");
                srhdr.WriteLine("file type = ENVI Standard");
                srhdr.WriteLine("data type = 1");
                srhdr.WriteLine("interleave = bsq");
                srhdr.WriteLine("sensor type = Unknown");
                srhdr.WriteLine("byte order = 0");
                srhdr.WriteLine("x start = 2542");
                srhdr.WriteLine("y start = 1353");
                srhdr.WriteLine("pixel size = {1.00000000e+000, 1.00000000e+000, units=Meters}");

                srhdr.Close();

                int rows = newBitmap.Height;
                int cols = newBitmap.Width;
                byte [,,]data = new byte[3,rows,cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Color c = newBitmap.GetPixel(j,i);
                        data[0,i,j] = (byte)c.R;  
                        data[1,i,j] = (byte)c.G;     
                        data[2,i,j] = (byte)c.B;     
                    }
                }

                string newpath = path.Substring(0, path.Length - 4);
                BinaryWriter br = new BinaryWriter(new FileStream(newpath, FileMode.CreateNew));

                for (int b = 0; b < 3; b++)
                {
                    for (int i = 0; i < newBitmap.Height; i++)
                    {
                        for (int j = 0; j < newBitmap.Width; j++)
                        {
                            byte value = data[b,i,j];
                            br.Write(value);
                        }
                    }
                }
                br.Close();
            }
            MessageBox.Show("保存成功！");
        }
    }
}
