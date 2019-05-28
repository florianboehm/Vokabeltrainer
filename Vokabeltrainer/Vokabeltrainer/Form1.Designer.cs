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
            this.wortÜbersetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bUebersetzer = new System.Windows.Forms.Button();
            this.bFach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // wortÜbersetzenToolStripMenuItem
            // 
            this.wortÜbersetzenToolStripMenuItem.Name = "wortÜbersetzenToolStripMenuItem";
            this.wortÜbersetzenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // lernenToolStripMenuItem
            // 
            this.lernenToolStripMenuItem.Name = "lernenToolStripMenuItem";
            this.lernenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // testSimulationToolStripMenuItem
            // 
            this.testSimulationToolStripMenuItem.Name = "testSimulationToolStripMenuItem";
            this.testSimulationToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bUebersetzer
            // 
            this.bUebersetzer.Location = new System.Drawing.Point(0, 0);
            this.bUebersetzer.Name = "bUebersetzer";
            this.bUebersetzer.Size = new System.Drawing.Size(212, 212);
            this.bUebersetzer.TabIndex = 0;
            this.bUebersetzer.Text = "Übersetzer";
            this.bUebersetzer.UseVisualStyleBackColor = true;
            this.bUebersetzer.Click += new System.EventHandler(this.bUebersetzer_Click);
            // 
            // bFach
            // 
            this.bFach.Location = new System.Drawing.Point(211, 0);
            this.bFach.Name = "bFach";
            this.bFach.Size = new System.Drawing.Size(212, 212);
            this.bFach.TabIndex = 1;
            this.bFach.Text = "Fach bearbeiten/hinzufügen";
            this.bFach.UseVisualStyleBackColor = true;
            this.bFach.Click += new System.EventHandler(this.bFach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 507);
            this.Controls.Add(this.bFach);
            this.Controls.Add(this.bUebersetzer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem wortÜbersetzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testSimulationToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button bUebersetzer;
        private System.Windows.Forms.Button bFach;
    }
}

