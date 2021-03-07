using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SleepHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime startTime = DateTime.Now;
            //Console.WriteLine("Program start.");
            //SleepAwhite(3);

            //DateTime endTime = DateTime.Now;
            //TimeSpan ts = endTime - startTime;
            //Console.WriteLine("Program End. Total use " + ts.TotalMilliseconds);
            //Console.ReadLine();

            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Program start.");
            sw.Start();
            SleepAwhite(3);
            sw.Stop();

            Console.WriteLine("1234");

            sw.Start();
            SleepAwhite(6);
            sw.Stop();

            Console.WriteLine("Program End.Total use " + sw.ElapsedMilliseconds);
            Console.ReadLine();


        }
        /// <summary>
        /// 暫停程式數秒鐘
        /// </summary>
        /// <param name="second"></param>
        public static void SleepAwhite(int second)
        {
            int ms = second * 1000;
            System.Threading.Thread.Sleep(ms);
        }
    }
}
