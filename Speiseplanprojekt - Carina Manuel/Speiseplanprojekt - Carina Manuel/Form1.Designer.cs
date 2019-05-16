namespace Speiseplanprojekt___Carina_Manuel
{
    partial class Speiseplan
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speiseplan));
            this.listViewSpeisen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.speiseAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speisenBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speisenLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speiseAnlegenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.speiseBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speiseLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datenbankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintergrundfarbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backColor = new System.Windows.Forms.ColorDialog();
            this.picture = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVorspeise = new System.Windows.Forms.ComboBox();
            this.cbHauptspeise = new System.Windows.Forms.ComboBox();
            this.cbNachspeise = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewSpeisen
            // 
            this.listViewSpeisen.AllowColumnReorder = true;
            this.listViewSpeisen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader4});
            this.listViewSpeisen.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewSpeisen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSpeisen.FullRowSelect = true;
            this.listViewSpeisen.GridLines = true;
            this.listViewSpeisen.Location = new System.Drawing.Point(16, 34);
            this.listViewSpeisen.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSpeisen.MultiSelect = false;
            this.listViewSpeisen.Name = "listViewSpeisen";
            this.listViewSpeisen.Size = new System.Drawing.Size(1249, 740);
            this.listViewSpeisen.TabIndex = 0;
            this.listViewSpeisen.UseCompatibleStateImageBehavior = false;
            this.listViewSpeisen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SID";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Speisenart";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 230;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "w/k";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Zusatz";
            this.columnHeader5.Width = 164;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vegetarisch";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kinderspeise";
            this.columnHeader8.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fleischart";
            this.columnHeader4.Width = 99;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speiseAnlegenToolStripMenuItem,
            this.speisenBearbeitenToolStripMenuItem,
            this.speisenLöschenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 76);
            // 
            // speiseAnlegenToolStripMenuItem
            // 
            this.speiseAnlegenToolStripMenuItem.Name = "speiseAnlegenToolStripMenuItem";
            this.speiseAnlegenToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.speiseAnlegenToolStripMenuItem.Text = "Speise anlegen";
            this.speiseAnlegenToolStripMenuItem.Click += new System.EventHandler(this.speiseAnlegenToolStripMenuItem_Click);
            // 
            // speisenBearbeitenToolStripMenuItem
            // 
            this.speisenBearbeitenToolStripMenuItem.Name = "speisenBearbeitenToolStripMenuItem";
            this.speisenBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.speisenBearbeitenToolStripMenuItem.Text = "Speisen bearbeiten";
            this.speisenBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.speisenBearbeitenToolStripMenuItem_Click);
            // 
            // speisenLöschenToolStripMenuItem
            // 
            this.speisenLöschenToolStripMenuItem.Name = "speisenLöschenToolStripMenuItem";
            this.speisenLöschenToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.speisenLöschenToolStripMenuItem.Text = "Speisen löschen";
            this.speisenLöschenToolStripMenuItem.Click += new System.EventHandler(this.speisenLöschenToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speiseAnlegenToolStripMenuItem1,
            this.speiseBearbeitenToolStripMenuItem,
            this.speiseLöschenToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1784, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speiseAnlegenToolStripMenuItem1
            // 
            this.speiseAnlegenToolStripMenuItem1.Name = "speiseAnlegenToolStripMenuItem1";
            this.speiseAnlegenToolStripMenuItem1.Size = new System.Drawing.Size(136, 27);
            this.speiseAnlegenToolStripMenuItem1.Text = "Speise anlegen";
            this.speiseAnlegenToolStripMenuItem1.Click += new System.EventHandler(this.speiseAnlegenToolStripMenuItem1_Click);
            // 
            // speiseBearbeitenToolStripMenuItem
            // 
            this.speiseBearbeitenToolStripMenuItem.Name = "speiseBearbeitenToolStripMenuItem";
            this.speiseBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(157, 27);
            this.speiseBearbeitenToolStripMenuItem.Text = "Speise bearbeiten";
            this.speiseBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.speiseBearbeitenToolStripMenuItem_Click);
            // 
            // speiseLöschenToolStripMenuItem
            // 
            this.speiseLöschenToolStripMenuItem.Name = "speiseLöschenToolStripMenuItem";
            this.speiseLöschenToolStripMenuItem.Size = new System.Drawing.Size(133, 27);
            this.speiseLöschenToolStripMenuItem.Text = "Speise löschen";
            this.speiseLöschenToolStripMenuItem.Click += new System.EventHandler(this.speiseLöschenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datenbankToolStripMenuItem,
            this.hintergrundfarbeToolStripMenuItem,
            this.logoToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(124, 27);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // datenbankToolStripMenuItem
            // 
            this.datenbankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.neuLadenToolStripMenuItem});
            this.datenbankToolStripMenuItem.Name = "datenbankToolStripMenuItem";
            this.datenbankToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.datenbankToolStripMenuItem.Text = "Datenbank";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // neuLadenToolStripMenuItem
            // 
            this.neuLadenToolStripMenuItem.Name = "neuLadenToolStripMenuItem";
            this.neuLadenToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.neuLadenToolStripMenuItem.Text = "Neu laden";
            // 
            // hintergrundfarbeToolStripMenuItem
            // 
            this.hintergrundfarbeToolStripMenuItem.Name = "hintergrundfarbeToolStripMenuItem";
            this.hintergrundfarbeToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.hintergrundfarbeToolStripMenuItem.Text = "Hintergrundfarbe";
            this.hintergrundfarbeToolStripMenuItem.Click += new System.EventHandler(this.hintergrundfarbeToolStripMenuItem_Click);
            // 
            // logoToolStripMenuItem
            // 
            this.logoToolStripMenuItem.Name = "logoToolStripMenuItem";
            this.logoToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.logoToolStripMenuItem.Text = "Logo";
            this.logoToolStripMenuItem.Click += new System.EventHandler(this.logoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNachspeise);
            this.groupBox1.Controls.Add(this.cbHauptspeise);
            this.groupBox1.Controls.Add(this.cbVorspeise);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1275, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(509, 560);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zufallsplan erstellen:";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(1514, 40);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(258, 178);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1272, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "*grün gekennzeichnet=Vegetarisch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorspeise:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hauptspeise:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nachspeise:";
            // 
            // cbVorspeise
            // 
            this.cbVorspeise.FormattingEnabled = true;
            this.cbVorspeise.Location = new System.Drawing.Point(269, 146);
            this.cbVorspeise.Name = "cbVorspeise";
            this.cbVorspeise.Size = new System.Drawing.Size(172, 33);
            this.cbVorspeise.TabIndex = 3;
            // 
            // cbHauptspeise
            // 
            this.cbHauptspeise.FormattingEnabled = true;
            this.cbHauptspeise.Location = new System.Drawing.Point(269, 234);
            this.cbHauptspeise.Name = "cbHauptspeise";
            this.cbHauptspeise.Size = new System.Drawing.Size(172, 33);
            this.cbHauptspeise.TabIndex = 4;
            // 
            // cbNachspeise
            // 
            this.cbNachspeise.FormattingEnabled = true;
            this.cbNachspeise.Location = new System.Drawing.Point(269, 322);
            this.cbNachspeise.Name = "cbNachspeise";
            this.cbNachspeise.Size = new System.Drawing.Size(172, 33);
            this.cbNachspeise.TabIndex = 5;
            // 
            // Speiseplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 790);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewSpeisen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Speiseplan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speiseplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSpeisen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speiseAnlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speisenBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speisenLöschenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speiseAnlegenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem speiseBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speiseLöschenToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datenbankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hintergrundfarbeToolStripMenuItem;
        private System.Windows.Forms.ColorDialog backColor;
        private System.Windows.Forms.ToolStripMenuItem logoToolStripMenuItem;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNachspeise;
        private System.Windows.Forms.ComboBox cbHauptspeise;
        private System.Windows.Forms.ComboBox cbVorspeise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

