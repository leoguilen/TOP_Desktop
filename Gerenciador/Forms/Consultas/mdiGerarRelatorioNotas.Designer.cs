namespace Gerenciador.Forms.Consultas
{
    partial class mdiGerarRelatorioNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiGerarRelatorioNotas));
            this.treeViewVisuRelatorio = new System.Windows.Forms.TreeView();
            this.cboxNota = new System.Windows.Forms.CheckBox();
            this.cboxDescArea = new System.Windows.Forms.CheckBox();
            this.cboxDetCur = new System.Windows.Forms.CheckBox();
            this.cboxDetFac = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.lblVisuRelatorio = new System.Windows.Forms.Label();
            this.lblCampos = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.treeViewOp = new System.Windows.Forms.TreeView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewVisuRelatorio
            // 
            this.treeViewVisuRelatorio.Location = new System.Drawing.Point(688, 115);
            this.treeViewVisuRelatorio.Name = "treeViewVisuRelatorio";
            this.treeViewVisuRelatorio.Size = new System.Drawing.Size(454, 317);
            this.treeViewVisuRelatorio.TabIndex = 111;
            this.treeViewVisuRelatorio.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewVisuRelatorio_NodeMouseClick);
            // 
            // cboxNota
            // 
            this.cboxNota.AutoCheck = false;
            this.cboxNota.AutoSize = true;
            this.cboxNota.Location = new System.Drawing.Point(20, 91);
            this.cboxNota.Name = "cboxNota";
            this.cboxNota.Size = new System.Drawing.Size(75, 17);
            this.cboxNota.TabIndex = 3;
            this.cboxNota.Text = "Nota MEC";
            this.cboxNota.UseVisualStyleBackColor = true;
            this.cboxNota.CheckedChanged += new System.EventHandler(this.cboxNota_CheckedChanged);
            // 
            // cboxDescArea
            // 
            this.cboxDescArea.AutoCheck = false;
            this.cboxDescArea.AutoSize = true;
            this.cboxDescArea.Location = new System.Drawing.Point(20, 68);
            this.cboxDescArea.Name = "cboxDescArea";
            this.cboxDescArea.Size = new System.Drawing.Size(98, 17);
            this.cboxDescArea.TabIndex = 2;
            this.cboxDescArea.Text = "Descrição area";
            this.cboxDescArea.UseVisualStyleBackColor = true;
            this.cboxDescArea.CheckedChanged += new System.EventHandler(this.cboxDescArea_CheckedChanged);
            // 
            // cboxDetCur
            // 
            this.cboxDetCur.AutoCheck = false;
            this.cboxDetCur.AutoSize = true;
            this.cboxDetCur.Location = new System.Drawing.Point(20, 45);
            this.cboxDetCur.Name = "cboxDetCur";
            this.cboxDetCur.Size = new System.Drawing.Size(98, 17);
            this.cboxDetCur.TabIndex = 1;
            this.cboxDetCur.Text = "Detalhes Curso";
            this.cboxDetCur.UseVisualStyleBackColor = true;
            this.cboxDetCur.CheckedChanged += new System.EventHandler(this.cboxDetCur_CheckedChanged);
            // 
            // cboxDetFac
            // 
            this.cboxDetFac.AutoCheck = false;
            this.cboxDetFac.AutoSize = true;
            this.cboxDetFac.Location = new System.Drawing.Point(20, 22);
            this.cboxDetFac.Name = "cboxDetFac";
            this.cboxDetFac.Size = new System.Drawing.Size(121, 17);
            this.cboxDetFac.TabIndex = 0;
            this.cboxDetFac.Text = "Detalhes Faculdade";
            this.cboxDetFac.UseVisualStyleBackColor = true;
            this.cboxDetFac.CheckedChanged += new System.EventHandler(this.cboxDetFac_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.cboxNota);
            this.groupBox1.Controls.Add(this.cboxDescArea);
            this.groupBox1.Controls.Add(this.cboxDetCur);
            this.groupBox1.Controls.Add(this.cboxDetFac);
            this.groupBox1.Location = new System.Drawing.Point(379, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 416);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = global::Gerenciador.Properties.Resources.Deletion_icon;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemover.Location = new System.Drawing.Point(1100, 75);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(42, 34);
            this.btnRemover.TabIndex = 109;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1100, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.Teal;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(933, 438);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(209, 38);
            this.btnGerarRelatorio.TabIndex = 107;
            this.btnGerarRelatorio.Text = "Gerar relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // lblVisuRelatorio
            // 
            this.lblVisuRelatorio.AutoSize = true;
            this.lblVisuRelatorio.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblVisuRelatorio.Location = new System.Drawing.Point(685, 85);
            this.lblVisuRelatorio.Name = "lblVisuRelatorio";
            this.lblVisuRelatorio.Size = new System.Drawing.Size(250, 15);
            this.lblVisuRelatorio.TabIndex = 106;
            this.lblVisuRelatorio.Text = "Pré-visualização dos relatórios";
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblCampos.Location = new System.Drawing.Point(376, 85);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(62, 15);
            this.lblCampos.TabIndex = 105;
            this.lblCampos.Text = "Campos";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarios.Location = new System.Drawing.Point(26, 85);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(258, 15);
            this.lblUsuarios.TabIndex = 104;
            this.lblUsuarios.Text = "Opções para inserir no relatório";
            // 
            // treeViewOp
            // 
            this.treeViewOp.Location = new System.Drawing.Point(29, 115);
            this.treeViewOp.Name = "treeViewOp";
            this.treeViewOp.Size = new System.Drawing.Size(316, 409);
            this.treeViewOp.TabIndex = 103;
            this.treeViewOp.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewOp_NodeMouseDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(421, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(334, 31);
            this.lblTitulo.TabIndex = 102;
            this.lblTitulo.Text = "Relatórios de avaliações";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // mdiGerarRelatorioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.treeViewVisuRelatorio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.lblVisuRelatorio);
            this.Controls.Add(this.lblCampos);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.treeViewOp);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiGerarRelatorioNotas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Relatorio de Avaliações";
            this.Load += new System.EventHandler(this.mdiGerarRelatorioNotas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewVisuRelatorio;
        private System.Windows.Forms.CheckBox cboxNota;
        private System.Windows.Forms.CheckBox cboxDescArea;
        private System.Windows.Forms.CheckBox cboxDetCur;
        private System.Windows.Forms.CheckBox cboxDetFac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label lblVisuRelatorio;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.TreeView treeViewOp;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}