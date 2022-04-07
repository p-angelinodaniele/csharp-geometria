using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MieiRettangoli
{
    internal class Rettangolo
    {
        private string nomeRettangolo;
        private int baseRettangolo;
        private int altezzaRettangolo;


        public Rettangolo(string nomeRettangolo, int baseRettangolo, int altezzaRettangolo)
        {
            this.nomeRettangolo = nomeRettangolo;
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }


        public int CalcolaArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;
        }

        public int CalcolaPerimetro()
        {
            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetro;
        }

        public void stampaRettangolo()
        {
            Console.WriteLine("——----" + nomeRettangolo + "——----");
            Console.WriteLine("Base: " + baseRettangolo);
            Console.WriteLine("Altezza: " + altezzaRettangolo);
            Console.WriteLine("Perimetro: " + CalcolaPerimetro());
            Console.WriteLine("Area: " + CalcolaArea());
        }


        public void Disegna()
        {

            int contatore = 0;
            while (contatore < baseRettangolo)
            {
                Console.Write("__");
                
                contatore++;
            }

            int contatore2 = 0;
            Console.WriteLine();
            while (contatore2 < altezzaRettangolo)
            {
                
                Console.Write("|");
                for (int i = 1; i <baseRettangolo*2; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
                contatore2++;
            }


            int contatore3 = 0;
            while (contatore3 < baseRettangolo)
            {
                Console.Write("__");

                contatore3++;
            }

            Console.WriteLine();

        }


       

    }

}
