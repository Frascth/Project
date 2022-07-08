using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pengacak_Lomba_Futsal
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class KumpulanVar
        {
            public static string pemenang1 = "...", pemenang2 = "...", pemenang3 = "...", pemenang4 = "...", tipat1 = "...", tipat2 = "...";
            public static string[] ntim = {"10 - IPA 1", "10 - IPA 2", "10 - IPA 3", "10 - IPA 4", "10 - IPA 5", "10 - IPA 6", "10 -  IPS 1", "10 -  IPS 2", "10 -  IPS 3", "10 -  IPS 4", "11 - IPA 1", "11 - IPA 2", "11 - IPA 3", "11 - IPA 4", "11 - IPA 5", "11 - IPA 6", "11 -  IPS 1", "11 -  IPS 2", "11 -  IPS 3", "11 -  IPS 4", "12 - IPA 1", "12 - IPA 2", "12 - IPA 3", "12 - IPA 4", "12 - IPA 5", "12 - IPA 6", "12 -  IPS 1", "12 -  IPS 2", "12 -  IPS 3", "12 -  IPS 4", "Tim Guru", "Tim TU" };
            public static int[] actim = new int[32];
            public static byte i = 0, j = 0, k = 0;
            public static Boolean fnama = false ,fkelas = false, refresh1 = false, refresh2 = false, buttonjuara = false, juara2_61 = false, juara2_62 = false, juara_63 = false, juara_64 = false;
        }

        public static class SavingText
        {
            public static string[] tbox;
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
            KumpulanVar.i = Convert.ToByte(textBoxNama.TextLength);
            if (KumpulanVar.i >= 1)
            {
                KumpulanVar.fnama = true;
            }
            else
            {
                KumpulanVar.fnama = false;
            }

            if (KumpulanVar.fnama && KumpulanVar.fkelas)
            {
                btnAcak.Enabled = true;
            }
            else
            {
                btnAcak.Enabled = false;
            }
        }

        private void textBoxKelas_TextChanged(object sender, EventArgs e)
        {
            KumpulanVar.j = Convert.ToByte(textBoxKelas.TextLength);
            if (KumpulanVar.j >= 1)
            {
                KumpulanVar.fkelas = true;
            }
            else
            {
                KumpulanVar.fkelas = false;
            }

            if (KumpulanVar.fnama && KumpulanVar.fkelas)
            {
                btnAcak.Enabled = true;
            }
            else
            {
                btnAcak.Enabled = false;
            }
        }

        private void btnAcak_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            KumpulanVar.actim = Enumerable.Range(0, 32).OrderBy(x => rnd.Next()).ToArray();
            MessageBox.Show("Pengacakan berhasil dilakukan tekan tombol refresh di tab lapangan untuk melihat hasil pengacakan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefresh.Enabled = true;
            btnRefresh2.Enabled = true;
            btnAcak.Enabled = false;
            textBoxNama.ReadOnly = true;
            textBoxKelas.ReadOnly = true;
        }

        private void llblKetRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol Refresh maka Anda akan melihat hasil dari pengacakan yang sudah Anda lakukan.","Keterangan Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMenang1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox1.Text + " sebagai pemenang pertandingan, dan " + textBox2.Text + " sebagai team yang kalah", "Persetujuan",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox17.Text = textBox1.Text;
                btnMenang1.Enabled = false;
                btnKalah1.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang1.Enabled = true;
                btnKalah1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnMenang1.Enabled = true;
            btnMenang4.Enabled = true;
            btnMenang5.Enabled = true;
            btnMenang8.Enabled = true;
            btnMenang9.Enabled = true;
            btnMenang12.Enabled = true;
            btnMenang13.Enabled = true;
            btnMenang16.Enabled = true;
            btnKalah1.Enabled = true;
            btnKalah4.Enabled = true;
            btnKalah5.Enabled = true;
            btnKalah8.Enabled = true;
            btnKalah9.Enabled = true;
            btnKalah12.Enabled = true;
            btnKalah13.Enabled = true;
            btnKalah16.Enabled = true;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            btnMenang17.Enabled = true;
            btnKalah17.Enabled = true;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            btnMenang20.Enabled = true;
            btnKalah20.Enabled = true;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            btnMenang21.Enabled = true;
            btnKalah21.Enabled = true;
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            btnMenang24.Enabled = true;
            btnKalah24.Enabled = true;
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            btnMenang25.Enabled = true;
            btnKalah25.Enabled = true;
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            btnMenang28.Enabled = true;
            btnKalah28.Enabled = true;
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            btnMenang29.Enabled = true;
            btnKalah29.Enabled = true;
        }

        private void btnMenang4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox4.Text + " sebagai pemenang pertandingan, dan " + textBox3.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox18.Text = textBox4.Text;
                btnMenang4.Enabled = false;
                btnKalah4.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang4.Enabled = true;
                btnKalah4.Enabled = true;
            }
        }

        private void btnMenang5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox5.Text + " sebagai pemenang pertandingan, dan " + textBox6.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox19.Text = textBox5.Text;
                btnMenang5.Enabled = false;
                btnKalah5.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang5.Enabled = true;
                btnKalah5.Enabled = true;
            }
        }

        private void btnMenang8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox8.Text + " sebagai pemenang pertandingan, dan " + textBox7.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox20.Text = textBox8.Text;
                btnMenang8.Enabled = false;
                btnKalah8.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang8.Enabled = true;
                btnKalah8.Enabled = true;
            }
        }

        private void btnMenang9_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox9.Text + " sebagai pemenang pertandingan, dan " + textBox10.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox21.Text = textBox9.Text;
                btnMenang9.Enabled = false;
                btnKalah9.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang9.Enabled = true;
                btnKalah9.Enabled = true;
            }
        }

        private void btnMenang12_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox12.Text + " sebagai pemenang pertandingan, dan " + textBox11.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox22.Text = textBox12.Text;
                btnMenang12.Enabled = false;
                btnKalah12.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang12.Enabled = true;
                btnKalah12.Enabled = true;
            }
        }

        private void btnMenang13_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox13.Text + " sebagai pemenang pertandingan, dan " + textBox14.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox23.Text = textBox13.Text;
                btnMenang13.Enabled = false;
                btnKalah13.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang13.Enabled = true;
                btnKalah13.Enabled = true;
            }
        }

        private void btnMenang16_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox16.Text + " sebagai pemenang pertandingan, dan " + textBox15.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox24.Text = textBox16.Text;
                btnMenang16.Enabled = false;
                btnKalah16.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang16.Enabled = true;
                btnKalah16.Enabled = true;
            }
        }

        private void btnMenang17_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox17.Text + " sebagai pemenang pertandingan, dan " + textBox18.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox25.Text = textBox17.Text;
                btnMenang17.Enabled = false;
                btnKalah17.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang17.Enabled = true;
                btnKalah17.Enabled = true;
            }
        }

        private void btnMenang20_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox20.Text + " sebagai pemenang pertandingan, dan " + textBox19.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox26.Text = textBox20.Text;
                btnMenang20.Enabled = false;
                btnKalah20.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang20.Enabled = true;
                btnKalah20.Enabled = true;
            }
        }

        private void btnMenang21_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox21.Text + " sebagai pemenang pertandingan, dan " + textBox22.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox27.Text = textBox21.Text;
                btnMenang21.Enabled = false;
                btnKalah21.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang21.Enabled = true;
                btnKalah21.Enabled = true;
            }
        }

        private void btnMenang24_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox24.Text + " sebagai pemenang pertandingan, dan " + textBox23.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox28.Text = textBox24.Text;
                btnMenang24.Enabled = false;
                btnKalah24.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang24.Enabled = true;
                btnKalah24.Enabled = true;
            }
        }

        private void btnMenang25_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox25.Text + " sebagai pemenang pertandingan, dan " + textBox26.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox29.Text = textBox25.Text;
                btnMenang25.Enabled = false;
                btnKalah25.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang25.Enabled = true;
                btnKalah25.Enabled = true;
            }
        }

        private void btnMenang28_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox28.Text + " sebagai pemenang pertandingan, dan " + textBox27.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox30.Text = textBox28.Text;
                btnMenang28.Enabled = false;
                btnKalah28.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang28.Enabled = true;
                btnKalah28.Enabled = true;
            }
        }

        private void btnKalah1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox2.Text + " sebagai pemenang pertandingan, dan " + textBox1.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox17.Text = textBox2.Text;
                btnMenang1.Enabled = false;
                btnKalah1.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang1.Enabled = true;
                btnKalah1.Enabled = true;
            }
        }

        private void btnKalah4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox3.Text + " sebagai pemenang pertandingan, dan " + textBox4.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox18.Text = textBox3.Text;
                btnMenang4.Enabled = false;
                btnKalah4.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang4.Enabled = true;
                btnKalah4.Enabled = true;
            }
        }

        private void btnKalah5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox6.Text + " sebagai pemenang pertandingan, dan " + textBox5.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox19.Text = textBox6.Text;
                btnMenang5.Enabled = false;
                btnKalah5.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang5.Enabled = true;
                btnKalah5.Enabled = true;
            }
        }

        private void btnKalah8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox7.Text + " sebagai pemenang pertandingan, dan " + textBox8.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox20.Text = textBox7.Text;
                btnMenang8.Enabled = false;
                btnKalah8.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang8.Enabled = true;
                btnKalah8.Enabled = true;
            }
        }

        private void btnKalah9_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox10.Text + " sebagai pemenang pertandingan, dan " + textBox9.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox21.Text = textBox10.Text;
                btnMenang9.Enabled = false;
                btnKalah9.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang9.Enabled = true;
                btnKalah9.Enabled = true;
            }
        }

        private void btnKalah12_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox11.Text + " sebagai pemenang pertandingan, dan " + textBox12.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox22.Text = textBox11.Text;
                btnMenang12.Enabled = false;
                btnKalah12.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang12.Enabled = true;
                btnKalah12.Enabled = true;
            }
        }

        private void btnKalah13_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox14.Text + " sebagai pemenang pertandingan, dan " + textBox13.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox23.Text = textBox14.Text;
                btnMenang13.Enabled = false;
                btnKalah13.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang13.Enabled = true;
                btnKalah13.Enabled = true;
            }
        }

        private void btnKalah16_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox15.Text + " sebagai pemenang pertandingan, dan " + textBox16.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox24.Text = textBox15.Text;
                btnMenang16.Enabled = false;
                btnKalah16.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang16.Enabled = true;
                btnKalah16.Enabled = true;
            }
        }

        private void btnKalah17_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox18.Text + " sebagai pemenang pertandingan, dan " + textBox17.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox25.Text = textBox18.Text;
                btnMenang17.Enabled = false;
                btnKalah17.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang17.Enabled = true;
                btnKalah17.Enabled = true;
            }
        }

        private void btnKalah20_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox19.Text + " sebagai pemenang pertandingan, dan " + textBox20.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox26.Text = textBox19.Text;
                btnMenang20.Enabled = false;
                btnKalah20.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang20.Enabled = true;
                btnKalah20.Enabled = true;
            }
        }

        private void btnKalah21_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox22.Text + " sebagai pemenang pertandingan, dan " + textBox21.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox27.Text = textBox22.Text;
                btnMenang21.Enabled = false;
                btnKalah21.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang21.Enabled = true;
                btnKalah21.Enabled = true;
            }
        }

        private void btnKalah24_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox23.Text + " sebagai pemenang pertandingan, dan " + textBox24.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox28.Text = textBox23.Text;
                btnMenang24.Enabled = false;
                btnKalah24.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang24.Enabled = true;
                btnKalah24.Enabled = true;
            }
        }

        private void btnKalah25_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox26.Text + " sebagai pemenang pertandingan, dan " + textBox25.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox29.Text = textBox26.Text;
                btnMenang25.Enabled = false;
                btnKalah25.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang25.Enabled = true;
                btnKalah25.Enabled = true;
            }
        }

        private void btnKalah28_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox27.Text + " sebagai pemenang pertandingan, dan " + textBox28.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox30.Text = textBox27.Text;
                btnMenang28.Enabled = false;
                btnKalah28.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang28.Enabled = true;
                btnKalah28.Enabled = true;
            }
        }

        private void btnMenang29_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox29.Text + " sebagai juara di lapangan 1, dan " + textBox30.Text + " sebagai team yang akan mengikuti babak 3/4", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                KumpulanVar.tipat1 = textBox30.Text;
                textBox30.Text = textBox30.Text + " (Masuk Babak 3/4)";
                selamat1.Text = "Selamat Kepada " + textBox29.Text;
                textBoxs1.Text = "Pemenang Dari Lapangan 1";
                btn_Pemenang_Lap1.Text = textBox29.Text;
                btnMenang29.Enabled = false;
                btnKalah29.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang29.Enabled = true;
                btnKalah29.Enabled = true;
            }
        }

        private void llblKetReset_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol reset ini maka semua pertandingan akan di hapus dan Anda bisa membuat pertandingan baru.", "Keterangan Reset",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void llblKetKeluar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol ini maka Anda akan menghentikan operasi dari aplikasi ini.", "Keterangan Keluar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llblKetAcak_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol ini berarti Anda telah membuat pertandingan baru dengan pengacakan, tetapi Anda tidak boleh memiliki pertandingan sebelumnya, serta Anda harus mengisi nama pengacak.", "Keterangan Acak", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKalah29_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox30.Text + " sebagai juara di lapangan 1, dan " + textBox29.Text + " sebagai team yang akan mengikuti babak 3/4", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                KumpulanVar.tipat1 = textBox29.Text;
                textBox29.Text = textBox29.Text + " (Masuk Babak 3/4)";
                selamat1.Text = "Selamat Kepada " + textBox30.Text;
                textBoxs1.Text = "Pemenang Dari Lapangan 1";
                btn_Pemenang_Lap1.Text = textBox30.Text;
                btnMenang29.Enabled = false;
                btnKalah29.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang29.Enabled = true;
                btnKalah29.Enabled = true;
            }
        }

        private void btnMenang31_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox31.Text + " sebagai pemenang pertandingan, dan " + textBox32.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox47.Text = textBox31.Text;
                btnMenang31.Enabled = false;
                btnKalah31.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang31.Enabled = true;
                btnKalah31.Enabled = true;
            }
        }

        private void btnKalah31_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox32.Text + " sebagai pemenang pertandingan, dan " + textBox31.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox47.Text = textBox32.Text;
                btnMenang31.Enabled = false;
                btnKalah31.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang31.Enabled = true;
                btnKalah31.Enabled = true;
            }
        }

        private void btnMenang34_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox34.Text + " sebagai pemenang pertandingan, dan " + textBox33.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox48.Text = textBox34.Text;
                btnMenang34.Enabled = false;
                btnKalah34.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang34.Enabled = true;
                btnKalah34.Enabled = true;
            }
        }

        private void btnKalah34_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox33.Text + " sebagai pemenang pertandingan, dan " + textBox34.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox48.Text = textBox33.Text;
                btnMenang34.Enabled = false;
                btnKalah34.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang34.Enabled = true;
                btnKalah34.Enabled = true;
            }
        }

        private void btnMenang35_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox35.Text + " sebagai pemenang pertandingan, dan " + textBox36.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox49.Text = textBox35.Text;
                btnMenang35.Enabled = false;
                btnKalah35.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang35.Enabled = true;
                btnKalah35.Enabled = true;
            }
        }

        private void btnKalah35_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox36.Text + " sebagai pemenang pertandingan, dan " + textBox35.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox49.Text = textBox36.Text;
                btnMenang35.Enabled = false;
                btnKalah35.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang35.Enabled = true;
                btnKalah35.Enabled = true;
            }
        }

        private void btnMenang38_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox38.Text + " sebagai pemenang pertandingan, dan " + textBox37.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox50.Text = textBox38.Text;
                btnMenang38.Enabled = false;
                btnKalah38.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang38.Enabled = true;
                btnKalah38.Enabled = true;
            }
        }

        private void btnKalah38_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox37.Text + " sebagai pemenang pertandingan, dan " + textBox38.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox50.Text = textBox37.Text;
                btnMenang38.Enabled = false;
                btnKalah38.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang38.Enabled = true;
                btnKalah38.Enabled = true;
            }
        }

        private void btnMenang39_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox39.Text + " sebagai pemenang pertandingan, dan " + textBox40.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox51.Text = textBox39.Text;
                btnMenang39.Enabled = false;
                btnKalah39.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang39.Enabled = true;
                btnKalah39.Enabled = true;
            }
        }

        private void btnKalah39_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox40.Text + " sebagai pemenang pertandingan, dan " + textBox39.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox51.Text = textBox40.Text;
                btnMenang39.Enabled = false;
                btnKalah39.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang39.Enabled = true;
                btnKalah39.Enabled = true;
            }
        }

        private void btnMenang42_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox42.Text + " sebagai pemenang pertandingan, dan " + textBox41.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox52.Text = textBox42.Text;
                btnMenang42.Enabled = false;
                btnKalah42.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang42.Enabled = true;
                btnKalah42.Enabled = true;
            }
        }

        private void btnKalah42_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox41.Text + " sebagai pemenang pertandingan, dan " + textBox42.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox52.Text = textBox41.Text;
                btnMenang42.Enabled = false;
                btnKalah42.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang42.Enabled = true;
                btnKalah42.Enabled = true;
            }
        }

        private void btnMenang43_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox43.Text + " sebagai pemenang pertandingan, dan " + textBox44.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox53.Text = textBox43.Text;
                btnMenang43.Enabled = false;
                btnKalah43.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang43.Enabled = true;
                btnKalah43.Enabled = true;
            }
        }

        private void btnKalah43_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox44.Text + " sebagai pemenang pertandingan, dan " + textBox43.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox53.Text = textBox44.Text;
                btnMenang43.Enabled = false;
                btnKalah43.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang43.Enabled = true;
                btnKalah43.Enabled = true;
            }
        }

        private void btnMenang46_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox46.Text + " sebagai pemenang pertandingan, dan " + textBox45.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox54.Text = textBox46.Text;
                btnMenang46.Enabled = false;
                btnKalah46.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang46.Enabled = true;
                btnKalah46.Enabled = true;
            }
        }

        private void btnKalah46_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox45.Text + " sebagai pemenang pertandingan, dan " + textBox46.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox54.Text = textBox45.Text;
                btnMenang46.Enabled = false;
                btnKalah46.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang46.Enabled = true;
                btnKalah46.Enabled = true;
            }
        }

        private void btnMenang47_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox47.Text + " sebagai pemenang pertandingan, dan " + textBox48.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox55.Text = textBox47.Text;
                btnMenang47.Enabled = false;
                btnKalah47.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang47.Enabled = true;
                btnKalah47.Enabled = true;
            }
        }

        private void btnKalah47_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox48.Text + " sebagai pemenang pertandingan, dan " + textBox47.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox55.Text = textBox48.Text;
                btnMenang47.Enabled = false;
                btnKalah47.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang47.Enabled = true;
                btnKalah47.Enabled = true;
            }
        }

        private void btnMenang50_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox50.Text + " sebagai pemenang pertandingan, dan " + textBox49.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox56.Text = textBox50.Text;
                btnMenang50.Enabled = false;
                btnKalah50.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang50.Enabled = true;
                btnKalah50.Enabled = true;
            }
        }

        private void btnKalah50_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox49.Text + " sebagai pemenang pertandingan, dan " + textBox50.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox56.Text = textBox49.Text;
                btnMenang50.Enabled = false;
                btnKalah50.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang50.Enabled = true;
                btnKalah50.Enabled = true;
            }
        }

        private void btnMenang51_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox51.Text + " sebagai pemenang pertandingan, dan " + textBox52.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox57.Text = textBox51.Text;
                btnMenang51.Enabled = false;
                btnKalah51.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang51.Enabled = true;
                btnKalah51.Enabled = true;
            }
        }

        private void btnKalah51_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox52.Text + " sebagai pemenang pertandingan, dan " + textBox51.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox57.Text = textBox52.Text;
                btnMenang51.Enabled = false;
                btnKalah51.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang51.Enabled = true;
                btnKalah51.Enabled = true;
            }
        }

        private void btnMenang54_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox54.Text + " sebagai pemenang pertandingan, dan " + textBox53.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox58.Text = textBox54.Text;
                btnMenang54.Enabled = false;
                btnKalah54.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang54.Enabled = true;
                btnKalah54.Enabled = true;
            }
        }

        private void btnKalah54_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox53.Text + " sebagai pemenang pertandingan, dan " + textBox54.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox58.Text = textBox53.Text;
                btnMenang54.Enabled = false;
                btnKalah54.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang54.Enabled = true;
                btnKalah54.Enabled = true;
            }
        }

        private void btnMenang55_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox55.Text + " sebagai pemenang pertandingan, dan " + textBox56.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox59.Text = textBox55.Text;
                btnMenang55.Enabled = false;
                btnKalah55.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang55.Enabled = true;
                btnKalah55.Enabled = true;
            }
        }

        private void btnKalah55_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox56.Text + " sebagai pemenang pertandingan, dan " + textBox55.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox59.Text = textBox56.Text;
                btnMenang55.Enabled = false;
                btnKalah55.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang55.Enabled = true;
                btnKalah55.Enabled = true;
            }
        }

        private void btnMenang58_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox58.Text + " sebagai pemenang pertandingan, dan " + textBox57.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox60.Text = textBox58.Text;
                btnMenang58.Enabled = false;
                btnKalah58.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang58.Enabled = true;
                btnKalah58.Enabled = true;
            }
        }

        private void btnKalah58_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox57.Text + " sebagai pemenang pertandingan, dan " + textBox58.Text + " sebagai team yang kalah", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                textBox60.Text = textBox57.Text;
                btnMenang58.Enabled = false;
                btnKalah58.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang58.Enabled = true;
                btnKalah58.Enabled = true;
            }
        }

        private void btnMenang59_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox59.Text + " sebagai juara di lapangan 2, dan " + textBox60.Text + " sebagai team yang akan mengikuti babak 3/4", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                KumpulanVar.tipat2 = textBox60.Text;
                textBox60.Text = textBox60.Text + " (Masuk Babak 3/4)";
                selamat2.Text = "Selamat Kepada " + textBox59.Text;
                textBoxs2.Text = "Pemenang Dari Lapangan 2";
                btn_Pemenang_Lap2.Text = textBox59.Text;
                btnMenang59.Enabled = false;
                btnKalah59.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang59.Enabled = true;
                btnKalah59.Enabled = true;
            }
        }

        private void btnKalah59_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda setuju bahwa " + textBox60.Text + " sebagai juara di lapangan 2, dan " + textBox59.Text + " sebagai team yang akan mengikuti babak 3/4", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                KumpulanVar.tipat2 = textBox59.Text;
                textBox59.Text = textBox59.Text + " (Masuk Babak 3/4)";
                selamat2.Text = "Selamat Kepada " + textBox60.Text;
                textBoxs2.Text = "Pemenang Dari Lapangan 2";
                btn_Pemenang_Lap2.Text = textBox60.Text;
                btnMenang59.Enabled = false;
                btnKalah59.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang59.Enabled = true;
                btnKalah59.Enabled = true;
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            btnMenang31.Enabled = true;
            btnMenang34.Enabled = true;
            btnMenang35.Enabled = true;
            btnMenang38.Enabled = true;
            btnMenang39.Enabled = true;
            btnMenang42.Enabled = true;
            btnMenang43.Enabled = true;
            btnMenang46.Enabled = true;
            btnKalah31.Enabled = true;
            btnKalah34.Enabled = true;
            btnKalah35.Enabled = true;
            btnKalah38.Enabled = true;
            btnKalah39.Enabled = true;
            btnKalah42.Enabled = true;
            btnKalah43.Enabled = true;
            btnKalah46.Enabled = true;
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            btnMenang47.Enabled = true;
            btnKalah47.Enabled = true;
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            btnMenang50.Enabled = true;
            btnKalah50.Enabled = true;
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            btnMenang51.Enabled = true;
            btnKalah51.Enabled = true;
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            btnMenang54.Enabled = true;
            btnKalah54.Enabled = true;
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            btnMenang55.Enabled = true;
            btnKalah55.Enabled = true;
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            btnMenang58.Enabled = true;
            btnKalah58.Enabled = true;
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            btnMenang59.Enabled = true;
            btnKalah59.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBox1.Text = KumpulanVar.ntim[KumpulanVar.actim[0]];
            textBox2.Text = KumpulanVar.ntim[KumpulanVar.actim[1]];
            textBox3.Text = KumpulanVar.ntim[KumpulanVar.actim[2]];
            textBox4.Text = KumpulanVar.ntim[KumpulanVar.actim[3]];
            textBox5.Text = KumpulanVar.ntim[KumpulanVar.actim[4]];
            textBox6.Text = KumpulanVar.ntim[KumpulanVar.actim[5]];
            textBox7.Text = KumpulanVar.ntim[KumpulanVar.actim[6]];
            textBox8.Text = KumpulanVar.ntim[KumpulanVar.actim[7]];
            textBox9.Text = KumpulanVar.ntim[KumpulanVar.actim[8]];
            textBox10.Text = KumpulanVar.ntim[KumpulanVar.actim[9]];
            textBox11.Text = KumpulanVar.ntim[KumpulanVar.actim[10]];
            textBox12.Text = KumpulanVar.ntim[KumpulanVar.actim[11]];
            textBox13.Text = KumpulanVar.ntim[KumpulanVar.actim[12]];
            textBox14.Text = KumpulanVar.ntim[KumpulanVar.actim[13]];
            textBox15.Text = KumpulanVar.ntim[KumpulanVar.actim[14]];
            textBox16.Text = KumpulanVar.ntim[KumpulanVar.actim[15]];
            textBox31.Text = KumpulanVar.ntim[KumpulanVar.actim[16]];
            textBox32.Text = KumpulanVar.ntim[KumpulanVar.actim[17]];
            textBox33.Text = KumpulanVar.ntim[KumpulanVar.actim[18]];
            textBox34.Text = KumpulanVar.ntim[KumpulanVar.actim[19]];
            textBox35.Text = KumpulanVar.ntim[KumpulanVar.actim[20]];
            textBox36.Text = KumpulanVar.ntim[KumpulanVar.actim[21]];
            textBox37.Text = KumpulanVar.ntim[KumpulanVar.actim[22]];
            textBox38.Text = KumpulanVar.ntim[KumpulanVar.actim[23]];
            textBox39.Text = KumpulanVar.ntim[KumpulanVar.actim[24]];
            textBox40.Text = KumpulanVar.ntim[KumpulanVar.actim[25]];
            textBox41.Text = KumpulanVar.ntim[KumpulanVar.actim[26]];
            textBox42.Text = KumpulanVar.ntim[KumpulanVar.actim[27]];
            textBox43.Text = KumpulanVar.ntim[KumpulanVar.actim[28]];
            textBox44.Text = KumpulanVar.ntim[KumpulanVar.actim[29]];
            textBox45.Text = KumpulanVar.ntim[KumpulanVar.actim[30]];
            textBox46.Text = KumpulanVar.ntim[KumpulanVar.actim[31]];
            lblNama.Text = "Nama Pengacak : " + textBoxNama.Text;
            lblNama2.Text = "Nama Pengacak : " + textBoxNama.Text;
            lblNama3.Text = "Nama Pengacak : " + textBoxNama.Text;
            lblNama4.Text = "Nama Pengacak : " + textBoxNama.Text;
            lblKelas.Text = "Kelas : " + textBoxKelas.Text;
            lblKelas2.Text = "Kelas : " + textBoxKelas.Text;
            lblKelas3.Text = "Kelas : " + textBoxKelas.Text;
            lblKelas4.Text = "Kelas : " + textBoxKelas.Text;
            btnSimpan.Enabled = true;
        }

        private void llblKetRefresh3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol refresh maka Anda akan melihat dua tim yang akan bertanding di final tentunya setelah finalisnya ditentukan di lapangan 1 dan 2", "Keterangan Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh3_Click(object sender, EventArgs e)
        {
            textBox61.Text = btn_Pemenang_Lap1.Text;
            textBox62.Text = btn_Pemenang_Lap2.Text;
            lblKelas3.Text = "Kelas : " + textBoxKelas.Text;
            lblNama3.Text = "Nama Pengacak : " + textBoxNama.Text;
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            btnMenang61.Enabled = true;
            btnKalah61.Enabled = true;
        }

        private void btnMenang61_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda yakin " + textBox61.Text + " Akan menjadi juara 1 dan " + textBox62.Text + " adalah tim yang akan menjadi juara 2","Persetujuan",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                btnJuara.Text = textBox61.Text;
                KumpulanVar.pemenang1 = textBox61.Text;
                KumpulanVar.pemenang2 = textBox62.Text;
                lblPemenang1.Text = "Juara 1 : " + KumpulanVar.pemenang1;
                lblPemenang2.Text = "Juara 2 : " + KumpulanVar.pemenang2;
                btnJuara.Visible = true;
                KumpulanVar.buttonjuara = true;
                lblJuara2_62.Visible = true;
                KumpulanVar.juara2_62 = true;
                btnMenang61.Enabled = false;
                btnKalah61.Enabled = false;
            }
            if(dr==DialogResult.No)
            {
                btnMenang61.Enabled = true;
                btnKalah61.Enabled = true;
            }
        }

        private void btnKalah61_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda yakin " + textBox62.Text + " Akan menjadi juara 1 dan " + textBox61.Text + " adalah tim yang akan menjadi juara 2", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                btnJuara.Text = textBox62.Text;
                KumpulanVar.pemenang1 = textBox62.Text;
                KumpulanVar.pemenang2 = textBox61.Text;
                lblPemenang1.Text = "Juara 1 : " + KumpulanVar.pemenang1;
                lblPemenang2.Text = "Juara 2 : " + KumpulanVar.pemenang2;
                btnJuara.Visible = true;
                KumpulanVar.buttonjuara = true;
                lblJuara2_61.Visible = true;
                KumpulanVar.juara2_61 = true;
                btnMenang61.Enabled = false;
                btnKalah61.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang61.Enabled = true;
                btnKalah61.Enabled = true;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah yakin Anda ingin keluar?", "Persetujuan Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {}
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda yakin ingin me-reset semua pertandingan?", "Persetujuan Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            { }
        }

        private void btn_Pemenang_Lap1_TextChanged(object sender, EventArgs e)
        {
            KumpulanVar.k += 1;
            if (KumpulanVar.k == 2)
            {
                btnRefresh3.Enabled = true;
                btnRefresh4.Enabled = true;
            }
        }

        private void btnRefresh4_Click(object sender, EventArgs e)
        {
            textBox63.Text = KumpulanVar.tipat1;
            textBox64.Text = KumpulanVar.tipat2;
            lblKelas4.Text = "Kelas : " + textBoxKelas.Text;
            lblNama4.Text = "Nama Pengacak : " + textBoxNama.Text;
            btnJuara2.Text = btnJuara.Text;
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            btnMenang63.Enabled = true;
            btnKalah63.Enabled = true;
        }

        private void llblKetRefresh4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol refresh ini maka Anda akan melihat dua tim yang akan bertanding di penentuan juara 3 & 4 ini.", "Keterangan Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKalah63_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda yakin " + textBox64.Text + " Akan menjadi juara 3 dan " + textBox63.Text + " adalah tim yang akan menjadi juara 4", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                lblJuara_63.Text += "4";
                lblJuara_64.Text += "3";
                KumpulanVar.pemenang3 = textBox64.Text;
                KumpulanVar.pemenang4 = textBox63.Text;
                lblPemenang3.Text = "Juara 3 : " + KumpulanVar.pemenang3;
                lblPemenang4.Text = "Juara 4 : " + KumpulanVar.pemenang4;
                lblJuara_63.Visible = true;
                lblJuara_64.Visible = true;
                KumpulanVar.juara_63 = true;
                KumpulanVar.juara_64 = true;
                btnMenang63.Enabled = false;
                btnKalah63.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang63.Enabled = true;
                btnKalah63.Enabled = true;
            }
        }

        private void btnMenang63_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda yakin " + textBox63.Text + " Akan menjadi juara 3 dan " + textBox64.Text + " adalah tim yang akan menjadi juara 4", "Persetujuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                lblJuara_63.Text += "3";
                lblJuara_64.Text += "4";
                KumpulanVar.pemenang3 = textBox63.Text;
                KumpulanVar.pemenang4 = textBox64.Text;
                lblPemenang3.Text = "Juara 3 : " + KumpulanVar.pemenang3;
                lblPemenang4.Text = "Juara 4 : " + KumpulanVar.pemenang4;
                lblJuara_63.Visible = true;
                lblJuara_64.Visible = true;
                KumpulanVar.juara_63 = true;
                KumpulanVar.juara_64 = true;
                btnMenang63.Enabled = false;
                btnKalah63.Enabled = false;
            }
            if (dr == DialogResult.No)
            {
                btnMenang63.Enabled = true;
                btnKalah63.Enabled = true;
            }
        }

        private void llblKetSimpan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol file maka Anda dapat menyimpan pertandingan dan membuka pertandingan yang sudah Anda simpan serta melanjutkanya", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llblKetSimpan_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol simpan maka semua pertandingan bisa Anda simpan.", "Keterangan Simpan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llblKetLoad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol load maka Anda dapat melanjutkan pertandingan yang sudah Anda simpan.", "Keterangan Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog simpan = new SaveFileDialog();
                simpan.Filter = "PLF File | *.plf";
                if (simpan.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(simpan.OpenFile());
                    //textBox Nama Tim Writer
                    sw.WriteLine(textBox1.Text); sw.WriteLine(textBox2.Text);
                    sw.WriteLine(textBox3.Text); sw.WriteLine(textBox4.Text);
                    sw.WriteLine(textBox5.Text); sw.WriteLine(textBox6.Text);
                    sw.WriteLine(textBox7.Text); sw.WriteLine(textBox8.Text);
                    sw.WriteLine(textBox9.Text); sw.WriteLine(textBox10.Text);
                    sw.WriteLine(textBox11.Text); sw.WriteLine(textBox12.Text);
                    sw.WriteLine(textBox13.Text); sw.WriteLine(textBox14.Text);
                    sw.WriteLine(textBox15.Text); sw.WriteLine(textBox16.Text);
                    sw.WriteLine(textBox17.Text); sw.WriteLine(textBox18.Text);
                    sw.WriteLine(textBox19.Text); sw.WriteLine(textBox20.Text);
                    sw.WriteLine(textBox21.Text); sw.WriteLine(textBox22.Text);
                    sw.WriteLine(textBox23.Text); sw.WriteLine(textBox24.Text);
                    sw.WriteLine(textBox25.Text); sw.WriteLine(textBox26.Text);
                    sw.WriteLine(textBox27.Text); sw.WriteLine(textBox28.Text);
                    sw.WriteLine(textBox29.Text); sw.WriteLine(textBox30.Text);
                    sw.WriteLine(textBox31.Text); sw.WriteLine(textBox32.Text);
                    sw.WriteLine(textBox33.Text); sw.WriteLine(textBox34.Text);
                    sw.WriteLine(textBox35.Text); sw.WriteLine(textBox36.Text);
                    sw.WriteLine(textBox37.Text); sw.WriteLine(textBox38.Text);
                    sw.WriteLine(textBox39.Text); sw.WriteLine(textBox40.Text);
                    sw.WriteLine(textBox41.Text); sw.WriteLine(textBox42.Text);
                    sw.WriteLine(textBox43.Text); sw.WriteLine(textBox44.Text);
                    sw.WriteLine(textBox45.Text); sw.WriteLine(textBox46.Text);
                    sw.WriteLine(textBox47.Text); sw.WriteLine(textBox48.Text);
                    sw.WriteLine(textBox49.Text); sw.WriteLine(textBox50.Text);
                    sw.WriteLine(textBox51.Text); sw.WriteLine(textBox52.Text);
                    sw.WriteLine(textBox53.Text); sw.WriteLine(textBox54.Text);
                    sw.WriteLine(textBox55.Text); sw.WriteLine(textBox56.Text);
                    sw.WriteLine(textBox57.Text); sw.WriteLine(textBox58.Text);
                    sw.WriteLine(textBox59.Text); sw.WriteLine(textBox60.Text);
                    sw.WriteLine(textBox61.Text); sw.WriteLine(textBox62.Text);
                    sw.WriteLine(textBox63.Text); sw.WriteLine(textBox64.Text);

                    //textBox Lain-Lain Writer
                    sw.WriteLine(textBoxNama.Text);         //[64]
                    sw.WriteLine(textBoxKelas.Text);        //[65]
                    sw.WriteLine(textBoxs1.Text);           //[66]
                    sw.WriteLine(btn_Pemenang_Lap1.Text);   //[67]
                    sw.WriteLine(KumpulanVar.tipat1);       //[68]
                    sw.WriteLine(selamat1.Text);            //[69]
                    sw.WriteLine(textBoxs2.Text);           //[70]
                    sw.WriteLine(btn_Pemenang_Lap2.Text);   //[71]
                    sw.WriteLine(KumpulanVar.tipat2);       //[72]
                    sw.WriteLine(selamat2.Text);            //[73]
                    sw.WriteLine(KumpulanVar.pemenang1);    //[74]
                    sw.WriteLine(KumpulanVar.pemenang2);    //[75]
                    sw.WriteLine(btnJuara2.Text);           //[76]
                    sw.WriteLine(KumpulanVar.pemenang3);    //[77]
                    sw.WriteLine(KumpulanVar.pemenang4);    //[78]
                    sw.WriteLine(lblJuara_63.Text);         //[79]
                    sw.WriteLine(lblJuara_64.Text);         //[80]
                    sw.WriteLine(lblPemenang1.Text);        //[81]
                    sw.WriteLine(lblPemenang2.Text);        //[82]
                    sw.WriteLine(lblPemenang3.Text);        //[83]
                    sw.WriteLine(lblPemenang4.Text);        //[84]

                    //Variable actim writer
                    foreach (var item in KumpulanVar.actim)
                    {
                        sw.WriteLine(item);                    //85 ~ 116
                    }


                    //attribute writer
                    sw.WriteLine(textBoxNama.ReadOnly);             //[117]
                    sw.WriteLine(textBoxKelas.ReadOnly);            //[118]
                    sw.WriteLine(btnSimpan.Enabled);                //[119]
                    sw.WriteLine(btnExport.Enabled);                //[120]
                    sw.WriteLine(btnAcak.Enabled);                  //[121]
                    sw.WriteLine(btnRefresh.Enabled);               //[122]
                    sw.WriteLine(btnMenang1.Enabled);               //[123]
                    sw.WriteLine(btnKalah1.Enabled);                //[124]
                    sw.WriteLine(btnMenang4.Enabled);               //[125]
                    sw.WriteLine(btnKalah4.Enabled);                //[126]
                    sw.WriteLine(btnMenang5.Enabled);               //[127]
                    sw.WriteLine(btnKalah5.Enabled);                //[128]
                    sw.WriteLine(btnMenang8.Enabled);               //[129]
                    sw.WriteLine(btnKalah8.Enabled);                //[130]
                    sw.WriteLine(btnMenang9.Enabled);               //[131]
                    sw.WriteLine(btnKalah9.Enabled);                //[132]
                    sw.WriteLine(btnMenang12.Enabled);              //[133]
                    sw.WriteLine(btnKalah12.Enabled);               //[134]
                    sw.WriteLine(btnMenang13.Enabled);              //[135]
                    sw.WriteLine(btnKalah13.Enabled);               //[136]
                    sw.WriteLine(btnMenang16.Enabled);              //[137]
                    sw.WriteLine(btnKalah16.Enabled);               //[138]
                    sw.WriteLine(btnMenang17.Enabled);              //[139]
                    sw.WriteLine(btnKalah17.Enabled);               //[140]
                    sw.WriteLine(btnMenang20.Enabled);              //[141]
                    sw.WriteLine(btnKalah20.Enabled);               //[142]
                    sw.WriteLine(btnMenang21.Enabled);              //[143]
                    sw.WriteLine(btnKalah21.Enabled);               //[144]
                    sw.WriteLine(btnMenang24.Enabled);              //[145]
                    sw.WriteLine(btnKalah24.Enabled);               //[146]
                    sw.WriteLine(btnMenang25.Enabled);              //[147]
                    sw.WriteLine(btnKalah25.Enabled);               //[148]
                    sw.WriteLine(btnMenang28.Enabled);              //[149]
                    sw.WriteLine(btnKalah28.Enabled);               //[150]
                    sw.WriteLine(btnMenang29.Enabled);              //[151]
                    sw.WriteLine(btnKalah29.Enabled);               //[152]

                    sw.WriteLine(btnRefresh2.Enabled);              //[153]
                    sw.WriteLine(btnMenang31.Enabled);              //[154]
                    sw.WriteLine(btnKalah31.Enabled);               //[155]
                    sw.WriteLine(btnMenang34.Enabled);              //[156]
                    sw.WriteLine(btnKalah34.Enabled);               //[157]
                    sw.WriteLine(btnMenang35.Enabled);              //[158]
                    sw.WriteLine(btnKalah35.Enabled);               //[159]
                    sw.WriteLine(btnMenang38.Enabled);              //[160]
                    sw.WriteLine(btnKalah38.Enabled);               //[161]
                    sw.WriteLine(btnMenang39.Enabled);              //[162]
                    sw.WriteLine(btnKalah39.Enabled);               //[163]
                    sw.WriteLine(btnMenang42.Enabled);              //[164]
                    sw.WriteLine(btnKalah42.Enabled);               //[165]
                    sw.WriteLine(btnMenang43.Enabled);              //[166]
                    sw.WriteLine(btnKalah43.Enabled);               //[167]
                    sw.WriteLine(btnMenang46.Enabled);              //[168]
                    sw.WriteLine(btnKalah46.Enabled);               //[169]
                    sw.WriteLine(btnMenang47.Enabled);              //[170]
                    sw.WriteLine(btnKalah47.Enabled);               //[171]
                    sw.WriteLine(btnMenang50.Enabled);              //[172]
                    sw.WriteLine(btnKalah50.Enabled);               //[173]
                    sw.WriteLine(btnMenang51.Enabled);              //[174]
                    sw.WriteLine(btnKalah51.Enabled);               //[175]
                    sw.WriteLine(btnMenang54.Enabled);              //[176]
                    sw.WriteLine(btnKalah54.Enabled);               //[177]
                    sw.WriteLine(btnMenang55.Enabled);              //[178]
                    sw.WriteLine(btnKalah55.Enabled);               //[179]
                    sw.WriteLine(btnMenang58.Enabled);              //[180]
                    sw.WriteLine(btnKalah58.Enabled);               //[181]
                    sw.WriteLine(btnMenang59.Enabled);              //[182]
                    sw.WriteLine(btnKalah59.Enabled);               //[183]

                    sw.WriteLine(btnRefresh3.Enabled);              //[184]
                    sw.WriteLine(KumpulanVar.buttonjuara);          //[185]
                    sw.WriteLine(btnMenang61.Enabled);              //[186]
                    sw.WriteLine(btnKalah61.Enabled);               //[187]
                    sw.WriteLine(KumpulanVar.juara2_61);            //[188]
                    sw.WriteLine(KumpulanVar.juara2_62);            //[189]

                    sw.WriteLine(btnRefresh4.Enabled);              //[190]
                    sw.WriteLine(btnMenang63.Enabled);              //[191]
                    sw.WriteLine(btnKalah63.Enabled);               //[192]
                    sw.WriteLine(KumpulanVar.juara_63);             //[193]
                    sw.WriteLine(KumpulanVar.juara_64);             //[194]
                   
                    sw.Close();
                    MessageBox.Show("Penyimpanan data sukses.", "Informasi Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Gagal untuk menyimpan file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PLF File | *.plf";
                List<string> tbox = new List<string>();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    btnSimpan.Enabled = true;
                    StreamReader sr = new StreamReader(ofd.FileName);
                    while ((line = sr.ReadLine()) != null)
                    {
                        tbox.Add(line);
                    }
                    SavingText.tbox = tbox.ToArray();
                    sr.Close();

                    //Load textBox
                    textBox1.Text = SavingText.tbox[0]; textBox2.Text = SavingText.tbox[1];
                    textBox3.Text = SavingText.tbox[2]; textBox4.Text = SavingText.tbox[3];
                    textBox5.Text = SavingText.tbox[4]; textBox6.Text = SavingText.tbox[5];
                    textBox7.Text = SavingText.tbox[6]; textBox8.Text = SavingText.tbox[7];
                    textBox9.Text = SavingText.tbox[8]; textBox10.Text = SavingText.tbox[9];
                    textBox11.Text = SavingText.tbox[10]; textBox12.Text = SavingText.tbox[11];
                    textBox13.Text = SavingText.tbox[12]; textBox14.Text = SavingText.tbox[13];
                    textBox15.Text = SavingText.tbox[14]; textBox16.Text = SavingText.tbox[15];
                    textBox17.Text = SavingText.tbox[16]; textBox18.Text = SavingText.tbox[17];
                    textBox19.Text = SavingText.tbox[18]; textBox20.Text = SavingText.tbox[19];
                    textBox21.Text = SavingText.tbox[20]; textBox22.Text = SavingText.tbox[21];
                    textBox23.Text = SavingText.tbox[22]; textBox24.Text = SavingText.tbox[23];
                    textBox25.Text = SavingText.tbox[24]; textBox26.Text = SavingText.tbox[25];
                    textBox27.Text = SavingText.tbox[26]; textBox28.Text = SavingText.tbox[27];
                    textBox29.Text = SavingText.tbox[28]; textBox30.Text = SavingText.tbox[29];
                    textBox31.Text = SavingText.tbox[30]; textBox32.Text = SavingText.tbox[31];
                    textBox33.Text = SavingText.tbox[32]; textBox34.Text = SavingText.tbox[33];
                    textBox35.Text = SavingText.tbox[34]; textBox36.Text = SavingText.tbox[35];
                    textBox37.Text = SavingText.tbox[36]; textBox38.Text = SavingText.tbox[37];
                    textBox39.Text = SavingText.tbox[38]; textBox40.Text = SavingText.tbox[39];
                    textBox41.Text = SavingText.tbox[40]; textBox42.Text = SavingText.tbox[41];
                    textBox43.Text = SavingText.tbox[42]; textBox44.Text = SavingText.tbox[43];
                    textBox45.Text = SavingText.tbox[44]; textBox46.Text = SavingText.tbox[45];
                    textBox47.Text = SavingText.tbox[46]; textBox48.Text = SavingText.tbox[47];
                    textBox49.Text = SavingText.tbox[48]; textBox50.Text = SavingText.tbox[49];
                    textBox51.Text = SavingText.tbox[50]; textBox52.Text = SavingText.tbox[51];
                    textBox53.Text = SavingText.tbox[52]; textBox54.Text = SavingText.tbox[53];
                    textBox55.Text = SavingText.tbox[54]; textBox56.Text = SavingText.tbox[55];
                    textBox57.Text = SavingText.tbox[56]; textBox58.Text = SavingText.tbox[57];
                    textBox59.Text = SavingText.tbox[58]; textBox60.Text = SavingText.tbox[59];
                    textBox61.Text = SavingText.tbox[60]; textBox62.Text = SavingText.tbox[61];
                    textBox63.Text = SavingText.tbox[62]; textBox64.Text = SavingText.tbox[63];


                    //synchronize var
                    KumpulanVar.pemenang1 = SavingText.tbox[74];
                    KumpulanVar.pemenang2 = SavingText.tbox[75];
                    KumpulanVar.pemenang3 = SavingText.tbox[77];
                    KumpulanVar.pemenang4 = SavingText.tbox[78];
                    KumpulanVar.tipat1 = SavingText.tbox[68];
                    KumpulanVar.tipat2 = SavingText.tbox[72];

                    KumpulanVar.actim[0] = Convert.ToInt16(SavingText.tbox[85]); KumpulanVar.actim[1] = Convert.ToInt16(SavingText.tbox[86]);
                    KumpulanVar.actim[2] = Convert.ToInt16(SavingText.tbox[87]); KumpulanVar.actim[3] = Convert.ToInt16(SavingText.tbox[88]);
                    KumpulanVar.actim[4] = Convert.ToInt16(SavingText.tbox[89]); KumpulanVar.actim[5] = Convert.ToInt16(SavingText.tbox[90]);
                    KumpulanVar.actim[6] = Convert.ToInt16(SavingText.tbox[91]); KumpulanVar.actim[7] = Convert.ToInt16(SavingText.tbox[92]);
                    KumpulanVar.actim[8] = Convert.ToInt16(SavingText.tbox[93]); KumpulanVar.actim[9] = Convert.ToInt16(SavingText.tbox[94]);
                    KumpulanVar.actim[10] = Convert.ToInt16(SavingText.tbox[95]); KumpulanVar.actim[11] = Convert.ToInt16(SavingText.tbox[96]);
                    KumpulanVar.actim[12] = Convert.ToInt16(SavingText.tbox[97]); KumpulanVar.actim[13] = Convert.ToInt16(SavingText.tbox[98]);
                    KumpulanVar.actim[14] = Convert.ToInt16(SavingText.tbox[99]); KumpulanVar.actim[15] = Convert.ToInt16(SavingText.tbox[100]);
                    KumpulanVar.actim[16] = Convert.ToInt16(SavingText.tbox[101]); KumpulanVar.actim[17] = Convert.ToInt16(SavingText.tbox[102]);
                    KumpulanVar.actim[18] = Convert.ToInt16(SavingText.tbox[103]); KumpulanVar.actim[19] = Convert.ToInt16(SavingText.tbox[104]);
                    KumpulanVar.actim[20] = Convert.ToInt16(SavingText.tbox[105]); KumpulanVar.actim[21] = Convert.ToInt16(SavingText.tbox[106]);
                    KumpulanVar.actim[22] = Convert.ToInt16(SavingText.tbox[107]); KumpulanVar.actim[23] = Convert.ToInt16(SavingText.tbox[108]);
                    KumpulanVar.actim[24] = Convert.ToInt16(SavingText.tbox[109]); KumpulanVar.actim[25] = Convert.ToInt16(SavingText.tbox[110]);
                    KumpulanVar.actim[26] = Convert.ToInt16(SavingText.tbox[111]); KumpulanVar.actim[27] = Convert.ToInt16(SavingText.tbox[112]);
                    KumpulanVar.actim[28] = Convert.ToInt16(SavingText.tbox[113]); KumpulanVar.actim[29] = Convert.ToInt16(SavingText.tbox[114]);
                    KumpulanVar.actim[30] = Convert.ToInt16(SavingText.tbox[115]); KumpulanVar.actim[31] = Convert.ToInt16(SavingText.tbox[116]);

                    //Load Lain-lain
                    textBoxNama.Text = SavingText.tbox[64];
                    textBoxKelas.Text = SavingText.tbox[65];
                    textBoxs1.Text = SavingText.tbox[66];
                    btn_Pemenang_Lap1.Text = SavingText.tbox[67];
                    //[68] var
                    selamat1.Text = SavingText.tbox[69];
                    textBoxs2.Text = SavingText.tbox[70];
                    btn_Pemenang_Lap2.Text = SavingText.tbox[71];
                    //[72] var
                    selamat2.Text = SavingText.tbox[73];
                    btnJuara.Text = SavingText.tbox[74];
                    //[75] var
                    btnJuara2.Text = SavingText.tbox[76];
                    //[77] var
                    //[78] var
                    lblJuara_63.Text = SavingText.tbox[79];
                    lblJuara_64.Text = SavingText.tbox[80];

                    lblNama.Text = "Nama Pengacak : " + textBoxNama.Text; lblNama2.Text = "Nama Pengacak : " + textBoxNama.Text;
                    lblKelas.Text = "Kelas : " + textBoxKelas.Text; lblKelas2.Text = "Kelas : " + textBoxKelas.Text;
                    lblNama3.Text = "Nama Pengacak : " + textBoxNama.Text; lblNama4.Text = "Nama Pengacak : " + textBoxNama.Text;
                    lblKelas3.Text = "Kelas : " + textBoxKelas.Text; lblKelas4.Text = "Kelas : " + textBoxKelas.Text;
                    lblPemenang1.Text = "Juara 1 : " + KumpulanVar.pemenang1; lblPemenang2.Text = "Juara 2 : " + KumpulanVar.pemenang2;
                    lblPemenang3.Text = "Juara 3 : " + KumpulanVar.pemenang3; lblPemenang4.Text = "Juara 4 : " + KumpulanVar.pemenang4;

                    //load attribute
                    textBoxNama.ReadOnly = Convert.ToBoolean(SavingText.tbox[117]); btnRefresh2.Enabled = Convert.ToBoolean(SavingText.tbox[153]);
                    textBoxKelas.ReadOnly = Convert.ToBoolean(SavingText.tbox[118]); btnMenang31.Enabled = Convert.ToBoolean(SavingText.tbox[154]);
                    btnSimpan.Enabled = Convert.ToBoolean(SavingText.tbox[119]); btnKalah31.Enabled = Convert.ToBoolean(SavingText.tbox[155]);
                    btnExport.Enabled = Convert.ToBoolean(SavingText.tbox[120]); btnMenang34.Enabled = Convert.ToBoolean(SavingText.tbox[156]);
                    btnAcak.Enabled = Convert.ToBoolean(SavingText.tbox[121]); btnKalah34.Enabled = Convert.ToBoolean(SavingText.tbox[157]);
                    btnRefresh.Enabled = Convert.ToBoolean(SavingText.tbox[122]); btnMenang35.Enabled = Convert.ToBoolean(SavingText.tbox[158]);
                    btnMenang1.Enabled = Convert.ToBoolean(SavingText.tbox[123]); btnKalah35.Enabled = Convert.ToBoolean(SavingText.tbox[159]);
                    btnKalah1.Enabled = Convert.ToBoolean(SavingText.tbox[124]); btnMenang38.Enabled = Convert.ToBoolean(SavingText.tbox[160]);
                    btnMenang4.Enabled = Convert.ToBoolean(SavingText.tbox[125]); btnKalah38.Enabled = Convert.ToBoolean(SavingText.tbox[161]);
                    btnKalah4.Enabled = Convert.ToBoolean(SavingText.tbox[126]); btnMenang39.Enabled = Convert.ToBoolean(SavingText.tbox[162]);
                    btnMenang5.Enabled = Convert.ToBoolean(SavingText.tbox[127]); btnKalah39.Enabled = Convert.ToBoolean(SavingText.tbox[163]);
                    btnKalah5.Enabled = Convert.ToBoolean(SavingText.tbox[128]); btnMenang42.Enabled = Convert.ToBoolean(SavingText.tbox[164]);
                    btnMenang8.Enabled = Convert.ToBoolean(SavingText.tbox[129]); btnKalah42.Enabled = Convert.ToBoolean(SavingText.tbox[165]);
                    btnKalah8.Enabled = Convert.ToBoolean(SavingText.tbox[130]); btnMenang43.Enabled = Convert.ToBoolean(SavingText.tbox[166]);
                    btnMenang9.Enabled = Convert.ToBoolean(SavingText.tbox[131]); btnKalah43.Enabled = Convert.ToBoolean(SavingText.tbox[167]);
                    btnKalah9.Enabled = Convert.ToBoolean(SavingText.tbox[132]); btnMenang46.Enabled = Convert.ToBoolean(SavingText.tbox[168]);
                    btnMenang12.Enabled = Convert.ToBoolean(SavingText.tbox[133]); btnKalah46.Enabled = Convert.ToBoolean(SavingText.tbox[169]);
                    btnKalah12.Enabled = Convert.ToBoolean(SavingText.tbox[134]); btnMenang47.Enabled = Convert.ToBoolean(SavingText.tbox[170]);
                    btnMenang13.Enabled = Convert.ToBoolean(SavingText.tbox[135]); btnKalah47.Enabled = Convert.ToBoolean(SavingText.tbox[171]);
                    btnKalah13.Enabled = Convert.ToBoolean(SavingText.tbox[136]); btnMenang50.Enabled = Convert.ToBoolean(SavingText.tbox[172]);
                    btnMenang16.Enabled = Convert.ToBoolean(SavingText.tbox[137]); btnKalah50.Enabled = Convert.ToBoolean(SavingText.tbox[173]);
                    btnKalah16.Enabled = Convert.ToBoolean(SavingText.tbox[138]); btnMenang51.Enabled = Convert.ToBoolean(SavingText.tbox[174]);
                    btnMenang17.Enabled = Convert.ToBoolean(SavingText.tbox[139]); btnKalah51.Enabled = Convert.ToBoolean(SavingText.tbox[175]);
                    btnKalah17.Enabled = Convert.ToBoolean(SavingText.tbox[140]); btnMenang54.Enabled = Convert.ToBoolean(SavingText.tbox[176]);
                    btnMenang20.Enabled = Convert.ToBoolean(SavingText.tbox[141]); btnKalah54.Enabled = Convert.ToBoolean(SavingText.tbox[177]);
                    btnKalah20.Enabled = Convert.ToBoolean(SavingText.tbox[142]); btnMenang55.Enabled = Convert.ToBoolean(SavingText.tbox[178]);
                    btnMenang21.Enabled = Convert.ToBoolean(SavingText.tbox[143]); btnKalah55.Enabled = Convert.ToBoolean(SavingText.tbox[179]);
                    btnKalah21.Enabled = Convert.ToBoolean(SavingText.tbox[144]); btnMenang58.Enabled = Convert.ToBoolean(SavingText.tbox[180]);
                    btnMenang24.Enabled = Convert.ToBoolean(SavingText.tbox[145]); btnKalah58.Enabled = Convert.ToBoolean(SavingText.tbox[181]);
                    btnKalah24.Enabled = Convert.ToBoolean(SavingText.tbox[146]); btnMenang59.Enabled = Convert.ToBoolean(SavingText.tbox[182]);
                    btnMenang25.Enabled = Convert.ToBoolean(SavingText.tbox[147]); btnKalah59.Enabled = Convert.ToBoolean(SavingText.tbox[183]);
                    btnKalah25.Enabled = Convert.ToBoolean(SavingText.tbox[148]);
                    btnMenang28.Enabled = Convert.ToBoolean(SavingText.tbox[149]);
                    btnKalah28.Enabled = Convert.ToBoolean(SavingText.tbox[150]);
                    btnMenang29.Enabled = Convert.ToBoolean(SavingText.tbox[151]);
                    btnKalah29.Enabled = Convert.ToBoolean(SavingText.tbox[152]);

                    btnRefresh3.Enabled = Convert.ToBoolean(SavingText.tbox[184]); btnRefresh4.Enabled = Convert.ToBoolean(SavingText.tbox[190]);
                    btnJuara.Visible = Convert.ToBoolean(SavingText.tbox[185]); btnMenang63.Enabled = Convert.ToBoolean(SavingText.tbox[191]);
                    btnMenang61.Enabled = Convert.ToBoolean(SavingText.tbox[186]); btnKalah63.Enabled = Convert.ToBoolean(SavingText.tbox[192]);
                    btnKalah61.Enabled = Convert.ToBoolean(SavingText.tbox[187]); lblJuara_63.Visible = Convert.ToBoolean(SavingText.tbox[193]);
                    lblJuara2_61.Visible = Convert.ToBoolean(SavingText.tbox[188]); lblJuara_64.Visible = Convert.ToBoolean(SavingText.tbox[194]);
                    lblJuara2_62.Visible = Convert.ToBoolean(SavingText.tbox[189]);
                    MessageBox.Show("Load data sukses Anda dapat melanjutkan pertandinganya.", "Informasi Load Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("Gagal untuk membuka file.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void llblKetExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Jika Anda menekan tombol export maka Anda dapat menyimpan hasil pertandingan dalam bentuk word. (Di versi ini belum tersedia)", "Keterangan Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxNama_KeyDown(object sender, KeyEventArgs e)
        {

            if (KumpulanVar.fnama && KumpulanVar.fkelas)
            {
                btnAcak.Enabled = true;
                if (e.KeyCode == Keys.Enter)
                {
                    btnAcak_Click(sender, e);
                }
            }
            else
            {
                btnAcak.Enabled = false;
                if (e.KeyCode == Keys.Enter)
                {
                    MessageBox.Show("Anda belum mengisi semua formulir.", "Error Acak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnRefresh.Enabled == true && e.KeyCode == Keys.F5)
            {
                btnRefresh_Click(sender, e);
            }

            if (btnRefresh3.Enabled == true && e.KeyCode == Keys.F5)
            {
                btnRefresh3_Click(sender, e);
            }

            if (btnRefresh4.Enabled == true && e.KeyCode == Keys.F5)
            {
                btnRefresh4_Click(sender, e);
            }
        }
    }
}
