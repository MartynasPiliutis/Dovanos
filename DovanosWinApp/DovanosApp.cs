using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteka;
using System.IO;

namespace DovanosWinApp
{
    public partial class dovanosApp : Form
    {
        public dovanosApp()
        {
            InitializeComponent();
            vaikuSarasoIkelimas();

        }

        private void ziuretDovanas_Click(object sender, EventArgs e)
        {
            vaikasPazymetasSarase();
        }

        public void vaikuSarasoIkelimas()
        {
            List<Vaikai> vaikuSarasas = Program.vaikuBiblioteka.GautiVaikuSarasa();
            foreach (var item in vaikuSarasas)
            {
                int id = item.VaikoId;
                string vardas = item.VaikoVardas;
                string pavarde = item.VaikoPavarde;
                textBox_vaikai.Items.Add(id+" "+vardas+" "+pavarde);
            }
        }

        public void vaikasPazymetasSarase()
        {
            textBox_dovanos.Items.Clear();
            string eilute = Convert.ToString(textBox_vaikai.SelectedItem);
            string idTemp= "";
            for (int i = 0; i < 5; i++)
            {
                char j = eilute[i];
                idTemp = idTemp + j;
            }
            int id = Convert.ToInt32(idTemp);
            List<string> vaikoDovanuSarasas = Program.dovanuBiblioteka.GautiDovanuSarasaPagalVaikoId(id);
            foreach (var item in vaikoDovanuSarasas)
            {
                textBox_dovanos.Items.Add(item);
            }
        }
        public int vaikoIdPazymetasSarase()
        {
            string eilute = Convert.ToString(textBox_vaikai.SelectedItem);
            string idTmp = "";
            for (int i = 0; i < 5; i++)
            {
                char d = eilute[i];
                idTmp = idTmp + d;
            }
            int id = Convert.ToInt32(idTmp);
            return id;
        }

        public void textBox_vaikai_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox_vaikai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_trinti_vaika_Click(object sender, EventArgs e)
        {
            string eilute = Convert.ToString(textBox_vaikai.SelectedItem);
            string idTemp = "";
            for (int i = 0; i < 5; i++)
            {
                char j = eilute[i];
                idTemp = idTemp + j;
            }
            int id = Convert.ToInt32(idTemp);

            Program.vaikuBiblioteka.PasalintiVaika(id);
            Program.dovanuBiblioteka.PasalintiDovanuSarasaPagalVaikoId(id);
            textBox_vaikai.Items.Clear();
            textBox_dovanos.Items.Clear();
            vaikuSarasoIkelimas();

        }

        private void btn_add_vaika_Click(object sender, EventArgs e)
        {
            this.Hide();
            addVaika pridetiVaika = new addVaika();
            pridetiVaika.ShowDialog();
            this.Close();
        }

        public void btn_add_dovana_Click(object sender, EventArgs e)
        {
            this.Hide();
            naujaDovana nDovana = new naujaDovana();
            nDovana.ShowDialog();
            this.Close();
        }
    }
}
