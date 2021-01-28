using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bahisoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * iki oyuncu vardır
             * her oyuncunun bir zarı vardır
             * her oyuncunun bakiyesi vardır
             * her oyuncunun bahisi vardır
             * oyuncu zar atar
             * zarlar karşılaştırılır
             * büyük atan kazanır
             * büyük atanın bakiyesi artar
             * küçük atanın bakiyesi azalır
             * parası biten kaybeder
             * 
             * nesneler
             * -oyun
             * -oyuncu
             * -zar
             */
        }

        oyun zarOyunu = new oyun();
        private void buttonAdEkle1_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxAd1.Text;
            zarOyunu.BirinciOyuncu = new oyuncu(oyuncuAdi);
            zarOyunu.BirinciOyuncu.OyuncununZari = new zar();
            labelAd1.Text = zarOyunu.BirinciOyuncu.Ad;
        }
        private void buttonAdEkle2_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxAd2.Text;
            zarOyunu.IkinciOyuncu = new oyuncu(oyuncuAdi);
            zarOyunu.IkinciOyuncu.OyuncununZari = new zar();
            labelAd2.Text = zarOyunu.IkinciOyuncu.Ad;
        }
        
        private void textBoxAd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBakiye1_Click(object sender, EventArgs e)
        {
            zarOyunu.BirinciOyuncu.Bakiye = Convert.ToInt32(textBoxBakiye1.Text);
            labelBakiye1.Text = Convert.ToString(zarOyunu.BirinciOyuncu.Bakiye);
            
        }

        private void buttonBakiye2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncu.Bakiye = Convert.ToInt32(textBoxBakiye2.Text);
            labelBakiye2.Text =Convert.ToString(zarOyunu.IkinciOyuncu.Bakiye);
            
        }
        private void buttonBahis1_Click(object sender, EventArgs e)
        {
            zarOyunu.BirinciOyuncu.Bahis = Convert.ToInt32(textBoxBahis1.Text);
            labelBahis1.Text = Convert.ToString(zarOyunu.BirinciOyuncu.Bahis);
            if (zarOyunu.BirinciOyuncu.Bakiye < zarOyunu.BirinciOyuncu.Bahis)
            {
                MessageBox.Show("YETERSİZ BAKİYE!!");
            }
        }

        private void buttonBahis2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncu.Bahis = Convert.ToInt32(textBoxBahis2.Text);
            labelBahis2.Text = Convert.ToString(zarOyunu.IkinciOyuncu.Bahis);
            if (zarOyunu.IkinciOyuncu.Bakiye < zarOyunu.IkinciOyuncu.Bahis)
            {
                MessageBox.Show("YETERSİZ BAKİYE!!");
            }
        }
        private void Oyuncu1Oyna_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            Oyuncu2Oyna.Enabled = true;


        }
        private void Oyuncu2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncuZarAt();
            oyuncu kazanan = zarOyunu.Karsilastir();
            labelBakiye1.Text = Convert.ToString(zarOyunu.BirinciOyuncu.Bakiye);
            labelBakiye2.Text = Convert.ToString(zarOyunu.IkinciOyuncu.Bakiye);
            if (kazanan != null)
            {
                labelKazanan.Text = $"{kazanan.Ad},{kazanan.OyuncununZari.Deger} atarak oyunu kazandı!!!";
            }
            else if(zarOyunu.BirinciOyuncu.Bakiye <= 0 || zarOyunu.IkinciOyuncu.Bakiye <= 0)
            {
                MessageBox.Show($"Oyun BİTTİ!!!");
               
            }
            else
            {
                labelKazanan.Text = $"Berabere";
            }
           
        }

       
    }

}

