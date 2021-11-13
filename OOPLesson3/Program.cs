using System;

namespace OOPLesson3
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank(150000, "nakopitel","");
            Bank bank1 = new Bank(250000, "nakopitel", "");
            Bank bank2 = new Bank(150000, "nakopitel", "");
            Bank bank3 = new Bank(150000, "nakopitel", "");
            Bank bank4 = new Bank(150000, "nakopitel", "");

            bool Tempes = bank.Equals(bank1,bank1);
            bool Temper = bank.GetHashCode(bank1, bank1);

            bank1.Number = "1215554875445";
            bank1.Number = "1215554875445";

            Console.WriteLine(bank == bank1);
            Console.WriteLine(bank != bank1);
            Console.WriteLine(Tempes == true);
            Console.WriteLine(Temper == true);

            string asd = "asfadasfas";
            Inverter inverter = new Inverter(asd);

            FileEmail file = new FileEmail();

            
        }
    }
}
