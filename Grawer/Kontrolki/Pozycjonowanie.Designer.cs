namespace Grawer.Kontrolki
{
    partial class Pozycjonowanie
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
            this.skokTextBox = new System.Windows.Forms.TextBox();
            this.pozPanel = new System.Windows.Forms.Panel();
            this.skokRightArrowButton = new Grawer.Kontrolki.RightArrowButton();
            this.skokUpArrowButton = new Grawer.Kontrolki.UpArrowButton();
            this.skokLeftArrowButton = new Grawer.Kontrolki.LeftArrowButton();
            this.skokDownArrowButton = new Grawer.Kontrolki.DownArrowButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.portyComboBox = new System.Windows.Forms.ComboBox();
            this.polaczButton = new System.Windows.Forms.Button();
            this.odswiezButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ekrankonsoliTextBox = new System.Windows.Forms.TextBox();
            this.konsolTextBox = new System.Windows.Forms.TextBox();
            this.wyslijButton = new System.Windows.Forms.Button();
            this.konsolaPanel = new System.Windows.Forms.Panel();
            this.pozPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.konsolaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // skokTextBox
            // 
            this.skokTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skokTextBox.Location = new System.Drawing.Point(89, 105);
            this.skokTextBox.MaxLength = 3;
            this.skokTextBox.Name = "skokTextBox";
            this.skokTextBox.Size = new System.Drawing.Size(73, 38);
            this.skokTextBox.TabIndex = 4;
            this.skokTextBox.Text = "5";
            this.skokTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skokTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skokTextBox_KeyPress);
            // 
            // pozPanel
            // 
            this.pozPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pozPanel.Controls.Add(this.skokTextBox);
            this.pozPanel.Controls.Add(this.skokRightArrowButton);
            this.pozPanel.Controls.Add(this.skokUpArrowButton);
            this.pozPanel.Controls.Add(this.skokLeftArrowButton);
            this.pozPanel.Controls.Add(this.skokDownArrowButton);
            this.pozPanel.Location = new System.Drawing.Point(461, 40);
            this.pozPanel.Name = "pozPanel";
            this.pozPanel.Size = new System.Drawing.Size(253, 253);
            this.pozPanel.TabIndex = 10;
            this.pozPanel.Visible = false;
            // 
            // skokRightArrowButton
            // 
            this.skokRightArrowButton.BackColor = System.Drawing.Color.Lime;
            this.skokRightArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skokRightArrowButton.Location = new System.Drawing.Point(168, 83);
            this.skokRightArrowButton.Name = "skokRightArrowButton";
            this.skokRightArrowButton.Size = new System.Drawing.Size(70, 80);
            this.skokRightArrowButton.TabIndex = 9;
            this.skokRightArrowButton.Text = "X+";
            this.skokRightArrowButton.UseVisualStyleBackColor = false;
            this.skokRightArrowButton.Click += new System.EventHandler(this.skokRightArrowButton_Click);
            this.skokRightArrowButton.MouseEnter += new System.EventHandler(this.skokRightArrowButton_MouseEnter);
            this.skokRightArrowButton.MouseLeave += new System.EventHandler(this.skokRightArrowButton_MouseLeave);
            // 
            // skokUpArrowButton
            // 
            this.skokUpArrowButton.BackColor = System.Drawing.Color.Lime;
            this.skokUpArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skokUpArrowButton.Location = new System.Drawing.Point(88, 8);
            this.skokUpArrowButton.Name = "skokUpArrowButton";
            this.skokUpArrowButton.Size = new System.Drawing.Size(80, 70);
            this.skokUpArrowButton.TabIndex = 5;
            this.skokUpArrowButton.Text = "Y+";
            this.skokUpArrowButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skokUpArrowButton.UseVisualStyleBackColor = false;
            this.skokUpArrowButton.Click += new System.EventHandler(this.skokUpArrowButton_Click);
            this.skokUpArrowButton.MouseEnter += new System.EventHandler(this.skokUpArrowButton_MouseEnter);
            this.skokUpArrowButton.MouseLeave += new System.EventHandler(this.skokUpArrowButton_MouseLeave);
            // 
            // skokLeftArrowButton
            // 
            this.skokLeftArrowButton.BackColor = System.Drawing.Color.Lime;
            this.skokLeftArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skokLeftArrowButton.Location = new System.Drawing.Point(13, 83);
            this.skokLeftArrowButton.Name = "skokLeftArrowButton";
            this.skokLeftArrowButton.Size = new System.Drawing.Size(70, 80);
            this.skokLeftArrowButton.TabIndex = 8;
            this.skokLeftArrowButton.Text = "X-";
            this.skokLeftArrowButton.UseVisualStyleBackColor = false;
            this.skokLeftArrowButton.Click += new System.EventHandler(this.skokLeftArrowButton_Click);
            this.skokLeftArrowButton.MouseEnter += new System.EventHandler(this.skokLeftArrowButton_MouseEnter);
            this.skokLeftArrowButton.MouseLeave += new System.EventHandler(this.skokLeftArrowButton_MouseLeave);
            // 
            // skokDownArrowButton
            // 
            this.skokDownArrowButton.BackColor = System.Drawing.Color.Lime;
            this.skokDownArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skokDownArrowButton.Location = new System.Drawing.Point(88, 168);
            this.skokDownArrowButton.Name = "skokDownArrowButton";
            this.skokDownArrowButton.Size = new System.Drawing.Size(80, 70);
            this.skokDownArrowButton.TabIndex = 6;
            this.skokDownArrowButton.Text = "Y-";
            this.skokDownArrowButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skokDownArrowButton.UseVisualStyleBackColor = false;
            this.skokDownArrowButton.Click += new System.EventHandler(this.skokDownArrowButton_Click);
            this.skokDownArrowButton.MouseEnter += new System.EventHandler(this.skokDownArrowButton_MouseEnter);
            this.skokDownArrowButton.MouseLeave += new System.EventHandler(this.skokDownArrowButton_MouseLeave);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(25, 750);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 750);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // portyComboBox
            // 
            this.portyComboBox.FormattingEnabled = true;
            this.portyComboBox.Location = new System.Drawing.Point(164, 34);
            this.portyComboBox.Name = "portyComboBox";
            this.portyComboBox.Size = new System.Drawing.Size(121, 21);
            this.portyComboBox.TabIndex = 1;
            // 
            // polaczButton
            // 
            this.polaczButton.Location = new System.Drawing.Point(165, 62);
            this.polaczButton.Name = "polaczButton";
            this.polaczButton.Size = new System.Drawing.Size(150, 23);
            this.polaczButton.TabIndex = 13;
            this.polaczButton.Text = "Połącz";
            this.polaczButton.UseVisualStyleBackColor = true;
            this.polaczButton.Click += new System.EventHandler(this.polaczButton_Click);
            // 
            // odswiezButton
            // 
            this.odswiezButton.Location = new System.Drawing.Point(292, 34);
            this.odswiezButton.Name = "odswiezButton";
            this.odswiezButton.Size = new System.Drawing.Size(23, 22);
            this.odswiezButton.TabIndex = 14;
            this.odswiezButton.Text = "O";
            this.odswiezButton.UseVisualStyleBackColor = true;
            this.odswiezButton.Click += new System.EventHandler(this.odswiezButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(344, 40);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(111, 16);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Nie połączono";
            // 
            // ekrankonsoliTextBox
            // 
            this.ekrankonsoliTextBox.Location = new System.Drawing.Point(3, 3);
            this.ekrankonsoliTextBox.Multiline = true;
            this.ekrankonsoliTextBox.Name = "ekrankonsoliTextBox";
            this.ekrankonsoliTextBox.ReadOnly = true;
            this.ekrankonsoliTextBox.Size = new System.Drawing.Size(690, 216);
            this.ekrankonsoliTextBox.TabIndex = 15;
            // 
            // konsolTextBox
            // 
            this.konsolTextBox.Location = new System.Drawing.Point(3, 224);
            this.konsolTextBox.Name = "konsolTextBox";
            this.konsolTextBox.Size = new System.Drawing.Size(576, 20);
            this.konsolTextBox.TabIndex = 16;
            this.konsolTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.konsolTextBox_KeyDown);
            // 
            // wyslijButton
            // 
            this.wyslijButton.Location = new System.Drawing.Point(585, 224);
            this.wyslijButton.Name = "wyslijButton";
            this.wyslijButton.Size = new System.Drawing.Size(108, 20);
            this.wyslijButton.TabIndex = 17;
            this.wyslijButton.Text = "Wyslij";
            this.wyslijButton.UseVisualStyleBackColor = true;
            this.wyslijButton.Click += new System.EventHandler(this.wyslijButton_Click);
            // 
            // konsolaPanel
            // 
            this.konsolaPanel.Controls.Add(this.wyslijButton);
            this.konsolaPanel.Controls.Add(this.konsolTextBox);
            this.konsolaPanel.Controls.Add(this.ekrankonsoliTextBox);
            this.konsolaPanel.Location = new System.Drawing.Point(165, 496);
            this.konsolaPanel.Name = "konsolaPanel";
            this.konsolaPanel.Size = new System.Drawing.Size(707, 251);
            this.konsolaPanel.TabIndex = 18;
            this.konsolaPanel.Visible = false;
            // 
            // Pozycjonowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.konsolaPanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.odswiezButton);
            this.Controls.Add(this.polaczButton);
            this.Controls.Add(this.portyComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pozPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Pozycjonowanie";
            this.Size = new System.Drawing.Size(900, 750);
            this.Load += new System.EventHandler(this.Pozycjonowanie_Load);
            this.pozPanel.ResumeLayout(false);
            this.pozPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.konsolaPanel.ResumeLayout(false);
            this.konsolaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox skokTextBox;
        private UpArrowButton skokUpArrowButton;
        private DownArrowButton skokDownArrowButton;
        private LeftArrowButton skokLeftArrowButton;
        private RightArrowButton skokRightArrowButton;
        private System.Windows.Forms.Panel pozPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portyComboBox;
        private System.Windows.Forms.Button polaczButton;
        private System.Windows.Forms.Button odswiezButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox ekrankonsoliTextBox;
        private System.Windows.Forms.TextBox konsolTextBox;
        private System.Windows.Forms.Button wyslijButton;
        private System.Windows.Forms.Panel konsolaPanel;
    }
}
