namespace LoversenySzimulator
{
    partial class Form1
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
            this.panelPalya = new System.Windows.Forms.Panel();
            this.buttonUjVerseny = new System.Windows.Forms.Button();
            this.buttonVersenyStart = new System.Windows.Forms.Button();
            this.panelFogadasTipus = new System.Windows.Forms.Panel();
            this.radio3as = new System.Windows.Forms.RadioButton();
            this.radioHelyezes = new System.Windows.Forms.RadioButton();
            this.panel3as = new System.Windows.Forms.Panel();
            this.panelHelyezes = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVersenyzo = new System.Windows.Forms.ComboBox();
            this.comboBoxHelyezes = new System.Windows.Forms.ComboBox();
            this.comboBox3hely = new System.Windows.Forms.ComboBox();
            this.comboBox2hely = new System.Windows.Forms.ComboBox();
            this.comboBox1hely = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVersenyzok = new System.Windows.Forms.Panel();
            this.panelFogadasTipus.SuspendLayout();
            this.panel3as.SuspendLayout();
            this.panelHelyezes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPalya
            // 
            this.panelPalya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPalya.Location = new System.Drawing.Point(0, 191);
            this.panelPalya.Name = "panelPalya";
            this.panelPalya.Size = new System.Drawing.Size(799, 259);
            this.panelPalya.TabIndex = 0;
            // 
            // buttonUjVerseny
            // 
            this.buttonUjVerseny.Location = new System.Drawing.Point(12, 12);
            this.buttonUjVerseny.Name = "buttonUjVerseny";
            this.buttonUjVerseny.Size = new System.Drawing.Size(155, 38);
            this.buttonUjVerseny.TabIndex = 1;
            this.buttonUjVerseny.Text = "Új Verseny";
            this.buttonUjVerseny.UseVisualStyleBackColor = true;
            this.buttonUjVerseny.Click += new System.EventHandler(this.buttonUjVerseny_Click);
            // 
            // buttonVersenyStart
            // 
            this.buttonVersenyStart.Enabled = false;
            this.buttonVersenyStart.Location = new System.Drawing.Point(12, 56);
            this.buttonVersenyStart.Name = "buttonVersenyStart";
            this.buttonVersenyStart.Size = new System.Drawing.Size(155, 38);
            this.buttonVersenyStart.TabIndex = 2;
            this.buttonVersenyStart.Text = "Verseny Indítása";
            this.buttonVersenyStart.UseVisualStyleBackColor = true;
            // 
            // panelFogadasTipus
            // 
            this.panelFogadasTipus.Controls.Add(this.radio3as);
            this.panelFogadasTipus.Controls.Add(this.radioHelyezes);
            this.panelFogadasTipus.Enabled = false;
            this.panelFogadasTipus.Location = new System.Drawing.Point(13, 101);
            this.panelFogadasTipus.Name = "panelFogadasTipus";
            this.panelFogadasTipus.Size = new System.Drawing.Size(154, 84);
            this.panelFogadasTipus.TabIndex = 3;
            // 
            // radio3as
            // 
            this.radio3as.AutoSize = true;
            this.radio3as.Location = new System.Drawing.Point(16, 44);
            this.radio3as.Name = "radio3as";
            this.radio3as.Size = new System.Drawing.Size(110, 24);
            this.radio3as.TabIndex = 1;
            this.radio3as.Text = "3as befutó";
            this.radio3as.UseVisualStyleBackColor = true;
            // 
            // radioHelyezes
            // 
            this.radioHelyezes.AutoSize = true;
            this.radioHelyezes.Checked = true;
            this.radioHelyezes.Location = new System.Drawing.Point(16, 14);
            this.radioHelyezes.Name = "radioHelyezes";
            this.radioHelyezes.Size = new System.Drawing.Size(99, 24);
            this.radioHelyezes.TabIndex = 0;
            this.radioHelyezes.TabStop = true;
            this.radioHelyezes.Text = "Helyezés";
            this.radioHelyezes.UseVisualStyleBackColor = true;
            // 
            // panel3as
            // 
            this.panel3as.Controls.Add(this.comboBox3hely);
            this.panel3as.Controls.Add(this.comboBox2hely);
            this.panel3as.Controls.Add(this.comboBox1hely);
            this.panel3as.Controls.Add(this.label3);
            this.panel3as.Controls.Add(this.label2);
            this.panel3as.Controls.Add(this.label1);
            this.panel3as.Enabled = false;
            this.panel3as.Location = new System.Drawing.Point(173, -175);
            this.panel3as.Name = "panel3as";
            this.panel3as.Size = new System.Drawing.Size(218, 172);
            this.panel3as.TabIndex = 4;
            // 
            // panelHelyezes
            // 
            this.panelHelyezes.Controls.Add(this.label5);
            this.panelHelyezes.Controls.Add(this.label4);
            this.panelHelyezes.Controls.Add(this.comboBoxVersenyzo);
            this.panelHelyezes.Controls.Add(this.comboBoxHelyezes);
            this.panelHelyezes.Enabled = false;
            this.panelHelyezes.Location = new System.Drawing.Point(173, 12);
            this.panelHelyezes.Name = "panelHelyezes";
            this.panelHelyezes.Size = new System.Drawing.Size(218, 173);
            this.panelHelyezes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Versenyző:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Helyezes:";
            // 
            // comboBoxVersenyzo
            // 
            this.comboBoxVersenyzo.FormattingEnabled = true;
            this.comboBoxVersenyzo.Location = new System.Drawing.Point(17, 128);
            this.comboBoxVersenyzo.Name = "comboBoxVersenyzo";
            this.comboBoxVersenyzo.Size = new System.Drawing.Size(181, 28);
            this.comboBoxVersenyzo.TabIndex = 1;
            // 
            // comboBoxHelyezes
            // 
            this.comboBoxHelyezes.FormattingEnabled = true;
            this.comboBoxHelyezes.Location = new System.Drawing.Point(17, 47);
            this.comboBoxHelyezes.Name = "comboBoxHelyezes";
            this.comboBoxHelyezes.Size = new System.Drawing.Size(181, 28);
            this.comboBoxHelyezes.TabIndex = 0;
            // 
            // comboBox3hely
            // 
            this.comboBox3hely.FormattingEnabled = true;
            this.comboBox3hely.Location = new System.Drawing.Point(61, 131);
            this.comboBox3hely.Name = "comboBox3hely";
            this.comboBox3hely.Size = new System.Drawing.Size(150, 28);
            this.comboBox3hely.TabIndex = 5;
            // 
            // comboBox2hely
            // 
            this.comboBox2hely.FormattingEnabled = true;
            this.comboBox2hely.Location = new System.Drawing.Point(61, 73);
            this.comboBox2hely.Name = "comboBox2hely";
            this.comboBox2hely.Size = new System.Drawing.Size(150, 28);
            this.comboBox2hely.TabIndex = 4;
            // 
            // comboBox1hely
            // 
            this.comboBox1hely.FormattingEnabled = true;
            this.comboBox1hely.Location = new System.Drawing.Point(60, 13);
            this.comboBox1hely.Name = "comboBox1hely";
            this.comboBox1hely.Size = new System.Drawing.Size(151, 28);
            this.comboBox1hely.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "3.hely";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.hely";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.hely";
            // 
            // panelVersenyzok
            // 
            this.panelVersenyzok.Location = new System.Drawing.Point(398, 12);
            this.panelVersenyzok.Name = "panelVersenyzok";
            this.panelVersenyzok.Size = new System.Drawing.Size(401, 173);
            this.panelVersenyzok.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelVersenyzok);
            this.Controls.Add(this.panelHelyezes);
            this.Controls.Add(this.panel3as);
            this.Controls.Add(this.panelFogadasTipus);
            this.Controls.Add(this.buttonVersenyStart);
            this.Controls.Add(this.buttonUjVerseny);
            this.Controls.Add(this.panelPalya);
            this.Name = "Form1";
            this.Text = "Lóverseny Szimulátor";
            this.panelFogadasTipus.ResumeLayout(false);
            this.panelFogadasTipus.PerformLayout();
            this.panel3as.ResumeLayout(false);
            this.panel3as.PerformLayout();
            this.panelHelyezes.ResumeLayout(false);
            this.panelHelyezes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPalya;
        private System.Windows.Forms.Button buttonUjVerseny;
        private System.Windows.Forms.Button buttonVersenyStart;
        private System.Windows.Forms.Panel panelFogadasTipus;
        private System.Windows.Forms.RadioButton radio3as;
        private System.Windows.Forms.RadioButton radioHelyezes;
        private System.Windows.Forms.Panel panel3as;
        private System.Windows.Forms.ComboBox comboBox3hely;
        private System.Windows.Forms.ComboBox comboBox2hely;
        private System.Windows.Forms.ComboBox comboBox1hely;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHelyezes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxVersenyzo;
        private System.Windows.Forms.ComboBox comboBoxHelyezes;
        private System.Windows.Forms.Panel panelVersenyzok;
    }
}

