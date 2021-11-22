using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Dovanos
    {
        public int VaikoId { get; private set; }
        public List<string> Dovana;

        public Dovanos(int vaikoId , List<string> dovana)
        {
            VaikoId = vaikoId;
            Dovana = dovana;
        }

    }
}
