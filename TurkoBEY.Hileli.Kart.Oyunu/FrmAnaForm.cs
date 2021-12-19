using MetroSet_UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Child;

namespace TurkoBEY.Hileli.Kart.Oyunu
{
    public partial class FrmAnaForm : MetroSet_UI.Forms.MetroSetForm
    {
        public int tiklama = 0, deger = 0, sonuc = 0;
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        #region Form
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            metroSetTabControl1.TabPages.Remove(Kart2);
            metroSetTabControl1.TabPages.Remove(Kart3);
            metroSetTabControl1.TabPages.Remove(Kart4);
            metroSetTabControl1.TabPages.Remove(Kart5);
            metroSetTabControl1.TabPages.Remove(Kart6);
            metroSetTabControl1.TabPages.Remove(Kart7);
            this.Kart2.Hide();
            this.Kart3.Hide();
            this.Kart4.Hide();
            this.Kart5.Hide();
            this.Kart6.Hide();
            this.Kart7.Hide();
        }

        private void FrmAnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAcilisEkrani frmAcilisEkrani = new FrmAcilisEkrani();
            this.Hide();
            frmAcilisEkrani.Show();
        }
        #endregion

        #region Kart
        private void KartAcKapat(int deger)
        {
            switch (deger)
            {
                case 1:
                    metroSetTabControl1.TabPages.Insert(1, Kart2);
                    if (metroSetTabControl1.TabPages.Count <= 7)
                    {
                        this.Kart2.Show();
                        metroSetTabControl1.TabPages.Remove(Kart1);
                        this.Kart1.Hide();
                    }
                    break;
                case 2:
                    metroSetTabControl1.TabPages.Insert(1, Kart3);
                    if (metroSetTabControl1.TabPages.Count <= 7)
                    {
                        this.Kart3.Show();
                        metroSetTabControl1.TabPages.Remove(Kart2);
                        this.Kart2.Hide();
                    }
                    break;
                case 3:
                    metroSetTabControl1.TabPages.Insert(1, Kart4);
                    if (metroSetTabControl1.TabPages.Count <= 5)
                    {
                        this.Kart4.Show();
                        metroSetTabControl1.TabPages.Remove(Kart1);
                        this.Kart1.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart2);
                        this.Kart2.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart3);
                        this.Kart3.Hide();
                    }
                    break;
                case 4:
                    metroSetTabControl1.TabPages.Insert(1, Kart5);
                    if (metroSetTabControl1.TabPages.Count <= 7)
                    {
                        this.Kart5.Show();
                        metroSetTabControl1.TabPages.Remove(Kart1);
                        this.Kart1.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart2);
                        this.Kart2.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart3);
                        this.Kart3.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart4);
                        this.Kart4.Hide();
                    }
                    break;
                case 5:
                    metroSetTabControl1.TabPages.Insert(1, Kart6);
                    if (metroSetTabControl1.TabPages.Count <= 7)
                    {
                        this.Kart6.Show();
                        metroSetTabControl1.TabPages.Remove(Kart1);
                        this.Kart1.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart2);
                        this.Kart2.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart3);
                        this.Kart3.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart4);
                        this.Kart4.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart5);
                        this.Kart5.Hide();
                    }
                    break;
                case 6:
                    metroSetTabControl1.TabPages.Insert(1, Kart7);
                    if (metroSetTabControl1.TabPages.Count <= 7)
                    {
                        this.Kart7.Show();
                        metroSetTabControl1.TabPages.Remove(Kart1);
                        this.Kart1.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart2);
                        this.Kart2.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart3);
                        this.Kart3.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart4);
                        this.Kart4.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart5);
                        this.Kart5.Hide();
                        metroSetTabControl1.TabPages.Remove(Kart6);
                        this.Kart6.Hide();
                    }
                    break;
                case 7:
                    this.Hide();
                    FrmSonucForm frmSonucForm = new FrmSonucForm();
                    frmSonucForm.Text = $"Tutmuş Olduğunuz SAYI  >>>>>  [  {sonuc}  ]";
                    frmSonucForm.Show();
                    break;
                default:
                    break;
            }
        }
        private void btnK7Ileri_Click(object sender, EventArgs e)
        {
            KartAcKapat(deger = 7);
        }

        private void metroSetTabControl1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(200);
        }
        #endregion

        #region EvetHayirButonlar
        public void YeniKart(int tiklama, MetroSetEllipse btnKEvet, MetroSetEllipse btnKHayir, MetroSetPanel metroSetPanel)
        {
            btnKEvet.Visible = false;
            btnKHayir.Visible = false;
            metroSetPanel.Visible = true;
            lblKartSayisi.Text = "Kalan Kart Sayısı: " + (7 - tiklama);
        }
        private void btnK1Evet_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK1Evet, btnK1Hayir, metroSetPanel1);
            sonuc += 1;
            KartAcKapat(deger = 1);
        }
        private void btnK1Hayir_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK1Evet, btnK1Hayir, metroSetPanel1);
            KartAcKapat(deger = 1);
        }

        private void btnK2Evet_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK2Evet, btnK2Hayir, metroSetPanel2);
            sonuc += 2;
            KartAcKapat(deger = 2);
        }
        private void btnK2Hayir_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK2Evet, btnK2Hayir, metroSetPanel2);
            KartAcKapat(deger = 2);
        }

        private void btnK3Evet_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK3Evet, btnK3Hayir, metroSetPanel3);
            sonuc += 4;
            KartAcKapat(deger = 3);
        }
        private void btnK3Hayir_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK3Evet, btnK3Hayir, metroSetPanel3);
            KartAcKapat(deger = 3);
        }

        private void btnK4Evet_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK4Evet, btnK4Hayir, metroSetPanel4);
            sonuc += 8;
            KartAcKapat(deger = 4);
        }
        private void btnK4Hayir_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK4Evet, btnK4Hayir, metroSetPanel4);
            KartAcKapat(deger = 4);
        }

        private void btnK5Evet_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK5Evet, btnK5Hayir, metroSetPanel5);
            sonuc += 16;
            KartAcKapat(deger = 5);
        }
        private void btnK5Hayir_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK5Evet, btnK5Hayir, metroSetPanel5);
            KartAcKapat(deger = 5);
        }

        private void btnK6Evet_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK6Evet, btnK6Hayir, metroSetPanel6);
            sonuc += 32;
            KartAcKapat(deger = 6);
        }
        private void btnK6Hayir_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK6Evet, btnK6Hayir, metroSetPanel6);
            KartAcKapat(deger = 6);
        }

        private void btnK7Evet_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK7Evet, btnK7Hayir, metroSetPanel7);
            btnK7Ileri.Visible = true;
            metroSetPanel7.Visible = true;
            sonuc += 64;
        }
        private void btnK7Hayir_Click(object sender, EventArgs e)
        {
            YeniKart(tiklama += 1, btnK7Evet, btnK7Hayir, metroSetPanel7);
            btnK7Ileri.Visible = true;
            metroSetPanel7.Visible = true;
        }
        #endregion
    }
}
