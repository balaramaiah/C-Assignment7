using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment7
{
    internal class BankAccountDetailes
    {
        public class Account
        {
            public string Name;
            public double AccountNumber;
            public double balance;

            public Account(string name, double accountnumber, double balance)
            {
                this.Name = name;
                this.AccountNumber = accountnumber;
                this.balance = balance;
            }
        }
        static void Main(string[] args)
        {

            string dir = @"D:\BankAccountDetails";
            string srcFilepath = @"D:\BankAccountDetails\Account.txt";
            Directory.CreateDirectory(dir);

            //create file and write
            FileStream fs = File.Create(srcFilepath);
            fs.Close();
            Console.WriteLine("Enter AccountHolder Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Account Number :");
            double accountNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Account Balance :");
            double balance = Convert.ToDouble(Console.ReadLine());
            Account a1 = new Account(name, accountNumber, balance);

            StreamWriter sw = new StreamWriter(srcFilepath);
            sw.WriteLine(a1.Name);
            sw.WriteLine(a1.AccountNumber);
            sw.WriteLine(a1.balance);




            sw.Close();

            // read and write on console
            StreamReader sr = new StreamReader(srcFilepath);
            string line;

            Console.WriteLine("\nAccounts Details :");
            while ((line = sr.ReadLine()) != null)
            {

                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
