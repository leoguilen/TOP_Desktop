namespace Gerenciador.Forms
{
    partial class mdiAtualizarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarUs = new System.Windows.Forms.TextBox();
            this.lblBuscarUs = new System.Windows.Forms.Label();
            this.dtGridUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVisualizarCad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(478, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar usuário";
            // 
            // txtBuscarUs
            // 
            this.txtBuscarUs.Location = new System.Drawing.Point(154, 137);
            this.txtBuscarUs.Name = "txtBuscarUs";
            this.txtBuscarUs.Size = new System.Drawing.Size(298, 20);
            this.txtBuscarUs.TabIndex = 2;
            this.txtBuscarUs.TextChanged += new System.EventHandler(this.txtBuscarUs_TextChanged);
            // 
            // lblBuscarUs
            // 
            this.lblBuscarUs.AutoSize = true;
            this.lblBuscarUs.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscarUs.Location = new System.Drawing.Point(151, 119);
            this.lblBuscarUs.Name = "lblBuscarUs";
            this.lblBuscarUs.Size = new System.Drawing.Size(176, 15);
            this.lblBuscarUs.TabIndex = 3;
            this.lblBuscarUs.Text = "BUSCAR USUÁRIO (NOME)";
            // 
            // dtGridUsuarios
            // 
            this.dtGridUsuarios.AllowUserToAddRows = false;
            this.dtGridUsuarios.AllowUserToDeleteRows = false;
            this.dtGridUsuarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUsuarios.Location = new System.Drawing.Point(115, 184);
            this.dtGridUsuarios.Name = "dtGridUsuarios";
            this.dtGridUsuarios.Size = new System.Drawing.Size(981, 326);
            this.dtGridUsuarios.TabIndex = 48;
            this.dtGridUsuarios.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtGridUsuarios_CellBeginEdit);
            this.dtGridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridUsuarios_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1160, 276);
            this.dataGridView1.TabIndex = 48;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::Gerenciador.Properties.Resources.fundoSalvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(12, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 35);
            this.btnSalvar.TabIndex = 49;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Gerenciador.Properties.Resources.Deletion_icon;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Location = new System.Drawing.Point(58, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 35);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // btnVisualizarCad
            // 
            this.btnVisualizarCad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnVisualizarCad.Location = new System.Drawing.Point(887, 119);
            this.btnVisualizarCad.Name = "btnVisualizarCad";
            this.btnVisualizarCad.Size = new System.Drawing.Size(209, 38);
            this.btnVisualizarCad.TabIndex = 53;
            this.btnVisualizarCad.Text = "Visualizar cadastro";
            this.btnVisualizarCad.UseVisualStyleBackColor = true;
            this.btnVisualizarCad.Visible = false;
            this.btnVisualizarCad.Click += new System.EventHandler(this.btnVisualizarCad_Click);
            // 
            // mdiAtualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnVisualizarCad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridUsuarios);
            this.Controls.Add(this.lblBuscarUs);
            this.Controls.Add(this.txtBuscarUs);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiAtualizarUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar/Atualizar usuário";
            this.Load += new System.EventHandler(this.mdiAtualizarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarUs;
        private System.Windows.Forms.Label lblBuscarUs;
        private System.Windows.Forms.DataGridView dtGridUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVisualizarCad;
    }
}