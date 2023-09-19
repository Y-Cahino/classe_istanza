using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classe_istanza
{
    public class Prodotto
    {
        private string nome;
        private double prezzo;
        public Prodotto(string nome, double prezzo)
        {
            this.nome = nome;
            this.prezzo = prezzo;
        }
        public string getnome()
        {
            return nome;
        }
        public double getprezzo()
        {
            return prezzo;
        }
        static void Main(string[] args)
        {
            //istanzia gli oggetti
            Prodotto p1 = new Prodotto("p1",20);
            Prodotto p2 = new Prodotto("p2", 30);
            

        }
    }
}
