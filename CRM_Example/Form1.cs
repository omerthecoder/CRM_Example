using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = @"..\..\data.json";
        Musteri SeciliMusteri = null;
        int SeciliIndex = -1;
        private void Form1_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        private string GetJson()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }

        private List<Musteri> musterilerDeserialize()
        {
            return JsonConvert.DeserializeObject<List<Musteri>>(GetJson());
        }

        private void GridDoldur()
        {
            List<Musteri> musteriler = musterilerDeserialize();

            FillgrdDatasource(musteriler);
        }

        private void FillgrdDatasource(List<Musteri> musteriler)
        {
            grdMusteriler.DataSource = null;
            grdMusteriler.DataSource = musteriler;
            grdMusteriler.Columns[0].Visible = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle();

            GridDoldur();
        }

        private void MusteriEkle()
        {
            try
            {
                List<Musteri> musteriler = musterilerDeserialize();
                Musteri musteri = new Musteri();
                musteri.Adi = txtAd.Text;
                musteri.Soyadi = txtSoyad.Text;
                musteri.DogumTarihi = dtpBirthDate.Value.Date;
                musteri.TCKNo = txtTCKNo.Text;
                musteri.Telefon = txtTelefon.Text;
                musteri.Mail = txtMail.Text;
                musteri.Adres = txtAdres.Text;
                musteri.SirketAdi = txtSirketAdi.Text;
                musteri.VKN = txtVKN.Text;
                musteri.SirketAdresi = txtSirketAdresi.Text;
                musteri.YillikCiro = Convert.ToDecimal(txtYillikCiro.Text);
                musteri.Sektor = txtSektor.Text;
                if (musteriler.Count > 0)
                {
                    musteri.Id = (musteriler[musteriler.Count - 1].Id) + 1;
                    musteriler.Add(musteri);
                }
                else
                {
                    List<Musteri> yenimusteri = new List<Musteri>();
                    musteri.Id = 1;
                    musteriler = yenimusteri;
                    musteriler.Add(musteri);
                }
                string jsonString = JsonConvert.SerializeObject(musteriler);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(jsonString);
                }
                SecimTemizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void grdPersonel_DoubleClick(object sender, EventArgs e)
        {
            if (grdMusteriler.SelectedRows[0].Index > -1)
            {
                ControlleriDoldur();
            }
        }

        private void ControlleriDoldur()
        {
            try
            {
                SeciliMusteri = ((List<Musteri>)grdMusteriler.DataSource)[grdMusteriler.SelectedRows[0].Index];
                SeciliIndex = grdMusteriler.SelectedRows[0].Index;
                txtAd.Text = SeciliMusteri.Adi;
                txtAdres.Text = SeciliMusteri.Adres;
                txtMail.Text = SeciliMusteri.Mail;
                txtSektor.Text = SeciliMusteri.Sektor;
                txtSirketAdi.Text = SeciliMusteri.SirketAdi;
                txtSirketAdresi.Text = SeciliMusteri.SirketAdresi;
                txtSoyad.Text = SeciliMusteri.Soyadi;
                txtTCKNo.Text = SeciliMusteri.TCKNo;
                txtTelefon.Text = SeciliMusteri.Telefon;
                txtVKN.Text = SeciliMusteri.VKN;
                txtYillikCiro.Text = SeciliMusteri.YillikCiro.ToString();
                dtpBirthDate.Value = SeciliMusteri.DogumTarihi;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SeciliMusteri != null)
            {
                MusteriSil();
                GridDoldur();
            }
        }

        private void MusteriSil()
        {
            try
            {
                List<Musteri> musteriler = musterilerDeserialize();
                if (musteriler == null)
                {
                    return;
                }
                musteriler.RemoveAt(SeciliIndex);

                string jsonString = JsonConvert.SerializeObject(musteriler);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(jsonString);
                }
                MusteriClear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MusteriClear()
        {
            SecimTemizle();
            txtAd.Text = "";
            txtAdres.Text = "";
            txtMail.Text = "";
            txtSektor.Text = "";
            txtSirketAdi.Text = "";
            txtSirketAdresi.Text = "";
            txtSoyad.Text = "";
            txtTCKNo.Text = "";
            txtTelefon.Text = "";
            txtVKN.Text = "";
            txtYillikCiro.Text = "";
            dtpBirthDate.Value = DateTime.Now;

        }

        private void SecimTemizle()
        {
            SeciliIndex = -1;
            SeciliMusteri = null;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (SeciliMusteri == null) return;
            musteriGuncelle();
            MusteriClear();
            GridDoldur();
        }

        private void musteriGuncelle()
        {
            try
            {
                SeciliMusteri.Adi = txtAd.Text;
                SeciliMusteri.Soyadi = txtSoyad.Text;
                SeciliMusteri.DogumTarihi = dtpBirthDate.Value;
                SeciliMusteri.TCKNo = txtTCKNo.Text;
                SeciliMusteri.Telefon = txtTelefon.Text;
                SeciliMusteri.Mail = txtMail.Text;
                SeciliMusteri.Adres = txtAdres.Text;
                SeciliMusteri.SirketAdi = txtSirketAdi.Text;
                SeciliMusteri.VKN = txtVKN.Text;
                SeciliMusteri.SirketAdresi = txtSirketAdresi.Text;
                SeciliMusteri.YillikCiro = Convert.ToDecimal(txtYillikCiro.Text);
                SeciliMusteri.Sektor = txtSektor.Text;

                List<Musteri> Musteriler = musterilerDeserialize();
                int index = Musteriler.FindIndex(t0 => t0.Id == SeciliMusteri.Id);
                Musteriler[index] = SeciliMusteri;

                string jsonString = JsonConvert.SerializeObject(Musteriler);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(jsonString);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
