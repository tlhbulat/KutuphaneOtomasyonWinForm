using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db=new KutuphaneOtomasyonEntities();



        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false;
            silKullanicibtn.Visible = false;
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
            }

            KullaniciListeForm klisteForm = new KullaniciListeForm();
            klisteForm.MdiParent = this;
            klisteForm.Show();





        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciEkleForm ekleForm = new Kullanici.KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();



        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciSilForm kSil = new Kullanici.KullaniciSilForm();
            kSil.MdiParent = this;
            kSil.Show();

        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciGuncelleForm kGuncel = new Kullanici.KullaniciGuncelleForm();
            kGuncel.MdiParent = this;
            kGuncel.Show();

        }
    }
}
