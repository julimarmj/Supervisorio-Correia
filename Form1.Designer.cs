namespace Supervisório___Correia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btOn = new System.Windows.Forms.Button();
            this.btOff = new System.Windows.Forms.Button();
            this.btRearm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEmer = new System.Windows.Forms.Button();
            this.lbDef = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTranspTot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOpacTot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTransp = new System.Windows.Forms.Label();
            this.lbOpac = new System.Windows.Forms.Label();
            this.pbBusy3 = new System.Windows.Forms.PictureBox();
            this.pbBusy2 = new System.Windows.Forms.PictureBox();
            this.pbBusy1 = new System.Windows.Forms.PictureBox();
            this.pbMotor = new System.Windows.Forms.PictureBox();
            this.pbSC = new System.Windows.Forms.PictureBox();
            this.pbSF2 = new System.Windows.Forms.PictureBox();
            this.pbSF1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btOn
            // 
            this.btOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOn.Location = new System.Drawing.Point(11, 3);
            this.btOn.Name = "btOn";
            this.btOn.Size = new System.Drawing.Size(120, 40);
            this.btOn.TabIndex = 9;
            this.btOn.Text = "Liga";
            this.btOn.UseVisualStyleBackColor = true;
            this.btOn.Click += new System.EventHandler(this.btOn_Click);
            // 
            // btOff
            // 
            this.btOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOff.Location = new System.Drawing.Point(11, 49);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(120, 40);
            this.btOff.TabIndex = 10;
            this.btOff.Text = "Desliga";
            this.btOff.UseVisualStyleBackColor = true;
            this.btOff.Click += new System.EventHandler(this.btOff_Click);
            // 
            // btRearm
            // 
            this.btRearm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRearm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRearm.Location = new System.Drawing.Point(11, 95);
            this.btRearm.Name = "btRearm";
            this.btRearm.Size = new System.Drawing.Size(120, 40);
            this.btRearm.TabIndex = 11;
            this.btRearm.Text = "Rearme";
            this.btRearm.UseVisualStyleBackColor = true;
            this.btRearm.Click += new System.EventHandler(this.btRearm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btEmer);
            this.panel1.Controls.Add(this.lbDef);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btRearm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btOff);
            this.panel1.Controls.Add(this.lbTranspTot);
            this.panel1.Controls.Add(this.btOn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbOpacTot);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbTransp);
            this.panel1.Controls.Add(this.lbOpac);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(114, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 191);
            this.panel1.TabIndex = 12;
            // 
            // btEmer
            // 
            this.btEmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmer.ForeColor = System.Drawing.Color.Red;
            this.btEmer.Location = new System.Drawing.Point(11, 141);
            this.btEmer.Name = "btEmer";
            this.btEmer.Size = new System.Drawing.Size(120, 40);
            this.btEmer.TabIndex = 17;
            this.btEmer.Text = "Emergência";
            this.btEmer.UseVisualStyleBackColor = false;
            this.btEmer.Click += new System.EventHandler(this.btEmer_Click);
            // 
            // lbDef
            // 
            this.lbDef.AutoSize = true;
            this.lbDef.BackColor = System.Drawing.Color.Yellow;
            this.lbDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDef.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDef.ForeColor = System.Drawing.Color.Red;
            this.lbDef.Location = new System.Drawing.Point(280, 121);
            this.lbDef.Name = "lbDef";
            this.lbDef.Size = new System.Drawing.Size(298, 39);
            this.lbDef.TabIndex = 16;
            this.lbDef.Text = "Defeito na Correia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Geral";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Peças transparentes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Atual";
            // 
            // lbTranspTot
            // 
            this.lbTranspTot.AutoSize = true;
            this.lbTranspTot.BackColor = System.Drawing.Color.White;
            this.lbTranspTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTranspTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTranspTot.Location = new System.Drawing.Point(609, 46);
            this.lbTranspTot.Name = "lbTranspTot";
            this.lbTranspTot.Size = new System.Drawing.Size(16, 18);
            this.lbTranspTot.TabIndex = 6;
            this.lbTranspTot.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peças Opacas:";
            // 
            // lbOpacTot
            // 
            this.lbOpacTot.AutoSize = true;
            this.lbOpacTot.BackColor = System.Drawing.Color.White;
            this.lbOpacTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbOpacTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpacTot.Location = new System.Drawing.Point(609, 70);
            this.lbOpacTot.Name = "lbOpacTot";
            this.lbOpacTot.Size = new System.Drawing.Size(16, 18);
            this.lbOpacTot.TabIndex = 4;
            this.lbOpacTot.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peças Opacas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peças transparentes:";
            // 
            // lbTransp
            // 
            this.lbTransp.AutoSize = true;
            this.lbTransp.BackColor = System.Drawing.Color.White;
            this.lbTransp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransp.Location = new System.Drawing.Point(383, 46);
            this.lbTransp.Name = "lbTransp";
            this.lbTransp.Size = new System.Drawing.Size(16, 18);
            this.lbTransp.TabIndex = 1;
            this.lbTransp.Text = "0";
            // 
            // lbOpac
            // 
            this.lbOpac.AutoSize = true;
            this.lbOpac.BackColor = System.Drawing.Color.White;
            this.lbOpac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbOpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpac.Location = new System.Drawing.Point(383, 68);
            this.lbOpac.Name = "lbOpac";
            this.lbOpac.Size = new System.Drawing.Size(16, 18);
            this.lbOpac.TabIndex = 0;
            this.lbOpac.Text = "0";
            // 
            // pbBusy3
            // 
            this.pbBusy3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pbBusy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBusy3.Image = global::Supervisório___Correia.Properties.Resources.Seta;
            this.pbBusy3.Location = new System.Drawing.Point(774, 357);
            this.pbBusy3.Name = "pbBusy3";
            this.pbBusy3.Size = new System.Drawing.Size(50, 80);
            this.pbBusy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBusy3.TabIndex = 15;
            this.pbBusy3.TabStop = false;
            // 
            // pbBusy2
            // 
            this.pbBusy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pbBusy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBusy2.Image = global::Supervisório___Correia.Properties.Resources.Seta;
            this.pbBusy2.Location = new System.Drawing.Point(440, 357);
            this.pbBusy2.Name = "pbBusy2";
            this.pbBusy2.Size = new System.Drawing.Size(50, 80);
            this.pbBusy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBusy2.TabIndex = 14;
            this.pbBusy2.TabStop = false;
            // 
            // pbBusy1
            // 
            this.pbBusy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.pbBusy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBusy1.Image = global::Supervisório___Correia.Properties.Resources.Seta;
            this.pbBusy1.Location = new System.Drawing.Point(153, 357);
            this.pbBusy1.Name = "pbBusy1";
            this.pbBusy1.Size = new System.Drawing.Size(50, 80);
            this.pbBusy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBusy1.TabIndex = 13;
            this.pbBusy1.TabStop = false;
            // 
            // pbMotor
            // 
            this.pbMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMotor.Image = global::Supervisório___Correia.Properties.Resources.OFF;
            this.pbMotor.Location = new System.Drawing.Point(190, 281);
            this.pbMotor.Name = "pbMotor";
            this.pbMotor.Size = new System.Drawing.Size(11, 18);
            this.pbMotor.TabIndex = 8;
            this.pbMotor.TabStop = false;
            // 
            // pbSC
            // 
            this.pbSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSC.Image = global::Supervisório___Correia.Properties.Resources.OFF;
            this.pbSC.Location = new System.Drawing.Point(510, 455);
            this.pbSC.Name = "pbSC";
            this.pbSC.Size = new System.Drawing.Size(10, 11);
            this.pbSC.TabIndex = 7;
            this.pbSC.TabStop = false;
            // 
            // pbSF2
            // 
            this.pbSF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSF2.Image = global::Supervisório___Correia.Properties.Resources.OFF;
            this.pbSF2.Location = new System.Drawing.Point(450, 458);
            this.pbSF2.Name = "pbSF2";
            this.pbSF2.Size = new System.Drawing.Size(26, 10);
            this.pbSF2.TabIndex = 6;
            this.pbSF2.TabStop = false;
            // 
            // pbSF1
            // 
            this.pbSF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSF1.Image = global::Supervisório___Correia.Properties.Resources.OFF;
            this.pbSF1.Location = new System.Drawing.Point(450, 327);
            this.pbSF1.Name = "pbSF1";
            this.pbSF1.Size = new System.Drawing.Size(26, 10);
            this.pbSF1.TabIndex = 5;
            this.pbSF1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supervisório___Correia.Properties.Resources.Esteira_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(82, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 248);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 616);
            this.Controls.Add(this.pbBusy3);
            this.Controls.Add(this.pbBusy2);
            this.Controls.Add(this.pbBusy1);
            this.Controls.Add(this.pbMotor);
            this.Controls.Add(this.pbSC);
            this.Controls.Add(this.pbSF2);
            this.Controls.Add(this.pbSF1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Correia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.on_closing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbSF1;
        private System.Windows.Forms.PictureBox pbSF2;
        private System.Windows.Forms.PictureBox pbSC;
        private System.Windows.Forms.PictureBox pbMotor;
        private System.Windows.Forms.Button btOn;
        private System.Windows.Forms.Button btOff;
        private System.Windows.Forms.Button btRearm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTranspTot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOpacTot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTransp;
        private System.Windows.Forms.Label lbOpac;
        private System.Windows.Forms.PictureBox pbBusy1;
        private System.Windows.Forms.PictureBox pbBusy2;
        private System.Windows.Forms.PictureBox pbBusy3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDef;
        private System.Windows.Forms.Button btEmer;
    }
}

