using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8_task_1
{
   class Program
    {
        static void SeeDirectories(string way)
        {
            if (Directory.Exists(way))
            {
                string[] dirs = Directory.GetDirectories(way);
                foreach (string dir in dirs)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(dir);
                    Console.WriteLine();
                    Console.WriteLine($"Подкаталог: {directoryInfo.Name}");
                    Console.WriteLine("Файлы подкаталога: ");
                    string[] inDir = Directory.GetFiles(dir);
                    foreach (string file in inDir)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        Console.WriteLine(fileInfo.Name);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Файлы каталога: ");
                string[] filess = Directory.GetFiles(way);
                foreach (string file in filess)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    Console.WriteLine(fileInfo.Name);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите путь к каталогу содержание которого хотите узнать: ");
            string wayDirectory = Console.ReadLine();
            SeeDirectories(wayDirectory);
            Console.ReadKey();

        }
    }
}
 