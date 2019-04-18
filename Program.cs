using System;
using System.IO;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadStream("Dir1/Hello1.txt");
            ReadStream(@"Dir1\Hello2.txt");
        }

        private static void ReadStream(string name)
        {
            var stream = typeof(Program).Assembly.GetManifestResourceStream(name);
            Console.WriteLine(new StreamReader(stream).ReadToEnd());
        }
    }
}
