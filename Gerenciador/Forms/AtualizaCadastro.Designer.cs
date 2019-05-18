namespace Gerenciador.Forms
{
    partial class AtualizaCadastro
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
            this.groupBoxDadosAtualizar = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.maskTxtCel = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxNivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxUF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupbxDataNasc = new System.Windows.Forms.GroupBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupbxSexo = new System.Windows.Forms.GroupBox();
            this.radiobtnFem = new System.Windows.Forms.RadioButton();
            this.radiobtnMasc = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeSelecionado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDadosAtualizar.SuspendLayout();
            this.groupbxDataNasc.SuspendLayout();
            this.groupbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDadosAtualizar
            // 
            this.groupBoxDadosAtualizar.Controls.Add(this.btnCancelar);
            this.groupBoxDadosAtualizar.Controls.Add(this.btnSalvar);
            this.groupBoxDadosAtualizar.Controls.Add(this.maskTxtCel);
            this.groupBoxDadosAtualizar.Controls.Add(this.maskTxtTel);
            this.groupBoxDadosAtualizar.Controls.Add(this.label3);
            this.groupBoxDadosAtualizar.Controls.Add(this.label4);
            this.groupBoxDadosAtualizar.Controls.Add(this.cboxNivel);
            this.groupBoxDadosAtualizar.Controls.Add(this.label6);
            this.groupBoxDadosAtualizar.Controls.Add(this.cboxUF);
            this.groupBoxDadosAtualizar.Controls.Add(this.label5);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblCidade);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtCidade);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtUsername);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblUsername);
            this.groupBoxDadosAtualizar.Controls.Add(this.groupbxDataNasc);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblEmail);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtEmail);
            this.groupBoxDadosAtualizar.Controls.Add(this.groupbxSexo);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblNome);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtNome);
            this.groupBoxDadosAtualizar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDadosAtualizar.Location = new System.Drawing.Point(12, 62);
            this.groupBoxDadosAtualizar.Name = "groupBoxDadosAtualizar";
            this.groupBoxDadosAtualizar.Size = new System.Drawing.Size(1053, 405);
            this.groupBoxDadosAtualizar.TabIndex = 85;
            this.groupBoxDadosAtualizar.TabStop = false;
            this.groupBoxDadosAtualizar.Text = "Dados do usuário";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(794, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 41);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(621, 318);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 41);
            this.btnSalvar.TabIndex = 103;
            this.btnSalvar.Text = "Salvar alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // maskTxtCel
            // 
            this.maskTxtCel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskTxtCel.Font = new System.Drawing.Font("Verdana", 9F);
            this.maskTxtCel.Location = new System.Drawing.Point(806, 239);
            this.maskTxtCel.Mask = "(00) 00000-0000";
            this.maskTxtCel.Name = "maskTxtCel";
            this.maskTxtCel.Size = new System.Drawing.Size(201, 22);
            this.maskTxtCel.TabIndex = 102;
            // 
            // maskTxtTel
            // 
            this.maskTxtTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskTxtTel.Font = new System.Drawing.Font("Verdana", 9F);
            this.maskTxtTel.Location = new System.Drawing.Point(566, 239);
            this.maskTxtTel.Mask = "(00) 0000-0000";
            this.maskTxtTel.Name = "maskTxtTel";
            this.maskTxtTel.Size = new System.Drawing.Size(201, 22);
            this.maskTxtTel.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(807, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "CELULAR";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(562, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "TELEFONE";
            // 
            // cboxNivel
            // 
            this.cboxNivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxNivel.Font = new System.Drawing.Font("Verdana", 9F);
            this.cboxNivel.FormattingEnabled = true;
            this.cboxNivel.Location = new System.Drawing.Point(564, 161);
            this.cboxNivel.Name = "cboxNivel";
            this.cboxNivel.Size = new System.Drawing.Size(365, 22);
            this.cboxNivel.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(853, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 97;
            this.label6.Text = "UF";
            // 
            // cboxUF
            // 
            this.cboxUF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxUF.Font = new System.Drawing.Font("Verdana", 9F);
            this.cboxUF.FormattingEnabled = true;
            this.cboxUF.Location = new System.Drawing.Point(856, 84);
            this.cboxUF.Name = "cboxUF";
            this.cboxUF.Size = new System.Drawing.Size(72, 22);
            this.cboxUF.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 95;
            this.label5.Text = "NIVEL ACADEMICO";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(561, 64);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 15);
            this.lblCidade.TabIndex = 94;
            this.lblCidade.Text = "CIDADE";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCidade.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCidade.Location = new System.Drawing.Point(563, 84);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(274, 22);
            this.txtCidade.TabIndex = 93;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtUsername.Location = new System.Drawing.Point(34, 328);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(467, 22);
            this.txtUsername.TabIndex = 92;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(32, 309);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 15);
            this.lblUsername.TabIndex = 91;
            this.lblUsername.Text = "USERNAME";
            // 
            // groupbxDataNasc
            // 
            this.groupbxDataNasc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupbxDataNasc.Controls.Add(this.txtDataNasc);
            this.groupbxDataNasc.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupbxDataNasc.Location = new System.Drawing.Point(270, 199);
            this.groupbxDataNasc.Name = "groupbxDataNasc";
            this.groupbxDataNasc.Size = new System.Drawing.Size(230, 83);
            this.groupbxDataNasc.TabIndex = 90;
            this.groupbxDataNasc.TabStop = false;
            this.groupbxDataNasc.Text = "Data de Nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDataNasc.Location = new System.Drawing.Point(50, 35);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(117, 22);
            this.txtDataNasc.TabIndex = 0;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(31, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 89;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtEmail.Location = new System.Drawing.Point(34, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(466, 22);
            this.txtEmail.TabIndex = 87;
            // 
            // groupbxSexo
            // 
            this.groupbxSexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupbxSexo.Controls.Add(this.radiobtnFem);
            this.groupbxSexo.Controls.Add(this.radiobtnMasc);
            this.groupbxSexo.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupbxSexo.Location = new System.Drawing.Point(34, 199);
            this.groupbxSexo.Name = "groupbxSexo";
            this.groupbxSexo.Size = new System.Drawing.Size(206, 83);
            this.groupbxSexo.TabIndex = 88;
            this.groupbxSexo.TabStop = false;
            this.groupbxSexo.Text = "SEXO";
            // 
            // radiobtnFem
            // 
            this.radiobtnFem.AutoSize = true;
            this.radiobtnFem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.radiobtnFem.Location = new System.Drawing.Point(54, 47);
            this.radiobtnFem.Name = "radiobtnFem";
            this.radiobtnFem.Size = new System.Drawing.Size(83, 20);
            this.radiobtnFem.TabIndex = 51;
            this.radiobtnFem.TabStop = true;
            this.radiobtnFem.Text = "Feminino";
            this.radiobtnFem.UseVisualStyleBackColor = true;
            // 
            // radiobtnMasc
            // 
            this.radiobtnMasc.AutoSize = true;
            this.radiobtnMasc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.radiobtnMasc.Location = new System.Drawing.Point(54, 26);
            this.radiobtnMasc.Name = "radiobtnMasc";
            this.radiobtnMasc.Size = new System.Drawing.Size(90, 20);
            this.radiobtnMasc.TabIndex = 50;
            this.radiobtnMasc.TabStop = true;
            this.radiobtnMasc.Text = "Masculino";
            this.radiobtnMasc.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(31, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 15);
            this.lblNome.TabIndex = 86;
            this.lblNome.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(33, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(466, 22);
            this.txtNome.TabIndex = 85;
            // 
            // lblNomeSelecionado
            // 
            this.lblNomeSelecionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeSelecionado.AutoSize = true;
            this.lblNomeSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSelecionado.Location = new System.Drawing.Point(12, 9);
            this.lblNomeSelecionado.Name = "lblNomeSelecionado";
            this.lblNomeSelecionado.Size = new System.Drawing.Size(139, 24);
            this.lblNomeSelecionado.TabIndex = 86;
            this.lblNomeSelecionado.Text = "Selecionado: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1006, 473);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // AtualizaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNomeSelecionado);
            this.Controls.Add(this.groupBoxDadosAtualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AtualizaCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtualizaCadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AtualizaCadastro_FormClosing);
            this.Load += new System.EventHandler(this.AtualizaCadastro_Load);
            this.groupBoxDadosAtualizar.ResumeLayout(false);
            this.groupBoxDadosAtualizar.PerformLayout();
            this.groupbxDataNasc.ResumeLayout(false);
            this.groupbxDataNasc.PerformLayout();
            this.groupbxSexo.ResumeLayout(false);
            this.groupbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDadosAtualizar;
        private System.Windows.Forms.MaskedTextBox maskTxtCel;
        private System.Windows.Forms.MaskedTextBox maskTxtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxUF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupbxDataNasc;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupbxSexo;
        private System.Windows.Forms.RadioButton radiobtnFem;
        private System.Windows.Forms.RadioButton radiobtnMasc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeSelecionado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}