namespace Grawer.Kontrolki
{
    partial class Obraz
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
            this.dolPanel = new System.Windows.Forms.Panel();
            this.resetJasnoscButton = new System.Windows.Forms.Button();
            this.jasnoscTrackBar = new System.Windows.Forms.TrackBar();
            this.resetKontrastButton = new System.Windows.Forms.Button();
            this.kontrastLabel = new System.Windows.Forms.Label();
            this.jasnoscLabel = new System.Windows.Forms.Label();
            this.kontrastTrackBar = new System.Windows.Forms.TrackBar();
            this.podgladPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sciezkaLabel = new System.Windows.Forms.Label();
            this.parametryPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rozdzielczoscTextBox = new System.Windows.Forms.TextBox();
            this.progPanel = new System.Windows.Forms.Panel();
            this.progTexBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.progTrackBar = new System.Windows.Forms.TrackBar();
            this.podgladButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.szpxTextBox = new System.Windows.Forms.TextBox();
            this.wyspxTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.szeTextBox = new System.Windows.Forms.TextBox();
            this.wysTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.algorytmLabel = new System.Windows.Forms.Label();
            this.algorytmComboBox = new System.Windows.Forms.ComboBox();
            this.lewoButton = new System.Windows.Forms.Button();
            this.prawoButton = new System.Windows.Forms.Button();
            this.skalujButton = new System.Windows.Forms.Button();
            this.nowyButton = new System.Windows.Forms.Button();
            this.otworzButton = new System.Windows.Forms.Button();
            this.dolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jasnoscTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podgladPictureBox)).BeginInit();
            this.parametryPanel.SuspendLayout();
            this.progPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // dolPanel
            // 
            this.dolPanel.Controls.Add(this.resetJasnoscButton);
            this.dolPanel.Controls.Add(this.jasnoscTrackBar);
            this.dolPanel.Controls.Add(this.resetKontrastButton);
            this.dolPanel.Controls.Add(this.kontrastLabel);
            this.dolPanel.Controls.Add(this.jasnoscLabel);
            this.dolPanel.Controls.Add(this.kontrastTrackBar);
            this.dolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dolPanel.Location = new System.Drawing.Point(0, 650);
            this.dolPanel.Name = "dolPanel";
            this.dolPanel.Size = new System.Drawing.Size(900, 100);
            this.dolPanel.TabIndex = 15;
            // 
            // resetJasnoscButton
            // 
            this.resetJasnoscButton.Location = new System.Drawing.Point(622, 8);
            this.resetJasnoscButton.Name = "resetJasnoscButton";
            this.resetJasnoscButton.Size = new System.Drawing.Size(75, 23);
            this.resetJasnoscButton.TabIndex = 6;
            this.resetJasnoscButton.Text = "Reset";
            this.resetJasnoscButton.UseVisualStyleBackColor = true;
            this.resetJasnoscButton.Click += new System.EventHandler(this.resetJasnoscButton_Click);
            // 
            // jasnoscTrackBar
            // 
            this.jasnoscTrackBar.Location = new System.Drawing.Point(103, 5);
            this.jasnoscTrackBar.Maximum = 255;
            this.jasnoscTrackBar.Minimum = -255;
            this.jasnoscTrackBar.Name = "jasnoscTrackBar";
            this.jasnoscTrackBar.Size = new System.Drawing.Size(521, 45);
            this.jasnoscTrackBar.TabIndex = 5;
            this.jasnoscTrackBar.ValueChanged += new System.EventHandler(this.jasnoscTrackBar_ValueChanged);
            // 
            // resetKontrastButton
            // 
            this.resetKontrastButton.Location = new System.Drawing.Point(622, 56);
            this.resetKontrastButton.Name = "resetKontrastButton";
            this.resetKontrastButton.Size = new System.Drawing.Size(75, 23);
            this.resetKontrastButton.TabIndex = 4;
            this.resetKontrastButton.Text = "Reset";
            this.resetKontrastButton.UseVisualStyleBackColor = true;
            this.resetKontrastButton.Click += new System.EventHandler(this.resetKontrastButton_Click);
            // 
            // kontrastLabel
            // 
            this.kontrastLabel.AutoSize = true;
            this.kontrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontrastLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kontrastLabel.Location = new System.Drawing.Point(18, 52);
            this.kontrastLabel.Name = "kontrastLabel";
            this.kontrastLabel.Size = new System.Drawing.Size(56, 16);
            this.kontrastLabel.TabIndex = 3;
            this.kontrastLabel.Text = "Kontrast";
            // 
            // jasnoscLabel
            // 
            this.jasnoscLabel.AutoSize = true;
            this.jasnoscLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jasnoscLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jasnoscLabel.Location = new System.Drawing.Point(18, 5);
            this.jasnoscLabel.Name = "jasnoscLabel";
            this.jasnoscLabel.Size = new System.Drawing.Size(59, 16);
            this.jasnoscLabel.TabIndex = 2;
            this.jasnoscLabel.Text = "Jasność";
            // 
            // kontrastTrackBar
            // 
            this.kontrastTrackBar.Location = new System.Drawing.Point(103, 52);
            this.kontrastTrackBar.Maximum = 255;
            this.kontrastTrackBar.Minimum = -255;
            this.kontrastTrackBar.Name = "kontrastTrackBar";
            this.kontrastTrackBar.Size = new System.Drawing.Size(521, 45);
            this.kontrastTrackBar.TabIndex = 1;
            this.kontrastTrackBar.ValueChanged += new System.EventHandler(this.kontrastTrackBar_ValueChanged);
            // 
            // podgladPictureBox
            // 
            this.podgladPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.podgladPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.podgladPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.podgladPictureBox.Location = new System.Drawing.Point(0, 0);
            this.podgladPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.podgladPictureBox.Name = "podgladPictureBox";
            this.podgladPictureBox.Size = new System.Drawing.Size(650, 650);
            this.podgladPictureBox.TabIndex = 16;
            this.podgladPictureBox.TabStop = false;
            this.podgladPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.podgladPictureBox_DragDrop);
            this.podgladPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.podgladPictureBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ścieżka";
            // 
            // sciezkaLabel
            // 
            this.sciezkaLabel.AutoSize = true;
            this.sciezkaLabel.Location = new System.Drawing.Point(61, 54);
            this.sciezkaLabel.Name = "sciezkaLabel";
            this.sciezkaLabel.Size = new System.Drawing.Size(15, 13);
            this.sciezkaLabel.TabIndex = 18;
            this.sciezkaLabel.Text = ":/";
            // 
            // parametryPanel
            // 
            this.parametryPanel.Controls.Add(this.label12);
            this.parametryPanel.Controls.Add(this.label3);
            this.parametryPanel.Controls.Add(this.rozdzielczoscTextBox);
            this.parametryPanel.Controls.Add(this.progPanel);
            this.parametryPanel.Controls.Add(this.podgladButton);
            this.parametryPanel.Controls.Add(this.label7);
            this.parametryPanel.Controls.Add(this.label8);
            this.parametryPanel.Controls.Add(this.label9);
            this.parametryPanel.Controls.Add(this.label10);
            this.parametryPanel.Controls.Add(this.szpxTextBox);
            this.parametryPanel.Controls.Add(this.wyspxTextBox);
            this.parametryPanel.Controls.Add(this.label6);
            this.parametryPanel.Controls.Add(this.label2);
            this.parametryPanel.Controls.Add(this.label5);
            this.parametryPanel.Controls.Add(this.label4);
            this.parametryPanel.Controls.Add(this.szeTextBox);
            this.parametryPanel.Controls.Add(this.wysTextBox);
            this.parametryPanel.Controls.Add(this.panel1);
            this.parametryPanel.Controls.Add(this.algorytmLabel);
            this.parametryPanel.Controls.Add(this.algorytmComboBox);
            this.parametryPanel.Controls.Add(this.lewoButton);
            this.parametryPanel.Controls.Add(this.prawoButton);
            this.parametryPanel.Controls.Add(this.skalujButton);
            this.parametryPanel.Controls.Add(this.nowyButton);
            this.parametryPanel.Controls.Add(this.otworzButton);
            this.parametryPanel.Controls.Add(this.label1);
            this.parametryPanel.Controls.Add(this.sciezkaLabel);
            this.parametryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.parametryPanel.Location = new System.Drawing.Point(650, 0);
            this.parametryPanel.Name = "parametryPanel";
            this.parametryPanel.Size = new System.Drawing.Size(250, 650);
            this.parametryPanel.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(205, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Rozmiar piksela";
            // 
            // rozdzielczoscTextBox
            // 
            this.rozdzielczoscTextBox.Location = new System.Drawing.Point(126, 115);
            this.rozdzielczoscTextBox.Name = "rozdzielczoscTextBox";
            this.rozdzielczoscTextBox.Size = new System.Drawing.Size(70, 20);
            this.rozdzielczoscTextBox.TabIndex = 47;
            this.rozdzielczoscTextBox.Text = "0.2";
            this.rozdzielczoscTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rozdzielczoscTextBox_KeyDown);
            this.rozdzielczoscTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rozdzielczoscTextBox_KeyPress);
            this.rozdzielczoscTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.rozdzielczoscTextBox_Validating);
            // 
            // progPanel
            // 
            this.progPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progPanel.Controls.Add(this.progTexBox);
            this.progPanel.Controls.Add(this.label11);
            this.progPanel.Controls.Add(this.progTrackBar);
            this.progPanel.Location = new System.Drawing.Point(15, 329);
            this.progPanel.Name = "progPanel";
            this.progPanel.Size = new System.Drawing.Size(223, 102);
            this.progPanel.TabIndex = 45;
            // 
            // progTexBox
            // 
            this.progTexBox.Location = new System.Drawing.Point(113, 26);
            this.progTexBox.Name = "progTexBox";
            this.progTexBox.Size = new System.Drawing.Size(100, 20);
            this.progTexBox.TabIndex = 2;
            this.progTexBox.Text = "127";
            this.progTexBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.progTexBox_KeyDown);
            this.progTexBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.progTexBox_KeyPress);
            this.progTexBox.Validating += new System.ComponentModel.CancelEventHandler(this.progTextBox_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(23, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Próg:";
            // 
            // progTrackBar
            // 
            this.progTrackBar.Location = new System.Drawing.Point(3, 52);
            this.progTrackBar.Maximum = 255;
            this.progTrackBar.Name = "progTrackBar";
            this.progTrackBar.Size = new System.Drawing.Size(216, 45);
            this.progTrackBar.TabIndex = 0;
            this.progTrackBar.Value = 127;
            this.progTrackBar.ValueChanged += new System.EventHandler(this.progTrackBar_ValueChanged);
            // 
            // podgladButton
            // 
            this.podgladButton.Location = new System.Drawing.Point(145, 299);
            this.podgladButton.Name = "podgladButton";
            this.podgladButton.Size = new System.Drawing.Size(75, 23);
            this.podgladButton.TabIndex = 44;
            this.podgladButton.Text = "Podgląd";
            this.podgladButton.UseVisualStyleBackColor = true;
            this.podgladButton.Click += new System.EventHandler(this.podgladButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(166, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "px";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(166, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "px";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(13, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Szerokość";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(13, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Wysokość";
            // 
            // szpxTextBox
            // 
            this.szpxTextBox.Location = new System.Drawing.Point(91, 200);
            this.szpxTextBox.Name = "szpxTextBox";
            this.szpxTextBox.Size = new System.Drawing.Size(70, 20);
            this.szpxTextBox.TabIndex = 39;
            this.szpxTextBox.Text = "0";
            this.szpxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.szpxTextBox_KeyPress);
            this.szpxTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.szpxTextBox_Validating);
            // 
            // wyspxTextBox
            // 
            this.wyspxTextBox.Location = new System.Drawing.Point(91, 175);
            this.wyspxTextBox.Name = "wyspxTextBox";
            this.wyspxTextBox.Size = new System.Drawing.Size(70, 20);
            this.wyspxTextBox.TabIndex = 38;
            this.wyspxTextBox.Text = "0";
            this.wyspxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wyspxTextBox_KeyPress);
            this.wyspxTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.wyspxTextBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(166, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(166, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Szerokość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Wysokość";
            // 
            // szeTextBox
            // 
            this.szeTextBox.Location = new System.Drawing.Point(91, 251);
            this.szeTextBox.Name = "szeTextBox";
            this.szeTextBox.Size = new System.Drawing.Size(70, 20);
            this.szeTextBox.TabIndex = 33;
            this.szeTextBox.Text = "0";
            this.szeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.szeTextBox_KeyPress);
            this.szeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.szeTextBox_Validating);
            // 
            // wysTextBox
            // 
            this.wysTextBox.Location = new System.Drawing.Point(91, 226);
            this.wysTextBox.Name = "wysTextBox";
            this.wysTextBox.Size = new System.Drawing.Size(70, 20);
            this.wysTextBox.TabIndex = 32;
            this.wysTextBox.Text = "0";
            this.wysTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wysTextBox_KeyPress);
            this.wysTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.wysTextBox_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(8, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 30;
            // 
            // algorytmLabel
            // 
            this.algorytmLabel.AutoSize = true;
            this.algorytmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorytmLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.algorytmLabel.Location = new System.Drawing.Point(15, 282);
            this.algorytmLabel.Name = "algorytmLabel";
            this.algorytmLabel.Size = new System.Drawing.Size(61, 16);
            this.algorytmLabel.TabIndex = 25;
            this.algorytmLabel.Text = "Algorytm";
            // 
            // algorytmComboBox
            // 
            this.algorytmComboBox.FormattingEnabled = true;
            this.algorytmComboBox.Items.AddRange(new object[] {
            "Stucki",
            "Floyd-Steinberg",
            "Progowe"});
            this.algorytmComboBox.Location = new System.Drawing.Point(15, 301);
            this.algorytmComboBox.Name = "algorytmComboBox";
            this.algorytmComboBox.Size = new System.Drawing.Size(121, 21);
            this.algorytmComboBox.TabIndex = 24;
            this.algorytmComboBox.SelectedIndexChanged += new System.EventHandler(this.algorytmComboBox_SelectedIndexChanged);
            // 
            // lewoButton
            // 
            this.lewoButton.BackgroundImage = global::Grawer.Properties.Resources.obrotLewo;
            this.lewoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lewoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lewoButton.Location = new System.Drawing.Point(91, 3);
            this.lewoButton.Name = "lewoButton";
            this.lewoButton.Size = new System.Drawing.Size(32, 32);
            this.lewoButton.TabIndex = 23;
            this.lewoButton.UseVisualStyleBackColor = true;
            this.lewoButton.Click += new System.EventHandler(this.lewoButton_Click);
            // 
            // prawoButton
            // 
            this.prawoButton.BackgroundImage = global::Grawer.Properties.Resources.obrotPrawo;
            this.prawoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prawoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prawoButton.Location = new System.Drawing.Point(129, 3);
            this.prawoButton.Name = "prawoButton";
            this.prawoButton.Size = new System.Drawing.Size(32, 32);
            this.prawoButton.TabIndex = 22;
            this.prawoButton.UseVisualStyleBackColor = true;
            this.prawoButton.Click += new System.EventHandler(this.prawoButton_Click);
            // 
            // skalujButton
            // 
            this.skalujButton.BackgroundImage = global::Grawer.Properties.Resources.skaluj;
            this.skalujButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skalujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skalujButton.Location = new System.Drawing.Point(207, 239);
            this.skalujButton.Name = "skalujButton";
            this.skalujButton.Size = new System.Drawing.Size(32, 32);
            this.skalujButton.TabIndex = 21;
            this.skalujButton.UseVisualStyleBackColor = true;
            this.skalujButton.Click += new System.EventHandler(this.skalujButton_Click);
            // 
            // nowyButton
            // 
            this.nowyButton.BackgroundImage = global::Grawer.Properties.Resources.Nowy;
            this.nowyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nowyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nowyButton.Location = new System.Drawing.Point(53, 3);
            this.nowyButton.Name = "nowyButton";
            this.nowyButton.Size = new System.Drawing.Size(32, 32);
            this.nowyButton.TabIndex = 20;
            this.nowyButton.UseVisualStyleBackColor = true;
            this.nowyButton.Click += new System.EventHandler(this.nowyButton_Click);
            // 
            // otworzButton
            // 
            this.otworzButton.BackgroundImage = global::Grawer.Properties.Resources.folder;
            this.otworzButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.otworzButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otworzButton.Location = new System.Drawing.Point(15, 3);
            this.otworzButton.Name = "otworzButton";
            this.otworzButton.Size = new System.Drawing.Size(32, 32);
            this.otworzButton.TabIndex = 19;
            this.otworzButton.UseVisualStyleBackColor = true;
            this.otworzButton.Click += new System.EventHandler(this.otworzButton_Click);
            // 
            // Obraz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.parametryPanel);
            this.Controls.Add(this.podgladPictureBox);
            this.Controls.Add(this.dolPanel);
            this.Name = "Obraz";
            this.Size = new System.Drawing.Size(900, 750);
            this.dolPanel.ResumeLayout(false);
            this.dolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jasnoscTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podgladPictureBox)).EndInit();
            this.parametryPanel.ResumeLayout(false);
            this.parametryPanel.PerformLayout();
            this.progPanel.ResumeLayout(false);
            this.progPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dolPanel;
        private System.Windows.Forms.PictureBox podgladPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sciezkaLabel;
        private System.Windows.Forms.Panel parametryPanel;
        private System.Windows.Forms.Button otworzButton;
        private System.Windows.Forms.Button lewoButton;
        private System.Windows.Forms.Button prawoButton;
        private System.Windows.Forms.Button skalujButton;
        private System.Windows.Forms.Button nowyButton;
        private System.Windows.Forms.Label algorytmLabel;
        private System.Windows.Forms.ComboBox algorytmComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar kontrastTrackBar;
        private System.Windows.Forms.Label kontrastLabel;
        private System.Windows.Forms.Label jasnoscLabel;
        private System.Windows.Forms.Button resetKontrastButton;
        private System.Windows.Forms.TrackBar jasnoscTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox szeTextBox;
        private System.Windows.Forms.TextBox wysTextBox;
        private System.Windows.Forms.Button resetJasnoscButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox szpxTextBox;
        private System.Windows.Forms.TextBox wyspxTextBox;
        private System.Windows.Forms.Button podgladButton;
        private System.Windows.Forms.Panel progPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar progTrackBar;
        private System.Windows.Forms.TextBox progTexBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rozdzielczoscTextBox;
    }
}
