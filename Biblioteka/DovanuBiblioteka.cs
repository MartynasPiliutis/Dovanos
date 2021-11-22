using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class DovanuBiblioteka
    {
        private List<Dovanos> DovanuSarasas;

        public DovanuBiblioteka()
        {
            DovanuSarasas = new List<Dovanos>();
            GeneruotiDovanuSarasa();
        }

        public List<Dovanos> GautiDovanuSarasa()
        {
            return DovanuSarasas;
        }

        public void GeneruotiDovanuSarasa()
        {
            List<string> VisasDovanuSarasas;
            string skyrius = "|";
            VisasDovanuSarasas = new List<string>();
            string[] vienasIrasas = System.IO.File.ReadAllLines(DuomenuFailai.dovanuData);
            foreach (string item in vienasIrasas)
            {
                int count = item.Length;
                if (count > 0)
                {
                    VisasDovanuSarasas.Add(item);
                }
            }
            System.IO.File.AppendAllLines(DuomenuFailai.dovanuDataTemp, VisasDovanuSarasas);
            foreach (string eilute in VisasDovanuSarasas)
            {
                int skaidymas = 1;
                string laikinasId = "";
                int id;
                string vienaDovana = "";
                List<string> vaikoDovanuSarasas = new List<string>();
                foreach (char objektas in eilute)
                {
                    string simbolis = Convert.ToString(objektas);
                    bool checkTarpas = skyrius.Equals(simbolis);
                    switch (skaidymas)
                    {
                        case 1:
                            if (checkTarpas == false)
                            {
                                laikinasId = laikinasId + simbolis;
                            }
                            else
                            {
                                skaidymas++;
                            }
                            break;
                        case 2:
                            if (checkTarpas == false)
                            {
                                vienaDovana = vienaDovana + simbolis;
                            }
                            else
                            {
                                vaikoDovanuSarasas.Add(vienaDovana);
                                vienaDovana = "";
                            }
                            break;
                    }
                }
                id = Convert.ToInt32(laikinasId);
                DovanuSarasas.Add(new Dovanos(id, vaikoDovanuSarasas));
            }
            System.IO.File.Replace(DuomenuFailai.dovanuDataTemp, DuomenuFailai.dovanuData, DuomenuFailai.dovanuDataBackup);
        }

        public List<string> GautiDovanuSarasaPagalVaikoId(int findId)
        {
            List<Dovanos> vaikuDovanos;
            List<string> vaikoDovanos = new List<string>();
            vaikuDovanos = GautiDovanuSarasa();
            foreach (var item in DovanuSarasas)
            {
                if (item.VaikoId == findId)
                {
                    vaikoDovanos = item.Dovana;
                }
            }
            return vaikoDovanos;
        }

        public void PridetiDovanaPagalVaikoId(int findId, string naujaDovana)
        {
            List<Dovanos> vaikuDovanos;
            vaikuDovanos = GautiDovanuSarasa();
            int check = 0;
            foreach (var item in vaikuDovanos)
            {
                if (item.VaikoId == findId)
                {
                    item.Dovana.Add(naujaDovana);
                    check = check + 1;
                }
            }
            if (check == 0)
            {
                List<string> Dovana = new List<string>();
                Dovana.Add(naujaDovana);
                vaikuDovanos.Add(new Dovanos(findId, Dovana));
            }
            AtnaujintiDovanuBaze();
        }

        public void PasalintiDovanuSarasaPagalVaikoId(int findId)
        {
            for (int i = 0; i < DovanuSarasas.Count; i++)
            {
                if (findId == DovanuSarasas[i].VaikoId)
                {
                    DovanuSarasas.RemoveAt(i);
                }
            }
        }

        public void PasalintiVienaDovanaIsVaikoSaraso(int findId, string pasalintiDovana)
        {
            List<string> VaikoDovanos = new List<string>();
            for (int i = 0; i < DovanuSarasas.Count; i++)
            {
                if (findId == DovanuSarasas[i].VaikoId)
                {
                    VaikoDovanos = DovanuSarasas[i].Dovana;
                    for (int j = 0; j < VaikoDovanos.Count; j++)
                    {
                        foreach (string item in VaikoDovanos)
                        {
                            bool matchText = pasalintiDovana.Equals(item, StringComparison.OrdinalIgnoreCase);
                            if (matchText == true)
                            {
                                VaikoDovanos.RemoveAt(i);
                            }
                        }
                    }
                }
            }
        }
        public void AtnaujintiDovanuSarasa()
        {
            DovanuSarasas = new List<Dovanos>();
            GeneruotiDovanuSarasa();
        }

        public void AtnaujintiDovanuBaze()
        {
            int i = 0;
            int irasuKiekis = DovanuSarasas.Count;
            string[] dovanuSarasoAtnaujinimas = new string[irasuKiekis];
            foreach (var item in DovanuSarasas)
            {
                string dovanuIrasas = Convert.ToString(item.VaikoId) + "|";
                List<string> atnaujinamasDovanuSarasas = item.Dovana;
                for (int j = 0; j < atnaujinamasDovanuSarasas.Count; j++)
                {
                    dovanuIrasas = dovanuIrasas + atnaujinamasDovanuSarasas[j] + "|";
                }
                dovanuSarasoAtnaujinimas[i] = dovanuIrasas;
                i++;
            }
            System.IO.File.AppendAllLines(DuomenuFailai.dovanuDataTemp, dovanuSarasoAtnaujinimas);
            System.IO.File.Replace(DuomenuFailai.dovanuDataTemp, DuomenuFailai.dovanuData, DuomenuFailai.dovanuDataBackup);
            AtnaujintiDovanuSarasa();
        }
    }
}
