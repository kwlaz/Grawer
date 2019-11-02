namespace Grawer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lewypanel = new System.Windows.Forms.Panel();
            this.czerwonyPanel = new System.Windows.Forms.Panel();
            this.grawerujButton = new System.Windows.Forms.Button();
            this.polaczenieButton = new System.Windows.Forms.Button();
            this.paramertryButton = new System.Windows.Forms.Button();
            this.obrazButton = new System.Windows.Forms.Button();
            this.logopanel = new System.Windows.Forms.Panel();
            this.gornypanel = new System.Windows.Forms.Panel();
            this._label = new System.Windows.Forms.Label();
            this.xlabel = new System.Windows.Forms.Label();
            this.contenerPanel = new System.Windows.Forms.Panel();
            this.podsumowanie = new Grawer.Kontrolki.Podsumowanie();
            this.pozycjonowanie = new Grawer.Kontrolki.Pozycjonowanie();
            this.parametry = new Grawer.Kontrolki.Parametry();
            this.obraz = new Grawer.Kontrolki.Obraz();
            this.lewypanel.SuspendLayout();
            this.gornypanel.SuspendLayout();
            this.contenerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lewypanel
            // 
            this.lewypanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lewypanel.Controls.Add(this.czerwonyPanel);
            this.lewypanel.Controls.Add(this.grawerujButton);
            this.lewypanel.Controls.Add(this.polaczenieButton);
            this.lewypanel.Controls.Add(this.paramertryButton);
            this.lewypanel.Controls.Add(this.obrazButton);
            this.lewypanel.Controls.Add(this.logopanel);
            resources.ApplyResources(this.lewypanel, "lewypanel");
            this.lewypanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lewypanel.Name = "lewypanel";
            // 
            // czerwonyPanel
            // 
            this.czerwonyPanel.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.czerwonyPanel, "czerwonyPanel");
            this.czerwonyPanel.Name = "czerwonyPanel";
            // 
            // grawerujButton
            // 
            this.grawerujButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.grawerujButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.grawerujButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.grawerujButton, "grawerujButton");
            this.grawerujButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grawerujButton.Name = "grawerujButton";
            this.grawerujButton.UseVisualStyleBackColor = true;
            this.grawerujButton.Click += new System.EventHandler(this.grawerujButton_Click);
            // 
            // polaczenieButton
            // 
            this.polaczenieButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.polaczenieButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.polaczenieButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.polaczenieButton, "polaczenieButton");
            this.polaczenieButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polaczenieButton.Name = "polaczenieButton";
            this.polaczenieButton.UseVisualStyleBackColor = true;
            this.polaczenieButton.Click += new System.EventHandler(this.polaczenieButton_Click);
            // 
            // paramertryButton
            // 
            this.paramertryButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.paramertryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.paramertryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.paramertryButton, "paramertryButton");
            this.paramertryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paramertryButton.Name = "paramertryButton";
            this.paramertryButton.UseVisualStyleBackColor = true;
            this.paramertryButton.Click += new System.EventHandler(this.paramertryButton_Click);
            // 
            // obrazButton
            // 
            this.obrazButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.obrazButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.obrazButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.obrazButton, "obrazButton");
            this.obrazButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.obrazButton.Name = "obrazButton";
            this.obrazButton.UseVisualStyleBackColor = true;
            this.obrazButton.Click += new System.EventHandler(this.obrazButton_Click);
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.logopanel, "logopanel");
            this.logopanel.Name = "logopanel";
            // 
            // gornypanel
            // 
            this.gornypanel.BackColor = System.Drawing.Color.Maroon;
            this.gornypanel.Controls.Add(this._label);
            this.gornypanel.Controls.Add(this.xlabel);
            resources.ApplyResources(this.gornypanel, "gornypanel");
            this.gornypanel.Name = "gornypanel";
            this.gornypanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gornypanel_MouseDown);
            this.gornypanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gornypanel_MouseMove);
            this.gornypanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gornypanel_MouseUp);
            // 
            // _label
            // 
            resources.ApplyResources(this._label, "_label");
            this._label.Name = "_label";
            this._label.Click += new System.EventHandler(this._label_Click);
            this._label.MouseEnter += new System.EventHandler(this.mouseEnterZM);
            this._label.MouseLeave += new System.EventHandler(this.mouseLeaveZM);
            // 
            // xlabel
            // 
            resources.ApplyResources(this.xlabel, "xlabel");
            this.xlabel.Name = "xlabel";
            this.xlabel.Click += new System.EventHandler(this.xlabel_Click);
            this.xlabel.MouseEnter += new System.EventHandler(this.mouseEnterZM);
            this.xlabel.MouseLeave += new System.EventHandler(this.mouseLeaveZM);
            // 
            // contenerPanel
            // 
            this.contenerPanel.Controls.Add(this.podsumowanie);
            this.contenerPanel.Controls.Add(this.pozycjonowanie);
            this.contenerPanel.Controls.Add(this.parametry);
            this.contenerPanel.Controls.Add(this.obraz);
            resources.ApplyResources(this.contenerPanel, "contenerPanel");
            this.contenerPanel.Name = "contenerPanel";
            // 
            // podsumowanie
            // 
            this.podsumowanie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.podsumowanie, "podsumowanie");
            this.podsumowanie.Name = "podsumowanie";
            // 
            // pozycjonowanie
            // 
            this.pozycjonowanie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pozycjonowanie.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.pozycjonowanie, "pozycjonowanie");
            this.pozycjonowanie.Name = "pozycjonowanie";
            // 
            // parametry
            // 
            this.parametry.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.parametry, "parametry");
            this.parametry.Name = "parametry";
            // 
            // obraz
            // 
            this.obraz.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.obraz, "obraz");
            this.obraz.Name = "obraz";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.contenerPanel);
            this.Controls.Add(this.gornypanel);
            this.Controls.Add(this.lewypanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.lewypanel.ResumeLayout(false);
            this.gornypanel.ResumeLayout(false);
            this.gornypanel.PerformLayout();
            this.contenerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lewypanel;
        private System.Windows.Forms.Button obrazButton;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel gornypanel;
        private System.Windows.Forms.Button grawerujButton;
        private System.Windows.Forms.Button polaczenieButton;
        private System.Windows.Forms.Button paramertryButton;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Panel contenerPanel;
        private System.Windows.Forms.Panel czerwonyPanel;
        private Kontrolki.Pozycjonowanie pozycjonowanie;
        private Kontrolki.Parametry parametry;
        private Kontrolki.Obraz obraz;
        private Kontrolki.Podsumowanie podsumowanie;
    }
}

