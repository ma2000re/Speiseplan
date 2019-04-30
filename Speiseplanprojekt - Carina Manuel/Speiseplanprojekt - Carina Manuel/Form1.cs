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
    }
}
