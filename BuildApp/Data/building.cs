using System;
using System.Collections.Generic;
using System.Text;

namespace BuildApp
{
    public class building
    {
        public building()
        {
           id = generateid();
           
        }

        private int FloorData;
        private int FlatData;
        private int EntranceData;
        private string BuildingId;
        public string id
        {
            get
            {
                return this.BuildingId;
            }
            set
            {
                this.BuildingId = value;
            }
        }
        public int floor
        {
            get
            {
                return this.FloorData;
            }
            set
            {
                this.FloorData = value;
            }
        }
        public int flat
        {
            get
            {
                return this.FlatData;
            }
            set
            {
                this.FlatData = value;
            }
        }
        public int entrance
        {
            get
            {
                return this.EntranceData;
            }
            set
            {
                this.EntranceData = value;
            }
        }


        public int FlatOnFloor = 4;
        public int Entrance = 5;

        public int FloorOnEntrance = 80;

        public int FloorOnBuilding(int FlatQuest)
        {
            int Datefloor = 0;
            int Answer = 0;
            if (FloorOnEntrance < FlatQuest)
            {
                int cointfloor = FlatQuest / FloorOnEntrance;
                for (int floorfate = 0; floorfate < cointfloor; floorfate++)
                {
                    entrance++;
                }
                Datefloor = FlatQuest % FloorOnEntrance;
                floor = Datefloor / FlatOnFloor;
                Answer = floor;
                entrance = entrance + 1;
                flat = FlatQuest;
                Console.WriteLine("Подъезд :" + entrance);
                Console.WriteLine("Этаж :" + floor);
                Console.WriteLine("Квартира :" + FlatQuest);
                return Answer;
            }
            entrance = 1;
            floor = FlatQuest  / FlatOnFloor;
            flat = FlatQuest;
            Console.WriteLine("Подъезд :" + entrance);
            Console.WriteLine("Этаж :" + floor);
            Console.WriteLine("Квартира :" + FlatQuest);
            return Answer;
        }

        public string generateid()
        {
            Random rnd = new Random();
            int count = 0;
            string countstr = "";
            for(int i=0; i < 10; i++)
            {
                count = rnd.Next(0, 255);
                countstr = count.ToString();
                id = id + countstr;
            }
            return id;
        }


        public void OnThePrint(int Floor, int Flat, int Entrance)
        {
            floor = Floor;
            flat = Flat;
            entrance = Entrance;
        }
    }
}
