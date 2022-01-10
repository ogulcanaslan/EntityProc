using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TarimEntities baglanti = new TarimEntities();
        public void Listele()
        {
            dataGridView1.DataSource = baglanti.UretimListele().ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtUretimAdi.Tag = row.Cells["UNo"].Value;
            txtUretimAdi.Text = row.Cells["UAdi"].Value.ToString();
            txtUretimMiktari.Text = row.Cells["UMiktar"].Value.ToString();
            txtUretimSehir.Text = row.Cells["USehir"].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Uretim ekle = new Uretim();
            ekle.UAdi = txtUretimAdi.Text;
            ekle.USehir = txtUretimSehir.Text;
            ekle.UMiktar = Convert.ToInt32(txtUretimMiktari.Text);
            baglanti.UretimEkleme(ekle.UAdi,ekle.USehir,ekle.UMiktar);
            Listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtUretimAdi.Tag);
            baglanti.UretimSil(no);
            Listele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Uretim yeni = new Uretim();
            yeni.UNo = Convert.ToInt32(txtUretimAdi.Tag);
            yeni.UAdi = txtUretimAdi.Text;
            yeni.USehir = txtUretimSehir.Text;
            yeni.UMiktar = Convert.ToInt32(txtUretimMiktari.Text);
            baglanti.UretimGuncelle(yeni.UNo, yeni.UAdi, yeni.USehir, yeni.UMiktar);
            Listele();
        }
    }
}
