using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

        

        public static bool operator ==(Bank bank, Bank bank1)
        {
            return (bank.number == bank1.number);
        }
        public static bool operator !=(Bank bank, Bank bank1)
        {
            return (bank.number != bank1.number);
        }

        public bool Equals(Bank bank, Bank bank1)
        {
            bool areEqual = false;

            if (bank.number == bank1.number && bank.balance == bank1.balance)
            {
                areEqual = true;
            }
            return areEqual;
        }

        public bool GetHashCode(Bank bank, Bank bank1)
        {
            if (bank.GetHashCode() == bank1.GetHashCode())
            {
                return true;
            }
            return false;
        }

        public Bank bank;
        private static Storage storage;

        public Bank(int BalanceValue, string TypeValue, string NumberOp)
        {
            Balance = BalanceValue;
            Type = TypeValue;
            NumberOp = GenerateNumber();
            Number = NumberOp;
            Storage.AddStorage(new Bank {Balance = BalanceValue, Type = TypeValue, Number = NumberOp });
        }

        
        public Bank()
        {
            
        }
       
        public string GenerateNumber()
        {
            Random rnd = new Random();
            string numbervalue = "";
            for (int i = 0; i < 5; i++)
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
