namespace Grawer.Formy
{
    partial class Podglad
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
            this.button1 = new System.Windows.Forms.Button();
            this.pPictureBox = new System.Windows.Forms.PictureBox();
            this.goraPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(175, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pPictureBox
            // 
            this.pPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pPictureBox.Location = new System.Drawing.Point(5, 30);
            this.pPictureBox.Name = "pPictureBox";
            this.pPictureBox.Size = new System.Drawing.Size(650, 650);
            this.pPictureBox.TabIndex = 1;
            this.pPictureBox.TabStop = false;
            // 
            // goraPanel
            // 
            this.goraPanel.BackColor = System.Drawing.Color.Maroon;
            this.goraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.goraPanel.Location = new System.Drawing.Point(0, 0);
            this.goraPanel.Name = "goraPanel";
            this.goraPanel.Size = new System.Drawing.Size(660, 30);
            this.goraPanel.TabIndex = 2;
            this.goraPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gornypanel_MouseDown);
            this.goraPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gornypanel_MouseMove);
            this.goraPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gornypanel_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 700);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(655, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 700);
            this.panel2.TabIndex = 4;
            // 
            // Podglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(660, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goraPanel);
            this.Controls.Add(this.pPictureBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Podglad";
            this.Text = "Podglad";
            ((System.ComponentModel.ISupportInitialize)(this.pPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pPictureBox;
        private System.Windows.Forms.Panel goraPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}