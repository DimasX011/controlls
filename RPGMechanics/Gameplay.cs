using System;
using System.Collections.Generic;
using System.Text;

namespace RPGMechanics
{
    class Gameplay
    {
        bool gameplay = false;
        string answer;
        List<Player> players= new List<Player>();
        int i = 0;
        int a = 1;
        int b = 0;
        int numberplayer = 1;
        int motion = 1;

        public Gameplay()
        {
            Start();
        }

        public void TheEnd(int numberplayer)
        {
            Console.WriteLine($"Игрок {numberplayer} победил");
            return;
        }

       

        public ConsoleColor Color(string number)
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
                    color = ConsoleColor.DarkYellow;
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

        public void Start()
        {
            string color1 = "";
            string color2 = "";
            for(int i = 1; i <= 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Игрок {i} выберете класс");
                Console.WriteLine("1-рыцарь смерти, 2 - охотник на демонов, 3 - друид, 4 - охотник, 5 - маг, 6 - монах, 7 - паладин, 8 - жрец, 9 - разбойник, 10 - шаман, 11 - чернокнижник, 12 - воин ");
                answer = Console.ReadLine();
                if (i == 1)
                {
                    color1 = answer;
                }
                else
                {
                    color2 = answer;
                }
                Player player = new Player(answer);
                players.Add(player);
            }
            gameplay = true;
            while (gameplay == true)
            {
                if (numberplayer == 1)
                {
                    Console.ForegroundColor = Color(color1);
                }
                else
                {
                    Console.ForegroundColor = Color(color2);
                }
                Console.WriteLine($"Ход игрока{numberplayer}");
                Console.WriteLine($"Здоровье игрока {numberplayer}:{players[b].health}, здоровье игрока {numberplayer+1}:{players[b+1].health} ");
                Console.WriteLine("Атака(1) или защита(2)?");
                string answerpl = Console.ReadLine();

                if (motion == 1)
                {
                    if (answerpl == "1")
                    {
                       
                        players[b+1].health = players[b+1].Damaging(players[b+1].health, players[b].dmhdps);
                        if (players[b + 1].health < 0)
                        {
                            TheEnd(motion);
                            return;
                        }
                        Console.WriteLine($"Здоровье игрока{a}:{players[b].health}, здоровье игрока{a+ 1}:{players[b+1].health}");
                        motion++;
                       
                    }
                    else if (answerpl == "2")
                    {
                       
                        players[b].health = players[b].Deffender(players[b].health, players[b].valueheal);
                        Console.WriteLine($"Здоровье игрока{a}:{players[b].health}, здоровье игрока{a + 1}:{players[b + 1].health}");
                        motion++;
                    }
                   
                   
                }
                else
                {
                    if (answerpl == "1")
                    {
                        players[b].health=players[b].Damaging(players[b].health, players[b+1].dmhdps);
                        if (players[b].health < 0)
                        {
                            TheEnd(motion);
                            return;
                        }
                        Console.WriteLine($"Здоровье игрока{a}:{players[b].health}, здоровье игрока{a+1}:{players[b+1].health}");
                        motion++;
                    }
                    else if (answerpl == "2")
                    {
                        players[b+1].health = players[b+1].Deffender(players[b+1].health, players[b+1].valueheal);
                        Console.WriteLine($"Здоровье игрока{a}:{players[b].health}, здоровье игрока{a + 1}:{players[b + 1].health}");
                        motion++;
                    }
                }
                if (i == 1)
                {
                    i--;
                    numberplayer--;
                    motion= motion-2;
                    continue;
                }
                i++;
                numberplayer++;
            }
                
                
        }
    }
}
