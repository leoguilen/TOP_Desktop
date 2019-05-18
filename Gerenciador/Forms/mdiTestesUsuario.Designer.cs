namespace Gerenciador.Forms
{
    partial class mdiTestesUsuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeViewTeste = new System.Windows.Forms.TreeView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxDadosAtualizar = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblIDTeste = new System.Windows.Forms.Label();
            this.txtIdTeste = new System.Windows.Forms.TextBox();
            this.groupBoxResultadoAreas = new System.Windows.Forms.GroupBox();
            this.txtExatas = new System.Windows.Forms.TextBox();
            this.txtHumanas = new System.Windows.Forms.TextBox();
            this.lblBiologicas = new System.Windows.Forms.Label();
            this.lblHumanas = new System.Windows.Forms.Label();
            this.txtBiologicas = new System.Windows.Forms.TextBox();
            this.lblExatas = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblIDUser = new System.Windows.Forms.Label();
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.lblTestes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxDadosAtualizar.SuspendLayout();
            this.groupBoxResultadoAreas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1113, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // treeViewTeste
            // 
            this.treeViewTeste.Location = new System.Drawing.Point(21, 95);
            this.treeViewTeste.Name = "treeViewTeste";
            this.treeViewTeste.Size = new System.Drawing.Size(395, 454);
            this.treeViewTeste.TabIndex = 54;
            this.treeViewTeste.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewTeste_NodeMouseDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(557, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 31);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "Testes";
            // 
            // groupBoxDadosAtualizar
            // 
            this.groupBoxDadosAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDadosAtualizar.Controls.Add(this.lblArea);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtArea);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblCurso);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtCurso);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblIDTeste);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtIdTeste);
            this.groupBoxDadosAtualizar.Controls.Add(this.groupBoxResultadoAreas);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtDuracao);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblDuracao);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblUsername);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtUsername);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblIDUser);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtIDUser);
            this.groupBoxDadosAtualizar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDadosAtualizar.Location = new System.Drawing.Point(445, 95);
            this.groupBoxDadosAtualizar.Name = "groupBoxDadosAtualizar";
            this.groupBoxDadosAtualizar.Size = new System.Drawing.Size(700, 418);
            this.groupBoxDadosAtualizar.TabIndex = 86;
            this.groupBoxDadosAtualizar.TabStop = false;
            this.groupBoxDadosAtualizar.Text = "Informações do teste";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(411, 349);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(48, 15);
            this.lblArea.TabIndex = 113;
            this.lblArea.Text = "Area ";
            // 
            // txtArea
            // 
            this.txtArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArea.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtArea.Location = new System.Drawing.Point(417, 367);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(111, 22);
            this.txtArea.TabIndex = 112;
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(188, 349);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(146, 15);
            this.lblCurso.TabIndex = 111;
            this.lblCurso.Text = "Curso selecionado";
            // 
            // txtCurso
            // 
            this.txtCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurso.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCurso.Location = new System.Drawing.Point(191, 367);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(208, 22);
            this.txtCurso.TabIndex = 110;
            // 
            // lblIDTeste
            // 
            this.lblIDTeste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDTeste.AutoSize = true;
            this.lblIDTeste.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTeste.Location = new System.Drawing.Point(332, 25);
            this.lblIDTeste.Name = "lblIDTeste";
            this.lblIDTeste.Size = new System.Drawing.Size(61, 15);
            this.lblIDTeste.TabIndex = 109;
            this.lblIDTeste.Text = "ID Teste";
            // 
            // txtIdTeste
            // 
            this.txtIdTeste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdTeste.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTeste.Location = new System.Drawing.Point(335, 43);
            this.txtIdTeste.Name = "txtIdTeste";
            this.txtIdTeste.ReadOnly = true;
            this.txtIdTeste.Size = new System.Drawing.Size(58, 22);
            this.txtIdTeste.TabIndex = 108;
            // 
            // groupBoxResultadoAreas
            // 
            this.groupBoxResultadoAreas.Controls.Add(this.txtExatas);
            this.groupBoxResultadoAreas.Controls.Add(this.txtHumanas);
            this.groupBoxResultadoAreas.Controls.Add(this.lblBiologicas);
            this.groupBoxResultadoAreas.Controls.Add(this.lblHumanas);
            this.groupBoxResultadoAreas.Controls.Add(this.txtBiologicas);
            this.groupBoxResultadoAreas.Controls.Add(this.lblExatas);
            this.groupBoxResultadoAreas.Location = new System.Drawing.Point(191, 217);
            this.groupBoxResultadoAreas.Name = "groupBoxResultadoAreas";
            this.groupBoxResultadoAreas.Size = new System.Drawing.Size(343, 112);
            this.groupBoxResultadoAreas.TabIndex = 107;
            this.groupBoxResultadoAreas.TabStop = false;
            this.groupBoxResultadoAreas.Text = "Resultado Areas";
            // 
            // txtExatas
            // 
            this.txtExatas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExatas.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtExatas.Location = new System.Drawing.Point(16, 54);
            this.txtExatas.Name = "txtExatas";
            this.txtExatas.ReadOnly = true;
            this.txtExatas.Size = new System.Drawing.Size(83, 22);
            this.txtExatas.TabIndex = 104;
            // 
            // txtHumanas
            // 
            this.txtHumanas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHumanas.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtHumanas.Location = new System.Drawing.Point(125, 54);
            this.txtHumanas.Name = "txtHumanas";
            this.txtHumanas.ReadOnly = true;
            this.txtHumanas.Size = new System.Drawing.Size(83, 22);
            this.txtHumanas.TabIndex = 106;
            // 
            // lblBiologicas
            // 
            this.lblBiologicas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBiologicas.AutoSize = true;
            this.lblBiologicas.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblBiologicas.Location = new System.Drawing.Point(229, 36);
            this.lblBiologicas.Name = "lblBiologicas";
            this.lblBiologicas.Size = new System.Drawing.Size(86, 15);
            this.lblBiologicas.TabIndex = 101;
            this.lblBiologicas.Text = "Biológicas";
            // 
            // lblHumanas
            // 
            this.lblHumanas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHumanas.AutoSize = true;
            this.lblHumanas.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblHumanas.Location = new System.Drawing.Point(122, 36);
            this.lblHumanas.Name = "lblHumanas";
            this.lblHumanas.Size = new System.Drawing.Size(75, 15);
            this.lblHumanas.TabIndex = 105;
            this.lblHumanas.Text = "Humanas";
            // 
            // txtBiologicas
            // 
            this.txtBiologicas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBiologicas.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtBiologicas.Location = new System.Drawing.Point(232, 54);
            this.txtBiologicas.Name = "txtBiologicas";
            this.txtBiologicas.ReadOnly = true;
            this.txtBiologicas.Size = new System.Drawing.Size(83, 22);
            this.txtBiologicas.TabIndex = 102;
            // 
            // lblExatas
            // 
            this.lblExatas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExatas.AutoSize = true;
            this.lblExatas.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblExatas.Location = new System.Drawing.Point(13, 36);
            this.lblExatas.Name = "lblExatas";
            this.lblExatas.Size = new System.Drawing.Size(58, 15);
            this.lblExatas.TabIndex = 103;
            this.lblExatas.Text = "Exatas";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDuracao.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDuracao.Location = new System.Drawing.Point(191, 177);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.ReadOnly = true;
            this.txtDuracao.Size = new System.Drawing.Size(82, 22);
            this.txtDuracao.TabIndex = 100;
            // 
            // lblDuracao
            // 
            this.lblDuracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblDuracao.Location = new System.Drawing.Point(188, 159);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(140, 15);
            this.lblDuracao.TabIndex = 99;
            this.lblDuracao.Text = "DURAÇÂO DO TESTE";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(290, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 15);
            this.lblUsername.TabIndex = 97;
            this.lblUsername.Text = "USERNAME";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtUsername.Location = new System.Drawing.Point(293, 115);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(213, 22);
            this.txtUsername.TabIndex = 95;
            // 
            // lblIDUser
            // 
            this.lblIDUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDUser.AutoSize = true;
            this.lblIDUser.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUser.Location = new System.Drawing.Point(188, 97);
            this.lblIDUser.Name = "lblIDUser";
            this.lblIDUser.Size = new System.Drawing.Size(85, 15);
            this.lblIDUser.TabIndex = 94;
            this.lblIDUser.Text = "ID Usuário";
            // 
            // txtIDUser
            // 
            this.txtIDUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUser.Location = new System.Drawing.Point(191, 115);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.ReadOnly = true;
            this.txtIDUser.Size = new System.Drawing.Size(82, 22);
            this.txtIDUser.TabIndex = 93;
            // 
            // lblTestes
            // 
            this.lblTestes.AutoSize = true;
            this.lblTestes.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblTestes.Location = new System.Drawing.Point(18, 68);
            this.lblTestes.Name = "lblTestes";
            this.lblTestes.Size = new System.Drawing.Size(140, 15);
            this.lblTestes.TabIndex = 87;
            this.lblTestes.Text = "Testes de usuários";
            // 
            // mdiTestesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblTestes);
            this.Controls.Add(this.groupBoxDadosAtualizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.treeViewTeste);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiTestesUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar testes";
            this.Load += new System.EventHandler(this.mdiTestesUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxDadosAtualizar.ResumeLayout(false);
            this.groupBoxDadosAtualizar.PerformLayout();
            this.groupBoxResultadoAreas.ResumeLayout(false);
            this.groupBoxResultadoAreas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeViewTeste;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxDadosAtualizar;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblIDUser;
        private System.Windows.Forms.TextBox txtIDUser;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtHumanas;
        private System.Windows.Forms.Label lblHumanas;
        private System.Windows.Forms.TextBox txtExatas;
        private System.Windows.Forms.Label lblExatas;
        private System.Windows.Forms.TextBox txtBiologicas;
        private System.Windows.Forms.Label lblBiologicas;
        private System.Windows.Forms.GroupBox groupBoxResultadoAreas;
        private System.Windows.Forms.Label lblTestes;
        private System.Windows.Forms.Label lblIDTeste;
        private System.Windows.Forms.TextBox txtIdTeste;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblCurso;
    }
}