using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption
{
    class BCoder : ICoder
    {
        internal int valueA;
        internal int valueB;
        internal string AnswerEncode;
        internal string AnswerDecode;
        List<string> vs = new List<string>();

        Dictionary<int, string> keyValues = new Dictionary<int, string>();

        internal BCoder()
        {
            Store();
        }

        string ICoder.Decode(string value)
        {
            return encrypt(value);
        }

        string ICoder.Encode(string value)
        {
            return encrypt(value);
        }

        protected string encrypt(string A)
        {
            char[] conv = A.ToCharArray();
            for (int i = 0; i < conv.Length; i++)
            {
                string valueconv = conv[i].ToString();
                int value = search(valueconv);
                A = vs[Dictionary(value)];
                AnswerEncode = AnswerEncode + A;
            }
            return AnswerEncode;
        }

        protected void Store()
        {
            vs.Add("a");
            vs.Add("b");
            vs.Add("c");
            vs.Add("d");
            vs.Add("e");
            vs.Add("f");
            vs.Add("g");
            vs.Add("h");
            vs.Add("i");
            vs.Add("j");
            vs.Add("k");
            vs.Add("l");
            vs.Add("m");
            vs.Add("n");
            vs.Add("o");
            vs.Add("p");
            vs.Add("r");
            vs.Add("s");
            vs.Add("t");
            vs.Add("u");
            vs.Add("v");
            vs.Add("w");
            vs.Add("x");
            vs.Add("y");
            vs.Add("z");
        }

        protected int search(string value)
        {
            int count = 0;
            foreach(var c in vs)
            {
                if (c == value)
                {
                    count = c.Length;
                }
            }
            return count;
        }


        protected int Dictionary(int enc)
        {
            switch (enc)
            {
                case 1:
                    valueB = 25-1;
                    break;
                case 2:
                    valueB = 25-2;
                    break;
                case 3:
                    valueB = 25-3;
                    break;
                case 4:
                    valueB = 25-4;
                    break;
                case 5:
                    valueB = 25-5;
                    break;
                case 6:
                    valueB = 25-6;
                    break;
                case 7:
                    valueB = 25-7;
                    break;
                case 8:
                    valueB = 25-8;
                    break;
                case 9:
                    valueB = 25-9;
                    break;
                case 10:
                    valueB = 25-10;
                    break;
                case 11:
                    valueB = 25-11;
                    break;
                case 12:
                    valueB = 25-12;
                    break;
                case 13:
                    valueB = 25-13;
                    break;
                case 14:
                    valueB = 25-14;
                    break;
                case 15:
                    valueB = 25-15;
                    break;
                case 16:
                    valueB = 25-16;
                    break;
                case 17:
                    valueB = 25-17;
                    break;
                case 18:
                    valueB = 25-18;
                    break;
                case 19:
                    valueB = 25-19;
                    break;
                case 20:
                    valueB = 25-20;
                    break;
                case 21:
                    valueB = 25-21;
                    break;
                case 22:
                    valueB = 25-22;
                    break;
                case 23:
                    valueB = 25-23;
                    break;
                case 24:
                    valueB = 25-24;
                    break;
                case 25:
                    valueB = 25;
                    break;
            }
            return valueB;
        }

    }
}
