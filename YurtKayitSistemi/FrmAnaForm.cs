using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet2.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter1.Fill(this.yurtKayitDataSet2.Ogrenci);
            // TODO: This line of code loads data into the 'yurtKayitDataSet11.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtKayitDataSet11.Ogrenci);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.Exe");
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayit form = new FrmOgrKayit();
            form.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe form = new FrmOgrListe();
            form.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler form = new FrmBolumler();
            form.Show();
        }

        private void öğrenciÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler form = new FrmOdemeler();
            form.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider form = new FrmGider();
            form.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi form = new FrmGiderListesi();
            form.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirIstatistik form = new FrmGelirIstatistik();
            form.Show();
        }


        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel form = new FrmPersonel();
            form.Show();
        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe form = new FrmOgrListe();
            form.Show();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotEkle form = new FrmNotEkle();
            form.Show();
        }

        private void öğrenciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciRapor form = new FrmOgrenciRapor();
            form.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Görsel Programlama dönem proje ödevidir.", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.None);

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Devam etmek istiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                this.Hide();
                FrmAdminGiris fr = new FrmAdminGiris();
                fr.Show();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Program kapatılamadı.");
            }
            
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiIslemleri form = new FrmYoneticiIslemleri();
            form.Show();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
           
            int srg = int.Parse(TxtAra.Text);
            string sorgu = "Select * from Ogrenci where Ogrid Like '" + srg + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataSet ds = new DataSet();
            adap.Fill(ds, "Ogrenci");
            this.dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

    }
}
