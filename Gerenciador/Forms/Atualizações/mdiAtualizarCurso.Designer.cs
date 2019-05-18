namespace Gerenciador.Forms.Atualizações
{
    partial class mdiAtualizarCurso
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
            this.btnVisualizarCad = new System.Windows.Forms.Button();
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            this.lblBuscarCur = new System.Windows.Forms.Label();
            this.txtBuscarcCur = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizarCad
            // 
            this.btnVisualizarCad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnVisualizarCad.Location = new System.Drawing.Point(857, 119);
            this.btnVisualizarCad.Name = "btnVisualizarCad";
            this.btnVisualizarCad.Size = new System.Drawing.Size(209, 38);
            this.btnVisualizarCad.TabIndex = 68;
            this.btnVisualizarCad.Text = "Visualizar cadastro";
            this.btnVisualizarCad.UseVisualStyleBackColor = true;
            this.btnVisualizarCad.Visible = false;
            this.btnVisualizarCad.Click += new System.EventHandler(this.btnVisualizarCad_Click);
            // 
            // dtGridCursos
            // 
            this.dtGridCursos.AllowUserToAddRows = false;
            this.dtGridCursos.AllowUserToDeleteRows = false;
            this.dtGridCursos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursos.Location = new System.Drawing.Point(134, 184);
            this.dtGridCursos.MultiSelect = false;
            this.dtGridCursos.Name = "dtGridCursos";
            this.dtGridCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCursos.Size = new System.Drawing.Size(943, 326);
            this.dtGridCursos.TabIndex = 65;
            this.dtGridCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellContentClick);
            // 
            // lblBuscarCur
            // 
            this.lblBuscarCur.AutoSize = true;
            this.lblBuscarCur.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscarCur.Location = new System.Drawing.Point(151, 119);
            this.lblBuscarCur.Name = "lblBuscarCur";
            this.lblBuscarCur.Size = new System.Drawing.Size(161, 15);
            this.lblBuscarCur.TabIndex = 64;
            this.lblBuscarCur.Text = "BUSCAR CURSO (NOME)";
            // 
            // txtBuscarcCur
            // 
            this.txtBuscarcCur.Location = new System.Drawing.Point(154, 137);
            this.txtBuscarcCur.Name = "txtBuscarcCur";
            this.txtBuscarcCur.Size = new System.Drawing.Size(298, 20);
            this.txtBuscarcCur.TabIndex = 63;
            this.txtBuscarcCur.TextChanged += new System.EventHandler(this.txtBuscarcCur_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(508, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 31);
            this.lblTitle.TabIndex = 62;
            this.lblTitle.Text = "Buscar curso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1110, 518);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // mdiAtualizarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnVisualizarCad);
            this.Controls.Add(this.dtGridCursos);
            this.Controls.Add(this.lblBuscarCur);
            this.Controls.Add(this.txtBuscarcCur);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiAtualizarCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar curso";
            this.Load += new System.EventHandler(this.mdiAtualizarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarCad;
        private System.Windows.Forms.DataGridView dtGridCursos;
        private System.Windows.Forms.Label lblBuscarCur;
        private System.Windows.Forms.TextBox txtBuscarcCur;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}