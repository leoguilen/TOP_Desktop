namespace Gerenciador.Forms.Atualizações
{
    partial class mdiModificarQuestao
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVisualizarCad = new System.Windows.Forms.Button();
            this.dtGridResp = new System.Windows.Forms.DataGridView();
            this.lblBuscarCur = new System.Windows.Forms.Label();
            this.cboxPerg = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridResp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1113, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(489, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 31);
            this.lblTitle.TabIndex = 90;
            this.lblTitle.Text = "Modificar questão";
            // 
            // btnVisualizarCad
            // 
            this.btnVisualizarCad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnVisualizarCad.Location = new System.Drawing.Point(845, 96);
            this.btnVisualizarCad.Name = "btnVisualizarCad";
            this.btnVisualizarCad.Size = new System.Drawing.Size(209, 38);
            this.btnVisualizarCad.TabIndex = 94;
            this.btnVisualizarCad.Text = "Modificar cadastro";
            this.btnVisualizarCad.UseVisualStyleBackColor = true;
            this.btnVisualizarCad.Visible = false;
            this.btnVisualizarCad.Click += new System.EventHandler(this.btnVisualizarCad_Click);
            // 
            // dtGridResp
            // 
            this.dtGridResp.AllowUserToAddRows = false;
            this.dtGridResp.AllowUserToDeleteRows = false;
            this.dtGridResp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridResp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridResp.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtGridResp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridResp.Location = new System.Drawing.Point(122, 161);
            this.dtGridResp.MultiSelect = false;
            this.dtGridResp.Name = "dtGridResp";
            this.dtGridResp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridResp.Size = new System.Drawing.Size(943, 326);
            this.dtGridResp.TabIndex = 93;
            this.dtGridResp.TabStop = false;
            this.dtGridResp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridResp_CellClick);
            // 
            // lblBuscarCur
            // 
            this.lblBuscarCur.AutoSize = true;
            this.lblBuscarCur.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscarCur.Location = new System.Drawing.Point(139, 96);
            this.lblBuscarCur.Name = "lblBuscarCur";
            this.lblBuscarCur.Size = new System.Drawing.Size(187, 15);
            this.lblBuscarCur.TabIndex = 92;
            this.lblBuscarCur.Text = "SELECIONE UMA PERGUNTA";
            // 
            // cboxPerg
            // 
            this.cboxPerg.FormattingEnabled = true;
            this.cboxPerg.Location = new System.Drawing.Point(142, 114);
            this.cboxPerg.Name = "cboxPerg";
            this.cboxPerg.Size = new System.Drawing.Size(350, 21);
            this.cboxPerg.TabIndex = 95;
            this.cboxPerg.SelectedIndexChanged += new System.EventHandler(this.cboxPerg_SelectedIndexChanged);
            // 
            // mdiModificarQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.cboxPerg);
            this.Controls.Add(this.btnVisualizarCad);
            this.Controls.Add(this.dtGridResp);
            this.Controls.Add(this.lblBuscarCur);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiModificarQuestao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar/Modificar Questão";
            this.Load += new System.EventHandler(this.mdiModificarQuestao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridResp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnVisualizarCad;
        private System.Windows.Forms.DataGridView dtGridResp;
        private System.Windows.Forms.Label lblBuscarCur;
        private System.Windows.Forms.ComboBox cboxPerg;
    }
}