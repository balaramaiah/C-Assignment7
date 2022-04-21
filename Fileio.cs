using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment7
{
    class ReadingAndwriting
    {


        public static void WriteFile(string filewrite)
        {
            File.WriteAllText(filewrite, "Hello Guys");

        }

        public static void readFile(string filewrite)
        {
            Console.WriteLine(File.ReadAllText(filewrite));

        }

    }


    class Fileio
    {
        public static void Main()
        {
            String fl = @"D:\Sample";
            ReadingAndwriting.WriteFile(fl);

            ReadingAndwriting.readFile(fl);



            DirectoryInfo dir = new DirectoryInfo(@"D:\");
            Console.WriteLine(dir.Exists);
            Console.WriteLine(dir.Attributes);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.LastAccessTimeUtc);
            Console.WriteLine(dir.LastWriteTime);
            Console.WriteLine(dir.LastWriteTimeUtc);
            Console.WriteLine(dir.Name);




            Console.ReadKey();

        }
    }
}
