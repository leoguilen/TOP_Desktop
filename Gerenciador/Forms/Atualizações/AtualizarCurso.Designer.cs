namespace Gerenciador.Forms.Atualizações
{
    partial class AtualizarCurso
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
            this.lblCursoSelecionado = new System.Windows.Forms.Label();
            this.groupBoxDadosAtualizar = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboxAreas = new System.Windows.Forms.ComboBox();
            this.groupTipoCurso = new System.Windows.Forms.GroupBox();
            this.radioPG = new System.Windows.Forms.RadioButton();
            this.radioG = new System.Windows.Forms.RadioButton();
            this.lblDescCurso = new System.Windows.Forms.Label();
            this.txtDescCur = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.cboxDuracao = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCur = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupMaxEMin = new System.Windows.Forms.GroupBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.maskTxtMax = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtMin = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxDadosAtualizar.SuspendLayout();
            this.groupTipoCurso.SuspendLayout();
            this.groupMaxEMin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1006, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // lblCursoSelecionado
            // 
            this.lblCursoSelecionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCursoSelecionado.AutoSize = true;
            this.lblCursoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoSelecionado.Location = new System.Drawing.Point(12, 16);
            this.lblCursoSelecionado.Name = "lblCursoSelecionado";
            this.lblCursoSelecionado.Size = new System.Drawing.Size(139, 24);
            this.lblCursoSelecionado.TabIndex = 92;
            this.lblCursoSelecionado.Text = "Selecionado: ";
            // 
            // groupBoxDadosAtualizar
            // 
            this.groupBoxDadosAtualizar.Controls.Add(this.groupMaxEMin);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblArea);
            this.groupBoxDadosAtualizar.Controls.Add(this.cboxAreas);
            this.groupBoxDadosAtualizar.Controls.Add(this.groupTipoCurso);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblDescCurso);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtDescCur);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblDuracao);
            this.groupBoxDadosAtualizar.Controls.Add(this.cboxDuracao);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblNome);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtNomeCur);
            this.groupBoxDadosAtualizar.Controls.Add(this.btnCancelar);
            this.groupBoxDadosAtualizar.Controls.Add(this.btnSalvar);
            this.groupBoxDadosAtualizar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDadosAtualizar.Location = new System.Drawing.Point(12, 58);
            this.groupBoxDadosAtualizar.Name = "groupBoxDadosAtualizar";
            this.groupBoxDadosAtualizar.Size = new System.Drawing.Size(1053, 405);
            this.groupBoxDadosAtualizar.TabIndex = 91;
            this.groupBoxDadosAtualizar.TabStop = false;
            this.groupBoxDadosAtualizar.Text = "Dados do curso";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(642, 104);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(44, 15);
            this.lblArea.TabIndex = 161;
            this.lblArea.Text = "Area";
            // 
            // cboxAreas
            // 
            this.cboxAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboxAreas.FormattingEnabled = true;
            this.cboxAreas.Location = new System.Drawing.Point(644, 122);
            this.cboxAreas.Name = "cboxAreas";
            this.cboxAreas.Size = new System.Drawing.Size(310, 21);
            this.cboxAreas.TabIndex = 158;
            // 
            // groupTipoCurso
            // 
            this.groupTipoCurso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupTipoCurso.Controls.Add(this.radioPG);
            this.groupTipoCurso.Controls.Add(this.radioG);
            this.groupTipoCurso.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupTipoCurso.Location = new System.Drawing.Point(38, 284);
            this.groupTipoCurso.Name = "groupTipoCurso";
            this.groupTipoCurso.Size = new System.Drawing.Size(288, 78);
            this.groupTipoCurso.TabIndex = 156;
            this.groupTipoCurso.TabStop = false;
            this.groupTipoCurso.Text = "Tipo curso";
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
            // lblDescCurso
            // 
            this.lblDescCurso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDescCurso.AutoSize = true;
            this.lblDescCurso.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCurso.Location = new System.Drawing.Point(35, 130);
            this.lblDescCurso.Name = "lblDescCurso";
            this.lblDescCurso.Size = new System.Drawing.Size(155, 15);
            this.lblDescCurso.TabIndex = 160;
            this.lblDescCurso.Text = "Descrição do curso";
            // 
            // txtDescCur
            // 
            this.txtDescCur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDescCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDescCur.Location = new System.Drawing.Point(38, 153);
            this.txtDescCur.Multiline = true;
            this.txtDescCur.Name = "txtDescCur";
            this.txtDescCur.Size = new System.Drawing.Size(467, 97);
            this.txtDescCur.TabIndex = 154;
            // 
            // lblDuracao
            // 
            this.lblDuracao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Location = new System.Drawing.Point(365, 299);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(76, 15);
            this.lblDuracao.TabIndex = 159;
            this.lblDuracao.Text = "Duração";
            // 
            // cboxDuracao
            // 
            this.cboxDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboxDuracao.FormattingEnabled = true;
            this.cboxDuracao.Location = new System.Drawing.Point(368, 317);
            this.cboxDuracao.Name = "cboxDuracao";
            this.cboxDuracao.Size = new System.Drawing.Size(137, 21);
            this.cboxDuracao.TabIndex = 157;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(34, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 15);
            this.lblNome.TabIndex = 155;
            this.lblNome.Text = "Nome curso";
            // 
            // txtNomeCur
            // 
            this.txtNomeCur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNomeCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNomeCur.Location = new System.Drawing.Point(36, 74);
            this.txtNomeCur.Name = "txtNomeCur";
            this.txtNomeCur.Size = new System.Drawing.Size(466, 20);
            this.txtNomeCur.TabIndex = 153;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(807, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 41);
            this.btnCancelar.TabIndex = 127;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(654, 311);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(147, 41);
            this.btnSalvar.TabIndex = 126;
            this.btnSalvar.Text = "Salvar alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupMaxEMin
            // 
            this.groupMaxEMin.Controls.Add(this.lblMax);
            this.groupMaxEMin.Controls.Add(this.lblMin);
            this.groupMaxEMin.Controls.Add(this.maskTxtMax);
            this.groupMaxEMin.Controls.Add(this.maskTxtMin);
            this.groupMaxEMin.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupMaxEMin.Location = new System.Drawing.Point(624, 185);
            this.groupMaxEMin.Name = "groupMaxEMin";
            this.groupMaxEMin.Size = new System.Drawing.Size(354, 76);
            this.groupMaxEMin.TabIndex = 162;
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
            // 
            // AtualizarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 511);
            this.Controls.Add(this.lblCursoSelecionado);
            this.Controls.Add(this.groupBoxDadosAtualizar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AtualizarCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Curso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AtualizarCurso_FormClosing);
            this.Load += new System.EventHandler(this.AtualizarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxDadosAtualizar.ResumeLayout(false);
            this.groupBoxDadosAtualizar.PerformLayout();
            this.groupTipoCurso.ResumeLayout(false);
            this.groupTipoCurso.PerformLayout();
            this.groupMaxEMin.ResumeLayout(false);
            this.groupMaxEMin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCursoSelecionado;
        private System.Windows.Forms.GroupBox groupBoxDadosAtualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cboxAreas;
        private System.Windows.Forms.GroupBox groupTipoCurso;
        private System.Windows.Forms.RadioButton radioPG;
        private System.Windows.Forms.RadioButton radioG;
        private System.Windows.Forms.Label lblDescCurso;
        private System.Windows.Forms.TextBox txtDescCur;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.ComboBox cboxDuracao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCur;
        private System.Windows.Forms.GroupBox groupMaxEMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.MaskedTextBox maskTxtMax;
        private System.Windows.Forms.MaskedTextBox maskTxtMin;
    }
}