namespace Grawer.Formy
{
    partial class Wypalanie
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.anulujButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.procentLabel = new System.Windows.Forms.Label();
            this.punktyLabel = new System.Windows.Forms.Label();
            this.czasLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gornyPanel = new System.Windows.Forms.Panel();
            this.gornyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(66, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(806, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // anulujButton
            // 
            this.anulujButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anulujButton.Location = new System.Drawing.Point(178, 136);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(141, 23);
            this.anulujButton.TabIndex = 1;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            this.anulujButton.Click += new System.EventHandler(this.anulujButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Punkty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Czas";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // procentLabel
            // 
            this.procentLabel.AutoSize = true;
            this.procentLabel.Location = new System.Drawing.Point(879, 89);
            this.procentLabel.Name = "procentLabel";
            this.procentLabel.Size = new System.Drawing.Size(43, 13);
            this.procentLabel.TabIndex = 4;
            this.procentLabel.Text = "procent";
            // 
            // punktyLabel
            // 
            this.punktyLabel.AutoSize = true;
            this.punktyLabel.Location = new System.Drawing.Point(110, 54);
            this.punktyLabel.Name = "punktyLabel";
            this.punktyLabel.Size = new System.Drawing.Size(35, 13);
            this.punktyLabel.TabIndex = 5;
            this.punktyLabel.Text = "label3";
            // 
            // czasLabel
            // 
            this.czasLabel.AutoSize = true;
            this.czasLabel.Location = new System.Drawing.Point(734, 106);
            this.czasLabel.Name = "czasLabel";
            this.czasLabel.Size = new System.Drawing.Size(68, 13);
            this.czasLabel.TabIndex = 6;
            this.czasLabel.Text = "00h:00m:00s";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(529, 136);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(902, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // gornyPanel
            // 
            this.gornyPanel.BackColor = System.Drawing.Color.Maroon;
            this.gornyPanel.Controls.Add(this.label3);
            this.gornyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gornyPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gornyPanel.Location = new System.Drawing.Point(0, 0);
            this.gornyPanel.Name = "gornyPanel";
            this.gornyPanel.Size = new System.Drawing.Size(957, 30);
            this.gornyPanel.TabIndex = 9;
            this.gornyPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gornypanel_MouseDown);
            this.gornyPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gornypanel_MouseMove);
            this.gornyPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gornypanel_MouseUp);
            // 
            // Wypalanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 169);
            this.Controls.Add(this.gornyPanel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.czasLabel);
            this.Controls.Add(this.punktyLabel);
            this.Controls.Add(this.procentLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anulujButton);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wypalanie";
            this.Text = "Wypalanie";
            this.gornyPanel.ResumeLayout(false);
            this.gornyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button anulujButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label procentLabel;
        private System.Windows.Forms.Label punktyLabel;
        private System.Windows.Forms.Label czasLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel gornyPanel;
    }
}