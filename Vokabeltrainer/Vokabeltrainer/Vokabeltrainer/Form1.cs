using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Vokabeltrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bUebersetzer_Click(object sender, EventArgs e)
        {
            Ubersetzer u = new Ubersetzer();
            u.Show();
        }

        private void bFach_Click(object sender, EventArgs e)
        {
            Fach f = new Fach();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.loadSubjects();
            Globals.loadTopics();
            Globals.loadVocs();
        }

        private void bLernen_Click(object sender, EventArgs e)
        {
            Lernen l = new Lernen();
            l.Show();
        }
    }
}
