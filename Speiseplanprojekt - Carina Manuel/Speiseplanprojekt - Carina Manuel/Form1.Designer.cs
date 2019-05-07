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
            this.contextMenuStrip1.SuspendLayout();
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
            this.listViewSpeisen.FullRowSelect = true;
            this.listViewSpeisen.Location = new System.Drawing.Point(19, 75);
            this.listViewSpeisen.Name = "listViewSpeisen";
            this.listViewSpeisen.Size = new System.Drawing.Size(790, 543);
            this.listViewSpeisen.TabIndex = 0;
            this.listViewSpeisen.UseCompatibleStateImageBehavior = false;
            this.listViewSpeisen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SID";
            this.columnHeader1.Width = 34;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Speisenart";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "WarmKalt";
            this.columnHeader7.Width = 59;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Zusatz";
            this.columnHeader5.Width = 164;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vegetarisch";
            this.columnHeader6.Width = 68;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kinderspeise";
            this.columnHeader8.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fleischart";
            this.columnHeader4.Width = 82;
            // 
            // contextMenuStrip1
            // 
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
            this.speiseAnlegenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speiseAnlegenToolStripMenuItem.Text = "Speise anlegen";
            // 
            // speisenBearbeitenToolStripMenuItem
            // 
            this.speisenBearbeitenToolStripMenuItem.Name = "speisenBearbeitenToolStripMenuItem";
            this.speisenBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speisenBearbeitenToolStripMenuItem.Text = "Speisen bearbeiten";
            // 
            // speisenLöschenToolStripMenuItem
            // 
            this.speisenLöschenToolStripMenuItem.Name = "speisenLöschenToolStripMenuItem";
            this.speisenLöschenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speisenLöschenToolStripMenuItem.Text = "Speisen löschen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 642);
            this.Controls.Add(this.listViewSpeisen);
            this.Name = "Form1";
            this.Text = "Speiseplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

