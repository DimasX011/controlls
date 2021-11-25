using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption

{
    public class Figure


    {
        internal int left = 5;
        internal int top = 30;

        internal ConsoleColor color;
        internal bool status;

        public Figure()
        {
            Console.WriteLine("Выберете цвет фигуры");
            Console.WriteLine("1-красный, 2 - фиолетовый, 3 - тёмно-жёлтый, 4 - тёмно-зелёный, 5 - голубой, 6 - зелёный, 7 - жёлтый, 8 - белый, 9 - серый, 10 - синий, 11 - тёмно-фиолетовый, 12 - тёмно-голубой ");
            string answer = Console.ReadLine();
            string answer1 = Console.ReadLine();
            string answer2 = Console.ReadLine();
            Console.ForegroundColor = Color(answer);
            Console.WriteLine("Фигура видимая?");
            answer1 = Console.ReadLine();
            if(answer1 == "да")
            {
                status = false;
            }
            else
            {
                status = true;
            }
            Console.WriteLine("Выберете тип фигуры? 1 - полуовалы, 2 прямоугольник");
            answer2 = Console.ReadLine();
            if (answer2 == "1")
            {
                Console.SetCursorPosition(left,top);
                Circle(10);
            }
            else
            {
                Console.SetCursorPosition(left, top);
                rectangle();
            }
            Console.ReadLine();
            Console.ReadLine();
        }

        internal void Status()
        {
            if(status == true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        internal ConsoleColor Color(string number)
        {
            ConsoleColor color = ConsoleColor.White;
            switch (number)
            {
                case "1":
                    color = ConsoleColor.Red;
                    break;
                case "2":
                    color = ConsoleColor.Magenta;
                    break;
                case "3":
                    color = ConsoleColor.DarkYellow;
                    break;
                case "4":
                    color = ConsoleColor.DarkGreen;
                    break;
                case "5":
                    color = ConsoleColor.Blue;
                    break;
                case "6":
                    color = ConsoleColor.Green;
                    break;
                case "7":
                    color = ConsoleColor.Yellow;
                    break;
                case "8":
                    color = ConsoleColor.White;
                    break;
                case "9":
                    color = ConsoleColor.Gray;
                    break;
                case "10":
                    color = ConsoleColor.DarkBlue;
                    break;
                case "11":
                    color = ConsoleColor.DarkMagenta;
                    break;
                case "12":
                    color = ConsoleColor.DarkCyan;
                    break;
            }
            return color;
        }
        internal void rectangle()
        {
            int value = 10;
            for (int i = 0; i < value; ++i)
            {
                Console.Write('.');
            }
            for (int i = 0; i < value; ++i)
            {
                Console.SetCursorPosition(10+ left, i + top);
                Console.Write('.');
            }
            for (int i = value; i >= 0; --i)
            {
                Console.SetCursorPosition(i + left, 10 + top);
                Console.Write('.');
            }
            for (int i = value; i >= 0; --i)
            {
                Console.SetCursorPosition(0 + left, i + top);
                Console.Write('.');
            }
        
        }

        internal void Circle(int r)
        {
            r = 15 + top;
            int x = left;
            for (int y = top; y < r; ++y)
            {
                x = (int)Math.Round(2 * Math.Sqrt((Math.Pow(r, 2) - Math.Pow(y, 2))));
                Console.SetCursorPosition(x + r, y + r);
                Console.Write('.');
                Console.SetCursorPosition(x + r, -y + r);
                Console.Write('.');
                Console.SetCursorPosition(-x + 2 * r, -y + r);
                Console.Write('.');
                Console.SetCursorPosition(-x + 2 * r, y + r);
                Console.Write('.');
            }
            Console.SetCursorPosition(left, r * 2 + 2 + top);
        }
    }
}
