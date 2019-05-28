using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vokabeltrainer
{
    public partial class Ubersetzer : Form
    {
        public Ubersetzer()
        {
            InitializeComponent();
        }

        public int mode = 0; // löschen = 1, speichern = 2
        public TextBox publicTbEingabe;
        public ComboBox publicCbSprache;
        public ListBox publicLbUebersetzung;
        public TextBox publicTbLog;
        public Button publicBSpeichern;
        public Button publicBLoeschen;
        public ComboBox publicCbFach;
        public Button publicBFachAdd;
        public TextBox publicTbEingFach;
        public ComboBox publicCbTopic;
        public Topic publicTopic;
        public TextBox publicTbTopic;
        public Subject publicFach;
        public TextBox publicTbNewTopic;
        public Label publicLNewTopic;

        private void Ubersetzer_Load(object sender, EventArgs e)
        {    
            //Überschrift und Beschreibungstext
            Label lUeberschrift = new Label();
            lUeberschrift.Text = "Übersetzer";
            lUeberschrift.Font = new Font("Arial", 12, FontStyle.Bold);
            lUeberschrift.Top = 20;
            lUeberschrift.Left = 20;
            this.Controls.Add(lUeberschrift);

            Label lBeschreibung = new Label();
            lBeschreibung.Text = "Bitte wählen Sie ein Fach aus und tippen Sie ein Wort ein.";
            lBeschreibung.Top = 50;
            lBeschreibung.Left = 20;
            lBeschreibung.MaximumSize = new Size(200, 0);
            lBeschreibung.AutoSize = true;
            this.Controls.Add(lBeschreibung);

            //DropDown-Menü Fach
            ComboBox cbFach = new ComboBox();
            publicCbFach = cbFach;
            cbFach.DisplayMember = "propName";

            for (int i = 0; i < Globals.subjects.Count; i++)
            {
                cbFach.Items.Add((Subject)Globals.subjects[i]);
            }

            cbFach.Text = "- bitte Sprache auswählen - ";
            cbFach.Top = 100;
            cbFach.Left = 20;
            cbFach.Width = 200;
            cbFach.Height = 20;
            cbFach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFach.SelectedIndexChanged += onCbSpracheSelectionChange;
            this.Controls.Add(cbFach);

            //Eingabefeld Wort was es zu Übersetzen gilt
            TextBox tbEingabe = new TextBox();
            publicTbEingabe = tbEingabe;
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
            bUebersetzen.Click += clickOnUebersetzen;
            this.Controls.Add(bUebersetzen);

            //Listbox als Anzeige der Übersetzungen
            ListBox lbUebersetzungen = new ListBox();
            publicLbUebersetzung = lbUebersetzungen;
            lbUebersetzungen.Top = 220;
            lbUebersetzungen.Left = 20;
            lbUebersetzungen.Width = 200;
            lbUebersetzungen.Height = 200;

            lbUebersetzungen.DisplayMember = "propDisplayName";
            lbUebersetzungen.ValueMember = "propTranslation";

            lbUebersetzungen.SelectedIndexChanged += onListBoxSelectionChange;
            this.Controls.Add(lbUebersetzungen);


            //Textbox für Log-Anzeige
            TextBox tbLog = new TextBox();
            publicTbLog = tbLog;
            tbLog.Top = 420;
            tbLog.Left = 20;
            tbLog.Width = 200;
            tbLog.Height = 20;
            tbLog.Enabled = false;
            this.Controls.Add(tbLog);

            //Button zum Löschen
            Button bLoeschen = new Button();
            publicBLoeschen = bLoeschen;
            bLoeschen.Text = "Löschen";
            bLoeschen.Top = 445;
            bLoeschen.Left = 20;
            bLoeschen.Width = 70;
            bLoeschen.Height = 20;
            bLoeschen.Font = new Font("Arial", 6, FontStyle.Bold);
            bLoeschen.BackColor = Color.White;
            bLoeschen.ForeColor = Color.Black;
            this.Controls.Add(bLoeschen);
            bLoeschen.Click += clickOnLoeschen;

            //Button zum Speichern
            Button bSpeichern = new Button();
            publicBSpeichern = bSpeichern;
            bSpeichern.Text = "Speichern";
            bSpeichern.Top = 445;
            bSpeichern.Left = 95;
            bSpeichern.Width = 70;
            bSpeichern.Height = 20;
            bSpeichern.Font = new Font("Arial", 6, FontStyle.Bold);
            bSpeichern.BackColor = Color.White;
            bSpeichern.ForeColor = Color.Black;
            this.Controls.Add(bSpeichern);
            bSpeichern.Click += clickOnSave;
        }

        /// <summary>
        /// Wird ausgelöst sobald man auf den Butten zum Übersetzen drückt
        /// </summary>
        private void clickOnUebersetzen(object sender, EventArgs e)
        {
            //bereite Übersetzung vor:
            string eingabe = publicTbEingabe.Text;
            int sprache = publicCbSprache.SelectedIndex;
            string laenderKuerzel; ;
            switch (sprache)
            {
                case 0:
                    laenderKuerzel = "en";
                    break;
                case 1:
                    laenderKuerzel = "fr";
                    break;
                case 2:
                    laenderKuerzel = "es";
                    break;
                default:
                    laenderKuerzel = "en";
                    break;
            }
            Vocable newVoc;
            //fülle ListBox
            if (publicTopic == null)
            {
                newVoc = new Vocable(eingabe, laenderKuerzel, new Topic(publicTbTopic.Text, publicFach));
            }
            else
            {
                newVoc = new Vocable(eingabe, laenderKuerzel, new Topic(publicTopic.propName,publicFach));
            }
            publicLbUebersetzung.Items.Add(newVoc);
           
        }

        /// <summary>
        /// Wird ausgeführt sobald man im DropDown-Menü ein Item wählt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCbSpracheSelectionChange(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            publicCbSprache = cb;
            publicFach = (Subject)cb.SelectedItem;
            string fach = ((Subject)cb.SelectedItem).propName;

            int topicCount = 0;
            for (int i = 0; i < Globals.vocs.Count; i++)
            {
               if((((Topic)((Vocable)Globals.vocs[i]).propTopic).propSubject).propName == fach)
               {
                    topicCount++;
               }
            }

            if (topicCount != 0)
            {

                if(publicTbNewTopic == null && publicLNewTopic == null )
                {
                    this.Controls.Remove(publicTbNewTopic);
                    this.Controls.Remove(publicLNewTopic);
                }
                // add DropDown-Menü Thema
                ComboBox cbTopic = new ComboBox();
                cbTopic.DisplayMember = "propName";
                publicCbTopic = cbTopic;
                for (int i = 0; i < Globals.topics.Count; i++)
                {
                    if ((((Topic)Globals.topics[i]).propSubject).propName == fach)
                    {
                        cbTopic.Items.Add((Topic)Globals.topics[i]);
                    }
                }
                cbTopic.Text = "- bitte Sprache auswählen - ";
                cbTopic.Top = 130;
                cbTopic.Left = 20;
                cbTopic.Width = 200;
                cbTopic.Height = 20;
                cbTopic.DropDownStyle = ComboBoxStyle.DropDownList;
                cbTopic.SelectedIndexChanged += onCbTopicSelectionChange;
                this.Controls.Add(cbTopic);
            }
            else
            {
                if (publicCbTopic != null)
                {
                    this.Controls.Remove(publicCbTopic);
                }
                Label l = new Label();
                publicLNewTopic = l;
                l.Text = "Neues Thema:";
                l.Top = 130;
                l.Left = 20;
                l.Width = 80;
                l.Height = 20;
                l.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(l);
                TextBox tb = new TextBox();
                publicTbNewTopic = tb;
                tb.Top = 130;
                tb.Left = 100;
                tb.Width = 120;
                tb.Height = 20;
                publicTbTopic = tb;
                this.Controls.Add(tb);
            }

            
        }

        private void onCbTopicSelectionChange(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Topic to = (Topic)cb.SelectedItem;
            publicTopic = to;
        }

        /// <summary>
        /// Wird ausgeführt sobald die Selektion in der Listbox wechselt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onListBoxSelectionChange(object sender, EventArgs e)
        {
            //wenn Mode = Löschen, dann:
            if (mode == 1)
            {
                ListBox lb = (ListBox)sender;
                if (lb.SelectedIndex != -1)
                {
                    string ausgabe = lb.GetItemText(lb.SelectedItem);
                    lb.Items.RemoveAt(lb.SelectedIndex);
                    publicTbLog.Text = ausgabe + " wurde gelöscht.";
                }
            }

            //wenn Mode = Speichern, dann:
            if (mode == 2)
            {
                ListBox lb = (ListBox)sender;
                if (lb.SelectedIndex != -1)
                {
                    Globals.vocs.Add(lb.SelectedItem);
                    string ausgabe = lb.GetItemText(lb.SelectedItem);
                    lb.Items.RemoveAt(lb.SelectedIndex);
                    publicTbLog.Text = ausgabe + " wurde gespeichert.";
                }
            }
        }

        private void clickOnLoeschen(object sender, EventArgs e)
        {
            Button bl = publicBLoeschen;
            Button bs = publicBSpeichern;
            if (mode != 1)
            {
                bl.BackColor = Color.Red;
                bl.ForeColor = Color.White;
                bs.BackColor = Color.White;
                bs.ForeColor = Color.Black;
                mode = 1;
            }
            else
            {
                bl.BackColor = Color.White;
                bl.ForeColor = Color.Black;
                mode = 0;
            }
        }

        private void clickOnSave(object sender, EventArgs e)
        {
            Button bs = publicBSpeichern;
            Button bl = publicBLoeschen;
            if (mode != 2)
            {
                bs.BackColor = Color.Blue;
                bs.ForeColor = Color.White;
                bl.BackColor = Color.White;
                bl.ForeColor = Color.Black;
                mode = 2;
            }
            else
            {
                bs.BackColor = Color.White;
                bs.ForeColor = Color.Black;
                mode = 0;
            }
        }
    }
}
