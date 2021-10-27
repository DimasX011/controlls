using System;
using System.Collections.Generic;
using System.Text;

namespace BuildApp
{
   public class Create
    {

        static  HashSet<building> hashbuild = new HashSet<building>();

       
       
        public Create()
        {
            
        }

        public static building BuildingCreator()
        {
            building build = new building();
            hashbuild.Add(build);
            ReturnId(build);
            return build;
        }

        public static string ReturnId(building build)
        {
            return build.id;
        }

        public static HashSet<building> Store()
        {
            return hashbuild;
        }

        public static building Search(string idSearch)
        {
            foreach (var c in hashbuild)
            {
                if (c.id == idSearch)
                {
                    return c;
                }
            }
            return null;
        }

        public static void Delete(string id)
        {
            var delsearch = Search(id);
            hashbuild.Remove(delsearch);
        }

    }
}
