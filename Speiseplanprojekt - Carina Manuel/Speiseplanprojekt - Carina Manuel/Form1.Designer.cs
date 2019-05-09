namespace Speiseplanprojekt___Carina_Manuel
{
    partial class Form1
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
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.listViewSpeisen.Location = new System.Drawing.Point(19, 75);
            this.listViewSpeisen.Name = "listViewSpeisen";
            this.listViewSpeisen.Size = new System.Drawing.Size(922, 543);
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
            this.columnHeader2.Width = 149;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "WarmKalt";
            this.columnHeader7.Width = 81;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 70);
            // 
            // speiseAnlegenToolStripMenuItem
            // 
            this.speiseAnlegenToolStripMenuItem.Name = "speiseAnlegenToolStripMenuItem";
            this.speiseAnlegenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.speiseAnlegenToolStripMenuItem.Text = "Speise anlegen";
            this.speiseAnlegenToolStripMenuItem.Click += new System.EventHandler(this.speiseAnlegenToolStripMenuItem_Click);
            // 
            // speisenBearbeitenToolStripMenuItem
            // 
            this.speisenBearbeitenToolStripMenuItem.Name = "speisenBearbeitenToolStripMenuItem";
            this.speisenBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.speisenBearbeitenToolStripMenuItem.Text = "Speisen bearbeiten";
            this.speisenBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.speisenBearbeitenToolStripMenuItem_Click);
            // 
            // speisenLöschenToolStripMenuItem
            // 
            this.speisenLöschenToolStripMenuItem.Name = "speisenLöschenToolStripMenuItem";
            this.speisenLöschenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.speisenLöschenToolStripMenuItem.Text = "Speisen löschen";
            this.speisenLöschenToolStripMenuItem.Click += new System.EventHandler(this.speisenLöschenToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speiseAnlegenToolStripMenuItem1,
            this.speiseBearbeitenToolStripMenuItem,
            this.speiseLöschenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1338, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speiseAnlegenToolStripMenuItem1
            // 
            this.speiseAnlegenToolStripMenuItem1.Name = "speiseAnlegenToolStripMenuItem1";
            this.speiseAnlegenToolStripMenuItem1.Size = new System.Drawing.Size(97, 20);
            this.speiseAnlegenToolStripMenuItem1.Text = "Speise anlegen";
            this.speiseAnlegenToolStripMenuItem1.Click += new System.EventHandler(this.speiseAnlegenToolStripMenuItem1_Click);
            // 
            // speiseBearbeitenToolStripMenuItem
            // 
            this.speiseBearbeitenToolStripMenuItem.Name = "speiseBearbeitenToolStripMenuItem";
            this.speiseBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.speiseBearbeitenToolStripMenuItem.Text = "Speise bearbeiten";
            this.speiseBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.speiseBearbeitenToolStripMenuItem_Click);
            // 
            // speiseLöschenToolStripMenuItem
            // 
            this.speiseLöschenToolStripMenuItem.Name = "speiseLöschenToolStripMenuItem";
            this.speiseLöschenToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.speiseLöschenToolStripMenuItem.Text = "Speise löschen";
            this.speiseLöschenToolStripMenuItem.Click += new System.EventHandler(this.speiseLöschenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 642);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewSpeisen);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Speiseplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

