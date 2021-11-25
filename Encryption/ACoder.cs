namespace Encryption
{
    public class ACoder : ICoder
    {

        internal string valueA;
        internal string valueB;
        internal string AnswerEncode;
        internal string AnswerDecode;

        string ICoder.Decode(string value)
        {
           return encrypt(value);
        }

        string ICoder.Encode(string value)
        {
            return decrypt(value);
        }


        public string encrypt(string A)
        {
            char[] conv = A.ToCharArray();
            for (int i = 0; i < conv.Length; i++)
            {
                A = conv[i].ToString();
                A = Dictionary(A);
                AnswerEncode = AnswerEncode + A;
            }
            return AnswerEncode;
        }

        public string decrypt(string A)
        {
            char[] conv = A.ToCharArray();
            for (int i = 0; i < conv.Length; i++)
            {
                A = conv[i].ToString();
                A = DictionaryDec(A);
                AnswerDecode = AnswerDecode + A;
            }
            return AnswerDecode;
        }

        public string Dictionary(string enc)
        {
            switch (enc)
            {
                case "a":
                    valueB = "b";
                    break;
                case "b":
                    valueB = "c";
                    break;
                case "c":
                    valueB = "d";
                    break;
                case "d":
                    valueB = "e";
                    break;
                case "e":
                    valueB = "f";
                    break;
                case "f":
                    valueB = "g";
                    break;
                case "g":
                    valueB = "h";
                    break;
                case "h":
                    valueB = "i";
                    break;
                case "i":
                    valueB = "j";
                    break;
                case "j":
                    valueB = "k";
                    break;
                case "k":
                    valueB = "l";
                    break;
                case "l":
                    valueB = "m";
                    break;
                case "m":
                    valueB = "n";
                    break;
                case "n":
                    valueB = "o";
                    break;
                case "o":
                    valueB = "p";
                    break;
                case "p":
                    valueB = "r";
                    break;
                case "r":
                    valueB = "s";
                    break;
                case "s":
                    valueB = "t";
                    break;
                case "t":
                    valueB = "u";
                    break;
                case "u":
                    valueB = "v";
                    break;
                case "v":
                    valueB = "w";
                    break;
                case "w":
                    valueB = "x";
                    break;
                case "x":
                    valueB = "y";
                    break;
                case "y":
                    valueB = "z";
                    break;
                case "z":
                    valueB = "a";
                    break;
            }
            return valueB;
        }

        public string DictionaryDec(string enc)
        {
            switch (enc)
            {
                case "b":
                    valueB = "a";
                    break;
                case "c":
                    valueB = "b";
                    break;
                case "d":
                    valueB = "c";
                    break;
                case "e":
                    valueB = "d";
                    break;
                case "f":
                    valueB = "e";
                    break;
                case "g":
                    valueB = "f";
                    break;
                case "h":
                    valueB = "g";
                    break;
                case "i":
                    valueB = "h";
                    break;
                case "j":
                    valueB = "i";
                    break;
                case "k":
                    valueB = "j";
                    break;
                case "l":
                    valueB = "k";
                    break;
                case "m":
                    valueB = "l";
                    break;
                case "n":
                    valueB = "m";
                    break;
                case "o":
                    valueB = "p";
                    break;
                case "p":
                    valueB = "o";
                    break;
                case "r":
                    valueB = "p";
                    break;
                case "s":
                    valueB = "r";
                    break;
                case "t":
                    valueB = "s";
                    break;
                case "u":
                    valueB = "t";
                    break;
                case "v":
                    valueB = "u";
                    break;
                case "w":
                    valueB = "v";
                    break;
                case "x":
                    valueB = "w";
                    break;
                case "y":
                    valueB = "x";
                    break;
                case "z":
                    valueB = "y";
                    break;
                case "a":
                    valueB = "z";
                    break;
            }
            return valueB;
        }

    }
}