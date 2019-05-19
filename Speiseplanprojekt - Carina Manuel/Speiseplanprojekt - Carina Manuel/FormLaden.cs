using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speiseplanprojekt___Carina_Manuel
{
    public partial class FormLaden : Form
    {
        public FormLaden()
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            timer1.Stop();
            this.Visible = false;
        }

        private void FormLaden_Load(object sender, EventArgs e)
        {
        }
    }
}
