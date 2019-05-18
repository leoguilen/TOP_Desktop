namespace Gerenciador.Forms.Atualizações
{
    partial class ModificarResposta
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
            this.lblRespSelecionada = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescResp = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBoxDadosModificar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxValorResp1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHumanas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExatas = new System.Windows.Forms.TextBox();
            this.txtPerg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxDadosModificar.SuspendLayout();
            this.groupBoxValorResp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1006, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // lblRespSelecionada
            // 
            this.lblRespSelecionada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRespSelecionada.AutoSize = true;
            this.lblRespSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespSelecionada.Location = new System.Drawing.Point(12, 26);
            this.lblRespSelecionada.Name = "lblRespSelecionada";
            this.lblRespSelecionada.Size = new System.Drawing.Size(139, 24);
            this.lblRespSelecionada.TabIndex = 94;
            this.lblRespSelecionada.Text = "Selecionado: ";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(34, 68);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(151, 15);
            this.lblDesc.TabIndex = 155;
            this.lblDesc.Text = "Descrição resposta";
            // 
            // txtDescResp
            // 
            this.txtDescResp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDescResp.Location = new System.Drawing.Point(36, 88);
            this.txtDescResp.Name = "txtDescResp";
            this.txtDescResp.Size = new System.Drawing.Size(455, 20);
            this.txtDescResp.TabIndex = 153;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(826, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 41);
            this.btnCancelar.TabIndex = 127;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Location = new System.Drawing.Point(646, 151);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(147, 41);
            this.btnSalvar.TabIndex = 126;
            this.btnSalvar.Text = "Salvar alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBoxDadosModificar
            // 
            this.groupBoxDadosModificar.Controls.Add(this.txtPerg);
            this.groupBoxDadosModificar.Controls.Add(this.label4);
            this.groupBoxDadosModificar.Controls.Add(this.groupBoxValorResp1);
            this.groupBoxDadosModificar.Controls.Add(this.lblDesc);
            this.groupBoxDadosModificar.Controls.Add(this.txtDescResp);
            this.groupBoxDadosModificar.Controls.Add(this.btnCancelar);
            this.groupBoxDadosModificar.Controls.Add(this.btnSalvar);
            this.groupBoxDadosModificar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDadosModificar.Location = new System.Drawing.Point(12, 79);
            this.groupBoxDadosModificar.Name = "groupBoxDadosModificar";
            this.groupBoxDadosModificar.Size = new System.Drawing.Size(1053, 323);
            this.groupBoxDadosModificar.TabIndex = 93;
            this.groupBoxDadosModificar.TabStop = false;
            this.groupBoxDadosModificar.Text = "Dados da resposta";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 15);
            this.label4.TabIndex = 158;
            this.label4.Text = "Pergunta dessa resposta";
            // 
            // groupBoxValorResp1
            // 
            this.groupBoxValorResp1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxValorResp1.Controls.Add(this.label3);
            this.groupBoxValorResp1.Controls.Add(this.txtBio);
            this.groupBoxValorResp1.Controls.Add(this.label2);
            this.groupBoxValorResp1.Controls.Add(this.txtHumanas);
            this.groupBoxValorResp1.Controls.Add(this.label1);
            this.groupBoxValorResp1.Controls.Add(this.txtExatas);
            this.groupBoxValorResp1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxValorResp1.Location = new System.Drawing.Point(36, 131);
            this.groupBoxValorResp1.Name = "groupBoxValorResp1";
            this.groupBoxValorResp1.Size = new System.Drawing.Size(541, 75);
            this.groupBoxValorResp1.TabIndex = 156;
            this.groupBoxValorResp1.TabStop = false;
            this.groupBoxValorResp1.Text = "Valores da resposta";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biológicas";
            // 
            // txtBio
            // 
            this.txtBio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBio.Location = new System.Drawing.Point(431, 30);
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(69, 20);
            this.txtBio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Humanas";
            // 
            // txtHumanas
            // 
            this.txtHumanas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHumanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtHumanas.Location = new System.Drawing.Point(251, 30);
            this.txtHumanas.Name = "txtHumanas";
            this.txtHumanas.Size = new System.Drawing.Size(69, 20);
            this.txtHumanas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exatas";
            // 
            // txtExatas
            // 
            this.txtExatas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtExatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtExatas.Location = new System.Drawing.Point(76, 30);
            this.txtExatas.Name = "txtExatas";
            this.txtExatas.Size = new System.Drawing.Size(66, 20);
            this.txtExatas.TabIndex = 0;
            // 
            // txtPerg
            // 
            this.txtPerg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPerg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPerg.Location = new System.Drawing.Point(35, 244);
            this.txtPerg.Name = "txtPerg";
            this.txtPerg.ReadOnly = true;
            this.txtPerg.Size = new System.Drawing.Size(455, 20);
            this.txtPerg.TabIndex = 159;
            // 
            // ModificarResposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 511);
            this.Controls.Add(this.lblRespSelecionada);
            this.Controls.Add(this.groupBoxDadosModificar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModificarResposta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Resposta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarResposta_FormClosing);
            this.Load += new System.EventHandler(this.ModificarResposta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxDadosModificar.ResumeLayout(false);
            this.groupBoxDadosModificar.PerformLayout();
            this.groupBoxValorResp1.ResumeLayout(false);
            this.groupBoxValorResp1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRespSelecionada;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescResp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBoxDadosModificar;
        private System.Windows.Forms.GroupBox groupBoxValorResp1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHumanas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExatas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerg;
    }
}