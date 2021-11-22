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
    public partial class naujaDovana : Form
    {
        public naujaDovana()
        {
            InitializeComponent();
        }

        public void button_add_dovana_Click(object sender, EventArgs e)
        {
            this.Hide();
            int id = Convert.ToInt32(textBox_vaikoId_nDovana.Text);
            string naujaDovana = textBox_nauja_dovana.Text;
            Program.dovanuBiblioteka.PridetiDovanaPagalVaikoId(id, naujaDovana);
            dovanosApp main = new dovanosApp();
            main.ShowDialog();
            this.Close();
        }
    }
}
