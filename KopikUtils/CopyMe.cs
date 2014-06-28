using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kopik
{
    public class CopyMe
    {
        public static void CopyCat(string path, string targetPath)
        {
            if (!System.IO.Directory.Exists(targetPath))          
                System.IO.Directory.CreateDirectory(targetPath);           

            if (System.IO.Directory.Exists(path))
            {
                string[] files = System.IO.Directory.GetFiles(path);
                string[] lineF = Directory.GetDirectories(path);
                if (lineF.Length != 0)
                {
                    foreach (string foldIn in lineF)
                    {
                        DirectoryInfo mydir = new DirectoryInfo(foldIn);
                        CopyCat(foldIn, Path.Combine(targetPath, mydir.Name));
                    }
                }
                //TODO Copy the files and overwrite destination files if they already exist.
                if (files.Length != 0)
                {
                    foreach (string s in files)
                    {
                        CopyFile(s, targetPath);
                    }
                }
            }
            else if (File.Exists(path))
            {
                try
                {
                    CopyFile(path, targetPath);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }


        }
        /// <summary>
        /// kopiowanie pojedyńczego pliku
        /// </summary>
        /// <param name="fileDir">pełna ścieżka pliku</param>
        /// <param name="targetPath">ścieżka docelowa gdzie ma być skopiowany plik</param>
        public static void CopyFile(string fileDir, string targetPath)
        {
            // Use static Path methods to extract only the file name from the path.
            string fileName = System.IO.Path.GetFileName(fileDir);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            if (!System.IO.File.Exists(destFile))
            {
                System.IO.File.Copy(fileDir, destFile, true);
                Console.WriteLine("Kopiowanie z \"{0}\" do \"{1}\"", fileDir, destFile);
            }
            else
            {
                Console.WriteLine("plik \"{0}\"' już istnieje", fileName);
            }

        }
    }
}
