using KopikUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SetParams
{
    public partial class BasicForm : Form
    {
        public BasicForm()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            if (!File.Exists(KopikUtils.BasicSettings.settingsPath)) return;

            var set = (KopikUtils.BasicSettings)Utils.DeserlializeXML(KopikUtils.BasicSettings.settingsPath);
            lb_elements.DataSource = set.CopyThis;
            tb_destDir.Text = set.RepoDir;

        }

        private void bAddFile_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdFile.ShowDialog();
            if (result != DialogResult.OK) return;

            string filePath = ofdFile.FileName;
            if (!lb_elements.Items.Contains(filePath))
                lb_elements.Items.Add(filePath);
            else MessageBox.Show("Ten folder już jest na liście");
        }


        private void bRunApp_Click(object sender, EventArgs e)
        {
            string basicDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string combinedDir = System.IO.Path.Combine(basicDir, "kopik.exe");
            System.Diagnostics.Process.Start(combinedDir, "step");
        }

        private void bAddDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Wybierz katalog który chcesz dodać";
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK) return;

            string selPath = folderBrowserDialog1.SelectedPath;
            if (!lb_elements.Items.Contains(selPath))
                lb_elements.Items.Add(selPath);
            else MessageBox.Show("Ten folder już jest na liście");

        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            object nowy;
            var path = KopikUtils.BasicSettings.settingsPath;
            nowy = Utils.DeserlializeXML(path);
        }



        private void bDelete_Click(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            string[] list = new string[lb_elements.Items.Count];
            lb_elements.Items.CopyTo(list, 0);
            KopikUtils.BasicSettings nowy = new KopikUtils.BasicSettings();
            nowy.CopyThis.AddRange(list);
            nowy.RepoDir = tb_destDir.Text;

            Utils.SerializeXML(nowy, KopikUtils.BasicSettings.settingsPath);
        }

       

        private void whereCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Wybierz folder docelowy";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK) return;

            tb_destDir.Text = folderBrowserDialog1.SelectedPath;
            SaveSettings();
        }
    }
}
