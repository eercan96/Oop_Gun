using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_Gun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cephanem Inventory;

        private void Form1_Load(object sender, EventArgs e)
        {
            Inventory = new Cephanem();
            Inventory.MyWeapons[0] = new Bicak("XS500", "Rambo", 0.5);
            Inventory.MyWeapons[1] = new Tabanca("Magnum", "6Patlar", 1.5, false, 33, false);
            Inventory.MyWeapons[2] = new Tufek("SuperPoze", "Bindirmeli", 4, false, 90, false, Tufek.TufekTipi.Pompalı);
            Inventory.MyWeapons[3] = new Tufek("Uzi", "Uzi500", 2, true, 50, true, Tufek.TufekTipi.Taramalı);
            Inventory.MyWeapons[4] = new Top();
            Inventory.MyWeapons[5] = new RoketAtar();
            pictureBox1.Image = Inventory.SilahDegis(1);
            Form1_KeyPress(this, new KeyPressEventArgs('2'));
            this.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {



                if (Convert.ToInt32(e.KeyChar.ToString()) < 7 && Convert.ToInt32(e.KeyChar.ToString()) > 0)
                {
                    pictureBox1.Image = Inventory.SilahDegis(Convert.ToInt32(e.KeyChar.ToString()));
                    pictureBox1.Tag = Convert.ToInt32(e.KeyChar.ToString()) - 1;
                    if (e.KeyChar.ToString() == "1")
                    {
                        grpKesici.Visible = true;
                        grpAtesli.Visible = false;
                        grpSarjor.Visible = false;
                    }
                    else
                    {
                        grpAtesli.Visible = true;
                        grpKesici.Visible = false;
                        grpSarjor.Visible = true;
                        RefreshProgressBar();
                        if ((Inventory.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir).DurbunluMu)
                        {
                            btnYakinlastir.Visible = true;
                            btnUzaklastir.Visible = true;
                        }
                        else
                        {
                            btnYakinlastir.Visible = false;
                            btnUzaklastir.Visible = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lutfen 1 ile 6 arasında seçim yapınız!!!");
                }
            }
            catch
            {
                MessageBox.Show("Lutfen 1 ile 6 arasında seçim yapınız!!!");
            }

        }
        private void RefreshProgressBar()
        {
            progressBar1.Maximum = (Inventory.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as AtesliSilah).MaxMermiSayisi;
            progressBar1.Value = (Inventory.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as AtesliSilah).MermiAdet;
            progressBar1.Refresh();
        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Inventory.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IAtesli).AtesEt());
            RefreshProgressBar();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Inventory.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IAtesli).Doldur());
            RefreshProgressBar();
        }

        private void btnYakinlastir_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Inventory.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir).Yakinlastir());
        }

        private void btnUzaklastir_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Inventory.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir).Uzaklastir());
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Inventory.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IKesici).Kes());
        }

        private void btnBileyle_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Inventory.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IKesici).Bileyle());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
