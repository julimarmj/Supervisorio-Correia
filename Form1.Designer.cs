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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btTeste = new System.Windows.Forms.Button();
            this.tbTeste1 = new System.Windows.Forms.TextBox();
            this.tbTeste2 = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbSF2 = new System.Windows.Forms.PictureBox();
            this.pbSF1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTeste
            // 
            this.btTeste.Location = new System.Drawing.Point(910, 104);
            this.btTeste.Name = "btTeste";
            this.btTeste.Size = new System.Drawing.Size(75, 23);
            this.btTeste.TabIndex = 0;
            this.btTeste.Text = "Send";
            this.btTeste.UseVisualStyleBackColor = true;
            this.btTeste.Click += new System.EventHandler(this.btTeste_Click);
            // 
            // tbTeste1
            // 
            this.tbTeste1.Location = new System.Drawing.Point(804, 106);
            this.tbTeste1.Name = "tbTeste1";
            this.tbTeste1.Size = new System.Drawing.Size(100, 20);
            this.tbTeste1.TabIndex = 1;
            // 
            // tbTeste2
            // 
            this.tbTeste2.Location = new System.Drawing.Point(804, 132);
            this.tbTeste2.Name = "tbTeste2";
            this.tbTeste2.Size = new System.Drawing.Size(100, 20);
            this.tbTeste2.TabIndex = 2;
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(910, 129);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 23);
            this.btCheck.TabIndex = 3;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(121, 439);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 11);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pbSF2
            // 
            this.pbSF2.Image = global::Supervisório___Correia.Properties.Resources.ON;
            this.pbSF2.Location = new System.Drawing.Point(120, 379);
            this.pbSF2.Name = "pbSF2";
            this.pbSF2.Size = new System.Drawing.Size(10, 26);
            this.pbSF2.TabIndex = 6;
            this.pbSF2.TabStop = false;
            // 
            // pbSF1
            // 
            this.pbSF1.Image = ((System.Drawing.Image)(resources.GetObject("pbSF1.Image")));
            this.pbSF1.Location = new System.Drawing.Point(250, 379);
            this.pbSF1.Name = "pbSF1";
            this.pbSF1.Size = new System.Drawing.Size(10, 26);
            this.pbSF1.TabIndex = 5;
            this.pbSF1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 781);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 837);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pbSF2);
            this.Controls.Add(this.pbSF1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbTeste2);
            this.Controls.Add(this.tbTeste1);
            this.Controls.Add(this.btTeste);
            this.Name = "Form1";
            this.Text = "Correia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTeste;
        private System.Windows.Forms.TextBox tbTeste1;
        private System.Windows.Forms.TextBox tbTeste2;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbSF1;
        private System.Windows.Forms.PictureBox pbSF2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

