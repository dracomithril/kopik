using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

  namespace Ini
  {
      /// <summary>
      /// Create a New INI file to store or load data
      /// </summary>
      public class IniFile
      {
          public string path;
  
          [DllImport("kernel32")]
          private static extern long WritePrivateProfileString(string section,string key,string val,string filePath);
          [DllImport("kernel32")]
          private static extern int GetPrivateProfileString(string section,string key,string def,StringBuilder retVal,int size,string filePath);
  
          /// <summary>
          /// INIFile Constructor.
          /// </summary>
          /// <param name="INIPath"></param>
          public IniFile(string INIPath)
          {
              path = INIPath;
          }
          /// <summary>
          /// Write Data to the INI File
          /// </summary>
          /// <param name="Section"></param>
          /// Section name
          /// <param name="Key"></param>
          /// Key Name
          /// <param name="Value"></param>
          /// Value Name
          public void IniWriteValue(string Section,string Key,string Value)
          {
              WritePrivateProfileString(Section,Key,Value,this.path);
          }
          
          /// <summary>
          /// Read Data Value From the Ini File
          /// </summary>
          /// <param name="Section"></param>
          /// <param name="Key"></param>
          /// <param name="Path"></param>
          /// <returns></returns>
          public string IniReadValue(string Section,string Key)
          {
              StringBuilder temp = new StringBuilder(255);
              int i = GetPrivateProfileString(Section,Key,"",temp,255,this.path);
              return temp.ToString();
  
          }

          public void IniWriteArray(string Section, string Key, string[] Value)
          {
              IniResetArray(Section, Key);
              int count = Value.Count();
              for (int i = 0; i < count; i++)
              {
                  IniWriteValue(Section, Key+i, Value[i]);
              }
          }
          public void IniResetArray(string Section, string Key)
          {
              List<string> list = File.ReadAllLines(path).ToList<string>();
            
             
              int licznik = 0;
              bool exists = true;
              do
              {
                  string getValue = IniReadValue(Section, Key+licznik);
                  if (getValue.Length != 0)
                  {
                      IniWriteValue(Section, Key + licznik, "");
                      licznik++;
                  }
                  else
                  {
                      if (list.IndexOf(Key + licznik + "=") != -1)
                      {
                          list.Remove(Key + licznik + "=");
                          File.WriteAllLines(path, list.ToArray());
                      }
                      exists = false;
                  }
              }
              while (exists);
              
              
              


          }
          public int IniArrayCount(string Section, string Key)
          {
              List<string> list = File.ReadAllLines(path).ToList<string>();
              int licznik=0;
              bool exists=true;
              do
              {
                  string getValue = IniReadValue(Section, Key + licznik);
                  if (getValue.Length != 0)
                  {
                      licznik++;
                  }
                  else
                  {
                      if (list.IndexOf(Key + licznik + "=") != -1)
                      {
                          list.Remove(Key + licznik + "=");
                          File.WriteAllLines(path, list.ToArray());
                      }
                      exists = false;
                  }
              }
              while (exists);


              return licznik;
          }
          public string[] IniReadArray(string Section, string Key)
          {
              //string[] krowa= new string[]{"krowa","sowa"};
              List<string> tab = new List<string>();
              bool exists = true;
              int licznik = 0;
              do
              {
                 
                  string getValue = IniReadValue(Section, Key + licznik);
                  if (getValue.Length !=0)
                  {
                      tab.Add(getValue);
                      licznik++;
                  }
                  else
                      exists = false;

              }
              while (exists);

              return tab.ToArray();
          }
      }
  }