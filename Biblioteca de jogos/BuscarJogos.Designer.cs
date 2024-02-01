namespace Biblioteca_de_jogos
{
    partial class BuscarJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarJogos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTelaInicial = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMeusFavoritos = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbJogos = new System.Windows.Forms.ComboBox();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLancamento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.resLancamento = new System.Windows.Forms.Label();
            this.resGenero = new System.Windows.Forms.Label();
            this.resNota = new System.Windows.Forms.Label();
            this.btnFavoritar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.resultsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameResultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imgGames = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGames)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTelaInicial,
            this.btnMeusFavoritos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(70, 20);
            this.btnTelaInicial.Text = "TelaInicial";
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // btnMeusFavoritos
            // 
            this.btnMeusFavoritos.Name = "btnMeusFavoritos";
            this.btnMeusFavoritos.Size = new System.Drawing.Size(99, 20);
            this.btnMeusFavoritos.Text = "Meus Favoritos";
            this.btnMeusFavoritos.Click += new System.EventHandler(this.btnMeusFavoritos_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(14, 69);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(445, 18);
            this.lblSubtitle.TabIndex = 10;
            this.lblSubtitle.Text = "Utilize a caixa de seleção para saber mais sobre determinado jogo";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 29);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Buscar Jogos";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 113);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 16);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome do jogo:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // cbJogos
            // 
            this.cbJogos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.resultsBindingSource, "name", true));
            this.cbJogos.DataSource = this.resultsBindingSource;
            this.cbJogos.DisplayMember = "name";
            this.cbJogos.FormattingEnabled = true;
            this.cbJogos.Location = new System.Drawing.Point(151, 112);
            this.cbJogos.Name = "cbJogos";
            this.cbJogos.Size = new System.Drawing.Size(175, 21);
            this.cbJogos.TabIndex = 12;
            this.cbJogos.ValueMember = "name";
            this.cbJogos.SelectedIndexChanged += new System.EventHandler(this.cbJogos_SelectedIndexChanged);
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "results";
            this.resultsBindingSource.DataSource = this.gameResultBindingSource;
            // 
            // gameResultBindingSource
            // 
            this.gameResultBindingSource.DataSource = typeof(Biblioteca_de_jogos.Models.GameResult);
            // 
            // gameDetailsBindingSource
            // 
            this.gameDetailsBindingSource.DataSource = typeof(Biblioteca_de_jogos.Models.GameDetails);
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamento.Location = new System.Drawing.Point(19, 151);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(95, 16);
            this.lblLancamento.TabIndex = 13;
            this.lblLancamento.Text = "Lançamento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(19, 188);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 16);
            this.lblGenero.TabIndex = 14;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(19, 225);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(112, 16);
            this.lblNota.TabIndex = 15;
            this.lblNota.Text = "Nota da crítica:";
            // 
            // resLancamento
            // 
            this.resLancamento.AutoSize = true;
            this.resLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLancamento.Location = new System.Drawing.Point(148, 151);
            this.resLancamento.Name = "resLancamento";
            this.resLancamento.Size = new System.Drawing.Size(0, 16);
            this.resLancamento.TabIndex = 17;
            // 
            // resGenero
            // 
            this.resGenero.AutoSize = true;
            this.resGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resGenero.Location = new System.Drawing.Point(148, 188);
            this.resGenero.Name = "resGenero";
            this.resGenero.Size = new System.Drawing.Size(0, 16);
            this.resGenero.TabIndex = 18;
            // 
            // resNota
            // 
            this.resNota.AutoSize = true;
            this.resNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resNota.Location = new System.Drawing.Point(148, 225);
            this.resNota.Name = "resNota";
            this.resNota.Size = new System.Drawing.Size(0, 16);
            this.resNota.TabIndex = 19;
            // 
            // btnFavoritar
            // 
            this.btnFavoritar.Location = new System.Drawing.Point(151, 321);
            this.btnFavoritar.Name = "btnFavoritar";
            this.btnFavoritar.Size = new System.Drawing.Size(93, 23);
            this.btnFavoritar.TabIndex = 20;
            this.btnFavoritar.Text = "Favoritar";
            this.btnFavoritar.UseVisualStyleBackColor = true;
            this.btnFavoritar.Click += new System.EventHandler(this.btnFavoritar_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 350);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(241, 43);
            this.lista.TabIndex = 21;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(22, 321);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // resultsBindingSource1
            // 
            this.resultsBindingSource1.DataMember = "results";
            this.resultsBindingSource1.DataSource = this.gameResultBindingSource;
            // 
            // gameResultBindingSource1
            // 
            this.gameResultBindingSource1.DataSource = typeof(Biblioteca_de_jogos.Models.GameResult);
            // 
            // imgGames
            // 
            this.imgGames.Location = new System.Drawing.Point(273, 223);
            this.imgGames.Name = "imgGames";
            this.imgGames.Size = new System.Drawing.Size(290, 170);
            this.imgGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGames.TabIndex = 23;
            this.imgGames.TabStop = false;
            // 
            // BuscarJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 412);
            this.Controls.Add(this.imgGames);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnFavoritar);
            this.Controls.Add(this.resNota);
            this.Controls.Add(this.resGenero);
            this.Controls.Add(this.resLancamento);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblLancamento);
            this.Controls.Add(this.cbJogos);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarJogos";
            this.Text = "Buscar Jogos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMeusFavoritos;
        private System.Windows.Forms.ToolStripMenuItem btnTelaInicial;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbJogos;
        private System.Windows.Forms.Label lblLancamento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label resLancamento;
        private System.Windows.Forms.Label resGenero;
        private System.Windows.Forms.Label resNota;
        private System.Windows.Forms.Button btnFavoritar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.BindingSource gameDetailsBindingSource;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private System.Windows.Forms.BindingSource gameResultBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource resultsBindingSource1;
        private System.Windows.Forms.BindingSource gameResultBindingSource1;
        private System.Windows.Forms.PictureBox imgGames;
    }
}