namespace Gerenciador.Forms
{
    partial class mdiAtualizarFacul
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
            this.btnVisualizarCad = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtGridFacul = new System.Windows.Forms.DataGridView();
            this.lblBuscarFac = new System.Windows.Forms.Label();
            this.txtBuscarFac = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFacul)).BeginInit();
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
            // btnVisualizarCad
            // 
            this.btnVisualizarCad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnVisualizarCad.Location = new System.Drawing.Point(860, 120);
            this.btnVisualizarCad.Name = "btnVisualizarCad";
            this.btnVisualizarCad.Size = new System.Drawing.Size(209, 38);
            this.btnVisualizarCad.TabIndex = 60;
            this.btnVisualizarCad.Text = "Visualizar cadastro";
            this.btnVisualizarCad.UseVisualStyleBackColor = true;
            this.btnVisualizarCad.Visible = false;
            this.btnVisualizarCad.Click += new System.EventHandler(this.btnVisualizarCad_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Gerenciador.Properties.Resources.Deletion_icon;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Location = new System.Drawing.Point(64, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 35);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::Gerenciador.Properties.Resources.fundoSalvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(18, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 35);
            this.btnSalvar.TabIndex = 58;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // dtGridFacul
            // 
            this.dtGridFacul.AllowUserToAddRows = false;
            this.dtGridFacul.AllowUserToDeleteRows = false;
            this.dtGridFacul.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtGridFacul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFacul.Location = new System.Drawing.Point(137, 185);
            this.dtGridFacul.Name = "dtGridFacul";
            this.dtGridFacul.Size = new System.Drawing.Size(943, 326);
            this.dtGridFacul.TabIndex = 57;
            this.dtGridFacul.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridFacul_CellClick);
            this.dtGridFacul.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridFacul_CellEndEdit_1);
            // 
            // lblBuscarFac
            // 
            this.lblBuscarFac.AutoSize = true;
            this.lblBuscarFac.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscarFac.Location = new System.Drawing.Point(154, 120);
            this.lblBuscarFac.Name = "lblBuscarFac";
            this.lblBuscarFac.Size = new System.Drawing.Size(196, 15);
            this.lblBuscarFac.TabIndex = 56;
            this.lblBuscarFac.Text = "BUSCAR FACULDADE (NOME)";
            // 
            // txtBuscarFac
            // 
            this.txtBuscarFac.Location = new System.Drawing.Point(157, 138);
            this.txtBuscarFac.Name = "txtBuscarFac";
            this.txtBuscarFac.Size = new System.Drawing.Size(298, 20);
            this.txtBuscarFac.TabIndex = 55;
            this.txtBuscarFac.TextChanged += new System.EventHandler(this.txtBuscarFac_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(484, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 31);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Buscar faculdade";
            // 
            // mdiAtualizarFacul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnVisualizarCad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridFacul);
            this.Controls.Add(this.lblBuscarFac);
            this.Controls.Add(this.txtBuscarFac);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiAtualizarFacul";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Faculdade";
            this.Load += new System.EventHandler(this.mdiAtualizarFacul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFacul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVisualizarCad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtGridFacul;
        private System.Windows.Forms.Label lblBuscarFac;
        private System.Windows.Forms.TextBox txtBuscarFac;
        private System.Windows.Forms.Label lblTitle;
    }
}