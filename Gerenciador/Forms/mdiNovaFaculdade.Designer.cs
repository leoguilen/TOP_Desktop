namespace Gerenciador.Forms
{
    partial class mdiNovaFaculdade
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
            this.checkBxBuscarCep = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarCep = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxUF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeFac = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNovoCad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailFac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelFac = new System.Windows.Forms.MaskedTextBox();
            this.txtCelFac = new System.Windows.Forms.MaskedTextBox();
            this.errCadFacul = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCadFacul)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBxBuscarCep
            // 
            this.checkBxBuscarCep.AutoSize = true;
            this.checkBxBuscarCep.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.checkBxBuscarCep.Location = new System.Drawing.Point(817, 164);
            this.checkBxBuscarCep.Name = "checkBxBuscarCep";
            this.checkBxBuscarCep.Size = new System.Drawing.Size(127, 20);
            this.checkBxBuscarCep.TabIndex = 81;
            this.checkBxBuscarCep.Text = "Buscar por CEP";
            this.checkBxBuscarCep.UseVisualStyleBackColor = true;
            this.checkBxBuscarCep.CheckedChanged += new System.EventHandler(this.checkBxBuscarCep_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(656, 164);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(126, 20);
            this.txtCep.TabIndex = 79;
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnBuscarCep.Location = new System.Drawing.Point(656, 195);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarCep.TabIndex = 78;
            this.btnBuscarCep.Text = "Buscar";
            this.btnBuscarCep.UseVisualStyleBackColor = true;
            this.btnBuscarCep.Click += new System.EventHandler(this.btnBuscarCep_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(884, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 76;
            this.label6.Text = "UF";
            // 
            // cboxUF
            // 
            this.cboxUF.FormattingEnabled = true;
            this.cboxUF.Location = new System.Drawing.Point(887, 321);
            this.cboxUF.Name = "cboxUF";
            this.cboxUF.Size = new System.Drawing.Size(72, 21);
            this.cboxUF.TabIndex = 68;
            this.cboxUF.SelectedIndexChanged += new System.EventHandler(this.cboxUF_SelectedIndexChanged);
            this.cboxUF.Validating += new System.ComponentModel.CancelEventHandler(this.cboxUF_Validating);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 74;
            this.label5.Text = "SITE";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(654, 365);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 15);
            this.lblCidade.TabIndex = 73;
            this.lblCidade.Text = "CIDADE";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCidade.Location = new System.Drawing.Point(656, 385);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(303, 20);
            this.txtCidade.TabIndex = 69;
            this.txtCidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtCidade_Validating);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(77, 146);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(115, 15);
            this.lblNome.TabIndex = 61;
            this.lblNome.Text = "Nome Fantasia";
            // 
            // txtNomeFac
            // 
            this.txtNomeFac.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNomeFac.Location = new System.Drawing.Point(79, 166);
            this.txtNomeFac.Name = "txtNomeFac";
            this.txtNomeFac.Size = new System.Drawing.Size(466, 20);
            this.txtNomeFac.TabIndex = 60;
            this.txtNomeFac.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomeFac_Validating);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(464, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 54);
            this.lblTitulo.TabIndex = 59;
            this.lblTitulo.Text = "Cadastro faculdade";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Gerenciador.Properties.Resources.Deletion_icon;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Location = new System.Drawing.Point(920, 445);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 49);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = global::Gerenciador.Properties.Resources.confirmaUser1;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.Location = new System.Drawing.Point(843, 445);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(60, 49);
            this.btnConfirmar.TabIndex = 83;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnNovoCad
            // 
            this.btnNovoCad.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoCad.BackgroundImage = global::Gerenciador.Properties.Resources.adicionar;
            this.btnNovoCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoCad.Location = new System.Drawing.Point(81, 51);
            this.btnNovoCad.Name = "btnNovoCad";
            this.btnNovoCad.Size = new System.Drawing.Size(56, 49);
            this.btnNovoCad.TabIndex = 82;
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
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(653, 245);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 15);
            this.lblEmail.TabIndex = 90;
            this.lblEmail.Text = "Endereço";
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEnd.Location = new System.Drawing.Point(656, 263);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(466, 20);
            this.txtEnd.TabIndex = 66;
            this.txtEnd.Validating += new System.ComponentModel.CancelEventHandler(this.txtEnd_Validating);
            // 
            // txtSite
            // 
            this.txtSite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSite.Location = new System.Drawing.Point(81, 424);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(467, 20);
            this.txtSite.TabIndex = 65;
            this.txtSite.Validating += new System.ComponentModel.CancelEventHandler(this.txtSite_Validating);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 93;
            this.label3.Text = "ESTADO";
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEstado.Location = new System.Drawing.Point(658, 324);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(186, 20);
            this.txtEstado.TabIndex = 67;
            this.txtEstado.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstado_Validating);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 95;
            this.label1.Text = "EMAIL";
            // 
            // txtEmailFac
            // 
            this.txtEmailFac.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEmailFac.Location = new System.Drawing.Point(81, 245);
            this.txtEmailFac.Name = "txtEmailFac";
            this.txtEmailFac.Size = new System.Drawing.Size(284, 20);
            this.txtEmailFac.TabIndex = 61;
            this.txtEmailFac.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailFac_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 97;
            this.label4.Text = "FAX";
            // 
            // txtFax
            // 
            this.txtFax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFax.Location = new System.Drawing.Point(380, 245);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(165, 20);
            this.txtFax.TabIndex = 62;
            this.txtFax.Validating += new System.ComponentModel.CancelEventHandler(this.txtFax_Validating);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 101;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 99;
            this.label8.Text = "Telefone";
            // 
            // txtTelFac
            // 
            this.txtTelFac.Location = new System.Drawing.Point(84, 335);
            this.txtTelFac.Mask = "(00) 0000-0000";
            this.txtTelFac.Name = "txtTelFac";
            this.txtTelFac.Size = new System.Drawing.Size(235, 20);
            this.txtTelFac.TabIndex = 63;
            this.txtTelFac.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelFac_Validating);
            // 
            // txtCelFac
            // 
            this.txtCelFac.Location = new System.Drawing.Point(333, 335);
            this.txtCelFac.Mask = "(00) 00000-0000";
            this.txtCelFac.Name = "txtCelFac";
            this.txtCelFac.Size = new System.Drawing.Size(215, 20);
            this.txtCelFac.TabIndex = 64;
            this.txtCelFac.Validating += new System.ComponentModel.CancelEventHandler(this.txtCelFac_Validating);
            // 
            // errCadFacul
            // 
            this.errCadFacul.ContainerControl = this;
            // 
            // mdiNovaFaculdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.txtCelFac);
            this.Controls.Add(this.txtTelFac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailFac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnNovoCad);
            this.Controls.Add(this.checkBxBuscarCep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnBuscarCep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxUF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomeFac);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiNovaFaculdade";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Faculdade";
            this.Load += new System.EventHandler(this.mdiNovaFaculdade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCadFacul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnNovoCad;
        private System.Windows.Forms.CheckBox checkBxBuscarCep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Button btnBuscarCep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxUF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeFac;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailFac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtTelFac;
        private System.Windows.Forms.MaskedTextBox txtCelFac;
        private System.Windows.Forms.ErrorProvider errCadFacul;
    }
}