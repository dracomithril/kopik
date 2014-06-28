using Ini;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace settings
{
    public class Ustawienia
    {
        string settingsFile = Path.Combine(Directory.GetCurrentDirectory(), "settings.ini");
       

        private string CopyDir
        {
            get
            {

                IniFile ini = new IniFile(settingsFile);
                return ini.IniReadValue("CopyDir", "RepoDir");

            }
            set
            {

                IniFile ini = new IniFile(settingsFile);
                ini.IniWriteValue("CopyDir", "RepoDir", value);

            }
        }
        
        public void SetTableOfElements(string[] elementy)
        {

            new IniFile(settingsFile).IniWriteArray("CopyList", "element", elementy);

        }


        //public void AddNewParam(string[] elementy)
        //{


        //    Properties.Settings settings = new Properties.Settings();

        //    settings.tablicaElementow = elementy;
        //    string[] baza = settings.tablicaElementow;
        //    settings.Save();

        //}
        //public void AddNewParam(string element)
        //{
        //    Properties.Settings settings = new Properties.Settings();
        //    settings.tablicaElementow[settings.tablicaElementow.Count()] = element;
        //    settings.Save();
        //}

        public void SetDir(string dir)
        {
            CopyDir = dir;

        }
        public string[] GetList()
        {
            string[] tablica = new IniFile(settingsFile).IniReadArray("CopyList", "element");

            return tablica;
        }
        public string GetDir()
        {
            return CopyDir;
        }

    }
}
