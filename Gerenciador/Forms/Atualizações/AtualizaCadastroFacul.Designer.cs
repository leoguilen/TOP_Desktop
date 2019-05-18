namespace Gerenciador.Forms
{
    partial class AtualizaCadastroFacul
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
            this.lblNomeSelecionado = new System.Windows.Forms.Label();
            this.groupBoxDadosAtualizar = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCelFac = new System.Windows.Forms.MaskedTextBox();
            this.txtTelFac = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailFac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxUF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeFac = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDadosAtualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeSelecionado
            // 
            this.lblNomeSelecionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeSelecionado.AutoSize = true;
            this.lblNomeSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSelecionado.Location = new System.Drawing.Point(12, 8);
            this.lblNomeSelecionado.Name = "lblNomeSelecionado";
            this.lblNomeSelecionado.Size = new System.Drawing.Size(139, 24);
            this.lblNomeSelecionado.TabIndex = 90;
            this.lblNomeSelecionado.Text = "Selecionado: ";
            // 
            // groupBoxDadosAtualizar
            // 
            this.groupBoxDadosAtualizar.Controls.Add(this.btnCancelar);
            this.groupBoxDadosAtualizar.Controls.Add(this.btnSalvar);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtCelFac);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtTelFac);
            this.groupBoxDadosAtualizar.Controls.Add(this.label7);
            this.groupBoxDadosAtualizar.Controls.Add(this.label8);
            this.groupBoxDadosAtualizar.Controls.Add(this.label4);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtFax);
            this.groupBoxDadosAtualizar.Controls.Add(this.label1);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtEmailFac);
            this.groupBoxDadosAtualizar.Controls.Add(this.label3);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtEstado);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtSite);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblEmail);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtEnd);
            this.groupBoxDadosAtualizar.Controls.Add(this.label6);
            this.groupBoxDadosAtualizar.Controls.Add(this.cboxUF);
            this.groupBoxDadosAtualizar.Controls.Add(this.label5);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblCidade);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtCidade);
            this.groupBoxDadosAtualizar.Controls.Add(this.lblNome);
            this.groupBoxDadosAtualizar.Controls.Add(this.txtNomeFac);
            this.groupBoxDadosAtualizar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDadosAtualizar.Location = new System.Drawing.Point(12, 61);
            this.groupBoxDadosAtualizar.Name = "groupBoxDadosAtualizar";
            this.groupBoxDadosAtualizar.Size = new System.Drawing.Size(1053, 405);
            this.groupBoxDadosAtualizar.TabIndex = 89;
            this.groupBoxDadosAtualizar.TabStop = false;
            this.groupBoxDadosAtualizar.Text = "Dados da faculdade";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(790, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 41);
            this.btnCancelar.TabIndex = 127;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(617, 322);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 41);
            this.btnSalvar.TabIndex = 126;
            this.btnSalvar.Text = "Salvar alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCelFac
            // 
            this.txtCelFac.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCelFac.Location = new System.Drawing.Point(264, 259);
            this.txtCelFac.Mask = "(00) 00000-0000";
            this.txtCelFac.Name = "txtCelFac";
            this.txtCelFac.Size = new System.Drawing.Size(201, 22);
            this.txtCelFac.TabIndex = 107;
            // 
            // txtTelFac
            // 
            this.txtTelFac.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtTelFac.Location = new System.Drawing.Point(43, 259);
            this.txtTelFac.Mask = "(00) 0000-0000";
            this.txtTelFac.Name = "txtTelFac";
            this.txtTelFac.Size = new System.Drawing.Size(193, 22);
            this.txtTelFac.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 125;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 124;
            this.label8.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 123;
            this.label4.Text = "FAX";
            // 
            // txtFax
            // 
            this.txtFax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFax.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtFax.Location = new System.Drawing.Point(339, 169);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(123, 22);
            this.txtFax.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 122;
            this.label1.Text = "EMAIL";
            // 
            // txtEmailFac
            // 
            this.txtEmailFac.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEmailFac.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtEmailFac.Location = new System.Drawing.Point(40, 169);
            this.txtEmailFac.Name = "txtEmailFac";
            this.txtEmailFac.Size = new System.Drawing.Size(278, 22);
            this.txtEmailFac.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 121;
            this.label3.Text = "ESTADO";
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEstado.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtEstado.Location = new System.Drawing.Point(573, 160);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(208, 22);
            this.txtEstado.TabIndex = 110;
            // 
            // txtSite
            // 
            this.txtSite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSite.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtSite.Location = new System.Drawing.Point(43, 335);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(425, 22);
            this.txtSite.TabIndex = 108;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(568, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 15);
            this.lblEmail.TabIndex = 120;
            this.lblEmail.Text = "Endereço";
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEnd.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtEnd.Location = new System.Drawing.Point(571, 90);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(424, 22);
            this.txtEnd.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(799, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 115;
            this.label6.Text = "UF";
            // 
            // cboxUF
            // 
            this.cboxUF.Font = new System.Drawing.Font("Verdana", 9F);
            this.cboxUF.FormattingEnabled = true;
            this.cboxUF.Location = new System.Drawing.Point(802, 157);
            this.cboxUF.Name = "cboxUF";
            this.cboxUF.Size = new System.Drawing.Size(85, 22);
            this.cboxUF.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 114;
            this.label5.Text = "SITE";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(569, 205);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 15);
            this.lblCidade.TabIndex = 113;
            this.lblCidade.Text = "CIDADE";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCidade.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCidade.Location = new System.Drawing.Point(571, 225);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(261, 22);
            this.txtCidade.TabIndex = 112;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(36, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(115, 15);
            this.lblNome.TabIndex = 103;
            this.lblNome.Text = "Nome Fantasia";
            // 
            // txtNomeFac
            // 
            this.txtNomeFac.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNomeFac.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtNomeFac.Location = new System.Drawing.Point(38, 90);
            this.txtNomeFac.Name = "txtNomeFac";
            this.txtNomeFac.Size = new System.Drawing.Size(424, 22);
            this.txtNomeFac.TabIndex = 102;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1006, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // AtualizaCadastroFacul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 511);
            this.Controls.Add(this.lblNomeSelecionado);
            this.Controls.Add(this.groupBoxDadosAtualizar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AtualizaCadastroFacul";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Faculdade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AtualizaCadastroFacul_FormClosing);
            this.Load += new System.EventHandler(this.AtualizaCadastroFacul_Load);
            this.groupBoxDadosAtualizar.ResumeLayout(false);
            this.groupBoxDadosAtualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomeSelecionado;
        private System.Windows.Forms.GroupBox groupBoxDadosAtualizar;
        private System.Windows.Forms.MaskedTextBox txtCelFac;
        private System.Windows.Forms.MaskedTextBox txtTelFac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailFac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxUF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeFac;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}