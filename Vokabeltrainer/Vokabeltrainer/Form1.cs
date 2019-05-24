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

        public int mode = 0; // löschen = 1, speichern = 2
        public ArrayList vocStack = new ArrayList();

        private void wortÜbersetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Überschrift und Beschreibungstext
            Label lUeberschrift = new Label();
            lUeberschrift.Text = "Übersetzer";
            lUeberschrift.Font = new Font("Arial", 12, FontStyle.Bold);
            lUeberschrift.Top = 50;
            lUeberschrift.Left = 20;
            this.Controls.Add(lUeberschrift);

            Label lBeschreibung = new Label();
            lBeschreibung.Text = "Bitte tippen Sie ein Wort ein und wählen Sie eine Sprache aus um es in diese zu übersetzen.";
            lBeschreibung.Top = 80;
            lBeschreibung.Left = 20;
            lBeschreibung.MaximumSize = new Size(200, 0);
            lBeschreibung.AutoSize = true;
            this.Controls.Add(lBeschreibung);

            //DropDown-Menü
            ComboBox cbSprache = new ComboBox();
            cbSprache.Items.Add("Englisch");
            cbSprache.Items.Add("Französisch");
            cbSprache.Items.Add("Spanisch");
            cbSprache.Text = "- bitte Sprache auswählen - ";
            cbSprache.Top = 130;
            cbSprache.Left = 20;
            cbSprache.Width = 200;
            cbSprache.Height = 20;
            cbSprache.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSprache.SelectedIndexChanged += onCbSpracheSelectionChange;
            this.Controls.Add(cbSprache);

            //Eingabefeld
            TextBox tbEingabe = new TextBox();
            tbEingabe.Top = 160;
            tbEingabe.Left = 20;
            tbEingabe.Width = 200;
            tbEingabe.Height = 20;
            this.Controls.Add(tbEingabe);

            //Button zum Starten der Übersetzung
            Button bUebersetzen = new Button();
            bUebersetzen.Text = "Übersetzen";
            bUebersetzen.Top = 190;
            bUebersetzen.Left = 140;
            bUebersetzen.Width = 80;
            bUebersetzen.Height = 20;
            this.Controls.Add(bUebersetzen);

            //Listbox als Anzeige der Übersetzungen
            ListBox lbUebersetzungen = new ListBox();
            lbUebersetzungen.Top = 220;
            lbUebersetzungen.Left = 20;
            lbUebersetzungen.Width = 200;
            lbUebersetzungen.Height = 200;


            lbUebersetzungen.Items.Add(new Vocable("origin"));
            vocStack.Add(new Vocable("origin"));
           
            lbUebersetzungen.DisplayMember = "propDisplayName";
            lbUebersetzungen.ValueMember = "propTranslation";

            lbUebersetzungen.SelectedIndexChanged += onListBoxSelectionChange;
            this.Controls.Add(lbUebersetzungen);

            //Button zum Löschen
            Button bLoeschen = new Button();
            bLoeschen.Text = "L";
            bLoeschen.Top = 420;
            bLoeschen.Left = 20;
            bLoeschen.Width = 20;
            bLoeschen.Height = 20;
            bLoeschen.Font = new Font("Arial", 6, FontStyle.Bold);
            bLoeschen.BackColor = Color.Red;
            bLoeschen.ForeColor = Color.White;
            this.Controls.Add(bLoeschen);
            bLoeschen.Click += clickOnLoeschen;
        }

        /// <summary>
        /// Wird ausgeführt sobald man im DropDown-Menü ein Item wählt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCbSpracheSelectionChange(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int i = comboBox.SelectedIndex;
            MessageBox.Show("Index: "+i);
            
            //@todo an dieser stelle muss die api angesprochen werden und das was sie zurück gibt muss hier ausgegeben werden:

        }

        /// <summary>
        /// Wird ausgeführt sobald die Selektion in der Listbox wechselt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onListBoxSelectionChange(object sender, EventArgs e)
        {
            ListBox vs = (ListBox)sender;
            if (mode == 1)
            {
                 vs.Items.Clear();
                //suche angeklicktes Item aus der ListBox in der ArrayList und lösche dieses Item
                for ( int i = 0; i < vocStack.Count; i++)
                {
                    if ( ( (Vocable)vocStack[i] ).propDisplayName.Equals( ( ( Vocable )vs.SelectedItem).propDisplayName ) ){
                        vocStack.RemoveRange(i, 1);
                        MessageBox.Show(((Vocable)vs.SelectedItem).propDisplayName + " wurde gelöscht");
                        vs.Items.RemoveAt(vs.SelectedIndex);
                    }
                }
            }
        }

        private void clickOnLoeschen(object sender, EventArgs e)
        {
            mode = 1;
        }
    }
}
