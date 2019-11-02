namespace Grawer.Formy
{
    partial class Skala
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
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.procentRadioButton = new System.Windows.Forms.RadioButton();
            this.pikselRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pionTextBox = new System.Windows.Forms.TextBox();
            this.poziomTextBox = new System.Windows.Forms.TextBox();
            this.ZatwierdzButton = new System.Windows.Forms.Button();
            this.radioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.procentRadioButton);
            this.radioGroupBox.Controls.Add(this.pikselRadioButton);
            this.radioGroupBox.Location = new System.Drawing.Point(13, 12);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(200, 39);
            this.radioGroupBox.TabIndex = 0;
            this.radioGroupBox.TabStop = false;
            // 
            // procentRadioButton
            // 
            this.procentRadioButton.AutoSize = true;
            this.procentRadioButton.Checked = true;
            this.procentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procentRadioButton.Location = new System.Drawing.Point(112, 16);
            this.procentRadioButton.Name = "procentRadioButton";
            this.procentRadioButton.Size = new System.Drawing.Size(106, 20);
            this.procentRadioButton.TabIndex = 1;
            this.procentRadioButton.TabStop = true;
            this.procentRadioButton.Text = "procentowo";
            this.procentRadioButton.UseVisualStyleBackColor = true;
            this.procentRadioButton.CheckedChanged += new System.EventHandler(this.procentRadioButton_CheckedChanged);
            // 
            // pikselRadioButton
            // 
            this.pikselRadioButton.AutoSize = true;
            this.pikselRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pikselRadioButton.Location = new System.Drawing.Point(0, 16);
            this.pikselRadioButton.Name = "pikselRadioButton";
            this.pikselRadioButton.Size = new System.Drawing.Size(77, 20);
            this.pikselRadioButton.TabIndex = 0;
            this.pikselRadioButton.Text = "piksele";
            this.pikselRadioButton.UseVisualStyleBackColor = true;
            this.pikselRadioButton.CheckedChanged += new System.EventHandler(this.pikselRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Poziom";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(13, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "proporcjonalnie";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pionTextBox
            // 
            this.pionTextBox.Location = new System.Drawing.Point(108, 80);
            this.pionTextBox.Name = "pionTextBox";
            this.pionTextBox.Size = new System.Drawing.Size(100, 20);
            this.pionTextBox.TabIndex = 4;
            this.pionTextBox.Text = "100";
            // 
            // poziomTextBox
            // 
            this.poziomTextBox.Location = new System.Drawing.Point(108, 109);
            this.poziomTextBox.Name = "poziomTextBox";
            this.poziomTextBox.Size = new System.Drawing.Size(100, 20);
            this.poziomTextBox.TabIndex = 5;
            this.poziomTextBox.Text = "100";
            // 
            // ZatwierdzButton
            // 
            this.ZatwierdzButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ZatwierdzButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZatwierdzButton.Location = new System.Drawing.Point(108, 136);
            this.ZatwierdzButton.Name = "ZatwierdzButton";
            this.ZatwierdzButton.Size = new System.Drawing.Size(100, 23);
            this.ZatwierdzButton.TabIndex = 6;
            this.ZatwierdzButton.Text = "OK";
            this.ZatwierdzButton.UseVisualStyleBackColor = true;
            this.ZatwierdzButton.Click += new System.EventHandler(this.ZatwierdzButton_Click);
            // 
            // Skala
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.ZatwierdzButton);
            this.Controls.Add(this.poziomTextBox);
            this.Controls.Add(this.pionTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Skala";
            this.ShowIcon = false;
            this.Text = "Skala";
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.RadioButton procentRadioButton;
        private System.Windows.Forms.RadioButton pikselRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox pionTextBox;
        private System.Windows.Forms.TextBox poziomTextBox;
        private System.Windows.Forms.Button ZatwierdzButton;
    }
}