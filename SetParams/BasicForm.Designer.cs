namespace SetParams
{
    partial class BasicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.bAddFile = new System.Windows.Forms.Button();
            this.bAddDir = new System.Windows.Forms.Button();
            this.bRunApp = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.tb_destDir = new System.Windows.Forms.TextBox();
            this.lb_elements = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dodajPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.whereCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeTSMI,
            this.koniecTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeTSMI
            // 
            this.opcjeTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajPlikToolStripMenuItem,
            this.dodajKatalogToolStripMenuItem,
            this.toolStripSeparator1,
            this.whereCopyToolStripMenuItem});
            this.opcjeTSMI.Name = "opcjeTSMI";
            this.opcjeTSMI.Size = new System.Drawing.Size(60, 24);
            this.opcjeTSMI.Text = "Opcje";
            // 
            // koniecTSMI
            // 
            this.koniecTSMI.Name = "koniecTSMI";
            this.koniecTSMI.Size = new System.Drawing.Size(66, 24);
            this.koniecTSMI.Text = "Koniec";
            // 
            // bAddFile
            // 
            this.bAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddFile.Location = new System.Drawing.Point(336, 33);
            this.bAddFile.Name = "bAddFile";
            this.bAddFile.Size = new System.Drawing.Size(92, 30);
            this.bAddFile.TabIndex = 1;
            this.bAddFile.Text = "Dodaj plik";
            this.bAddFile.UseVisualStyleBackColor = true;
            this.bAddFile.Click += new System.EventHandler(this.bAddFile_Click);
            // 
            // bAddDir
            // 
            this.bAddDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddDir.Location = new System.Drawing.Point(336, 66);
            this.bAddDir.Name = "bAddDir";
            this.bAddDir.Size = new System.Drawing.Size(92, 56);
            this.bAddDir.TabIndex = 2;
            this.bAddDir.Text = "Dodaj katalog";
            this.bAddDir.UseVisualStyleBackColor = true;
            this.bAddDir.Click += new System.EventHandler(this.bAddDir_Click);
            // 
            // bRunApp
            // 
            this.bRunApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRunApp.Location = new System.Drawing.Point(336, 179);
            this.bRunApp.Name = "bRunApp";
            this.bRunApp.Size = new System.Drawing.Size(92, 40);
            this.bRunApp.TabIndex = 3;
            this.bRunApp.Text = "Uruchom";
            this.bRunApp.UseVisualStyleBackColor = true;
            this.bRunApp.Click += new System.EventHandler(this.bRunApp_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRefresh.Location = new System.Drawing.Point(336, 258);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(92, 40);
            this.bRefresh.TabIndex = 4;
            this.bRefresh.Text = "Odświerz";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Location = new System.Drawing.Point(336, 301);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(92, 40);
            this.bDelete.TabIndex = 5;
            this.bDelete.Text = "Usuń";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(336, 344);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(92, 56);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Zapisz liste";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tb_destDir
            // 
            this.tb_destDir.Location = new System.Drawing.Point(12, 73);
            this.tb_destDir.Name = "tb_destDir";
            this.tb_destDir.Size = new System.Drawing.Size(318, 22);
            this.tb_destDir.TabIndex = 7;
            // 
            // lb_elements
            // 
            this.lb_elements.FormattingEnabled = true;
            this.lb_elements.ItemHeight = 16;
            this.lb_elements.Location = new System.Drawing.Point(12, 125);
            this.lb_elements.Name = "lb_elements";
            this.lb_elements.Size = new System.Drawing.Size(318, 276);
            this.lb_elements.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gdzie zostanie wykonana kopia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "To co chcesz skopiować:";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // dodajPlikToolStripMenuItem
            // 
            this.dodajPlikToolStripMenuItem.Name = "dodajPlikToolStripMenuItem";
            this.dodajPlikToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.dodajPlikToolStripMenuItem.Text = "Dodaj plik";
            // 
            // dodajKatalogToolStripMenuItem
            // 
            this.dodajKatalogToolStripMenuItem.Name = "dodajKatalogToolStripMenuItem";
            this.dodajKatalogToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.dodajKatalogToolStripMenuItem.Text = "Dodaj katalog";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // whereCopyToolStripMenuItem
            // 
            this.whereCopyToolStripMenuItem.Name = "whereCopyToolStripMenuItem";
            this.whereCopyToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.whereCopyToolStripMenuItem.Text = "Gdzie skopiować";
            this.whereCopyToolStripMenuItem.Click += new System.EventHandler(this.whereCopyToolStripMenuItem_Click);
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_elements);
            this.Controls.Add(this.tb_destDir);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bRunApp);
            this.Controls.Add(this.bAddDir);
            this.Controls.Add(this.bAddFile);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BasicForm";
            this.Text = "SetParams";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button bAddFile;
        private System.Windows.Forms.Button bAddDir;
        private System.Windows.Forms.Button bRunApp;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ToolStripMenuItem opcjeTSMI;
        private System.Windows.Forms.ToolStripMenuItem koniecTSMI;
        private System.Windows.Forms.TextBox tb_destDir;
        private System.Windows.Forms.ListBox lb_elements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem dodajPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem whereCopyToolStripMenuItem;
    }
}

