using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SetParams2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            storage.CopyThisList = new List<string>();
        }

        private void bAddFile_Click(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();
            if (result != true) return;

            string filePath = ofd.FileName;
            if (!storage.CopyThisList.Contains(filePath))
                storage.CopyThisList.Add(filePath);
            else MessageBox.Show("Ten folder już jest na liście");

        }

        private void bAddDir_Click(object sender, RoutedEventArgs e)
        {
            var fbd = new System.Windows.Forms.FolderBrowserDialog();
            fbd.Description = "Wybierz katalog który chcesz dodać";
            fbd.ShowNewFolderButton = false;
            var result = fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string selPath = fbd.SelectedPath;
                if (!storage.CopyThisList.Contains(selPath))
                    storage.CopyThisList.Add(selPath);          
                else MessageBox.Show("Ten folder już jest na liście");
            }
        }

        private void bRunApp_Click(object sender, RoutedEventArgs e)
        {
            string basicDir = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            string combinedDir = System.IO.Path.Combine(basicDir, "kopik.exe");
            System.Diagnostics.Process.Start(combinedDir, "step");
        }

        private void bSaveList_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
