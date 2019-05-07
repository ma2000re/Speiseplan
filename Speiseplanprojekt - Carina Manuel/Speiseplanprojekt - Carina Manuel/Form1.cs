using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Speiseplanprojekt___Carina_Manuel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListViewItem lvItem;
        Datenbank db;
        string sql;
        OleDbDataReader dr;
        int id;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Datenbank();
            einlesenSpeisen();
        }

       private void einlesenSpeisen()
        {
            listViewSpeisen.Items.Clear();
            sql = "Select * from Speisen";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                lvItem.SubItems.Add(dr[2].ToString());
                lvItem.SubItems.Add(dr[3].ToString());
                lvItem.SubItems.Add(dr[4].ToString());
                lvItem.SubItems.Add(dr[5].ToString());
                lvItem.SubItems.Add(dr[6].ToString());
                lvItem.SubItems.Add(dr[7].ToString());
                
                listViewSpeisen.Items.Add(lvItem);
            }
        }

        private void speiseAnlegenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 fSpeise = new Form2();
            fSpeise.Text = "Speise anlegen";
            fSpeise.ShowDialog();
            einlesenSpeisen();

        }

        private void speiseBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fSpeise = new Form2();
            fSpeise.Text = "Speise bearbeiten";
            fSpeise.ShowDialog();
            einlesenSpeisen();
        }

        private void speiseAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fSpeise = new Form2();
            fSpeise.Text = "Speise anlegen";
            fSpeise.ShowDialog();
            einlesenSpeisen();
        }

        private void speisenBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fSpeise = new Form2();
            fSpeise.Text = "Speise bearbeiten";
            fSpeise.ShowDialog();
            einlesenSpeisen();
        }

        private void speiseLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fSpeise = new Form2();

            lvItem = listViewSpeisen.SelectedItems[0];
            id = Convert.ToInt32(lvItem.SubItems[0].Text);

            DialogResult dialogResult = MessageBox.Show("Die gewählte Speise wird gelöscht,\n wollen Sie fortfahren?", "Achtung", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Ausfuehren("DELETE FROM Speisen where SID=" + id + ";");
            }
            einlesenSpeisen();
        }

        private void speisenLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fSpeise = new Form2();

            lvItem = listViewSpeisen.SelectedItems[0];
            id = Convert.ToInt32(lvItem.SubItems[0].Text);

            DialogResult dialogResult = MessageBox.Show("Die gewählte Speise wird gelöscht,\n wollen Sie fortfahren?", "Achtung", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Ausfuehren("DELETE FROM Speisen where SID=" + id + ";");
            }
            einlesenSpeisen();
        }
    }
}
