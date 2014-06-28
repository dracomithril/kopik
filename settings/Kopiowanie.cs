using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ini;

namespace settings
{
    public class Kopiowanie

    {
        public void CopyCat(string direct, string targetPath)
        {
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            string line = direct;


            if (System.IO.Directory.Exists(line))
            {

                string[] files = System.IO.Directory.GetFiles(line);
                string[] lineF = Directory.GetDirectories(line);
                if (lineF.Length != 0)
                {
                    foreach (string foldIn in lineF)
                    {
                        DirectoryInfo mydir = new DirectoryInfo(foldIn);
                        CopyCat(foldIn, Path.Combine(targetPath, mydir.Name));
                    }
                }
                // Copy the files and overwrite destination files if they already exist.
                if (files.Length != 0)
                {
                    foreach (string s in files)
                    {
                        CopyFile(s, targetPath);
                    }
                }
            }
            else if (File.Exists(line))
            {
                try
                {
                    CopyFile(line, targetPath);
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
        public void CopyFile(string fileDir, string targetPath)
        {
            //Properties.Settings settings = new Properties.Settings();
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
