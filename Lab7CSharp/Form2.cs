using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//форма з кодом для другого завдання
namespace laboratorna_robota7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void button2_Click(object sender, EventArgs e)
        {
            
        }
        //задаємо дію на кнопку,яка відкриватиме пошукове вікно, і при виборі сповіщатиме нас про відкритий файл:
        void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "bmp files (*.bmp)|*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            MessageBox.Show("Файл вiдкрито!");
            pictureBox1.Image = new Bitmap(openFileDialog.FileName);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //задаємо дію на кнопку,яка інверсуватиме фото в залежності від обраних фільтрів та режимів
        //що задані у нас на RadioButton'ах
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {   
                Bitmap pic = new Bitmap(pictureBox1.Image);
                for (int y = 0; (y <= (pic.Height - 1)); y++)
                {
                    for (int x = 0; (x <= (pic.Width - 1)); x++)
                    {
                        Color inv = pic.GetPixel(x, y);
                        inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                        pic.SetPixel(x, y, inv);
                    }
                }
                pictureBox1.Image = pic;
            }
            if (radioButton2.Checked)
            {
                if (radioButton3.Checked)
                {
                    Bitmap pic = new Bitmap(pictureBox1.Image);
                    for (int y = 0; (y <= (pic.Height - 1)); y++)
                    {
                        for (int x = 0; (x <= (pic.Width - 1)); x++)
                        {
                            Color inv = pic.GetPixel(x, y);
                            inv = Color.FromArgb(255, (255 - inv.R), (inv.G), (inv.B));
                            pic.SetPixel(x, y, inv);
                        }
                    }
                    pictureBox1.Image = pic;
                }
                if (radioButton4.Checked)
                {
                    Bitmap pic = new Bitmap(pictureBox1.Image);
                    for (int y = 0; (y <= (pic.Height - 1)); y++)
                    {
                        for (int x = 0; (x <= (pic.Width - 1)); x++)
                        {
                            Color inv = pic.GetPixel(x, y);
                            inv = Color.FromArgb(255, (inv.R), (inv.G), (255-inv.B));
                            pic.SetPixel(x, y, inv);
                        }
                    }
                }
                if (radioButton5.Checked)
                {
                    Bitmap pic = new Bitmap(pictureBox1.Image);
                    for (int y = 0; (y <= (pic.Height - 1)); y++)
                    {
                        for (int x = 0; (x <= (pic.Width - 1)); x++)
                        {
                            Color inv = pic.GetPixel(x, y);
                            inv = Color.FromArgb(255, (inv.R), (255-inv.G), (inv.B));
                            pic.SetPixel(x, y, inv);
                        }
                    }
                }
            }
            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        //задаємо дію на кнопку,яка зберігатиме та записуватиме зображення в заданому форматі
        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(sfd.FileName, format);
            }



            MessageBox.Show("Файл успiшно збережено!");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
