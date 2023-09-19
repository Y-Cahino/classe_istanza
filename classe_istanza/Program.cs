using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classe_istanza
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            string n,n2;
            double pr,pr2;
            Random random= new Random();
            //istanzia gli oggetti
            Console.WriteLine("Inserisci nomi:");
            n= Console.ReadLine();
            n2 = Console.ReadLine();
            Console.WriteLine("Inserisci prezzi:");
            pr=Convert.ToInt32(Console.ReadLine());
            pr2 = Convert.ToInt32(Console.ReadLine());
            Prodotto p1 = new Prodotto(n,pr);
            Prodotto p2 = new Prodotto(n2,pr2);
            Console.WriteLine("p1:\nNome: " + p1.getnome() + "\nPrezzo: " + p1.getprezzo());
            Console.WriteLine("p2:\nNome: " + p2.getnome() + "\nPrezzo: {0} €" + p2.getprezzo());
        }
    }
}
