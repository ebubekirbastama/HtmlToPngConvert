using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace htmltopng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap m_Bitmap = new Bitmap(400, 600);
            PointF point = new PointF(0, 0);
            SizeF maxSize = new SizeF(500, 500);
            HtmlRender.Render(Graphics.FromImage(m_Bitmap),richTextBox1.Text,point, maxSize);

            m_Bitmap.Save(Application.StartupPath + @"Test.png", ImageFormat.Png);
        }
    }
}
