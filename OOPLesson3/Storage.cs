using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLesson3
{
    class Storage
    {
        List<Bank> banks = new List<Bank>();

        public void  AddStorage(Bank bank)
        {
            banks.Add(bank);
        }

        public List<Bank> GetStorage()
        {
            return banks;
        }

        public Bank SearchNumber(string NumberValue)
        {
            foreach( var c in banks)
            {
                try
                {
                    if (c.Number == NumberValue)
                    {
                        return c;
                    }
                }
                catch
                {
                    Console.WriteLine("Номер счёта не найден");
                }
                
                
            }
            return null;
        }
    }
}
