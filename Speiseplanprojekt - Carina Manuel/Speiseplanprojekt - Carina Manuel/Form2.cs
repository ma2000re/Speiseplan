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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
       
        db = new Datenbank();
        }

    Datenbank db;
    OleDbDataReader dr;
        internal long id;
        string sql;

        private void btAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie einen Namen ein!");
                return;
            }
            
            if (cbFleischart.Text.Equals(""))
            {
                MessageBox.Show("Bitte wählen Sie eine Fleischart aus!");
                return;
            }

            if (cbSpeisenart.Text.Equals(""))
            {
                MessageBox.Show("Bitte wählen Sie eine Speisenart aus!");
                return;
            }

            



            if (this.Text.Equals("Speise anlegen"))
            {
                sql = "Insert into Speisen (Speisenart, Name, WarmKalt, Zusatz, Vegetarisch, Kinderspeise, Fleischart) values ('"+ cbSpeisenart.Text + "','" + txtName.Text + "','" + cbwk.Text + "','" + txtZusatz.Text + "','" + checkBoxVegetarisch.Checked + "','" + checkBoxKinderspeise.Checked + "','" + cbFleischart.Text + "');";
                MessageBox.Show(sql);
            }
            else
            {
                sql = "Update Speisen set Speisenart='"+ cbSpeisenart.Text+  "', Name='" + txtName.Text + "', WarmKalt='" + cbwk.Text + "', Zusatz'" + txtZusatz.Text + "', Vegetarisch'" + checkBoxVegetarisch.Checked + "', Kinderspeise'" + checkBoxKinderspeise.Checked+ "', Fleischart'" + cbFleischart.Text + "' where SID=" + id + ";";
            }
            db.Ausfuehren(sql);
            this.Close();
        }
    }
}
