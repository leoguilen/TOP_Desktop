namespace Gerenciador.Forms.Consultas
{
    partial class mdiListarCursosPorArea
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
            this.lblTestes = new System.Windows.Forms.Label();
            this.groupBoxDadosAtualizar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipoCurso = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescCurso = new System.Windows.Forms.TextBox();
            this.lblIDTeste = new System.Windows.Forms.Label();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.treeViewCurso = new System.Windows.Forms.TreeView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picImgCurso = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDadosAtualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestes
            // 
            this.lblTestes.AutoSize = true;
            this.lblTestes.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblTestes.Location = new System.Drawing.Point(29, 61);
            this.lblTestes.Name = "lblTestes";
            this.lblTestes.Size = new System.Drawing.Size(140, 15);
            this.lblTestes.TabIndex = 101;
            this.lblTestes.Text = "Cursos Dísponiveis";
            // 
            // groupBoxDadosAtualizar
            // 
            this.groupBoxDadosAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDadosAtualizar.Controls.Add(this.picImgCurso);
            this.groupBoxDadosAtualizar.Controls.Add(this.label2);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtDuracao);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblTipo);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtTipoCurso);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblArea);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtArea);
            this.groupBoxDadosAtualizar.Controls.Add(this.label1);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtDescCurso);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblIDTeste);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtIdCurso);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblCurso);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtCurso);
            this.groupBoxDadosAtualizar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDadosAtualizar.Location = new System.Drawing.Point(456, 88);
            this.groupBoxDadosAtualizar.Name = "groupBoxDadosAtualizar";
            this.groupBoxDadosAtualizar.Size = new System.Drawing.Size(700, 418);
            this.groupBoxDadosAtualizar.TabIndex = 100;
            this.groupBoxDadosAtualizar.TabStop = false;
            this.groupBoxDadosAtualizar.Text = "Informações do curso";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 117;
            this.label2.Text = "Duração média";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDuracao.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracao.Location = new System.Drawing.Point(198, 241);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.ReadOnly = true;
            this.txtDuracao.Size = new System.Drawing.Size(149, 22);
            this.txtDuracao.TabIndex = 116;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(23, 223);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(110, 15);
            this.lblTipo.TabIndex = 115;
            this.lblTipo.Text = "Tipo do curso";
            // 
            // txtTipoCurso
            // 
            this.txtTipoCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTipoCurso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCurso.Location = new System.Drawing.Point(26, 241);
            this.txtTipoCurso.Name = "txtTipoCurso";
            this.txtTipoCurso.ReadOnly = true;
            this.txtTipoCurso.Size = new System.Drawing.Size(138, 22);
            this.txtTipoCurso.TabIndex = 114;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(25, 160);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(44, 15);
            this.lblArea.TabIndex = 113;
            this.lblArea.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(28, 178);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(204, 22);
            this.txtArea.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 111;
            this.label1.Text = "Descrição do curso";
            // 
            // txtDescCurso
            // 
            this.txtDescCurso.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDescCurso.Location = new System.Drawing.Point(25, 301);
            this.txtDescCurso.Multiline = true;
            this.txtDescCurso.Name = "txtDescCurso";
            this.txtDescCurso.ReadOnly = true;
            this.txtDescCurso.Size = new System.Drawing.Size(400, 102);
            this.txtDescCurso.TabIndex = 110;
            // 
            // lblIDTeste
            // 
            this.lblIDTeste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDTeste.AutoSize = true;
            this.lblIDTeste.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTeste.Location = new System.Drawing.Point(22, 29);
            this.lblIDTeste.Name = "lblIDTeste";
            this.lblIDTeste.Size = new System.Drawing.Size(70, 15);
            this.lblIDTeste.TabIndex = 109;
            this.lblIDTeste.Text = "ID Curso";
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCurso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCurso.Location = new System.Drawing.Point(25, 47);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.ReadOnly = true;
            this.txtIdCurso.Size = new System.Drawing.Size(58, 22);
            this.txtIdCurso.TabIndex = 108;
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(23, 101);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(52, 15);
            this.lblCurso.TabIndex = 94;
            this.lblCurso.Text = "Curso";
            // 
            // txtCurso
            // 
            this.txtCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(26, 119);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(293, 22);
            this.txtCurso.TabIndex = 93;
            // 
            // treeViewCurso
            // 
            this.treeViewCurso.Location = new System.Drawing.Point(32, 88);
            this.treeViewCurso.Name = "treeViewCurso";
            this.treeViewCurso.Size = new System.Drawing.Size(395, 454);
            this.treeViewCurso.TabIndex = 98;
            this.treeViewCurso.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewCurso_NodeMouseDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(499, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 31);
            this.lblTitulo.TabIndex = 99;
            this.lblTitulo.Text = "Cursos por area";
            // 
            // picImgCurso
            // 
            this.picImgCurso.Location = new System.Drawing.Point(350, 38);
            this.picImgCurso.Name = "picImgCurso";
            this.picImgCurso.Size = new System.Drawing.Size(329, 137);
            this.picImgCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgCurso.TabIndex = 118;
            this.picImgCurso.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1113, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // mdiListarCursosPorArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblTestes);
            this.Controls.Add(this.groupBoxDadosAtualizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.treeViewCurso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiListarCursosPorArea";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Cursos";
            this.Load += new System.EventHandler(this.mdiListarCursos_Load);
            this.groupBoxDadosAtualizar.ResumeLayout(false);
            this.groupBoxDadosAtualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTestes;
        private System.Windows.Forms.GroupBox groupBoxDadosAtualizar;
        private System.Windows.Forms.Label lblIDTeste;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TreeView treeViewCurso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescCurso;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipoCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.PictureBox picImgCurso;
    }
}