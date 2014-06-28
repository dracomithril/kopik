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
        private static KopikUtils.BasicSettings _settings;
        static void Main(string[] args)
        {            
            bool stepOn = false;
        
            if (File.Exists(KopikUtils.BasicSettings.settingsPath))
                _settings = (KopikUtils.BasicSettings)KopikUtils.Utils.DeserlializeXML(KopikUtils.BasicSettings.settingsPath);
            else
            {
                Console.WriteLine("Brak pliku ustawień");
                return;
            }
            string whereCopy = _settings.RepoDir;

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

                        string[] lines =  _settings.CopyThis.ToArray<string>() ;

                        foreach (string li in lines)
                        {
                            DirectoryInfo skad = new DirectoryInfo(li);
                            CopyMe.CopyCat(li, System.IO.Path.Combine( targetPath, skad.Name));
                        }
                    break;
                
                case @"\step":

                    stepOn = true;
                    goto case"\\start";
                    //break;
                case @"\getD":
                    Console.WriteLine(whereCopy);
                    Console.WriteLine("Ciekawe co");
                        Console.WriteLine(_settings.RepoDir);
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

