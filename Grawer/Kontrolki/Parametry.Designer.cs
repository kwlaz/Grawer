namespace Grawer.Kontrolki
{
    partial class Parametry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.czasNaPunktLabel = new System.Windows.Forms.Label();
            this.profilLabel = new System.Windows.Forms.Label();
            this.wentylatorxyLabel = new System.Windows.Forms.Label();
            this.predkoscLabel = new System.Windows.Forms.Label();
            this.mocLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.czasNaPunktTextBox = new System.Windows.Forms.TextBox();
            this.dodajProfilButton = new System.Windows.Forms.Button();
            this.profileComboBox = new System.Windows.Forms.ComboBox();
            this.wentylatorXYComboBox = new System.Windows.Forms.ComboBox();
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.predkoscTextBox = new System.Windows.Forms.TextBox();
            this.mocTextBox = new System.Windows.Forms.TextBox();
            this.usunButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.czasNaPunktLabel);
            this.splitContainer1.Panel1.Controls.Add(this.profilLabel);
            this.splitContainer1.Panel1.Controls.Add(this.wentylatorxyLabel);
            this.splitContainer1.Panel1.Controls.Add(this.predkoscLabel);
            this.splitContainer1.Panel1.Controls.Add(this.mocLabel);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.usunButton);
            this.splitContainer1.Panel2.Controls.Add(this.czasNaPunktTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.dodajProfilButton);
            this.splitContainer1.Panel2.Controls.Add(this.profileComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.wentylatorXYComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.zatwierdzButton);
            this.splitContainer1.Panel2.Controls.Add(this.predkoscTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.mocTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(900, 750);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 0;
            // 
            // czasNaPunktLabel
            // 
            this.czasNaPunktLabel.AutoSize = true;
            this.czasNaPunktLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.czasNaPunktLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.czasNaPunktLabel.Location = new System.Drawing.Point(32, 133);
            this.czasNaPunktLabel.Name = "czasNaPunktLabel";
            this.czasNaPunktLabel.Size = new System.Drawing.Size(105, 16);
            this.czasNaPunktLabel.TabIndex = 8;
            this.czasNaPunktLabel.Text = "Czas na Punkt";
            // 
            // profilLabel
            // 
            this.profilLabel.AutoSize = true;
            this.profilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profilLabel.Location = new System.Drawing.Point(32, 34);
            this.profilLabel.Name = "profilLabel";
            this.profilLabel.Size = new System.Drawing.Size(44, 16);
            this.profilLabel.TabIndex = 7;
            this.profilLabel.Text = "Profil";
            // 
            // wentylatorxyLabel
            // 
            this.wentylatorxyLabel.AutoSize = true;
            this.wentylatorxyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wentylatorxyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wentylatorxyLabel.Location = new System.Drawing.Point(31, 164);
            this.wentylatorxyLabel.Name = "wentylatorxyLabel";
            this.wentylatorxyLabel.Size = new System.Drawing.Size(82, 16);
            this.wentylatorxyLabel.TabIndex = 4;
            this.wentylatorxyLabel.Text = "Wentylator";
            // 
            // predkoscLabel
            // 
            this.predkoscLabel.AutoSize = true;
            this.predkoscLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predkoscLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.predkoscLabel.Location = new System.Drawing.Point(31, 104);
            this.predkoscLabel.Name = "predkoscLabel";
            this.predkoscLabel.Size = new System.Drawing.Size(78, 16);
            this.predkoscLabel.TabIndex = 2;
            this.predkoscLabel.Text = "Prędkość:";
            // 
            // mocLabel
            // 
            this.mocLabel.AutoSize = true;
            this.mocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mocLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mocLabel.Location = new System.Drawing.Point(31, 78);
            this.mocLabel.Name = "mocLabel";
            this.mocLabel.Size = new System.Drawing.Size(41, 16);
            this.mocLabel.TabIndex = 1;
            this.mocLabel.Text = "Moc:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(25, 750);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // czasNaPunktTextBox
            // 
            this.czasNaPunktTextBox.Location = new System.Drawing.Point(3, 128);
            this.czasNaPunktTextBox.Name = "czasNaPunktTextBox";
            this.czasNaPunktTextBox.Size = new System.Drawing.Size(179, 20);
            this.czasNaPunktTextBox.TabIndex = 9;
            this.czasNaPunktTextBox.Text = "10";
            // 
            // dodajProfilButton
            // 
            this.dodajProfilButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.dodajProfilButton.Location = new System.Drawing.Point(95, 203);
            this.dodajProfilButton.Name = "dodajProfilButton";
            this.dodajProfilButton.Size = new System.Drawing.Size(75, 23);
            this.dodajProfilButton.TabIndex = 8;
            this.dodajProfilButton.Text = "dodaj";
            this.dodajProfilButton.UseVisualStyleBackColor = true;
            this.dodajProfilButton.Click += new System.EventHandler(this.dodajProfilButton_Click);
            // 
            // profileComboBox
            // 
            this.profileComboBox.FormattingEnabled = true;
            this.profileComboBox.Location = new System.Drawing.Point(3, 34);
            this.profileComboBox.Name = "profileComboBox";
            this.profileComboBox.Size = new System.Drawing.Size(179, 21);
            this.profileComboBox.TabIndex = 7;
            this.profileComboBox.SelectedIndexChanged += new System.EventHandler(this.profileComboBox_SelectedIndexChanged);
            // 
            // wentylatorXYComboBox
            // 
            this.wentylatorXYComboBox.FormattingEnabled = true;
            this.wentylatorXYComboBox.Items.AddRange(new object[] {
            "Włączony",
            "Wyłączony"});
            this.wentylatorXYComboBox.Location = new System.Drawing.Point(3, 164);
            this.wentylatorXYComboBox.Name = "wentylatorXYComboBox";
            this.wentylatorXYComboBox.Size = new System.Drawing.Size(179, 21);
            this.wentylatorXYComboBox.TabIndex = 4;
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(3, 203);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(86, 23);
            this.zatwierdzButton.TabIndex = 3;
            this.zatwierdzButton.Text = "Aktualizuj";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // predkoscTextBox
            // 
            this.predkoscTextBox.Location = new System.Drawing.Point(3, 104);
            this.predkoscTextBox.MaxLength = 4;
            this.predkoscTextBox.Name = "predkoscTextBox";
            this.predkoscTextBox.Size = new System.Drawing.Size(179, 20);
            this.predkoscTextBox.TabIndex = 1;
            this.predkoscTextBox.Text = "1200";
            this.predkoscTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mocTextBox_KeyPress);
            // 
            // mocTextBox
            // 
            this.mocTextBox.Location = new System.Drawing.Point(3, 74);
            this.mocTextBox.MaxLength = 3;
            this.mocTextBox.Name = "mocTextBox";
            this.mocTextBox.Size = new System.Drawing.Size(179, 20);
            this.mocTextBox.TabIndex = 0;
            this.mocTextBox.Text = "100";
            this.mocTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mocTextBox_KeyPress);
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(176, 203);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(75, 23);
            this.usunButton.TabIndex = 10;
            this.usunButton.Text = "Usuń";
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // Parametry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Parametry";
            this.Size = new System.Drawing.Size(900, 750);
            this.Load += new System.EventHandler(this.Parametry_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label wentylatorxyLabel;
        private System.Windows.Forms.Label predkoscLabel;
        private System.Windows.Forms.Label mocLabel;
        private System.Windows.Forms.TextBox mocTextBox;
        private System.Windows.Forms.TextBox predkoscTextBox;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.ComboBox wentylatorXYComboBox;
        private System.Windows.Forms.Label profilLabel;
        private System.Windows.Forms.ComboBox profileComboBox;
        private System.Windows.Forms.Button dodajProfilButton;
        private System.Windows.Forms.Label czasNaPunktLabel;
        private System.Windows.Forms.TextBox czasNaPunktTextBox;
        private System.Windows.Forms.Button usunButton;
    }
}
