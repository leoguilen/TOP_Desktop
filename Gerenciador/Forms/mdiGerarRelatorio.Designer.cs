namespace Gerenciador.Forms
{
    partial class mdiGerarRelatorio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.treeViewUsuarios = new System.Windows.Forms.TreeView();
            this.lblCampos = new System.Windows.Forms.Label();
            this.lblVisuRelatorio = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cboxIdUser = new System.Windows.Forms.CheckBox();
            this.cboxUsername = new System.Windows.Forms.CheckBox();
            this.cboxIdTeste = new System.Windows.Forms.CheckBox();
            this.cboxInicio = new System.Windows.Forms.CheckBox();
            this.cboxFinal = new System.Windows.Forms.CheckBox();
            this.cboxDuracao = new System.Windows.Forms.CheckBox();
            this.cboxResultados = new System.Windows.Forms.CheckBox();
            this.cboxDetCurso = new System.Windows.Forms.CheckBox();
            this.cboxDetFacul = new System.Windows.Forms.CheckBox();
            this.cboxNota = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewVisuRelatorio = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(533, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Relatórios";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarios.Location = new System.Drawing.Point(39, 95);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(73, 15);
            this.lblUsuarios.TabIndex = 89;
            this.lblUsuarios.Text = "Usuários";
            // 
            // treeViewUsuarios
            // 
            this.treeViewUsuarios.Location = new System.Drawing.Point(42, 125);
            this.treeViewUsuarios.Name = "treeViewUsuarios";
            this.treeViewUsuarios.Size = new System.Drawing.Size(316, 409);
            this.treeViewUsuarios.TabIndex = 88;
            this.treeViewUsuarios.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewUsuarios_NodeMouseDoubleClick);
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblCampos.Location = new System.Drawing.Point(389, 95);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(62, 15);
            this.lblCampos.TabIndex = 92;
            this.lblCampos.Text = "Campos";
            // 
            // lblVisuRelatorio
            // 
            this.lblVisuRelatorio.AutoSize = true;
            this.lblVisuRelatorio.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblVisuRelatorio.Location = new System.Drawing.Point(698, 95);
            this.lblVisuRelatorio.Name = "lblVisuRelatorio";
            this.lblVisuRelatorio.Size = new System.Drawing.Size(250, 15);
            this.lblVisuRelatorio.TabIndex = 93;
            this.lblVisuRelatorio.Text = "Pré-visualização dos relatórios";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.Teal;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(946, 448);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(209, 38);
            this.btnGerarRelatorio.TabIndex = 95;
            this.btnGerarRelatorio.Text = "Gerar relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1113, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = global::Gerenciador.Properties.Resources.Deletion_icon;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemover.Location = new System.Drawing.Point(1113, 85);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(42, 34);
            this.btnRemover.TabIndex = 98;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cboxIdUser
            // 
            this.cboxIdUser.AutoCheck = false;
            this.cboxIdUser.AutoSize = true;
            this.cboxIdUser.Location = new System.Drawing.Point(20, 22);
            this.cboxIdUser.Name = "cboxIdUser";
            this.cboxIdUser.Size = new System.Drawing.Size(76, 17);
            this.cboxIdUser.TabIndex = 0;
            this.cboxIdUser.Text = "ID Usuário";
            this.cboxIdUser.UseVisualStyleBackColor = true;
            this.cboxIdUser.CheckedChanged += new System.EventHandler(this.cboxIdUser_CheckedChanged);
            // 
            // cboxUsername
            // 
            this.cboxUsername.AutoCheck = false;
            this.cboxUsername.AutoSize = true;
            this.cboxUsername.Location = new System.Drawing.Point(20, 45);
            this.cboxUsername.Name = "cboxUsername";
            this.cboxUsername.Size = new System.Drawing.Size(74, 17);
            this.cboxUsername.TabIndex = 1;
            this.cboxUsername.Text = "Username";
            this.cboxUsername.UseVisualStyleBackColor = true;
            this.cboxUsername.CheckedChanged += new System.EventHandler(this.cboxUsername_CheckedChanged);
            // 
            // cboxIdTeste
            // 
            this.cboxIdTeste.AutoCheck = false;
            this.cboxIdTeste.AutoSize = true;
            this.cboxIdTeste.Location = new System.Drawing.Point(20, 68);
            this.cboxIdTeste.Name = "cboxIdTeste";
            this.cboxIdTeste.Size = new System.Drawing.Size(67, 17);
            this.cboxIdTeste.TabIndex = 2;
            this.cboxIdTeste.Text = "ID Teste";
            this.cboxIdTeste.UseVisualStyleBackColor = true;
            this.cboxIdTeste.CheckedChanged += new System.EventHandler(this.cboxIdTeste_CheckedChanged);
            // 
            // cboxInicio
            // 
            this.cboxInicio.AutoCheck = false;
            this.cboxInicio.AutoSize = true;
            this.cboxInicio.Location = new System.Drawing.Point(20, 91);
            this.cboxInicio.Name = "cboxInicio";
            this.cboxInicio.Size = new System.Drawing.Size(77, 17);
            this.cboxInicio.TabIndex = 3;
            this.cboxInicio.Text = "Inicio teste";
            this.cboxInicio.UseVisualStyleBackColor = true;
            this.cboxInicio.CheckedChanged += new System.EventHandler(this.cboxInicio_CheckedChanged);
            // 
            // cboxFinal
            // 
            this.cboxFinal.AutoCheck = false;
            this.cboxFinal.AutoSize = true;
            this.cboxFinal.Location = new System.Drawing.Point(20, 114);
            this.cboxFinal.Name = "cboxFinal";
            this.cboxFinal.Size = new System.Drawing.Size(74, 17);
            this.cboxFinal.TabIndex = 4;
            this.cboxFinal.Text = "Final teste";
            this.cboxFinal.UseVisualStyleBackColor = true;
            this.cboxFinal.CheckedChanged += new System.EventHandler(this.cboxFinal_CheckedChanged);
            // 
            // cboxDuracao
            // 
            this.cboxDuracao.AutoCheck = false;
            this.cboxDuracao.AutoSize = true;
            this.cboxDuracao.Location = new System.Drawing.Point(20, 137);
            this.cboxDuracao.Name = "cboxDuracao";
            this.cboxDuracao.Size = new System.Drawing.Size(93, 17);
            this.cboxDuracao.TabIndex = 5;
            this.cboxDuracao.Text = "Duração teste";
            this.cboxDuracao.UseVisualStyleBackColor = true;
            this.cboxDuracao.CheckedChanged += new System.EventHandler(this.cboxDuracao_CheckedChanged);
            // 
            // cboxResultados
            // 
            this.cboxResultados.AutoCheck = false;
            this.cboxResultados.AutoSize = true;
            this.cboxResultados.Location = new System.Drawing.Point(20, 160);
            this.cboxResultados.Name = "cboxResultados";
            this.cboxResultados.Size = new System.Drawing.Size(79, 17);
            this.cboxResultados.TabIndex = 6;
            this.cboxResultados.Text = "Resultados";
            this.cboxResultados.UseVisualStyleBackColor = true;
            this.cboxResultados.CheckedChanged += new System.EventHandler(this.cboxResultados_CheckedChanged);
            // 
            // cboxDetCurso
            // 
            this.cboxDetCurso.AutoCheck = false;
            this.cboxDetCurso.AutoSize = true;
            this.cboxDetCurso.Location = new System.Drawing.Point(20, 183);
            this.cboxDetCurso.Name = "cboxDetCurso";
            this.cboxDetCurso.Size = new System.Drawing.Size(112, 17);
            this.cboxDetCurso.TabIndex = 7;
            this.cboxDetCurso.Text = "Detalhes do curso";
            this.cboxDetCurso.UseVisualStyleBackColor = true;
            this.cboxDetCurso.CheckedChanged += new System.EventHandler(this.cboxDetCurso_CheckedChanged);
            // 
            // cboxDetFacul
            // 
            this.cboxDetFacul.AutoCheck = false;
            this.cboxDetFacul.AutoSize = true;
            this.cboxDetFacul.Location = new System.Drawing.Point(20, 206);
            this.cboxDetFacul.Name = "cboxDetFacul";
            this.cboxDetFacul.Size = new System.Drawing.Size(133, 17);
            this.cboxDetFacul.TabIndex = 8;
            this.cboxDetFacul.Text = "Detalhes da faculdade";
            this.cboxDetFacul.UseVisualStyleBackColor = true;
            this.cboxDetFacul.CheckedChanged += new System.EventHandler(this.cboxDetFacul_CheckedChanged);
            // 
            // cboxNota
            // 
            this.cboxNota.AutoCheck = false;
            this.cboxNota.AutoSize = true;
            this.cboxNota.Location = new System.Drawing.Point(20, 229);
            this.cboxNota.Name = "cboxNota";
            this.cboxNota.Size = new System.Drawing.Size(75, 17);
            this.cboxNota.TabIndex = 9;
            this.cboxNota.Text = "Nota MEC";
            this.cboxNota.UseVisualStyleBackColor = true;
            this.cboxNota.CheckedChanged += new System.EventHandler(this.cboxNota_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.cboxNota);
            this.groupBox1.Controls.Add(this.cboxDetFacul);
            this.groupBox1.Controls.Add(this.cboxDetCurso);
            this.groupBox1.Controls.Add(this.cboxResultados);
            this.groupBox1.Controls.Add(this.cboxDuracao);
            this.groupBox1.Controls.Add(this.cboxFinal);
            this.groupBox1.Controls.Add(this.cboxInicio);
            this.groupBox1.Controls.Add(this.cboxIdTeste);
            this.groupBox1.Controls.Add(this.cboxUsername);
            this.groupBox1.Controls.Add(this.cboxIdUser);
            this.groupBox1.Location = new System.Drawing.Point(392, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 416);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // treeViewVisuRelatorio
            // 
            this.treeViewVisuRelatorio.Location = new System.Drawing.Point(701, 125);
            this.treeViewVisuRelatorio.Name = "treeViewVisuRelatorio";
            this.treeViewVisuRelatorio.Size = new System.Drawing.Size(454, 317);
            this.treeViewVisuRelatorio.TabIndex = 101;
            this.treeViewVisuRelatorio.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewVisuRelatorio_NodeMouseClick);
            // 
            // mdiGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.treeViewVisuRelatorio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.lblVisuRelatorio);
            this.Controls.Add(this.lblCampos);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.treeViewUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiGerarRelatorio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Relatório";
            this.Load += new System.EventHandler(this.mdiGerarRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.TreeView treeViewUsuarios;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.Label lblVisuRelatorio;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.CheckBox cboxIdUser;
        private System.Windows.Forms.CheckBox cboxUsername;
        private System.Windows.Forms.CheckBox cboxIdTeste;
        private System.Windows.Forms.CheckBox cboxInicio;
        private System.Windows.Forms.CheckBox cboxFinal;
        private System.Windows.Forms.CheckBox cboxDuracao;
        private System.Windows.Forms.CheckBox cboxResultados;
        private System.Windows.Forms.CheckBox cboxDetCurso;
        private System.Windows.Forms.CheckBox cboxDetFacul;
        private System.Windows.Forms.CheckBox cboxNota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeViewVisuRelatorio;
    }
}