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
            Random random= new Random();
            //istanzia gli oggetti
            Prodotto p1 = new Prodotto("p1",random.Next(1,99));
            Prodotto p2 = new Prodotto("p2", random.Next(1, 99));
            Console.WriteLine("p1:\nNome: " + p1.getnome() + "\nPrezzo: " + p1.getprezzo());
            Console.WriteLine("p2:\nNome: " + p2.getnome() + "\nPrezzo: " + p2.getprezzo());
        }
    }
}
