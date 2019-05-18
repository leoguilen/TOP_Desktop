namespace Gerenciador.Forms.Cadastros
{
    partial class mdiNovoCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiNovoCurso));
            this.lblDescCurso = new System.Windows.Forms.Label();
            this.txtDescCur = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.cboxDuracao = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCur = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.radioPG = new System.Windows.Forms.RadioButton();
            this.radioG = new System.Windows.Forms.RadioButton();
            this.groupTipoCurso = new System.Windows.Forms.GroupBox();
            this.btnBuscarImg = new System.Windows.Forms.Button();
            this.errCadCurso = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblArea = new System.Windows.Forms.Label();
            this.cboxAreas = new System.Windows.Forms.ComboBox();
            this.btnNovaArea = new System.Windows.Forms.Button();
            this.picImgCurso = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNovoCad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupMaxEMin = new System.Windows.Forms.GroupBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.maskTxtMax = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtMin = new System.Windows.Forms.MaskedTextBox();
            this.groupTipoCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCadCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupMaxEMin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescCurso
            // 
            this.lblDescCurso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDescCurso.AutoSize = true;
            this.lblDescCurso.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCurso.Location = new System.Drawing.Point(71, 232);
            this.lblDescCurso.Name = "lblDescCurso";
            this.lblDescCurso.Size = new System.Drawing.Size(155, 15);
            this.lblDescCurso.TabIndex = 126;
            this.lblDescCurso.Text = "Descrição do curso";
            // 
            // txtDescCur
            // 
            this.txtDescCur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDescCur.Location = new System.Drawing.Point(74, 255);
            this.txtDescCur.Multiline = true;
            this.txtDescCur.Name = "txtDescCur";
            this.txtDescCur.Size = new System.Drawing.Size(467, 97);
            this.txtDescCur.TabIndex = 104;
            this.txtDescCur.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescCur_Validating);
            // 
            // lblDuracao
            // 
            this.lblDuracao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Location = new System.Drawing.Point(402, 395);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(76, 15);
            this.lblDuracao.TabIndex = 116;
            this.lblDuracao.Text = "Duração";
            // 
            // cboxDuracao
            // 
            this.cboxDuracao.FormattingEnabled = true;
            this.cboxDuracao.Location = new System.Drawing.Point(404, 413);
            this.cboxDuracao.Name = "cboxDuracao";
            this.cboxDuracao.Size = new System.Drawing.Size(134, 21);
            this.cboxDuracao.TabIndex = 106;
            this.cboxDuracao.Validating += new System.ComponentModel.CancelEventHandler(this.cboxDuracao_Validating);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(70, 156);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 15);
            this.lblNome.TabIndex = 104;
            this.lblNome.Text = "Nome curso";
            // 
            // txtNomeCur
            // 
            this.txtNomeCur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNomeCur.Location = new System.Drawing.Point(72, 176);
            this.txtNomeCur.Name = "txtNomeCur";
            this.txtNomeCur.Size = new System.Drawing.Size(466, 20);
            this.txtNomeCur.TabIndex = 103;
            this.txtNomeCur.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomeCur_Validating);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(457, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 54);
            this.lblTitulo.TabIndex = 102;
            this.lblTitulo.Text = "Cadastro de curso";
            // 
            // radioPG
            // 
            this.radioPG.AutoSize = true;
            this.radioPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.radioPG.Location = new System.Drawing.Point(145, 33);
            this.radioPG.Name = "radioPG";
            this.radioPG.Size = new System.Drawing.Size(126, 20);
            this.radioPG.TabIndex = 51;
            this.radioPG.TabStop = true;
            this.radioPG.Text = "Pós-Graduação";
            this.radioPG.UseVisualStyleBackColor = true;
            // 
            // radioG
            // 
            this.radioG.AutoSize = true;
            this.radioG.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.radioG.Location = new System.Drawing.Point(25, 33);
            this.radioG.Name = "radioG";
            this.radioG.Size = new System.Drawing.Size(96, 20);
            this.radioG.TabIndex = 50;
            this.radioG.TabStop = true;
            this.radioG.Text = "Graduação";
            this.radioG.UseVisualStyleBackColor = true;
            // 
            // groupTipoCurso
            // 
            this.groupTipoCurso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupTipoCurso.Controls.Add(this.radioPG);
            this.groupTipoCurso.Controls.Add(this.radioG);
            this.groupTipoCurso.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupTipoCurso.Location = new System.Drawing.Point(74, 375);
            this.groupTipoCurso.Name = "groupTipoCurso";
            this.groupTipoCurso.Size = new System.Drawing.Size(288, 78);
            this.groupTipoCurso.TabIndex = 105;
            this.groupTipoCurso.TabStop = false;
            this.groupTipoCurso.Text = "Tipo curso";
            this.groupTipoCurso.Validating += new System.ComponentModel.CancelEventHandler(this.groupTipoCurso_Validating);
            // 
            // btnBuscarImg
            // 
            this.btnBuscarImg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnBuscarImg.Location = new System.Drawing.Point(955, 139);
            this.btnBuscarImg.Name = "btnBuscarImg";
            this.btnBuscarImg.Size = new System.Drawing.Size(204, 31);
            this.btnBuscarImg.TabIndex = 128;
            this.btnBuscarImg.Text = "Buscar imagem ";
            this.btnBuscarImg.UseVisualStyleBackColor = true;
            this.btnBuscarImg.Click += new System.EventHandler(this.btnBuscarImg_Click);
            // 
            // errCadCurso
            // 
            this.errCadCurso.ContainerControl = this;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(72, 465);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(44, 15);
            this.lblArea.TabIndex = 131;
            this.lblArea.Text = "Area";
            // 
            // cboxAreas
            // 
            this.cboxAreas.FormattingEnabled = true;
            this.cboxAreas.Location = new System.Drawing.Point(74, 483);
            this.cboxAreas.Name = "cboxAreas";
            this.cboxAreas.Size = new System.Drawing.Size(288, 21);
            this.cboxAreas.TabIndex = 107;
            this.cboxAreas.Validating += new System.ComponentModel.CancelEventHandler(this.cboxAreas_Validating);
            // 
            // btnNovaArea
            // 
            this.btnNovaArea.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnNovaArea.Location = new System.Drawing.Point(404, 481);
            this.btnNovaArea.Name = "btnNovaArea";
            this.btnNovaArea.Size = new System.Drawing.Size(134, 26);
            this.btnNovaArea.TabIndex = 132;
            this.btnNovaArea.Text = "Nova area";
            this.btnNovaArea.UseVisualStyleBackColor = true;
            this.btnNovaArea.Click += new System.EventHandler(this.btnNovaArea_Click);
            // 
            // picImgCurso
            // 
            this.picImgCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picImgCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImgCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImgCurso.Location = new System.Drawing.Point(626, 176);
            this.picImgCurso.Name = "picImgCurso";
            this.picImgCurso.Size = new System.Drawing.Size(533, 220);
            this.picImgCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgCurso.TabIndex = 129;
            this.picImgCurso.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Gerenciador.Properties.Resources.Deletion_icon;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Location = new System.Drawing.Point(1099, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 49);
            this.btnCancelar.TabIndex = 123;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = global::Gerenciador.Properties.Resources.confirmaUser1;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.Location = new System.Drawing.Point(1022, 447);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(60, 49);
            this.btnConfirmar.TabIndex = 122;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnNovoCad
            // 
            this.btnNovoCad.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoCad.BackgroundImage = global::Gerenciador.Properties.Resources.adicionar;
            this.btnNovoCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoCad.Location = new System.Drawing.Point(74, 61);
            this.btnNovoCad.Name = "btnNovoCad";
            this.btnNovoCad.Size = new System.Drawing.Size(56, 49);
            this.btnNovoCad.TabIndex = 121;
            this.btnNovoCad.UseVisualStyleBackColor = false;
            this.btnNovoCad.Click += new System.EventHandler(this.btnNovoCad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1113, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupMaxEMin
            // 
            this.groupMaxEMin.Controls.Add(this.lblMax);
            this.groupMaxEMin.Controls.Add(this.lblMin);
            this.groupMaxEMin.Controls.Add(this.maskTxtMax);
            this.groupMaxEMin.Controls.Add(this.maskTxtMin);
            this.groupMaxEMin.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupMaxEMin.Location = new System.Drawing.Point(626, 431);
            this.groupMaxEMin.Name = "groupMaxEMin";
            this.groupMaxEMin.Size = new System.Drawing.Size(354, 76);
            this.groupMaxEMin.TabIndex = 135;
            this.groupMaxEMin.TabStop = false;
            this.groupMaxEMin.Text = "Valores Max e Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lblMax.Location = new System.Drawing.Point(186, 33);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(37, 16);
            this.lblMax.TabIndex = 138;
            this.lblMax.Text = "MAX";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lblMin.Location = new System.Drawing.Point(24, 34);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(33, 16);
            this.lblMin.TabIndex = 137;
            this.lblMin.Text = "MIN";
            // 
            // maskTxtMax
            // 
            this.maskTxtMax.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.maskTxtMax.Location = new System.Drawing.Point(227, 31);
            this.maskTxtMax.Mask = "##%";
            this.maskTxtMax.Name = "maskTxtMax";
            this.maskTxtMax.Size = new System.Drawing.Size(100, 23);
            this.maskTxtMax.TabIndex = 136;
            this.maskTxtMax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskTxtMax.Validating += new System.ComponentModel.CancelEventHandler(this.maskTxtMax_Validating);
            // 
            // maskTxtMin
            // 
            this.maskTxtMin.AllowPromptAsInput = false;
            this.maskTxtMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.maskTxtMin.Location = new System.Drawing.Point(63, 31);
            this.maskTxtMin.Mask = "##%";
            this.maskTxtMin.Name = "maskTxtMin";
            this.maskTxtMin.Size = new System.Drawing.Size(100, 23);
            this.maskTxtMin.TabIndex = 135;
            this.maskTxtMin.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskTxtMin.Validating += new System.ComponentModel.CancelEventHandler(this.maskTxtMin_Validating);
            // 
            // mdiNovoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupMaxEMin);
            this.Controls.Add(this.btnNovaArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cboxAreas);
            this.Controls.Add(this.picImgCurso);
            this.Controls.Add(this.btnBuscarImg);
            this.Controls.Add(this.groupTipoCurso);
            this.Controls.Add(this.lblDescCurso);
            this.Controls.Add(this.txtDescCur);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnNovoCad);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.cboxDuracao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomeCur);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mdiNovoCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo curso";
            this.Load += new System.EventHandler(this.mdiNovoCurso_Load);
            this.groupTipoCurso.ResumeLayout(false);
            this.groupTipoCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCadCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupMaxEMin.ResumeLayout(false);
            this.groupMaxEMin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescCurso;
        private System.Windows.Forms.TextBox txtDescCur;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnNovoCad;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.ComboBox cboxDuracao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCur;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton radioPG;
        private System.Windows.Forms.RadioButton radioG;
        private System.Windows.Forms.GroupBox groupTipoCurso;
        private System.Windows.Forms.Button btnBuscarImg;
        private System.Windows.Forms.PictureBox picImgCurso;
        private System.Windows.Forms.ErrorProvider errCadCurso;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cboxAreas;
        private System.Windows.Forms.Button btnNovaArea;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupMaxEMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.MaskedTextBox maskTxtMax;
        private System.Windows.Forms.MaskedTextBox maskTxtMin;
    }
}