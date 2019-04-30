using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Speiseplanprojekt___Carina_Manuel
{
    class Datenbank
    {
        private OleDbConnection verbindung;
        private OleDbCommand cmd;
        private string cn;

        public Datenbank()
        {
            cn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Speisen.accdb";
            verbindung = new OleDbConnection(cn);
            verbindung.Open();
        }

        public OleDbDataReader Einlesen(string sql)
        {
            try
            {
                verbindung.Close();
                verbindung.Open();
                cmd = new OleDbCommand(sql, verbindung);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Einlesen" + ex.Message);
            }
            //finally
            //{
            //    verbindung.Close();
            //}
        }

        public void Ausfuehren(string sql)
        {
            try
            {
                verbindung.Close();
                verbindung.Open();
                cmd = new OleDbCommand(sql, verbindung);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Ausführen" + ex.Message);
            }
            finally
            {
                verbindung.Close();
            }
        }

       
    }
}
