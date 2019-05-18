namespace Gerenciador.Forms
{
    partial class mdiNovoUsuario
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
            this.lblTitulo = new System.Windows.Forms.Label();
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cboxUF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxNivel = new System.Windows.Forms.ComboBox();
            this.btnBuscarCep = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBxBuscarCep = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNovoCad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtCel = new System.Windows.Forms.MaskedTextBox();
            this.errCadUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupbxDataNasc.SuspendLayout();
            this.groupbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCadUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(471, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 54);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Cadastro usuário";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(88, 396);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(467, 20);
            this.txtUsername.TabIndex = 26;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(86, 377);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 15);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "USERNAME";
            // 
            // groupbxDataNasc
            // 
            this.groupbxDataNasc.Controls.Add(this.txtDataNasc);
            this.groupbxDataNasc.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupbxDataNasc.Location = new System.Drawing.Point(325, 258);
            this.groupbxDataNasc.Name = "groupbxDataNasc";
            this.groupbxDataNasc.Size = new System.Drawing.Size(230, 83);
            this.groupbxDataNasc.TabIndex = 24;
            this.groupbxDataNasc.TabStop = false;
            this.groupbxDataNasc.Text = "Data de Nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNasc.Location = new System.Drawing.Point(50, 35);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(117, 23);
            this.txtDataNasc.TabIndex = 0;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            this.txtDataNasc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDataNasc_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(86, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEmail.Location = new System.Drawing.Point(89, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(466, 20);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // groupbxSexo
            // 
            this.groupbxSexo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupbxSexo.Controls.Add(this.radiobtnFem);
            this.groupbxSexo.Controls.Add(this.radiobtnMasc);
            this.groupbxSexo.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupbxSexo.Location = new System.Drawing.Point(89, 258);
            this.groupbxSexo.Name = "groupbxSexo";
            this.groupbxSexo.Size = new System.Drawing.Size(206, 83);
            this.groupbxSexo.TabIndex = 22;
            this.groupbxSexo.TabStop = false;
            this.groupbxSexo.Text = "SEXO";
            this.groupbxSexo.Validating += new System.ComponentModel.CancelEventHandler(this.groupbxSexo_Validating);
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
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(87, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 15);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNome.Location = new System.Drawing.Point(89, 136);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(466, 20);
            this.txtNome.TabIndex = 19;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(86, 464);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(219, 20);
            this.txtSenha.TabIndex = 28;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenha_Validating);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblSenha.Location = new System.Drawing.Point(85, 446);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 15);
            this.lblSenha.TabIndex = 27;
            this.lblSenha.Text = "SENHA";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(336, 465);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(219, 20);
            this.txtConfSenha.TabIndex = 30;
            this.txtConfSenha.UseSystemPasswordChar = true;
            this.txtConfSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfSenha_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(330, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "CONFIRMAR SENHA";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(669, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "NIVEL ACADEMICO";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(670, 221);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 15);
            this.lblCidade.TabIndex = 32;
            this.lblCidade.Text = "CIDADE";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCidade.Location = new System.Drawing.Point(672, 241);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(274, 20);
            this.txtCidade.TabIndex = 31;
            this.txtCidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtCidade_Validating);
            // 
            // cboxUF
            // 
            this.cboxUF.FormattingEnabled = true;
            this.cboxUF.Location = new System.Drawing.Point(965, 239);
            this.cboxUF.Name = "cboxUF";
            this.cboxUF.Size = new System.Drawing.Size(72, 21);
            this.cboxUF.TabIndex = 43;
            this.cboxUF.Validating += new System.ComponentModel.CancelEventHandler(this.cboxUF_Validating);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(962, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "UF";
            // 
            // cboxNivel
            // 
            this.cboxNivel.FormattingEnabled = true;
            this.cboxNivel.Location = new System.Drawing.Point(672, 310);
            this.cboxNivel.Name = "cboxNivel";
            this.cboxNivel.Size = new System.Drawing.Size(365, 21);
            this.cboxNivel.TabIndex = 45;
            this.cboxNivel.Validating += new System.ComponentModel.CancelEventHandler(this.cboxNivel_Validating);
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnBuscarCep.Location = new System.Drawing.Point(672, 165);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarCep.TabIndex = 46;
            this.btnBuscarCep.Text = "Buscar";
            this.btnBuscarCep.UseVisualStyleBackColor = true;
            this.btnBuscarCep.Click += new System.EventHandler(this.btnBuscarCep_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(672, 134);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(126, 20);
            this.txtCep.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "CEP";
            // 
            // checkBxBuscarCep
            // 
            this.checkBxBuscarCep.AutoSize = true;
            this.checkBxBuscarCep.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.checkBxBuscarCep.Location = new System.Drawing.Point(833, 134);
            this.checkBxBuscarCep.Name = "checkBxBuscarCep";
            this.checkBxBuscarCep.Size = new System.Drawing.Size(127, 20);
            this.checkBxBuscarCep.TabIndex = 49;
            this.checkBxBuscarCep.Text = "Buscar por CEP";
            this.checkBxBuscarCep.UseVisualStyleBackColor = true;
            this.checkBxBuscarCep.CheckedChanged += new System.EventHandler(this.checkBxBuscarCep_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Gerenciador.Properties.Resources.Deletion_icon;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Location = new System.Drawing.Point(900, 449);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 49);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = global::Gerenciador.Properties.Resources.confirmaUser1;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.Location = new System.Drawing.Point(823, 449);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(60, 49);
            this.btnConfirmar.TabIndex = 52;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1113, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnNovoCad
            // 
            this.btnNovoCad.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoCad.BackgroundImage = global::Gerenciador.Properties.Resources.addUser;
            this.btnNovoCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoCad.Location = new System.Drawing.Point(88, 35);
            this.btnNovoCad.Name = "btnNovoCad";
            this.btnNovoCad.Size = new System.Drawing.Size(56, 49);
            this.btnNovoCad.TabIndex = 50;
            this.btnNovoCad.UseVisualStyleBackColor = false;
            this.btnNovoCad.Click += new System.EventHandler(this.btnNovoCad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(914, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "CELULAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(669, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "TELEFONE";
            // 
            // maskTxtTel
            // 
            this.maskTxtTel.Location = new System.Drawing.Point(673, 379);
            this.maskTxtTel.Mask = "(00) 0000-0000";
            this.maskTxtTel.Name = "maskTxtTel";
            this.maskTxtTel.Size = new System.Drawing.Size(201, 20);
            this.maskTxtTel.TabIndex = 57;
            this.maskTxtTel.Validating += new System.ComponentModel.CancelEventHandler(this.maskTxtTel_Validating);
            // 
            // maskTxtCel
            // 
            this.maskTxtCel.Location = new System.Drawing.Point(913, 379);
            this.maskTxtCel.Mask = "(00) 00000-0000";
            this.maskTxtCel.Name = "maskTxtCel";
            this.maskTxtCel.Size = new System.Drawing.Size(201, 20);
            this.maskTxtCel.TabIndex = 58;
            this.maskTxtCel.TextChanged += new System.EventHandler(this.maskTxtCel_TextChanged);
            this.maskTxtCel.Validating += new System.ComponentModel.CancelEventHandler(this.maskTxtCel_Validating);
            // 
            // errCadUsuario
            // 
            this.errCadUsuario.ContainerControl = this;
            // 
            // mdiNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.maskTxtCel);
            this.Controls.Add(this.maskTxtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNovoCad);
            this.Controls.Add(this.checkBxBuscarCep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnBuscarCep);
            this.Controls.Add(this.cboxNivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxUF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.groupbxDataNasc);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.groupbxSexo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiNovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuario";
            this.Load += new System.EventHandler(this.mdiNovoUsuario_Load);
            this.groupbxDataNasc.ResumeLayout(false);
            this.groupbxDataNasc.PerformLayout();
            this.groupbxSexo.ResumeLayout(false);
            this.groupbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCadUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupbxDataNasc;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupbxSexo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cboxUF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxNivel;
        private System.Windows.Forms.Button btnBuscarCep;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBxBuscarCep;
        private System.Windows.Forms.RadioButton radiobtnFem;
        private System.Windows.Forms.RadioButton radiobtnMasc;
        private System.Windows.Forms.Button btnNovoCad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskTxtTel;
        private System.Windows.Forms.MaskedTextBox maskTxtCel;
        private System.Windows.Forms.ErrorProvider errCadUsuario;
    }
}