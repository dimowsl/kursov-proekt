using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchilishte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Брой ученици: ");
            int broiUchenici = int.Parse(Console.ReadLine());

            List<Uchenik> uchenici = new List<Uchenik>();

            for (int i = 1; i <= broiUchenici; i++)
            {
                Console.WriteLine($"Ученик #{i}");

                Console.Write("Име: ");
                string ime = Console.ReadLine();

                Console.Write("Години: ");
                int godini = int.Parse(Console.ReadLine());

                Console.Write("Месец на раждане (1-12): ");
                int mesec = int.Parse(Console.ReadLine());

                Uchenik uchenik = new Uchenik(ime, godini, mesec);
                uchenici.Add(uchenik);
            }

            
            for (int i = 0; i < uchenici.Count - 1; i++)
            {
                for (int j = 0; j < uchenici.Count - 1 - i; j++)
                {
                    if (uchenici[j].Godini > uchenici[j + 1].Godini)
                    {
                        Uchenik neshtosi = uchenici[j];
                        uchenici[j] = uchenici[j + 1];
                        uchenici[j + 1] = neshtosi;
                    }
                }
            }

            
            foreach (Uchenik uchenik in uchenici)
            {
                Console.Write($"{uchenik.Ime} - ");
                if (uchenik.Godini == 15)
                {
                    if (uchenik.Mesec < 9)
                    {
                        Console.WriteLine("8-ми клас");
                    }
                    else
                    {
                        Console.WriteLine("9-ти клас");
                    }
                }
                else if (uchenik.Godini == 16)
                {
                    if (uchenik.Mesec < 9)
                    {
                        Console.WriteLine("9-ти клас");
                    }
                    else
                    {
                        Console.WriteLine("10-ти клас");
                    }
                }
                else if (uchenik.Godini == 17)
                {
                    if (uchenik.Mesec < 9)
                    {
                        Console.WriteLine("10-ти клас");
                    }
                    else
                    {
                        Console.WriteLine("11-ти клас");
                    }
                }
                else if (uchenik.Godini == 18)
                {
                    if (uchenik.Mesec < 9)
                    {
                        Console.WriteLine("11-ти клас");
                    }
                    else
                    {
                        Console.WriteLine("12-ти клас");
                    }
                }
                else
                {
                    Console.WriteLine("не се вписва в дадените условия за класификация.");
                }
            }

            Console.WriteLine();
        }
    }

    class Uchenik
    {
        public string Ime { get; set; }
        public int Godini { get; set; }
        public int Mesec { get; set; }

        public Uchenik(string ime, int godini, int mesec)
        {
            Ime = ime;
            Godini = godini;
            Mesec = mesec;
        }


    }
}








        





