using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using settings;

namespace kopik
{
    class Program
    {

        static void Main(string[] args)
        {
            
            bool stepOn = false;
            //string settings.Kopiowanie.GetDir() = @"gdzie.ini";
            //string skadCopy = @"katalogi.ini";
            //settings.Kopiowanie ustaw = new settings.Kopiowanie();
            
           
            string whereCopy = new Ustawienia().GetDir();

            //if (whereCopy.Length == 0)
            //{
            //    settings.Kopiowanie.SetDir(@"C:\test");
            //    whereCopy = @"C:\test";
            //}
            if (args.Length == 0)
            {
                Console.WriteLine("Nie podano parametru");
                Console.ReadKey();
            }
           
            switch (args[0])
            {
                case @"\start":
                        string folderName = DateTime.Today.ToString("dd-MM-yyyy");
                        string targetPath = Path.Combine(whereCopy, folderName);
                        Console.WriteLine(targetPath);
                        //jeżeli istnieje katalog docelowy kopiowania sprawdź date utworzenia i porównaj z obecną
                        string dirInf;
                        string curentTime;
                        if (Directory.Exists(targetPath))
                        {
                            dirInf = System.IO.Directory.GetCreationTime(targetPath).ToString("yyyy-MM-dd HH");
                            curentTime = DateTime.Now.ToString("yyyy-MM-dd HH");



                        }

                        string[] lines =  new Ustawienia().GetList() ;

                        foreach (string li in lines)
                        {
                            DirectoryInfo skad = new DirectoryInfo(li);
                            string files = System.IO.Path.GetExtension(li);
                            if (files != "")
                            {
                                files = System.IO.Path.GetDirectoryName(li);
                                skad = new DirectoryInfo(files);
                            }

                            CopyMe.CopyCat(li, System.IO.Path.Combine( targetPath, skad.Name));
                        }
                    break;
                case @"\setD":
                    try
                    {

                        if (args[1] != null)
                        {
                            //do metody
                            //string key;
                            //DirectoryInfo lokalizacja = System.IO.Directory.GetParent(args[1]);
                            //string curentLocation = System.IO.Directory.GetCurrentDirectory();
                            //if (curentLocation == lokalizacja.FullName)
                            //{
                               // Console.WriteLine("Czy napewno chcesz utworzyć nowy folder w {0} który jest folderem programu Y/N" , lokalizacja.FullName);
                               // key = Console.ReadKey().KeyChar.ToString();
                                //TODO
                              
                                    if (args[1] != new Ustawienia().GetDir())
                                    {
                                        if (!System.IO.Directory.Exists(args[1]))
                                        {
                                            System.IO.Directory.CreateDirectory(whereCopy);
                                        }


                                        new Ustawienia().SetDir(whereCopy);
                                    }
                                    else
                                        Console.WriteLine("Taka ścieżka jest już ustawiona");
                                    Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Nie podałeś ścieżki docelowej. \nPo parametrze \\setD podaj ścieżke docelową\n \"\\setD [ścieżka]\" ");
                            Console.ReadKey();
                        }
                    }
                    catch
                    {

                    }

                    break;
                case @"\step":

                    stepOn = true;
                    goto case"\\start";
                    //break;
                case @"\getD":
                    Console.WriteLine(whereCopy);
                    Console.WriteLine("Ciekawe co");
                        Console.WriteLine(new Ustawienia().GetDir());
                        Console.ReadKey();
                    break;
                case @"\help":
                case @"\?":
                case @"\pomoc":
                   
                        Console.WriteLine("tu trzeba napisać pomoc");
                        Console.ReadKey();
                    
                    break;
                case "test":
                    try
                    {
                        string dirPath = @"d:\Repo";

                        List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));

                        foreach (var dir in dirs)
                        {
                            Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
                        }
                        Console.WriteLine("{0} directories found.", dirs.Count);
                    }
                    catch (UnauthorizedAccessException UAEx)
                    {
                        Console.WriteLine(UAEx.Message);
                    }
                    catch (PathTooLongException PathEx)
                    {
                        Console.WriteLine(PathEx.Message);
                    }
                    Console.ReadKey();
                    break;
                default :
                   Console.WriteLine("to tak nie działa zajżyj do pomocy używając \\? lub \\help");
                Console.ReadKey();
                    break;
            }
            if (stepOn) Console.ReadKey();
            
       

        }

    }

}

