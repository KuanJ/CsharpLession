using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePeth = ConfigurationManager.AppSettings["SourceFilePath"];
            string targetPeth = ConfigurationManager.AppSettings["TargetFilePath"];

            Console.WriteLine(" " + sourcePeth);
            Console.WriteLine(" " + targetPeth);

            Console.ReadLine();

        }
    }
}
