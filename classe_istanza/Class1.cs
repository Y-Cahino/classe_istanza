using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_istanza
{
    public class Prodotto
    {
        private string nome;
        private double prezzo;
        public Prodotto()
        {
            nome = "";
            prezzo = 0.0;
        }
        public Prodotto(string n,double pr)
        {
            setnome(n);
            setprezzo(pr);
        }
        //metodo accessor
        public string getnome()
        {
            return nome;
        }
        public double getprezzo()
        {
            return prezzo;
        }
        public void setprezzo(double pr)
        {
            if (pr > 0)
            {
                prezzo = pr;
            }
        }
        public void setnome(string n)
        {
            nome = n;
        }
    }
}
