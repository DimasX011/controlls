using System;
using System.Collections.Generic;

namespace BuildApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<building> hashSet = new HashSet<building>();
            Create.BuildingCreator();
            Create.BuildingCreator();
            Create.BuildingCreator();
            Create.BuildingCreator();
            building buildes = Create.BuildingCreator();
            hashSet = Create.Store();

            string id = Create.ReturnId(buildes);
            Create.Delete(id);

            int answer = hashSet.Count;
            Console.ReadLine();
            


        }
    }
}
