using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class VaikuBiblioteka
    {
        private List<Vaikai> VaikuSarasas;

        public VaikuBiblioteka()
        {
            VaikuSarasas = new List<Vaikai>();
            GeneruotiVaikuSarasa();
        }

        public List<Vaikai> GautiVaikuSarasa()
        {
            return VaikuSarasas;
        }

        public void GeneruotiVaikuSarasa()
        {
            List<string> VisasSarasas;
            string skyrius = "|";
            VisasSarasas = new List<string>();
            string[] vienasIrasas = System.IO.File.ReadAllLines(DuomenuFailai.vaikuData);
            foreach (string item in vienasIrasas)
            {
                int count = item.Length;
                if (count > 0)
                {
                    VisasSarasas.Add(item);
                }
            }
            System.IO.File.AppendAllLines(DuomenuFailai.vaikuDataTemp, VisasSarasas);
            foreach (string eilute in VisasSarasas)
            {
                int skaidymas = 1;
                string laikinasId = "";
                int id;
                string vardas = "";
                string pavarde = "";
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
                                vardas = vardas + simbolis;
                            }
                            else
                            {
                                skaidymas++;
                            }
                            break;
                        case 3:
                            if (checkTarpas == false)
                            {
                                pavarde = pavarde + simbolis;
                            }
                            else
                            {
                                skaidymas++;
                            }
                            break;
                    }
                }
                id = Convert.ToInt32(laikinasId);
                VaikuSarasas.Add(new Vaikai(id, vardas, pavarde));
            }
            System.IO.File.Replace(DuomenuFailai.vaikuDataTemp, DuomenuFailai.vaikuData, DuomenuFailai.vaikuDataBackup);
        }
        public int NaujoVaikoID()
        {
            List<Vaikai> dabartinisSarasas = GautiVaikuSarasa();
            int idMax = dabartinisSarasas.Max(paskutinisId => paskutinisId.VaikoId);
            int idNaujas = idMax+1;
            return idNaujas;
        }
        public void PridetiNaujaVaika(int naujoVaikoId, string naujoVaikoVardas, string naujoVaikoPavarde)
        {
            naujoVaikoId = NaujoVaikoID();
            VaikuSarasas.Add(new Vaikai(naujoVaikoId, naujoVaikoVardas, naujoVaikoPavarde));

            PakeistiVaikuSarasa();
        }
        public void PasalintiVaika(int pasalintiVaikaId)
        {
            for (int i = 0; i < VaikuSarasas.Count; i++)
            {
                if (pasalintiVaikaId == VaikuSarasas[i].VaikoId)
                {
                    VaikuSarasas.RemoveAt(i);
                }
            }
            
            PakeistiVaikuSarasa();
        }

        public void PakeistiVaikuSarasa()
        {
            int i = 0;
            int irasuKiekis = VaikuSarasas.Count;
            string[] vaikuSarasoAtnaujinimas = new string[irasuKiekis];
            foreach (var item in VaikuSarasas)
            {
                string vaikoIrasas = Convert.ToString(item.VaikoId) + "|" + item.VaikoVardas + "|" + item.VaikoPavarde;
                vaikuSarasoAtnaujinimas[i] = vaikoIrasas;
                i++;
            }
            System.IO.File.AppendAllLines(DuomenuFailai.vaikuDataTemp, vaikuSarasoAtnaujinimas);
            System.IO.File.Replace(DuomenuFailai.vaikuDataTemp, DuomenuFailai.vaikuData, DuomenuFailai.vaikuDataBackup);
            AtnaujintiVaikuSarasa();
        }
        public void AtnaujintiVaikuSarasa()
        {
            VaikuSarasas = new List<Vaikai>();
            GeneruotiVaikuSarasa();
        }

    }
}
