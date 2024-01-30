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
            this.btnRemover.Location = new System.Drawing.Point(448, 355);
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
            this.listaFavoritos.Size = new System.Drawing.Size(391, 264);
            this.listaFavoritos.TabIndex = 10;
            this.listaFavoritos.SelectedIndexChanged += new System.EventHandler(this.listaFavoritos_SelectedIndexChanged);
            // 
            // MeusFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 412);
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
    }
}