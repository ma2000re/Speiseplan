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
using System.IO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Threading;

namespace Speiseplanprojekt___Carina_Manuel
{
    public partial class Form1 : Form
    {
        internal static Form1 f1;
        public Form1()
        {

            f1 = this;
            InitializeComponent();
        }

        ListViewItem lvItem;
        Datenbank db;
        string sql;
        OleDbDataReader dr;
        int id;
        StreamReader sr;
        StreamWriter sw;
        Random rand;
        int[] ids;


        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Datenbank();
            einlesenSpeisen();
            hintergrundfarbeEinlesen();
            bildeinlesen();
            einlesenCbVorspeisen();
            einlesenCbHauptspeisen();
            einlesenCbNachspeisen();
            speisenZiehen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void speisenZiehen()
        {
            vorspeisenZiehen();
            hauptspeisenZiehen();
            nachspeisenZiehen();
        }

        private void einlesenCbVorspeisen()
        {
            cbVorMontag.Items.Clear();
            cbVorDienstag.Items.Clear();
            cbVorMittwoch.Items.Clear();
            cbVorDonnerstag.Items.Clear();
            cbVorFreitag.Items.Clear();

            sql = "SELECT Name FROM Speisen WHERE Speisenart='Vorspeise'";
            dr = db.Einlesen(sql);
            while(dr.Read())
            {
                cbVorMontag.Items.Add(dr[0].ToString());
                cbVorDienstag.Items.Add(dr[0].ToString());
                cbVorMittwoch.Items.Add(dr[0].ToString());
                cbVorDonnerstag.Items.Add(dr[0].ToString());
                cbVorFreitag.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void einlesenCbHauptspeisen()
        {
            cbHauptMontag.Items.Clear();
            cbHauptDienstag.Items.Clear();
            cbHauptMittwoch.Items.Clear();
            cbHauptDonnerstag.Items.Clear();
            cbHauptFreitag.Items.Clear();

            sql = "SELECT Name FROM Speisen WHERE Speisenart='Hauptspeise'";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                cbHauptMontag.Items.Add(dr[0].ToString());
                cbHauptDienstag.Items.Add(dr[0].ToString());
                cbHauptMittwoch.Items.Add(dr[0].ToString());
                cbHauptDonnerstag.Items.Add(dr[0].ToString());
                cbHauptFreitag.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void einlesenCbNachspeisen()
        {
            cbNachMontag.Items.Clear();
            cbNachDienstag.Items.Clear();
            cbNachMittwoch.Items.Clear();
            cbNachDonnerstag.Items.Clear();
            cbNachFreitag.Items.Clear();

            sql = "SELECT Name FROM Speisen WHERE Speisenart='Nachspeise'";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                cbNachMontag.Items.Add(dr[0].ToString());
                cbNachDienstag.Items.Add(dr[0].ToString());
                cbNachMittwoch.Items.Add(dr[0].ToString());
                cbNachDonnerstag.Items.Add(dr[0].ToString());
                cbNachFreitag.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }   

        private void einlesenSpeisen()
        {
            listViewSpeisen.Items.Clear();
            sql = "Select * from Speisen order by SID";
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

                //MessageBox.Show(lvItem.SubItems[5].Text);
                if (this.lvItem.SubItems[5].Text.Equals("True"))
                {
                    //MessageBox.Show(lvItem.SubItems[1].Text);
                    this.lvItem.BackColor = Color.Green;
                    this.lvItem.ForeColor = Color.White;
                }
            }

            
        }
       

        private void speiseAnlegenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 fSpeise = new Form2();
            fSpeise.Text = "Speise anlegen";
            fSpeise.ShowDialog();
            einlesenSpeisen();
            speisenZiehen();

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
            speisenZiehen();
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
            speisenZiehen();
        }

        private void speisenBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speisebearbeiten();
        }

        private void speiseLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewSpeisen.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wählen Sie bitte eine Speise aus!");
                return;
            }

            lvItem = listViewSpeisen.SelectedItems[0];
            id = Convert.ToInt32(lvItem.SubItems[0].Text);

