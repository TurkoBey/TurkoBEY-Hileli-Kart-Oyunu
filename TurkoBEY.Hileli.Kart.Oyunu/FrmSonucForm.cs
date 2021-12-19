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
    public partial class FrmSonucForm : MetroSet_UI.Forms.MetroSetForm
    {
        public FrmSonucForm()
        {
            InitializeComponent();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            FrmAcilisEkrani frmAcilisEkrani = new FrmAcilisEkrani();
            frmAcilisEkrani.Show();
            this.Close();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); 
        }

        private void FrmSonucForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
