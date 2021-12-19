using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkoBEY.Hileli.Kart.Oyunu
{
    public partial class FrmAcilisEkrani : MetroSet_UI.Forms.MetroSetForm
    {
        public FrmAcilisEkrani()
        {
            InitializeComponent();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TurkoBey/TurkoBEY-Hileli-Kart-Oyunu");
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();  
            frmAnaForm.Show();
            this.Hide();
        }
        private void btnBilgiKarti_Click(object sender, EventArgs e)
        {
            FrmOyunNedir frmOyunNedir = new FrmOyunNedir();
            frmOyunNedir.Show();
        }
        private void FrmAcilisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
