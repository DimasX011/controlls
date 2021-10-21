using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLesson3
{
    class Bank
    {
        private string number;
        private int balance;
        private string type;
        bool TakeBalance = false;

        public string Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public int Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        List<string> Banks = new List<string>();
       
        
       public Bank(int BalanceValue, string TypeValue, string Number)
        {
            Balance = BalanceValue;
            Type = TypeValue;
            Number = GenerateNumber();
            Bank bank = new Bank(Balance, Type, Number);
            Storage storage = new Storage();
            storage.AddStorage(bank);
        }

        public string GenerateNumber()
        {
            Random rnd = new Random();
            string numbervalue = "";
            for (int i = 0; i < 11; i++)
                {
                var value = rnd.Next(0, 10);
                string gen = value.ToString();
                numbervalue = numbervalue + gen;
            }
            string StrNumber = numbervalue;
            return ("номер банковского счёта:" + StrNumber);
        }

        public void Write()
        {
            Banks.Add(Number);
            Banks.Add("баланс банковского счёта:" + Balance);
            Banks.Add("тип банковского счёта:" + Type);
        }
        public void Read()
        {
           foreach (var c in Banks) {
                Console.WriteLine(c);
            }
        }

        public bool  CheckBalanceStatus(int value)
        {
            if (value > Balance)
            {
                TakeBalance = true;
            }
            return TakeBalance;
        }

        public void TakeOffBalance(int ValueTakeOff)
        {
            CheckBalanceStatus(ValueTakeOff);
            if(TakeBalance == true)
            {
                Balance = Balance - ValueTakeOff;
            }
            else
            {
                Console.WriteLine("Извините, на вашем счету недостаточно средств");
            }
        }

        public void AddBalance(int ValueTakeOff)
        {
            Balance = Balance + ValueTakeOff;
        }

        public void TrancferBalance(string NumberTake, string NumberPut, int Summ)
        {
            Storage storage = new Storage();
            Bank BankTake = storage.SearchNumber(NumberTake);
            Bank BankPut = storage.SearchNumber(NumberPut);
            if (BankTake.CheckBalanceStatus(Summ) == true)
            {
                BankPut.Balance = BankPut.Balance + BankTake.Balance;
            }
            else
            {
                Console.WriteLine("На вашем счёте недостаточно средств!");
            }

        }
    }
}
