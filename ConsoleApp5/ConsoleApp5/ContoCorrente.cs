using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ContoCorrente
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public bool OpenAccount = false;
        public decimal Saldo {  get; set; }

        public decimal Versati { get; set; }

        public decimal Prelevati {  get; set; }
        // public uint Versa = Convert.ToUInt32(Console.ReadLine());
        // public uint Preleva = Convert.ToUInt32(Console.ReadLine());
          

        public void SelectOperation()
        {
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
               
            {
                case 0: OpenNewAccount(); break;
                case 1: Versamento(); break;
                case 2: Prelievo(); break;
                    default : break;    
            }
        }
       
        public void OpenNewAccount()
        {
            Console.WriteLine("Nome: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Cognome: ");
            string Surname = Console.ReadLine();

            if(Saldo >= 1000)
            {
                Console.WriteLine("Hai aperto il tuo account");
            } else
            {
                Console.WriteLine("Non puoi aprire l'account");
            }
        }

        public void Versamento()
        {
            Console.WriteLine("Denaro da versare: ");
            decimal Versati = Convert.ToDecimal(Console.ReadLine());
            if(Versati >= 1000)
            {
                Console.WriteLine(Saldo + Versati);
            }
            if(Versati < 1000)
            {
                Console.WriteLine("non puoi versare meno di 1000");
            }
        }

        public void Prelievo()
        {
            Console.WriteLine("Denaro da prelevare: ");
            decimal Prelevati = Convert.ToDecimal(Console.ReadLine());
            if (Prelevati <= Saldo)
            {
                Console.WriteLine(Saldo + Prelevati);
            }
            if (Prelevati > Saldo)
            {
                Console.WriteLine("non puoi prelevare più soldi di quelli presenti sul saldo");
            }
        }

    }
}
