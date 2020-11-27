using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuislemeProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        islemler islem = new islemler();

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIslem.SelectedIndex = 0;
            pbIslenmis.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //Seçilen işleme göre formdaki değişiklikleri ayarlıyoruz
        private void cmbIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbIslem.SelectedIndex)
            {
                case 0:
                    trackBar1.Visible = false;
                    btnIsle.Visible = false;
                    lblDeger.Visible = false;
                    pbIslenmemis.SizeMode = PictureBoxSizeMode.Normal;
                    pbIslenmis.Image = null;
                    break;
                case 1:
                    trackBar1.Visible = false;
                    btnIsle.Visible = true;
                    lblDeger.Visible = false;
                    pbIslenmemis.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    trackBar1.Visible = false;
                    btnIsle.Visible = true;
                    lblDeger.Visible = false;
                    pbIslenmemis.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    trackBar1.Visible = false;
                    btnIsle.Visible = true;
                    lblDeger.Visible = false;
                    pbIslenmemis.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    trackBar1.Visible = true;
                    btnIsle.Visible = false;
                    lblDeger.Visible = true;
                    pbIslenmemis.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        //PC deki kalsörümüzü açmamız için gereken kodlar
        OpenFileDialog file = new OpenFileDialog();

        private void btnYukle_Click(object sender, EventArgs e)
        {          
            if (file.ShowDialog() == DialogResult.OK)
            {
                pbIslenmemis.ImageLocation = file.FileName;
            }
        }

        //Fotoğrafdaki pixelin rengini mouse imlecinin değdiği yeri gösterme
        private void pbIslenmemis_MouseMove(object sender, MouseEventArgs e)
        {
            if(pbIslenmemis.Image != null && cmbIslem.SelectedIndex ==0)
            {
                if (e.X>e.Y)
                {
                    Bitmap Islenmemis = (Bitmap)pbIslenmemis.Image;
                    Color renk = Islenmemis.GetPixel(e.X, e.Y);
                    pbIslenmis.BackColor = renk;
                }

            }
        }

        //İşlemler butonumuz
        public void btnIsle_Click(object sender, EventArgs e)
        {
            Bitmap gelenResim;

            switch (cmbIslem.SelectedIndex)
            {
                //Resmi negatife çevirme
                case 1:
                    pbIslenmis.BackColor = Color.LightSeaGreen;
                    gelenResim = islem.negative((Bitmap)pbIslenmemis.Image);
                    pbIslenmis.Image = gelenResim;
                    break;
                
                //Resmi griye çevirme
                case 2:
                    pbIslenmis.BackColor = Color.LightSeaGreen;
                    gelenResim = islem.griCevir((Bitmap)pbIslenmemis.Image);
                    pbIslenmis.Image = gelenResim;
                    break;
                
                //Resmi siyah-beyaz yapma
                case 3:
                    pbIslenmis.BackColor = Color.LightSeaGreen;
                    gelenResim = islem.griCevir((Bitmap)pbIslenmemis.Image);
                    gelenResim = islem.siyahBeyazCevir((Bitmap)pbIslenmemis.Image,128);
                    pbIslenmis.Image = gelenResim;
                    break;
                
                //İşle butonuna basıldığında TrackBar daki değerin parlaklığını fotoğrafa parlaklığını ayarlama
                //case 4:
                //    pbIslenmis.BackColor = Color.LightSeaGreen;
                //    gelenResim = islem.parlaklik((Bitmap)pbIslenmemis.Image, int.Parse(lblDeger.Text));
                //    pbIslenmis.Image = gelenResim;
                //    break;
            }
        }

        //TrackBar da değer değiştiğinde fotoğrafın parlaklığını ayarlama
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lblDeger.Text = trackBar1.Value.ToString();
            if (cmbIslem.SelectedIndex==4)
            {
                pbIslenmis.BackColor = Color.LightSeaGreen;
                Bitmap gelenResim = islem.parlaklik((Bitmap)pbIslenmemis.Image,trackBar1.Value);
                pbIslenmis.Image = gelenResim;
            }
        }
    }
}
