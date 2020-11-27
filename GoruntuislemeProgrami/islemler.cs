using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GoruntuislemeProgrami
{
    class islemler
    {

        //Fotoğrafın negatifini alma
        public Bitmap negative (Bitmap resim)
        {
            Bitmap sonuc = new Bitmap(resim.Width, resim.Height);
            Color ilkRenk, ikinciRenk;
            int r, g, b;

            for (int i = 0; i < resim.Width; i++)
            {
                for (int j = 0; j < resim.Height; j++)
                {
                    ilkRenk = resim.GetPixel(i, j);
                    r = 255 - ilkRenk.R;
                    g = 255 - ilkRenk.G;
                    b = 255 - ilkRenk.B;
                    ikinciRenk = Color.FromArgb(r, g, b);
                    sonuc.SetPixel(i, j, ikinciRenk);
                }
            }
            return sonuc;
        }

        //Fotoğrafı griye çevirme
        public Bitmap griCevir(Bitmap foto)
        {
            Bitmap sonuc = new Bitmap(foto.Width, foto.Height);
            int ton;
            Color renk1, renk2;

            for (int i = 0; i < foto.Width; i++)
            {
                for (int j = 0; j < foto.Height; j++)
                {
                    renk1 = foto.GetPixel(i, j);
                    ton = Convert.ToInt16(renk1.R * 0.299) + Convert.ToInt16(renk1.G * 0.587) + Convert.ToInt16(renk1.B * 0.114);
                    renk2 = Color.FromArgb(ton, ton, ton);
                    sonuc.SetPixel(i, j, renk2);
                }
            }
            return sonuc;
        }

        //Fotoğrafı siyah-beyaz yapma
        public Bitmap siyahBeyazCevir(Bitmap son,int esik)
        {
            Bitmap sonuc = new Bitmap(son.Width, son.Height);
            Color renk1, renk2;

            for (int i = 0; i < son.Width; i++)
            {
                for (int j = 0; j < son.Height; j++)
                {
                    renk1 = son.GetPixel(i, j);
                    if (renk1.R > esik)
                    {
                        renk2 = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        renk2 = Color.FromArgb(0, 0, 0);
                    }
                    sonuc.SetPixel(i, j, renk2);
                }
            }
            return sonuc;
        }

        //Fotoğrafın parlaklk derecesini ayarlama
        public Bitmap parlaklik(Bitmap foto,int parlaklikDerecesi)
        {
            Bitmap sonuc = new Bitmap(foto.Width, foto.Height);
            Color renk1, renk2;
            int r, g, b;

            for (int i = 0; i < foto.Width; i++)
            {
                for (int j = 0; j < foto.Height; j++)
                {
                    renk1 = foto.GetPixel(i, j);
                    if (renk1.R + parlaklikDerecesi > 255)
                    {
                        r = 255;
                    }
                    else if (renk1.R + parlaklikDerecesi < 0)
                    {
                        r = 0;
                    }
                    else
                    {
                        r = renk1.R + parlaklikDerecesi;
                    }

                    renk1 = foto.GetPixel(i, j);
                    if (renk1.G + parlaklikDerecesi > 255)
                    {
                        g = 255;
                    }
                    else if (renk1.G + parlaklikDerecesi < 0)
                    {
                        g = 0;
                    }
                    else
                    {
                        g = renk1.G + parlaklikDerecesi;
                    }

                    renk1 = foto.GetPixel(i, j);
                    if (renk1.B + parlaklikDerecesi > 255)
                    {
                        b = 255;
                    }
                    else if (renk1.B + parlaklikDerecesi < 0)
                    {
                        b = 0;
                    }
                    else
                    {
                        b = renk1.B + parlaklikDerecesi;
                    }

                    renk2 = Color.FromArgb(r, g, b);
                    sonuc.SetPixel(i, j, renk2);
                }
            }
            return sonuc;
        }
    }
}
