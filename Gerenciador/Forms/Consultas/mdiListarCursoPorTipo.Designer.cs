namespace Gerenciador.Forms.Consultas
{
    partial class mdiListarCursoPorTipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxDadosCursos = new System.Windows.Forms.GroupBox();
            this.dtGridCurso = new System.Windows.Forms.DataGridView();
            this.groupBuscar = new System.Windows.Forms.GroupBox();
            this.txtNomeCur = new System.Windows.Forms.TextBox();
            this.lblNomeCur = new System.Windows.Forms.Label();
            this.ckFiltroNome = new System.Windows.Forms.CheckBox();
            this.cboxArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.ckFiltroArea = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.radioG = new System.Windows.Forms.RadioButton();
            this.radioPG = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxDadosCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCurso)).BeginInit();
            this.groupBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1105, 515);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(483, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 31);
            this.lblTitulo.TabIndex = 104;
            this.lblTitulo.Text = "Cursos por tipo";
            // 
            // groupBoxDadosCursos
            // 
            this.groupBoxDadosCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDadosCursos.Controls.Add(this.dtGridCurso);
            this.groupBoxDadosCursos.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDadosCursos.Location = new System.Drawing.Point(472, 84);
            this.groupBoxDadosCursos.Name = "groupBoxDadosCursos";
            this.groupBoxDadosCursos.Size = new System.Drawing.Size(700, 418);
            this.groupBoxDadosCursos.TabIndex = 107;
            this.groupBoxDadosCursos.TabStop = false;
            this.groupBoxDadosCursos.Text = "Curso selecionado";
            // 
            // dtGridCurso
            // 
            this.dtGridCurso.AllowUserToAddRows = false;
            this.dtGridCurso.AllowUserToDeleteRows = false;
            this.dtGridCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridCurso.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtGridCurso.Location = new System.Drawing.Point(6, 31);
            this.dtGridCurso.Name = "dtGridCurso";
            this.dtGridCurso.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGridCurso.Size = new System.Drawing.Size(688, 381);
            this.dtGridCurso.TabIndex = 0;
            // 
            // groupBuscar
            // 
            this.groupBuscar.Controls.Add(this.radioPG);
            this.groupBuscar.Controls.Add(this.radioG);
            this.groupBuscar.Controls.Add(this.btnBuscar);
            this.groupBuscar.Controls.Add(this.ckFiltroArea);
            this.groupBuscar.Controls.Add(this.lblArea);
            this.groupBuscar.Controls.Add(this.cboxArea);
            this.groupBuscar.Controls.Add(this.ckFiltroNome);
            this.groupBuscar.Controls.Add(this.lblNomeCur);
            this.groupBuscar.Controls.Add(this.txtNomeCur);
            this.groupBuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBuscar.Location = new System.Drawing.Point(41, 84);
            this.groupBuscar.Name = "groupBuscar";
            this.groupBuscar.Size = new System.Drawing.Size(398, 381);
            this.groupBuscar.TabIndex = 108;
            this.groupBuscar.TabStop = false;
            this.groupBuscar.Text = "Buscar cursos";
            // 
            // txtNomeCur
            // 
            this.txtNomeCur.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCur.Location = new System.Drawing.Point(45, 124);
            this.txtNomeCur.Name = "txtNomeCur";
            this.txtNomeCur.Size = new System.Drawing.Size(280, 22);
            this.txtNomeCur.TabIndex = 0;
            // 
            // lblNomeCur
            // 
            this.lblNomeCur.AutoSize = true;
            this.lblNomeCur.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCur.Location = new System.Drawing.Point(42, 107);
            this.lblNomeCur.Name = "lblNomeCur";
            this.lblNomeCur.Size = new System.Drawing.Size(101, 14);
            this.lblNomeCur.TabIndex = 1;
            this.lblNomeCur.Text = "Nome do curso";
            // 
            // ckFiltroNome
            // 
            this.ckFiltroNome.AutoSize = true;
            this.ckFiltroNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFiltroNome.Location = new System.Drawing.Point(124, 37);
            this.ckFiltroNome.Name = "ckFiltroNome";
            this.ckFiltroNome.Size = new System.Drawing.Size(126, 18);
            this.ckFiltroNome.TabIndex = 2;
            this.ckFiltroNome.Text = "Filtrar por nome";
            this.ckFiltroNome.UseVisualStyleBackColor = true;
            this.ckFiltroNome.CheckedChanged += new System.EventHandler(this.ckFiltroNome_CheckedChanged);
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
            // radioG
            // 
            this.radioG.AutoSize = true;
            this.radioG.Font = new System.Drawing.Font("Verdana", 9F);
            this.radioG.Location = new System.Drawing.Point(63, 223);
            this.radioG.Name = "radioG";
            this.radioG.Size = new System.Drawing.Size(93, 18);
            this.radioG.TabIndex = 9;
            this.radioG.TabStop = true;
            this.radioG.Text = "Graduação";
            this.radioG.UseVisualStyleBackColor = true;
            // 
            // radioPG
            // 
            this.radioPG.AutoSize = true;
            this.radioPG.Font = new System.Drawing.Font("Verdana", 9F);
            this.radioPG.Location = new System.Drawing.Point(63, 256);
            this.radioPG.Name = "radioPG";
            this.radioPG.Size = new System.Drawing.Size(121, 18);
            this.radioPG.TabIndex = 10;
            this.radioPG.TabStop = true;
            this.radioPG.Text = "Pós-Graduação";
            this.radioPG.UseVisualStyleBackColor = true;
            // 
            // mdiListarCursoPorTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBuscar);
            this.Controls.Add(this.groupBoxDadosCursos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiListarCursoPorTipo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Cursos";
            this.Load += new System.EventHandler(this.mdiListarCursoPorTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxDadosCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCurso)).EndInit();
            this.groupBuscar.ResumeLayout(false);
            this.groupBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxDadosCursos;
        private System.Windows.Forms.DataGridView dtGridCurso;
        private System.Windows.Forms.GroupBox groupBuscar;
        private System.Windows.Forms.TextBox txtNomeCur;
        private System.Windows.Forms.Label lblNomeCur;
        private System.Windows.Forms.CheckBox ckFiltroNome;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cboxArea;
        private System.Windows.Forms.CheckBox ckFiltroArea;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton radioPG;
        private System.Windows.Forms.RadioButton radioG;
    }
}