using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("------程式啟動-------");
            string parameter1 = "";
            string stringCpmpare = "";
            string path1 = "";


            //用EXE檔打開的話會=0,用CMD打開的話args.Length會>0
            if (args.Length == 0)
            {
                Console.WriteLine("請輸入第一個參數");
                parameter1 = Console.ReadLine();
            }
            else
            {
                //用陣列args[0](參數1)的決定啟動的method
                string method = args[0];
                //將輸入的英文字都變小寫
                stringCpmpare = method.ToLower();
                //將參數args[1](參數2)設成path1
                path1 = args[1];
            }

            if (stringCpmpare == "movefile" || parameter1.ToLower() == "movefile")
            {
                if (args.Length != 0)
                {
                    string path2 = args[2];
                    Method.MoveFile(path1, path2);
                }
                else
                {
                    //寫入+讀出
                    Console.WriteLine("請輸入第二個參數");
                    string parameter2 = Console.ReadLine();
                    Console.WriteLine("請輸入第三個參數");
                    string parameter3 = Console.ReadLine();
                    Method.MoveFile(parameter2, parameter3);
                }
            }
            if (stringCpmpare == "copyfile" || parameter1.ToLower() == "copyfile")
            {
                if (args.Length != 0)
                {
                    string path2 = args[2];
                    Method.MoveFile(path1, path2);
                }
                else
                {
                    Console.WriteLine("請輸入第二個參數");
                    string parameter2 = Console.ReadLine();
                    Console.WriteLine("請輸入第三個參數");
                    string parameter3 = Console.ReadLine();
                    Method.CopyFile(parameter2, parameter3);
                }
            }
            if (stringCpmpare == "readfile" || parameter1.ToLower() == "readfile")
            {
                if (args.Length != 0)
                {
                    Method.ReadFile(path1);
                }
                else
                {
                    Console.WriteLine("請輸入參數二");
                    string parameter2 = Console.ReadLine();
                    Method.ReadFile(parameter2);
                }
            }

            if (stringCpmpare == "deletefile" || parameter1.ToLower() == "deletefile")
            {
                if (args.Length != 0)
                {
                    //讀檔只需一個路徑故不使用path2
                    Method.DeleteFile(args);
                }
                else
                {
                    //用字串變數wantDeleteFile去接user輸入的字串
                    //並用Split以空格做切分,
                    //切分後放到字串陣列wantDeleteFilesArray,然後作為Method.DeleteFile的參數
                    Console.WriteLine("請輸入欲想刪除檔案的完整路徑，如為複數請以空格分開");
                    string wantDeleteFile = Console.ReadLine();
                    string[] wantDeleteFilesArray = wantDeleteFile.Split(' ');
                    Method.DeleteFile(wantDeleteFilesArray);
                }
            }

            if(stringCpmpare == "createfolder" || parameter1.ToLower() == "createfolder")
            {
                if(args.Length != 0)
                {
                    //讀檔只需一個路徑故不使用path2
                    Method.CreateFolder(path1);
                }
                else
                {
                    Console.WriteLine("請輸入參數二");
                    string parameter2 = Console.ReadLine();
                    Method.CreateFolder(parameter2);
                }
            }


            if (stringCpmpare == "deletefolder" || parameter1.ToLower() == "deletefolder")
            { 
                if (args.Length != 0)
                {
                    Method.DeleteFile(args);
                }
                else
                {

                    //用字串變數wantDeleteFile去接user輸入的字串
                    //並用Split以空格做切分,
                    //切分後放到字串陣列wantDeleteFilesArray,然後作為Method.DeleteFile的參數
                    Console.WriteLine("請輸入想刪除資料夾的完整路徑，如為複數請以空格分開");
                    string wantDeleteFolder = Console.ReadLine();
                    string[] wantDeleteFolderArray = wantDeleteFolder.Split(' ');
                    Method.DeleteFolder(wantDeleteFolderArray);
                }
            }
            Console.WriteLine("---請按任意鍵結束程式---");
            Console.ReadLine();
        }
    }
}
