namespace POOAtvForms
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
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnOctagono = new System.Windows.Forms.Button();
            this.btnPentagono = new System.Windows.Forms.Button();
            this.btnRetangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnHexagono = new System.Windows.Forms.Button();
            this.txtBaseQuadrado = new System.Windows.Forms.TextBox();
            this.txtAlturaQuadrado = new System.Windows.Forms.TextBox();
            this.txtLadoOcta = new System.Windows.Forms.TextBox();
            this.txtApotemaOcta = new System.Windows.Forms.TextBox();
            this.txtLadoPenta = new System.Windows.Forms.TextBox();
            this.txtApotemaPenta = new System.Windows.Forms.TextBox();
            this.txtLarguraReta = new System.Windows.Forms.TextBox();
            this.txtAlturaReta = new System.Windows.Forms.TextBox();
            this.txtBaseTriang = new System.Windows.Forms.TextBox();
            this.txtAlturaTriang = new System.Windows.Forms.TextBox();
            this.txtRaioCirc = new System.Windows.Forms.TextBox();
            this.txtDiametroCirc = new System.Windows.Forms.TextBox();
            this.txtLadoHexa = new System.Windows.Forms.TextBox();
            this.pictureBoxForma = new System.Windows.Forms.PictureBox();
            this.lblResultadoArea = new System.Windows.Forms.Label();
            this.lblResultadoPeri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.Location = new System.Drawing.Point(85, 108);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(98, 23);
            this.btnQuadrado.TabIndex = 0;
            this.btnQuadrado.Text = "QUADRADO";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOctagono
            // 
            this.btnOctagono.Location = new System.Drawing.Point(85, 137);
            this.btnOctagono.Name = "btnOctagono";
            this.btnOctagono.Size = new System.Drawing.Size(98, 23);
            this.btnOctagono.TabIndex = 1;
            this.btnOctagono.Text = "OCTAGONO";
            this.btnOctagono.UseVisualStyleBackColor = true;
            // 
            // btnPentagono
            // 
            this.btnPentagono.Location = new System.Drawing.Point(85, 166);
            this.btnPentagono.Name = "btnPentagono";
            this.btnPentagono.Size = new System.Drawing.Size(98, 23);
            this.btnPentagono.TabIndex = 2;
            this.btnPentagono.Text = "PENTAGONO";
            this.btnPentagono.UseVisualStyleBackColor = true;
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.Location = new System.Drawing.Point(85, 195);
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(98, 23);
            this.btnRetangulo.TabIndex = 3;
            this.btnRetangulo.Text = "RETANGULO";
            this.btnRetangulo.UseVisualStyleBackColor = true;
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(85, 224);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(98, 23);
            this.btnTriangulo.TabIndex = 4;
            this.btnTriangulo.Text = "TRIANGULO";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(85, 253);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(98, 23);
            this.btnCirculo.TabIndex = 5;
            this.btnCirculo.Text = "CIRCULO";
            this.btnCirculo.UseVisualStyleBackColor = true;
            // 
            // btnHexagono
            // 
            this.btnHexagono.Location = new System.Drawing.Point(85, 282);
            this.btnHexagono.Name = "btnHexagono";
            this.btnHexagono.Size = new System.Drawing.Size(98, 23);
            this.btnHexagono.TabIndex = 6;
            this.btnHexagono.Text = "HEXAGONO";
            this.btnHexagono.UseVisualStyleBackColor = true;
            // 
            // txtBaseQuadrado
            // 
            this.txtBaseQuadrado.Location = new System.Drawing.Point(198, 111);
            this.txtBaseQuadrado.Name = "txtBaseQuadrado";
            this.txtBaseQuadrado.Size = new System.Drawing.Size(72, 20);
            this.txtBaseQuadrado.TabIndex = 8;
            this.txtBaseQuadrado.Text = "Base";
            this.txtBaseQuadrado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAlturaQuadrado
            // 
            this.txtAlturaQuadrado.Location = new System.Drawing.Point(276, 111);
            this.txtAlturaQuadrado.Name = "txtAlturaQuadrado";
            this.txtAlturaQuadrado.ShortcutsEnabled = false;
            this.txtAlturaQuadrado.Size = new System.Drawing.Size(72, 20);
            this.txtAlturaQuadrado.TabIndex = 9;
            this.txtAlturaQuadrado.Text = "Atura";
            // 
            // txtLadoOcta
            // 
            this.txtLadoOcta.Location = new System.Drawing.Point(198, 140);
            this.txtLadoOcta.Name = "txtLadoOcta";
            this.txtLadoOcta.Size = new System.Drawing.Size(72, 20);
            this.txtLadoOcta.TabIndex = 10;
            this.txtLadoOcta.Text = "Lado";
            // 
            // txtApotemaOcta
            // 
            this.txtApotemaOcta.Location = new System.Drawing.Point(276, 140);
            this.txtApotemaOcta.Name = "txtApotemaOcta";
            this.txtApotemaOcta.Size = new System.Drawing.Size(72, 20);
            this.txtApotemaOcta.TabIndex = 11;
            this.txtApotemaOcta.Text = "Apotema";
            // 
            // txtLadoPenta
            // 
            this.txtLadoPenta.Location = new System.Drawing.Point(198, 168);
            this.txtLadoPenta.Name = "txtLadoPenta";
            this.txtLadoPenta.Size = new System.Drawing.Size(72, 20);
            this.txtLadoPenta.TabIndex = 12;
            this.txtLadoPenta.Text = "Lado";
            // 
            // txtApotemaPenta
            // 
            this.txtApotemaPenta.Location = new System.Drawing.Point(276, 168);
            this.txtApotemaPenta.Name = "txtApotemaPenta";
            this.txtApotemaPenta.Size = new System.Drawing.Size(72, 20);
            this.txtApotemaPenta.TabIndex = 13;
            this.txtApotemaPenta.Text = "Apotema";
            // 
            // txtLarguraReta
            // 
            this.txtLarguraReta.Location = new System.Drawing.Point(198, 194);
            this.txtLarguraReta.Name = "txtLarguraReta";
            this.txtLarguraReta.Size = new System.Drawing.Size(72, 20);
            this.txtLarguraReta.TabIndex = 14;
            this.txtLarguraReta.Text = "Largura";
            // 
            // txtAlturaReta
            // 
            this.txtAlturaReta.Location = new System.Drawing.Point(276, 194);
            this.txtAlturaReta.Name = "txtAlturaReta";
            this.txtAlturaReta.Size = new System.Drawing.Size(72, 20);
            this.txtAlturaReta.TabIndex = 15;
            this.txtAlturaReta.Text = "Altura";
            // 
            // txtBaseTriang
            // 
            this.txtBaseTriang.Location = new System.Drawing.Point(198, 220);
            this.txtBaseTriang.Name = "txtBaseTriang";
            this.txtBaseTriang.Size = new System.Drawing.Size(72, 20);
            this.txtBaseTriang.TabIndex = 16;
            this.txtBaseTriang.Text = "Base";
            // 
            // txtAlturaTriang
            // 
            this.txtAlturaTriang.Location = new System.Drawing.Point(276, 220);
            this.txtAlturaTriang.Name = "txtAlturaTriang";
            this.txtAlturaTriang.Size = new System.Drawing.Size(72, 20);
            this.txtAlturaTriang.TabIndex = 17;
            this.txtAlturaTriang.Text = "Altura";
            // 
            // txtRaioCirc
            // 
            this.txtRaioCirc.Location = new System.Drawing.Point(198, 255);
            this.txtRaioCirc.Name = "txtRaioCirc";
            this.txtRaioCirc.Size = new System.Drawing.Size(72, 20);
            this.txtRaioCirc.TabIndex = 18;
            this.txtRaioCirc.Text = "Raio";
            // 
            // txtDiametroCirc
            // 
            this.txtDiametroCirc.Location = new System.Drawing.Point(276, 256);
            this.txtDiametroCirc.Name = "txtDiametroCirc";
            this.txtDiametroCirc.Size = new System.Drawing.Size(72, 20);
            this.txtDiametroCirc.TabIndex = 19;
            this.txtDiametroCirc.Text = "Diametro";
            // 
            // txtLadoHexa
            // 
            this.txtLadoHexa.Location = new System.Drawing.Point(198, 285);
            this.txtLadoHexa.Name = "txtLadoHexa";
            this.txtLadoHexa.Size = new System.Drawing.Size(72, 20);
            this.txtLadoHexa.TabIndex = 20;
            this.txtLadoHexa.Text = "Lado";
            // 
            // pictureBoxForma
            // 
            this.pictureBoxForma.Location = new System.Drawing.Point(170, 12);
            this.pictureBoxForma.Name = "pictureBoxForma";
            this.pictureBoxForma.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxForma.TabIndex = 21;
            this.pictureBoxForma.TabStop = false;
            // 
            // lblResultadoArea
            // 
            this.lblResultadoArea.AutoSize = true;
            this.lblResultadoArea.Location = new System.Drawing.Point(157, 74);
            this.lblResultadoArea.Name = "lblResultadoArea";
            this.lblResultadoArea.Size = new System.Drawing.Size(40, 13);
            this.lblResultadoArea.TabIndex = 22;
            this.lblResultadoArea.Text = "R Area";
            this.lblResultadoArea.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblResultadoPeri
            // 
            this.lblResultadoPeri.AutoSize = true;
            this.lblResultadoPeri.Location = new System.Drawing.Point(225, 74);
            this.lblResultadoPeri.Name = "lblResultadoPeri";
            this.lblResultadoPeri.Size = new System.Drawing.Size(62, 13);
            this.lblResultadoPeri.TabIndex = 23;
            this.lblResultadoPeri.Text = "R Perimetro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultadoPeri);
            this.Controls.Add(this.lblResultadoArea);
            this.Controls.Add(this.pictureBoxForma);
            this.Controls.Add(this.txtLadoHexa);
            this.Controls.Add(this.txtDiametroCirc);
            this.Controls.Add(this.txtRaioCirc);
            this.Controls.Add(this.txtAlturaTriang);
            this.Controls.Add(this.txtBaseTriang);
            this.Controls.Add(this.txtAlturaReta);
            this.Controls.Add(this.txtLarguraReta);
            this.Controls.Add(this.txtApotemaPenta);
            this.Controls.Add(this.txtLadoPenta);
            this.Controls.Add(this.txtApotemaOcta);
            this.Controls.Add(this.txtLadoOcta);
            this.Controls.Add(this.txtAlturaQuadrado);
            this.Controls.Add(this.txtBaseQuadrado);
            this.Controls.Add(this.btnHexagono);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnRetangulo);
            this.Controls.Add(this.btnPentagono);
            this.Controls.Add(this.btnOctagono);
            this.Controls.Add(this.btnQuadrado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnOctagono;
        private System.Windows.Forms.Button btnPentagono;
        private System.Windows.Forms.Button btnRetangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnHexagono;
        private System.Windows.Forms.TextBox txtBaseQuadrado;
        private System.Windows.Forms.TextBox txtAlturaQuadrado;
        private System.Windows.Forms.TextBox txtLadoOcta;
        private System.Windows.Forms.TextBox txtApotemaOcta;
        private System.Windows.Forms.TextBox txtLadoPenta;
        private System.Windows.Forms.TextBox txtApotemaPenta;
        private System.Windows.Forms.TextBox txtLarguraReta;
        private System.Windows.Forms.TextBox txtAlturaReta;
        private System.Windows.Forms.TextBox txtBaseTriang;
        private System.Windows.Forms.TextBox txtAlturaTriang;
        private System.Windows.Forms.TextBox txtRaioCirc;
        private System.Windows.Forms.TextBox txtDiametroCirc;
        private System.Windows.Forms.TextBox txtLadoHexa;
        private System.Windows.Forms.PictureBox pictureBoxForma;
        private System.Windows.Forms.Label lblResultadoArea;
        private System.Windows.Forms.Label lblResultadoPeri;
    }
}

