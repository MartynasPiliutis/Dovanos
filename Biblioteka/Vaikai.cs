using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Vaikai
    {
        public int VaikoId { get; private set; }
        public string VaikoVardas { get; private set; }
        public string VaikoPavarde { get; private set; }

        public Vaikai(int vaikoId, string vaikoVardas, string vaikoPavarde)
        {
            VaikoId = vaikoId;
            VaikoVardas = vaikoVardas;
            VaikoPavarde = vaikoPavarde;
        }
    }
}
