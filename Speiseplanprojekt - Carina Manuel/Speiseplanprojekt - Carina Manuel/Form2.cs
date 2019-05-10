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
            
            if (cbSpeisenart.Text.Equals(""))
            {
                MessageBox.Show("Bitte wählen Sie eine Speisenart aus!");
                return;
            }


            string speisenart = cbSpeisenart.Text;
            string name = txtName.Text;
            string warmKalt = cbwk.Text.ToLower();
            string zusatz = txtZusatz.Text;
            bool veg = checkBoxVegetarisch.Checked;
            bool kind = checkBoxKinderspeise.Checked;
            string fleischart = cbFleischart.Text;


            if (this.Text.Equals("Speise anlegen"))
            {
                sql = "Insert into Speisen (Speisenart, Name, WarmKalt, Zusatz, Vegetarisch, Kinderspeise, Fleischart) values ('"+ speisenart + "','" + name + "','" + warmKalt + "','" + zusatz + "'," + veg + "," + kind + ",'" + fleischart + "')";
            }
            else
            {
                sql = "Update Speisen set Speisenart='"+speisenart+  "', Name='" + name + "', WarmKalt='" + warmKalt + "', Zusatz='" + zusatz + "', Vegetarisch=" + veg + ", Kinderspeise=" + kind+ ", Fleischart='" + fleischart+ "' where SID=" + id + ";";
            }
            db.Ausfuehren(sql);
            this.Close();
        }

        private void checkBoxVegetarisch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVegetarisch.Checked == true)
                cbFleischart.Enabled = false;
            if (checkBoxVegetarisch.Checked == false)
                cbFleischart.Enabled = true;
        }
    }
}
