using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Assignment7
{
    [Serializable]
    class Manager
    {
        public int id;
        public String name;
        public double salary;
        public Manager(int eid, String ename, int esalary)
        {
            id = eid;
            name = ename;
            salary = esalary;
        }


    }

    class ManagerSerAndDec
    {

        public static void Main(string[] args)
        {
            string path = "D:\\Manager.txt";

            Manager m = new Manager(539735, "pandya", 10000000);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, m);
            stream.Close();

            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();
            //Manager m = (Manager)(formatter.Deserialize(stream));
            //Console.WriteLine(m.id);
            //Console.WriteLine(m.name);
            //Console.WriteLine(m.salary);
            //Console.ReadKey();



        }
    }
}