            DialogResult dialogResult = MessageBox.Show("Die gewählte Speise wird gelöscht,\n wollen Sie fortfahren?", "Achtung", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Ausfuehren("DELETE FROM Speisen where SID=" + id + ";");
            }
            einlesenSpeisen();
            speisenZiehen();
        }

        private void speisenLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewSpeisen.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wählen Sie bitte eine Speise aus!");
                return;
            }

            lvItem = listViewSpeisen.SelectedItems[0];
            id = Convert.ToInt32(lvItem.SubItems[0].Text);

            DialogResult dialogResult = MessageBox.Show("Die gewählte Speise wird gelöscht,\n wollen Sie fortfahren?", "Achtung", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Ausfuehren("DELETE FROM Speisen where SID=" + id + ";");
            }
            einlesenSpeisen();
            speisenZiehen();
        }

        private void hintergrundfarbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hintergrundfarbeSchreiben();
        }

        private void hintergrundfarbeEinlesen()
        {
            sr = new StreamReader("BackColor.ini");
            int a = Convert.ToInt16(sr.ReadLine().Trim());
            int b = Convert.ToInt16(sr.ReadLine().Trim());
            int r = Convert.ToInt16(sr.ReadLine().Trim());
            int g = Convert.ToInt16(sr.ReadLine().Trim());
            sr.Close();

            this.BackColor = Color.FromArgb(a, r, g, b);
        }

        private void bildeinlesen()
        {
            try
            {
                sr = new StreamReader("pfadbild.txt");
                string pfad = sr.ReadLine();
                picture.Image = new Bitmap(pfad);

                sr.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Bild wurde nicht gefunden!");
            }
        }

        private void hintergrundfarbeSchreiben()
        {
            backColor.ShowDialog();
            this.BackColor = backColor.Color;
            groupBox1.BackColor = backColor.Color;
            sw = new StreamWriter("BackColor.ini");
            sw.WriteLine(backColor.Color.A);
            sw.WriteLine(backColor.Color.B);
            sw.WriteLine(backColor.Color.R);
            sw.WriteLine(backColor.Color.G);
            sw.Close();
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void logoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "jpg files (*.jpg)|*.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
              picture.Image=new Bitmap (dlg.FileName);
            }
            
            dlg.Dispose();

            sw = new StreamWriter("pfadbild.txt");
            sw.WriteLine(dlg.FileName);
            sw.Close();

        }

        private void vorspeisenZiehen()
        {
            ids = new int[5];
            int vorMax = cbVorMontag.Items.Count;

            bool doppelt;
            int inde;
            rand = new Random();

            for (int i=0; i<5;i++)
            {
                do
                {
                    doppelt = true;
                    ids[i] = rand.Next(0, vorMax);
                }
                while (doppelt == false);
            }
            cbVorMontag.SelectedIndex = ids[0];
            cbVorDienstag.SelectedIndex = ids[1];
            cbVorMittwoch.SelectedIndex = ids[2];
            cbVorDonnerstag.SelectedIndex = ids[3];
            cbVorFreitag.SelectedIndex = ids[4];
        }

        private void hauptspeisenZiehen()
        {
            ids = new int[5];
            int hauptMax = cbHauptMontag.Items.Count;

            bool doppelt;
            int inde;
            rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    doppelt = true;
                    ids[i] = rand.Next(0, hauptMax);
                }
                while (doppelt == false);
            }
            cbHauptMontag.SelectedIndex = ids[0];
            cbHauptDienstag.SelectedIndex = ids[1];
            cbHauptMittwoch.SelectedIndex = ids[2];
            cbHauptDonnerstag.SelectedIndex = ids[3];
            cbHauptFreitag.SelectedIndex = ids[4];
        }

        private void nachspeisenZiehen()
        {
            ids = new int[5];
            int nachMax = cbNachMontag.Items.Count;

            bool doppelt;
            int inde;
            rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    doppelt = true;
                    ids[i] = rand.Next(0, nachMax);
                }
                while (doppelt == false);
            }
            cbNachMontag.SelectedIndex = ids[0];
            cbNachDienstag.SelectedIndex = ids[1];
            cbNachMittwoch.SelectedIndex = ids[2];
            cbNachDonnerstag.SelectedIndex = ids[3];
            cbNachFreitag.SelectedIndex = ids[4];
        }

        private void btDienstag_Click(object sender, EventArgs e)
        {
            speisenZiehen();
        }

        private void btdrucken_Click(object sender, EventArgs e)
        {
            excelöffnen();
        }

        private void excelöffnen()
        {
            sw = new StreamWriter("Speise.csv", false, Encoding.Default);

            sw.WriteLine("Speiseplan " + tabPage1.Text, new System.Drawing.Font("Times New Roman", 14, FontStyle.Bold));                             
            sw.WriteLine("Vorspeise: " + cbVorMontag.Text);                                          
            sw.WriteLine("Hauptspeise: " + cbHauptMontag.Text);
            sw.WriteLine("Nachspeise: " + cbNachMontag.Text);
            sw.WriteLine("");


            sw.WriteLine("Speiseplan " + tabPage2.Text);                              
            sw.WriteLine("Vorspeise: " + cbVorDienstag.Text);                                          
            sw.WriteLine("Hauptspeise: " + cbHauptDienstag.Text);
            sw.WriteLine("Nachspeise: " + cbNachDienstag.Text);
            sw.WriteLine("");

            sw.WriteLine("Speiseplan " + tabPage3.Text);                             
            sw.WriteLine("Vorspeise: " + cbVorMittwoch.Text);                                          
            sw.WriteLine("Hauptspeise: " + cbHauptMittwoch.Text);
            sw.WriteLine("Nachspeise: " + cbNachMittwoch.Text);
            sw.WriteLine("");

            sw.WriteLine("Speiseplan " + tabPage4.Text);                              
            sw.WriteLine("Vorspeise: " + cbVorDonnerstag.Text);                                          
            sw.WriteLine("Hauptspeise: " + cbHauptDonnerstag.Text);
            sw.WriteLine("Nachspeise: " + cbNachDonnerstag.Text);
            sw.WriteLine("");

            sw.WriteLine("Speiseplan " + tabPage5.Text);                             
            sw.WriteLine("Vorspeise: " + cbVorFreitag.Text);                                          
            sw.WriteLine("Hauptspeise: " + cbHauptFreitag.Text);
            sw.WriteLine("Nachspeise: " + cbNachFreitag.Text);

            sw.WriteLine("");
           
            sw.Close();
            //object missing = Missing.Value;
            //Excel.Application excel = new Excel.Application();
            //string datei = @"C:\Users\Carina\Documents\Schule\4CK\SWPP\GitHub\Projekt\Speiseplan\Speiseplanprojekt - Carina Manuel\Speiseplanprojekt - Carina Manuel\bin\Debug"; //@: nur ein \ notwendig, sonst 2!
            //excel.Workbooks.Open(datei + "\\Speisenplan.csv");
            //Worksheet ws = excel.ActiveWorkbook.Worksheets[1];
            //ws.get_Range("A1:A1", missing).Interior.Color = Color.Red;
            //ws.get_Range("A1:A1", missing).Font.Bold = true;
            //((Excel.Range)ws.Columns[1, missing]).AutoFit();

            //excel.Visible = true;
        }

        internal void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWHoleWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWHoleWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllForms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }


        internal void CreateWordDocument(object filename, object saveAs)
        {
            Word.Application wordApp = new Word.Application();


            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {

                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;


                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);


                myWordDoc.Activate();
                wordApp.Visible = false;

                //suche
                this.FindAndReplace(wordApp, "<vorMontag>", cbVorMontag.Text);
                this.FindAndReplace(wordApp, "<hauptMontag>", cbHauptMontag.Text);
                this.FindAndReplace(wordApp, "<nachMontag>", cbNachMontag.Text);

                this.FindAndReplace(wordApp, "<vorDienstag>", cbVorDienstag.Text);
                this.FindAndReplace(wordApp, "<hauptDienstag>", cbHauptDienstag.Text);
                this.FindAndReplace(wordApp, "<nachDienstag>", cbNachDienstag.Text);

                this.FindAndReplace(wordApp, "<vorMittwoch>", cbVorMittwoch.Text);
                this.FindAndReplace(wordApp, "<hauptMittwoch>", cbHauptMittwoch.Text);
                this.FindAndReplace(wordApp, "<nachMittwoch>", cbNachMittwoch.Text);

                this.FindAndReplace(wordApp, "<vorDonnerstag>", cbVorDonnerstag.Text);
                this.FindAndReplace(wordApp, "<hauptDonnerstag>", cbHauptDonnerstag.Text);
                this.FindAndReplace(wordApp, "<nachDonnerstag>", cbNachDonnerstag.Text);

                this.FindAndReplace(wordApp, "<vorFreitag>", cbVorFreitag.Text);
                this.FindAndReplace(wordApp, "<hauptFreitag>", cbHauptFreitag.Text);
                this.FindAndReplace(wordApp, "<nachFreitag>", cbNachFreitag.Text);

                this.FindAndReplace(wordApp, "<datum>", DateTime.Now.ToShortDateString());
            }
            else
            {
                MessageBox.Show("Dokument konnte nicht gefunden werden");
            }



            ////Speichern
            myWordDoc.SaveAs2(ref saveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            myWordDoc.PrintOut();
            
            myWordDoc.Close();
            wordApp.Quit();

            MessageBox.Show("Ihr Speiseplan wurde angelegt!");

            

        }

        private void btWord_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string vorlage = path + @"\PlanVorlage.docx";
            string speicherort = path + @"\Speiseplan.docx";

           
            CreateWordDocument(vorlage, speicherort);
            //CreateWordDocument(@"\Speiseplanprojekt - Carina Manuel\Speiseplanprojekt - Carina Manuel\PlanVorlage.docx", @"\Speiseplanprojekt - Carina Manuel\Speiseplanprojekt - Carina Manuel\Speiseplan.docx");
            




        }

    }
}
