namespace Biblioteca_de_jogos
{
    partial class MeusFavoritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeusFavoritos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTelaInicial = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarJogos = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.listaFavoritos = new System.Windows.Forms.ListBox();
            this.resDev = new System.Windows.Forms.Label();
            this.resPubli = new System.Windows.Forms.Label();
            this.lblPubli = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.resNota = new System.Windows.Forms.Label();
            this.resGenero = new System.Windows.Forms.Label();
            this.resLancamento = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblLancamento = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTelaInicial,
            this.btnBuscarJogos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(73, 20);
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // btnBuscarJogos
            // 
            this.btnBuscarJogos.Name = "btnBuscarJogos";
            this.btnBuscarJogos.Size = new System.Drawing.Size(87, 20);
            this.btnBuscarJogos.Text = "Buscar Jogos";
            this.btnBuscarJogos.Click += new System.EventHandler(this.btnBuscarJogos_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 29);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Meus Favoritos";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(14, 69);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(314, 18);
            this.lblSubtitle.TabIndex = 8;
            this.lblSubtitle.Text = "Aqui você encontra sua lista de jogos favoritos";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(367, 355);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(91, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // listaFavoritos
            // 
            this.listaFavoritos.FormattingEnabled = true;
            this.listaFavoritos.Location = new System.Drawing.Point(19, 114);
            this.listaFavoritos.Name = "listaFavoritos";
            this.listaFavoritos.Size = new System.Drawing.Size(229, 264);
            this.listaFavoritos.TabIndex = 10;
            this.listaFavoritos.SelectedIndexChanged += new System.EventHandler(this.listaFavoritos_SelectedIndexChanged);
            // 
            // resDev
            // 
            this.resDev.AutoSize = true;
            this.resDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDev.Location = new System.Drawing.Point(397, 244);
            this.resDev.Name = "resDev";
            this.resDev.Size = new System.Drawing.Size(0, 16);
            this.resDev.TabIndex = 38;
            // 
            // resPubli
            // 
            this.resPubli.AutoSize = true;
            this.resPubli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPubli.Location = new System.Drawing.Point(398, 212);
            this.resPubli.Name = "resPubli";
            this.resPubli.Size = new System.Drawing.Size(0, 16);
            this.resPubli.TabIndex = 37;
            // 
            // lblPubli
            // 
            this.lblPubli.AutoSize = true;
            this.lblPubli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubli.Location = new System.Drawing.Point(258, 212);
            this.lblPubli.Name = "lblPubli";
            this.lblPubli.Size = new System.Drawing.Size(95, 16);
            this.lblPubli.TabIndex = 36;
            this.lblPubli.Text = "Publicadora:";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(258, 244);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(126, 16);
            this.lblDev.TabIndex = 35;
            this.lblDev.Text = "Desenvolvedora:";
            // 
            // resNota
            // 
            this.resNota.AutoSize = true;
            this.resNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resNota.Location = new System.Drawing.Point(398, 276);
            this.resNota.Name = "resNota";
            this.resNota.Size = new System.Drawing.Size(0, 16);
            this.resNota.TabIndex = 34;
            // 
            // resGenero
            // 
            this.resGenero.AutoSize = true;
            this.resGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resGenero.Location = new System.Drawing.Point(398, 182);
            this.resGenero.Name = "resGenero";
            this.resGenero.Size = new System.Drawing.Size(0, 16);
            this.resGenero.TabIndex = 33;
            // 
            // resLancamento
            // 
            this.resLancamento.AutoSize = true;
            this.resLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLancamento.Location = new System.Drawing.Point(398, 155);
            this.resLancamento.Name = "resLancamento";
            this.resLancamento.Size = new System.Drawing.Size(0, 16);
            this.resLancamento.TabIndex = 32;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(258, 276);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(112, 16);
            this.lblNota.TabIndex = 31;
            this.lblNota.Text = "Nota da crítica:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(258, 182);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 16);
            this.lblGenero.TabIndex = 30;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamento.Location = new System.Drawing.Point(259, 155);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(95, 16);
            this.lblLancamento.TabIndex = 29;
            this.lblLancamento.Text = "Lançamento:";
            // 
            // MeusFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 412);
            this.Controls.Add(this.resDev);
            this.Controls.Add(this.resPubli);
            this.Controls.Add(this.lblPubli);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.resNota);
            this.Controls.Add(this.resGenero);
            this.Controls.Add(this.resLancamento);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblLancamento);
            this.Controls.Add(this.listaFavoritos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MeusFavoritos";
            this.Text = "Meus Favoritos";
            this.Load += new System.EventHandler(this.MeusFavoritos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarJogos;
        private System.Windows.Forms.ToolStripMenuItem btnTelaInicial;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox listaFavoritos;
        private System.Windows.Forms.Label resDev;
        private System.Windows.Forms.Label resPubli;
        private System.Windows.Forms.Label lblPubli;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label resNota;
        private System.Windows.Forms.Label resGenero;
        private System.Windows.Forms.Label resLancamento;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblLancamento;
    }
}