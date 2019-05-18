namespace Gerenciador.Forms.Consultas
{
    partial class mdiBuscarAvaliacoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupFiltrarAvaliacoes = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ckFiltroArea = new System.Windows.Forms.CheckBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboxArea = new System.Windows.Forms.ComboBox();
            this.ckFiltroNome = new System.Windows.Forms.CheckBox();
            this.lblNomeCur = new System.Windows.Forms.Label();
            this.txtNomeInst = new System.Windows.Forms.TextBox();
            this.groupBoxDetalhes = new System.Windows.Forms.GroupBox();
            this.dtGridDetalhes = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboxNts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupFiltrarAvaliacoes.SuspendLayout();
            this.groupBoxDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1113, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // groupFiltrarAvaliacoes
            // 
            this.groupFiltrarAvaliacoes.Controls.Add(this.label1);
            this.groupFiltrarAvaliacoes.Controls.Add(this.cboxNts);
            this.groupFiltrarAvaliacoes.Controls.Add(this.btnBuscar);
            this.groupFiltrarAvaliacoes.Controls.Add(this.ckFiltroArea);
            this.groupFiltrarAvaliacoes.Controls.Add(this.lblArea);
            this.groupFiltrarAvaliacoes.Controls.Add(this.cboxArea);
            this.groupFiltrarAvaliacoes.Controls.Add(this.ckFiltroNome);
            this.groupFiltrarAvaliacoes.Controls.Add(this.lblNomeCur);
            this.groupFiltrarAvaliacoes.Controls.Add(this.txtNomeInst);
            this.groupFiltrarAvaliacoes.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupFiltrarAvaliacoes.Location = new System.Drawing.Point(27, 103);
            this.groupFiltrarAvaliacoes.Name = "groupFiltrarAvaliacoes";
            this.groupFiltrarAvaliacoes.Size = new System.Drawing.Size(398, 381);
            this.groupFiltrarAvaliacoes.TabIndex = 111;
            this.groupFiltrarAvaliacoes.TabStop = false;
            this.groupFiltrarAvaliacoes.Text = "Filtrar avaliações";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(143, 306);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 31);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ckFiltroArea
            // 
            this.ckFiltroArea.AutoSize = true;
            this.ckFiltroArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFiltroArea.Location = new System.Drawing.Point(124, 71);
            this.ckFiltroArea.Name = "ckFiltroArea";
            this.ckFiltroArea.Size = new System.Drawing.Size(120, 18);
            this.ckFiltroArea.TabIndex = 5;
            this.ckFiltroArea.Text = "Filtrar por area";
            this.ckFiltroArea.UseVisualStyleBackColor = true;
            this.ckFiltroArea.CheckedChanged += new System.EventHandler(this.ckFiltroArea_CheckedChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(42, 161);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 14);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            // 
            // cboxArea
            // 
            this.cboxArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxArea.FormattingEnabled = true;
            this.cboxArea.Location = new System.Drawing.Point(45, 178);
            this.cboxArea.Name = "cboxArea";
            this.cboxArea.Size = new System.Drawing.Size(177, 22);
            this.cboxArea.TabIndex = 3;
            // 
            // ckFiltroNome
            // 
            this.ckFiltroNome.AutoSize = true;
            this.ckFiltroNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFiltroNome.Location = new System.Drawing.Point(124, 37);
            this.ckFiltroNome.Name = "ckFiltroNome";
            this.ckFiltroNome.Size = new System.Drawing.Size(155, 18);
            this.ckFiltroNome.TabIndex = 2;
            this.ckFiltroNome.Text = "Filtrar por instituição";
            this.ckFiltroNome.UseVisualStyleBackColor = true;
            this.ckFiltroNome.CheckedChanged += new System.EventHandler(this.ckFiltroNome_CheckedChanged);
            // 
            // lblNomeCur
            // 
            this.lblNomeCur.AutoSize = true;
            this.lblNomeCur.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCur.Location = new System.Drawing.Point(42, 107);
            this.lblNomeCur.Name = "lblNomeCur";
            this.lblNomeCur.Size = new System.Drawing.Size(131, 14);
            this.lblNomeCur.TabIndex = 1;
            this.lblNomeCur.Text = "Nome da instituição";
            // 
            // txtNomeInst
            // 
            this.txtNomeInst.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeInst.Location = new System.Drawing.Point(45, 124);
            this.txtNomeInst.Name = "txtNomeInst";
            this.txtNomeInst.Size = new System.Drawing.Size(280, 22);
            this.txtNomeInst.TabIndex = 0;
            // 
            // groupBoxDetalhes
            // 
            this.groupBoxDetalhes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDetalhes.Controls.Add(this.dtGridDetalhes);
            this.groupBoxDetalhes.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDetalhes.Location = new System.Drawing.Point(458, 103);
            this.groupBoxDetalhes.Name = "groupBoxDetalhes";
            this.groupBoxDetalhes.Size = new System.Drawing.Size(700, 418);
            this.groupBoxDetalhes.TabIndex = 110;
            this.groupBoxDetalhes.TabStop = false;
            this.groupBoxDetalhes.Text = "Detalhes";
            // 
            // dtGridDetalhes
            // 
            this.dtGridDetalhes.AllowUserToAddRows = false;
            this.dtGridDetalhes.AllowUserToDeleteRows = false;
            this.dtGridDetalhes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtGridDetalhes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridDetalhes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridDetalhes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridDetalhes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridDetalhes.Location = new System.Drawing.Point(6, 31);
            this.dtGridDetalhes.Name = "dtGridDetalhes";
            this.dtGridDetalhes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridDetalhes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridDetalhes.Size = new System.Drawing.Size(688, 381);
            this.dtGridDetalhes.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(458, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 31);
            this.lblTitulo.TabIndex = 109;
            this.lblTitulo.Text = "Buscar avaliações ";
            // 
            // cboxNts
            // 
            this.cboxNts.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNts.FormattingEnabled = true;
            this.cboxNts.Location = new System.Drawing.Point(45, 236);
            this.cboxNts.Name = "cboxNts";
            this.cboxNts.Size = new System.Drawing.Size(128, 22);
            this.cboxNts.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valor da avaliação";
            // 
            // mdiBuscarAvaliacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupFiltrarAvaliacoes);
            this.Controls.Add(this.groupBoxDetalhes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiBuscarAvaliacoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Avaliações";
            this.Load += new System.EventHandler(this.mdiBuscarAvaliacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupFiltrarAvaliacoes.ResumeLayout(false);
            this.groupFiltrarAvaliacoes.PerformLayout();
            this.groupBoxDetalhes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDetalhes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupFiltrarAvaliacoes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox ckFiltroArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cboxArea;
        private System.Windows.Forms.CheckBox ckFiltroNome;
        private System.Windows.Forms.Label lblNomeCur;
        private System.Windows.Forms.TextBox txtNomeInst;
        private System.Windows.Forms.GroupBox groupBoxDetalhes;
        private System.Windows.Forms.DataGridView dtGridDetalhes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxNts;
    }
}