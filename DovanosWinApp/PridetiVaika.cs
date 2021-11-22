using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovanosWinApp
{
    public partial class addVaika : Form
    {
        public addVaika()
        {
            InitializeComponent();
        }

        private void textBox_prideti_varda_TextChanged(object sender, EventArgs e)
        {

        }

        private void addChild_Click(object sender, EventArgs e)
        {
            
            string naujasVardas = textBox_prideti_varda.Text;
            string naujaPavarde = textBox_prideti_pavarde.Text;
            int naujasVaikoId = Program.vaikuBiblioteka.NaujoVaikoID();
            Program.vaikuBiblioteka.PridetiNaujaVaika(naujasVaikoId, naujasVardas, naujaPavarde);
            this.Hide();
            dovanosApp main = new dovanosApp();
            main.ShowDialog();
            this.Close();

        }
    }
}

