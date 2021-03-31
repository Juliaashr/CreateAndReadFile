using System;
using System.IO.Compression;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = new FileStream(@".\text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (var writer = new StreamWriter(path, Encoding.UTF8))
            {        
                writer.WriteLine("Привет!");

                writer.WriteLine("Rезиновый подлокотник эскалатора в метро двигается с другой скоростью для того, чтобы пассажир не уснул на эскаlаторе.");

                Console.WriteLine("файл создан, текст занесен в него");
            }   

            using (StreamReader reader = File.OpenText(@".\text.txt"))
            {
                Console.WriteLine("попытка прочесть файл text.txt ...");

                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
