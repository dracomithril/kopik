using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kopik
{
    class Program
    {

        static void Main(string[] args)
        {
            bool stepOn = false;
            string gdzieCopy = @"gdzie.ini";
            string skadCopy = @"katalogi.ini";
            if (!File.Exists(gdzieCopy))
            {
                File.WriteAllText(gdzieCopy, @"c:\Kopie");
            }
            string whereCopy = File.ReadAllText(gdzieCopy);

            if (whereCopy.Length == 0)
            {
                whereCopy = @"C:\test";
            }
        start:
            if (args.Length == 0 || stepOn)
            {
            
                string folderName = DateTime.Today.ToString("dd-MM-yyyy");

                Console.WriteLine(folderName);

                string targetPath = whereCopy + "\\" + folderName;


                if (File.Exists(skadCopy))
                {
                    string[] lines = System.IO.File.ReadAllLines(skadCopy);

                    foreach (string li in lines)
                    {
                        DirectoryInfo skad = new DirectoryInfo(li);
                        string files = System.IO.Path.GetExtension(li);
                        if (files != "")
                        {
                            files = System.IO.Path.GetDirectoryName(li);
                            skad = new DirectoryInfo(files);

                        }

                        CopyMe.CopyCat(li, targetPath + "\\" + skad.Name);
                    }
                    // Keep the console window open in debug mode.                  

                }
                else
                {
                    Console.WriteLine("nie ma katalogu");
                    Console.ReadKey();
                }


            }
            else if (args[0] == "setD")
            {
                if (args[1] != null)
                {
                    Console.WriteLine("tu");
                    whereCopy = args[1];

                    if (!System.IO.Directory.Exists(whereCopy))
                    {
                        System.IO.Directory.CreateDirectory(whereCopy);
                    }
                    File.WriteAllText(gdzieCopy, whereCopy);
                    Properties.Settings.Default.Save();
                }

            }
            else if (args[0] == "getD")
            {
                Console.WriteLine(whereCopy);
                Console.ReadKey();
            }
            else if (args[0] == "step")
            {
                stepOn = true;
               // args[0] = "lizak";
                goto start;

            }
            else
            {
                Console.WriteLine("to tak nie działa");
                Console.ReadKey();
            }
            if(stepOn) Console.ReadKey();

        }

    }

}

