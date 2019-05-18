namespace Gerenciador.Forms
{
    partial class Gerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarTestesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faculdadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEAtualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosDeCadaInstituiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosPorAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCursoPorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaMECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atribuirNovaNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAvaliaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarPerguntaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarQuestõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.faculdadeToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.notaMECToolStripMenuItem,
            this.questõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.visualizarTestesToolStripMenuItem,
            this.gerarRelatóriosToolStripMenuItem});
            this.usuarioToolStripMenuItem.Image = global::Gerenciador.Properties.Resources._16480_1_;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.novoToolStripMenuItem.Text = "Novo usuário";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.atualizarToolStripMenuItem.Text = "Buscar/Modificar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // visualizarTestesToolStripMenuItem
            // 
            this.visualizarTestesToolStripMenuItem.Name = "visualizarTestesToolStripMenuItem";
            this.visualizarTestesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.visualizarTestesToolStripMenuItem.Text = "Visualizar testes";
            this.visualizarTestesToolStripMenuItem.Click += new System.EventHandler(this.visualizarTestesToolStripMenuItem_Click);
            // 
            // gerarRelatóriosToolStripMenuItem
            // 
            this.gerarRelatóriosToolStripMenuItem.Name = "gerarRelatóriosToolStripMenuItem";
            this.gerarRelatóriosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gerarRelatóriosToolStripMenuItem.Text = "Gerar relatórios";
            this.gerarRelatóriosToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatóriosToolStripMenuItem_Click);
            // 
            // faculdadeToolStripMenuItem
            // 
            this.faculdadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.buscarEAtualizarToolStripMenuItem,
            this.cursosDeCadaInstituiçãoToolStripMenuItem});
            this.faculdadeToolStripMenuItem.Image = global::Gerenciador.Properties.Resources.fundo_facul;
            this.faculdadeToolStripMenuItem.Name = "faculdadeToolStripMenuItem";
            this.faculdadeToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.faculdadeToolStripMenuItem.Text = "Faculdade";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.novoToolStripMenuItem1.Text = "Nova faculdade";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // buscarEAtualizarToolStripMenuItem
            // 
            this.buscarEAtualizarToolStripMenuItem.Name = "buscarEAtualizarToolStripMenuItem";
            this.buscarEAtualizarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.buscarEAtualizarToolStripMenuItem.Text = "Buscar/Modificar";
            this.buscarEAtualizarToolStripMenuItem.Click += new System.EventHandler(this.buscarEAtualizarToolStripMenuItem_Click);
            // 
            // cursosDeCadaInstituiçãoToolStripMenuItem
            // 
            this.cursosDeCadaInstituiçãoToolStripMenuItem.Name = "cursosDeCadaInstituiçãoToolStripMenuItem";
            this.cursosDeCadaInstituiçãoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cursosDeCadaInstituiçãoToolStripMenuItem.Text = "Cursos de cada instituição";
            this.cursosDeCadaInstituiçãoToolStripMenuItem.Click += new System.EventHandler(this.cursosDeCadaInstituiçãoToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem2,
            this.listarCursosToolStripMenuItem,
            this.cursosPorAreaToolStripMenuItem,
            this.listarCursoPorTipoToolStripMenuItem});
            this.cursoToolStripMenuItem.Image = global::Gerenciador.Properties.Resources.fundoCurso;
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.cursoToolStripMenuItem.Text = "Curso/área";
            // 
            // novoToolStripMenuItem2
            // 
            this.novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            this.novoToolStripMenuItem2.Size = new System.Drawing.Size(185, 22);
            this.novoToolStripMenuItem2.Text = "Novo curso";
            this.novoToolStripMenuItem2.Click += new System.EventHandler(this.novoToolStripMenuItem2_Click);
            // 
            // listarCursosToolStripMenuItem
            // 
            this.listarCursosToolStripMenuItem.Name = "listarCursosToolStripMenuItem";
            this.listarCursosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listarCursosToolStripMenuItem.Text = "Buscar/Modificar";
            this.listarCursosToolStripMenuItem.Click += new System.EventHandler(this.listarCursosToolStripMenuItem_Click);
            // 
            // cursosPorAreaToolStripMenuItem
            // 
            this.cursosPorAreaToolStripMenuItem.Name = "cursosPorAreaToolStripMenuItem";
            this.cursosPorAreaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cursosPorAreaToolStripMenuItem.Text = "Listar cursos por área";
            this.cursosPorAreaToolStripMenuItem.Click += new System.EventHandler(this.cursosPorAreaToolStripMenuItem_Click);
            // 
            // listarCursoPorTipoToolStripMenuItem
            // 
            this.listarCursoPorTipoToolStripMenuItem.Name = "listarCursoPorTipoToolStripMenuItem";
            this.listarCursoPorTipoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listarCursoPorTipoToolStripMenuItem.Text = "Listar curso por tipo";
            this.listarCursoPorTipoToolStripMenuItem.Click += new System.EventHandler(this.listarCursoPorTipoToolStripMenuItem_Click);
            // 
            // notaMECToolStripMenuItem
            // 
            this.notaMECToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atribuirNovaNotaToolStripMenuItem,
            this.buscarAvaliaçõesToolStripMenuItem,
            this.gerarRelatórioDeNotasToolStripMenuItem});
            this.notaMECToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notaMECToolStripMenuItem.Image = global::Gerenciador.Properties.Resources.notas_check;
            this.notaMECToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.notaMECToolStripMenuItem.Name = "notaMECToolStripMenuItem";
            this.notaMECToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.notaMECToolStripMenuItem.Text = "Nota MEC";
            // 
            // atribuirNovaNotaToolStripMenuItem
            // 
            this.atribuirNovaNotaToolStripMenuItem.Name = "atribuirNovaNotaToolStripMenuItem";
            this.atribuirNovaNotaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.atribuirNovaNotaToolStripMenuItem.Text = "Atribuir nova nota";
            this.atribuirNovaNotaToolStripMenuItem.Click += new System.EventHandler(this.atribuirNovaNotaToolStripMenuItem_Click);
            // 
            // buscarAvaliaçõesToolStripMenuItem
            // 
            this.buscarAvaliaçõesToolStripMenuItem.Name = "buscarAvaliaçõesToolStripMenuItem";
            this.buscarAvaliaçõesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.buscarAvaliaçõesToolStripMenuItem.Text = "Detalhes de avaliações";
            this.buscarAvaliaçõesToolStripMenuItem.Click += new System.EventHandler(this.buscarAvaliaçõesToolStripMenuItem_Click);
            // 
            // gerarRelatórioDeNotasToolStripMenuItem
            // 
            this.gerarRelatórioDeNotasToolStripMenuItem.Name = "gerarRelatórioDeNotasToolStripMenuItem";
            this.gerarRelatórioDeNotasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.gerarRelatórioDeNotasToolStripMenuItem.Text = "Gerar relatório de notas";
            this.gerarRelatórioDeNotasToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatórioDeNotasToolStripMenuItem_Click);
            // 
            // questõesToolStripMenuItem
            // 
            this.questõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarPerguntaToolStripMenuItem,
            this.buscarModificarToolStripMenuItem,
            this.visualizarQuestõesToolStripMenuItem});
            this.questõesToolStripMenuItem.Image = global::Gerenciador.Properties.Resources.help_512_1_;
            this.questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            this.questõesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.questõesToolStripMenuItem.Text = "Questões";
            // 
            // criarPerguntaToolStripMenuItem
            // 
            this.criarPerguntaToolStripMenuItem.Name = "criarPerguntaToolStripMenuItem";
            this.criarPerguntaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.criarPerguntaToolStripMenuItem.Text = "Criar nova questão";
            this.criarPerguntaToolStripMenuItem.Click += new System.EventHandler(this.criarPerguntaToolStripMenuItem_Click);
            // 
            // buscarModificarToolStripMenuItem
            // 
            this.buscarModificarToolStripMenuItem.Name = "buscarModificarToolStripMenuItem";
            this.buscarModificarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buscarModificarToolStripMenuItem.Text = "Buscar/Modificar";
            this.buscarModificarToolStripMenuItem.Click += new System.EventHandler(this.buscarModificarToolStripMenuItem_Click);
            // 
            // visualizarQuestõesToolStripMenuItem
            // 
            this.visualizarQuestõesToolStripMenuItem.Name = "visualizarQuestõesToolStripMenuItem";
            this.visualizarQuestõesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.visualizarQuestõesToolStripMenuItem.Text = "Visualizar questões";
            this.visualizarQuestõesToolStripMenuItem.Click += new System.EventHandler(this.visualizarQuestõesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Gerenciador.Properties.Resources.fundoSair3;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Gerenciador.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(250, 169);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(282, 125);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOP Manager - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.Gerenciador_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarTestesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faculdadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarEAtualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosDeCadaInstituiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosPorAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCursoPorTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaMECToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atribuirNovaNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAvaliaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarPerguntaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarQuestõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarModificarToolStripMenuItem;
        public System.Windows.Forms.PictureBox picLogo;
    }
}