using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using settings;


namespace SetParameters
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //string[] lines = System.IO.File.ReadAllLines(dirFile);
            foreach (string d in new Ustawienia().GetList())
            {
                listBox1.Items.Add(d);
                
            }
            textBox1.Text = new Ustawienia().GetDir();
        }
      
        
        
        
        private void addFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                
                if (!listBox1.Items.Contains(filePath))
                {
                    listBox1.Items.Add(filePath);
                }
                else MessageBox.Show("Ten folder już jest na liście");
            }
        }

        
        private void addCat_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Wybierz katalog który chcesz dodać";
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selPath = folderBrowserDialog1.SelectedPath;

                if (!listBox1.Items.Contains(selPath))
                {
                    listBox1.Items.Add(selPath);
                }
                else MessageBox.Show("Ten folder już jest na liście");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
          
            string[] list = new string[listBox1.Items.Count];
            listBox1.Items.CopyTo(list, 0);
          
            
            try
            {
                
                new Ustawienia().SetTableOfElements(list);
                //textBox1.Text = settings.Kopiowanie.GetDir();
            }
            catch(Exception z)
            {
                MessageBox.Show(z.Message);
            }
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] list = new Ustawienia().GetList();

            foreach (string li in list)
            {
                listBox1.Items.Add(li);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           string where_copy = null;
            folderBrowserDialog1.Description = "Wybierz folder docelowy";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                where_copy = folderBrowserDialog1.SelectedPath;
                //string basicDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                //string combinedDir = System.IO.Path.Combine(basicDir, "kopik.exe");
                new Ustawienia().SetDir(where_copy);
            }
            textBox1.Text = where_copy;

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void koniecToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string basicDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string combinedDir = System.IO.Path.Combine(basicDir, "kopik.exe");
            System.Diagnostics.Process.Start(combinedDir,"step");
        }
       

       

      
    }
}
