namespace Vokabeltrainer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wortÜbersetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wortÜbersetzenToolStripMenuItem,
            this.lernenToolStripMenuItem,
            this.testSimulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wortÜbersetzenToolStripMenuItem
            // 
            this.wortÜbersetzenToolStripMenuItem.Name = "wortÜbersetzenToolStripMenuItem";
            this.wortÜbersetzenToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.wortÜbersetzenToolStripMenuItem.Text = "Wort übersetzen";
            this.wortÜbersetzenToolStripMenuItem.Click += new System.EventHandler(this.wortÜbersetzenToolStripMenuItem_Click);
            // 
            // lernenToolStripMenuItem
            // 
            this.lernenToolStripMenuItem.Name = "lernenToolStripMenuItem";
            this.lernenToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.lernenToolStripMenuItem.Text = "Lernen";
            // 
            // testSimulationToolStripMenuItem
            // 
            this.testSimulationToolStripMenuItem.Name = "testSimulationToolStripMenuItem";
            this.testSimulationToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.testSimulationToolStripMenuItem.Text = "Test-Simulation";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(311, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wortÜbersetzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testSimulationToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListView listView1;
    }
}

