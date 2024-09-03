// using System;
using System;
using System.IO;
namespace Enums
{
    // global enum from jan 1 to dec 
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Dec;
            int myBirthDay = 23;
            int myBirthYear = 1997;

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";
            //wirteall text creates a new file and writie the contests to it if the file aleady exists
            File.WriteAllText("myFile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));
            // file exists tests whether the file exist
            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }
            // appedntext appends text at the end of an existing file 
            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}