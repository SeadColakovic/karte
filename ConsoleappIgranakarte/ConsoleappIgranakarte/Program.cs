using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleappIgranakarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int ukupnoKarata = 0;
                int brojKarata = 0;
                Console.WriteLine("unesi ispravnu kartu od 1 do 13 ");


                while (ukupnoKarata < 31)
                {                                   
                    brojKarata = Convert.ToInt32(Console.ReadLine() );
                    {
                        
                    }
                    ukupnoKarata += brojKarata;
                    {
                        Console.WriteLine("Zbroj kararta u špilu");
                    }
                }

                if (ukupnoKarata == 31)
                {
                    Console.WriteLine("Pobjeda!");
                }
                else
                {
                    Console.WriteLine("Izgubljena!");
                }
            }
        }



        

    }
}

