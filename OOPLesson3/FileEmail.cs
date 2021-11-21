using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace OOPLesson3
{
    class FileEmail
    {
      




       // string path = @"C:\Users\док\source\repos\OOPLesson3\bin\Debug\netcoreapp3.1\data.txt";
       // string pathwrite = @"C:\Users\док\source\repos\OOPLesson3\bin\Debug\netcoreapp3.1\data1.txt";

        List<string> datavalue = new List<string>();
        IList<string> dataread = new List<string>();
        public FileEmail()
        {

            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var relativePath = @"data.txt";
            var relativePath1 = @"data1.txt";

            var path = Path.Combine(appDir, relativePath);
            var pathwrite = Path.Combine(appDir, relativePath1);


            IList<string> dataread = new List<string>();
            string[] filename = File.ReadAllLines(path);
            foreach(var c in filename)
            {
                datavalue.Add(c);
                string[] data = c.Split(new char[] { '&' });
                for (int i = data.Length; i % 2 == 0; i --)
                {
                    dataread.Add(data[i - 1]);
                }

            }
            foreach (var a in dataread)
            {
                Console.WriteLine(a);
                File.AppendAllText(pathwrite, a);
                File.AppendAllText(pathwrite, Environment.NewLine);
            }

        }
        
       


    }
}
