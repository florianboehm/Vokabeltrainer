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
    public partial class Lernen : Form
    {
        public Lernen()
        {
            InitializeComponent();
        }

        private void Lernen_Load(object sender, EventArgs e)
        {
            List<Vocable> randomList = new List<Vocable>();

            Random r = new Random();
            int randomIndex = 0;
            ListBox list = new ListBox();
            this.Controls.Add(list);
            ArrayList shadowVocs = Globals.vocs;
            

            while (shadowVocs.Count > 0)
            {
                randomIndex = r.Next(0, shadowVocs.Count); //Choose a random object in the list
                randomList.Add((Vocable)shadowVocs[randomIndex]); //add it to the new, random list
                list.Items.Add(((Vocable)shadowVocs[randomIndex]).propDisplayName);
                shadowVocs.RemoveAt(randomIndex); //remove to avoid duplicates
            }
        }
    }
}
