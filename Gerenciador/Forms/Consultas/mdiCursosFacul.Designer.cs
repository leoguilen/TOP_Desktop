namespace Gerenciador.Forms.Consultas
{
    partial class mdiCursosFacul
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTestes = new System.Windows.Forms.Label();
            this.groupBoxDadosCursos = new System.Windows.Forms.GroupBox();
            this.dtGridCurso = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.treeViewFacul = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxDadosCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1113, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // lblTestes
            // 
            this.lblTestes.AutoSize = true;
            this.lblTestes.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblTestes.Location = new System.Drawing.Point(29, 61);
            this.lblTestes.Name = "lblTestes";
            this.lblTestes.Size = new System.Drawing.Size(180, 15);
            this.lblTestes.TabIndex = 91;
            this.lblTestes.Text = "Faculdades por estado";
            // 
            // groupBoxDadosCursos
            // 
            this.groupBoxDadosCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDadosCursos.Controls.Add(this.dtGridCurso);
            this.groupBoxDadosCursos.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDadosCursos.Location = new System.Drawing.Point(456, 88);
            this.groupBoxDadosCursos.Name = "groupBoxDadosCursos";
            this.groupBoxDadosCursos.Size = new System.Drawing.Size(700, 418);
            this.groupBoxDadosCursos.TabIndex = 90;
            this.groupBoxDadosCursos.TabStop = false;
            this.groupBoxDadosCursos.Text = "Cursos dessa faculdade";
            // 
            // dtGridCurso
            // 
            this.dtGridCurso.AllowUserToAddRows = false;
            this.dtGridCurso.AllowUserToDeleteRows = false;
            this.dtGridCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridCurso.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridCurso.Location = new System.Drawing.Point(6, 31);
            this.dtGridCurso.Name = "dtGridCurso";
            this.dtGridCurso.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridCurso.Size = new System.Drawing.Size(688, 381);
            this.dtGridCurso.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(472, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 31);
            this.lblTitulo.TabIndex = 89;
            this.lblTitulo.Text = "Cursos faculdades";
            // 
            // treeViewFacul
            // 
            this.treeViewFacul.Location = new System.Drawing.Point(32, 88);
            this.treeViewFacul.Name = "treeViewFacul";
            this.treeViewFacul.Size = new System.Drawing.Size(395, 454);
            this.treeViewFacul.TabIndex = 88;
            this.treeViewFacul.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFacul_NodeMouseDoubleClick);
            // 
            // mdiCursosFacul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblTestes);
            this.Controls.Add(this.groupBoxDadosCursos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.treeViewFacul);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiCursosFacul";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos das faculdades";
            this.Load += new System.EventHandler(this.mdiCursosFacul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxDadosCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTestes;
        private System.Windows.Forms.GroupBox groupBoxDadosCursos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TreeView treeViewFacul;
        private System.Windows.Forms.DataGridView dtGridCurso;
    }
}