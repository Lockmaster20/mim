using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mim
{
    class Checkit
    {
        private double _n;
        private Random rnd = new Random();

        public int sorte = 0;

        public string Numer { set => _n = Convert.ToDouble(value); }

        public string Men
        {
            get
            {
                string lista = "";
                sorte += rnd.Next(10);
                if (sorte > _n) lista += "Perdeste";
                return lista;
            }
        }

        public string Igu
        {
            get
            {
                int sorte = 0;
                string lista = "";
                sorte += rnd.Next(10);
                if (sorte = _n) lista += "Perdeste";
                
                return lista;
            }
        }

        public string Mai
        {
            get
            {
                int sorte = 0;
                string lista = "";
                sorte += rnd.Next(10);
                if (sorte < _n) lista += "Perdeste";
                return lista;
            }
        }

    }
}
