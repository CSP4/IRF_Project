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
            this.components = new System.ComponentModel.Container();
            this.panelPalya = new System.Windows.Forms.Panel();
            this.buttonUjVerseny = new System.Windows.Forms.Button();
            this.buttonVersenyStart = new System.Windows.Forms.Button();
            this.panelFogadasTipus = new System.Windows.Forms.Panel();
            this.radio3as = new System.Windows.Forms.RadioButton();
            this.radioHelyezes = new System.Windows.Forms.RadioButton();
            this.panel3as = new System.Windows.Forms.Panel();
            this.comboBox3hely = new System.Windows.Forms.ComboBox();
            this.comboBox2hely = new System.Windows.Forms.ComboBox();
            this.comboBox1hely = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHelyezes = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVersenyzo = new System.Windows.Forms.ComboBox();
            this.comboBoxHelyezes = new System.Windows.Forms.ComboBox();
            this.panelVersenyzok = new System.Windows.Forms.Panel();
            this.timerFutam = new System.Windows.Forms.Timer(this.components);
            this.panelFogadasTipus.SuspendLayout();
            this.panel3as.SuspendLayout();
            this.panelHelyezes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPalya
            // 
            this.panelPalya.BackColor = System.Drawing.Color.Black;
            this.panelPalya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelPalya.Location = new System.Drawing.Point(5, 124);
            this.panelPalya.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPalya.Name = "panelPalya";
            this.panelPalya.Size = new System.Drawing.Size(1000, 272);
            this.panelPalya.TabIndex = 0;
            // 
            // buttonUjVerseny
            // 
            this.buttonUjVerseny.Location = new System.Drawing.Point(8, 8);
            this.buttonUjVerseny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUjVerseny.Name = "buttonUjVerseny";
            this.buttonUjVerseny.Size = new System.Drawing.Size(103, 25);
            this.buttonUjVerseny.TabIndex = 1;
            this.buttonUjVerseny.Text = "Új Verseny";
            this.buttonUjVerseny.UseVisualStyleBackColor = true;
            this.buttonUjVerseny.Click += new System.EventHandler(this.buttonUjVerseny_Click);
            // 
            // buttonVersenyStart
            // 
            this.buttonVersenyStart.Enabled = false;
            this.buttonVersenyStart.Location = new System.Drawing.Point(8, 36);
            this.buttonVersenyStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVersenyStart.Name = "buttonVersenyStart";
            this.buttonVersenyStart.Size = new System.Drawing.Size(103, 25);
            this.buttonVersenyStart.TabIndex = 2;
            this.buttonVersenyStart.Text = "Verseny Indítása";
            this.buttonVersenyStart.UseVisualStyleBackColor = true;
            this.buttonVersenyStart.Click += new System.EventHandler(this.buttonVersenyStart_Click);
            // 
            // panelFogadasTipus
            // 
            this.panelFogadasTipus.Controls.Add(this.radio3as);
            this.panelFogadasTipus.Controls.Add(this.radioHelyezes);
            this.panelFogadasTipus.Enabled = false;
            this.panelFogadasTipus.Location = new System.Drawing.Point(9, 66);
            this.panelFogadasTipus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFogadasTipus.Name = "panelFogadasTipus";
            this.panelFogadasTipus.Size = new System.Drawing.Size(103, 55);
            this.panelFogadasTipus.TabIndex = 3;
            // 
            // radio3as
            // 
            this.radio3as.AutoSize = true;
            this.radio3as.Location = new System.Drawing.Point(11, 29);
            this.radio3as.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio3as.Name = "radio3as";
            this.radio3as.Size = new System.Drawing.Size(75, 17);
            this.radio3as.TabIndex = 1;
            this.radio3as.Text = "3as befutó";
            this.radio3as.UseVisualStyleBackColor = true;
            this.radio3as.CheckedChanged += new System.EventHandler(this.radio3as_CheckedChanged);
            // 
            // radioHelyezes
            // 
            this.radioHelyezes.AutoSize = true;
            this.radioHelyezes.Checked = true;
            this.radioHelyezes.Location = new System.Drawing.Point(11, 9);
            this.radioHelyezes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioHelyezes.Name = "radioHelyezes";
            this.radioHelyezes.Size = new System.Drawing.Size(68, 17);
            this.radioHelyezes.TabIndex = 0;
            this.radioHelyezes.TabStop = true;
            this.radioHelyezes.Text = "Helyezés";
            this.radioHelyezes.UseVisualStyleBackColor = true;
            this.radioHelyezes.CheckedChanged += new System.EventHandler(this.radioHelyezes_CheckedChanged);
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
            this.panel3as.Location = new System.Drawing.Point(115, -114);
            this.panel3as.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3as.Name = "panel3as";
            this.panel3as.Size = new System.Drawing.Size(145, 112);
            this.panel3as.TabIndex = 4;
            // 
            // comboBox3hely
            // 
            this.comboBox3hely.FormattingEnabled = true;
            this.comboBox3hely.Items.AddRange(new object[] {
            "1. Versenyző",
            "2. Versenyző",
            "3. Versenyző",
            "4. Versenyző",
            "5. Versenyző"});
            this.comboBox3hely.Location = new System.Drawing.Point(41, 85);
            this.comboBox3hely.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3hely.Name = "comboBox3hely";
            this.comboBox3hely.Size = new System.Drawing.Size(101, 21);
            this.comboBox3hely.TabIndex = 5;
            this.comboBox3hely.SelectedIndexChanged += new System.EventHandler(this.comboBox3hely_SelectedIndexChanged);
            // 
            // comboBox2hely
            // 
            this.comboBox2hely.FormattingEnabled = true;
            this.comboBox2hely.Items.AddRange(new object[] {
            "1. Versenyző",
            "2. Versenyző",
            "3. Versenyző",
            "4. Versenyző",
            "5. Versenyző"});
            this.comboBox2hely.Location = new System.Drawing.Point(41, 47);
            this.comboBox2hely.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2hely.Name = "comboBox2hely";
            this.comboBox2hely.Size = new System.Drawing.Size(101, 21);
            this.comboBox2hely.TabIndex = 4;
            this.comboBox2hely.SelectedIndexChanged += new System.EventHandler(this.comboBox2hely_SelectedIndexChanged);
            // 
            // comboBox1hely
            // 
            this.comboBox1hely.FormattingEnabled = true;
            this.comboBox1hely.Items.AddRange(new object[] {
            "1. Versenyző",
            "2. Versenyző",
            "3. Versenyző",
            "4. Versenyző",
            "5. Versenyző"});
            this.comboBox1hely.Location = new System.Drawing.Point(40, 8);
            this.comboBox1hely.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1hely.Name = "comboBox1hely";
            this.comboBox1hely.Size = new System.Drawing.Size(102, 21);
            this.comboBox1hely.TabIndex = 3;
            this.comboBox1hely.SelectedIndexChanged += new System.EventHandler(this.comboBox1hely_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3.hely";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.hely";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.hely";
            // 
            // panelHelyezes
            // 
            this.panelHelyezes.Controls.Add(this.label5);
            this.panelHelyezes.Controls.Add(this.label4);
            this.panelHelyezes.Controls.Add(this.comboBoxVersenyzo);
            this.panelHelyezes.Controls.Add(this.comboBoxHelyezes);
            this.panelHelyezes.Enabled = false;
            this.panelHelyezes.Location = new System.Drawing.Point(115, 8);
            this.panelHelyezes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHelyezes.Name = "panelHelyezes";
            this.panelHelyezes.Size = new System.Drawing.Size(145, 112);
            this.panelHelyezes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Versenyző:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Helyezes:";
            // 
            // comboBoxVersenyzo
            // 
            this.comboBoxVersenyzo.FormattingEnabled = true;
            this.comboBoxVersenyzo.Items.AddRange(new object[] {
            "1. Versenyző",
            "2. Versenyző",
            "3. Versenyző",
            "4. Versenyző",
            "5. Versenyző"});
            this.comboBoxVersenyzo.Location = new System.Drawing.Point(11, 83);
            this.comboBoxVersenyzo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxVersenyzo.Name = "comboBoxVersenyzo";
            this.comboBoxVersenyzo.Size = new System.Drawing.Size(122, 21);
            this.comboBoxVersenyzo.TabIndex = 1;
            this.comboBoxVersenyzo.SelectedIndexChanged += new System.EventHandler(this.comboBoxVersenyzo_SelectedIndexChanged);
            // 
            // comboBoxHelyezes
            // 
            this.comboBoxHelyezes.FormattingEnabled = true;
            this.comboBoxHelyezes.Items.AddRange(new object[] {
            "1. Hely",
            "2. Hely",
            "3. Hely",
            "4. Hely",
            "5. Hely"});
            this.comboBoxHelyezes.Location = new System.Drawing.Point(11, 31);
            this.comboBoxHelyezes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxHelyezes.Name = "comboBoxHelyezes";
            this.comboBoxHelyezes.Size = new System.Drawing.Size(122, 21);
            this.comboBoxHelyezes.TabIndex = 0;
            this.comboBoxHelyezes.SelectedIndexChanged += new System.EventHandler(this.comboBoxHelyezes_SelectedIndexChanged);
            // 
            // panelVersenyzok
            // 
            this.panelVersenyzok.Location = new System.Drawing.Point(265, 8);
            this.panelVersenyzok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelVersenyzok.Name = "panelVersenyzok";
            this.panelVersenyzok.Size = new System.Drawing.Size(450, 112);
            this.panelVersenyzok.TabIndex = 6;
            // 
            // timerFutam
            // 
            this.timerFutam.Tick += new System.EventHandler(this.timerFutam_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1014, 411);
            this.Controls.Add(this.panelVersenyzok);
            this.Controls.Add(this.panelHelyezes);
            this.Controls.Add(this.panel3as);
            this.Controls.Add(this.panelFogadasTipus);
            this.Controls.Add(this.buttonVersenyStart);
            this.Controls.Add(this.buttonUjVerseny);
            this.Controls.Add(this.panelPalya);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Timer timerFutam;
    }
}

