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
    public partial class Speiseplan : Form
    {
        public Speiseplan()
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

        private void speisebearbeiten()
        {
            if (listViewSpeisen.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wählen Sie bitte eine Speise aus!");
                return;
            }
            lvItem = listViewSpeisen.SelectedItems[0];

            Form2 fSpeise = new Form2();
            fSpeise.Text = "Speise bearbeiten";

            fSpeise.id = Convert.ToInt64(lvItem.SubItems[0].Text);
            fSpeise.txtID.Text = lvItem.SubItems[0].Text;
            fSpeise.cbSpeisenart.Text = lvItem.SubItems[1].Text;
            fSpeise.txtName.Text = lvItem.SubItems[2].Text;
            fSpeise.cbwk.Text = lvItem.SubItems[3].Text;
            fSpeise.txtZusatz.Text = lvItem.SubItems[4].Text;
            
            fSpeise.cbFleischart.Text = lvItem.SubItems[7].Text;

            if (lvItem.SubItems[5].Text.Equals("True"))
            {
                fSpeise.checkBoxVegetarisch.Checked = true;
            }
            else
            {
                fSpeise.checkBoxVegetarisch.Checked = false;
            }


            if (lvItem.SubItems[6].Text.Equals("True"))
            {
                fSpeise.checkBoxKinderspeise.Checked = true;
            }
            else
            {
                fSpeise.checkBoxKinderspeise.Checked = false;
            }

            fSpeise.ShowDialog();
            einlesenSpeisen();
        }

        private void speiseBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speisebearbeiten();
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
            speisebearbeiten();
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
