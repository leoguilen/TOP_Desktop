namespace Gerenciador.Forms.Consultas
{
    partial class mdiVisualizarQuestoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBuscar = new System.Windows.Forms.GroupBox();
            this.checkBuscarMaior = new System.Windows.Forms.CheckBox();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioH = new System.Windows.Forms.RadioButton();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboxPerg = new System.Windows.Forms.ComboBox();
            this.groupBoxDadosResp = new System.Windows.Forms.GroupBox();
            this.dtGridResp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.errBuscar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBuscar.SuspendLayout();
            this.groupBoxDadosResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridResp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBuscar)).BeginInit();
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(473, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 31);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Visualizar questões";
            // 
            // groupBuscar
            // 
            this.groupBuscar.Controls.Add(this.checkBuscarMaior);
            this.groupBuscar.Controls.Add(this.radioB);
            this.groupBuscar.Controls.Add(this.radioH);
            this.groupBuscar.Controls.Add(this.radioE);
            this.groupBuscar.Controls.Add(this.btnBuscar);
            this.groupBuscar.Controls.Add(this.lblArea);
            this.groupBuscar.Controls.Add(this.cboxPerg);
            this.groupBuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBuscar.Location = new System.Drawing.Point(12, 82);
            this.groupBuscar.Name = "groupBuscar";
            this.groupBuscar.Size = new System.Drawing.Size(398, 329);
            this.groupBuscar.TabIndex = 110;
            this.groupBuscar.TabStop = false;
            this.groupBuscar.Text = "Buscar respostas";
            // 
            // checkBuscarMaior
            // 
            this.checkBuscarMaior.AutoSize = true;
            this.checkBuscarMaior.Font = new System.Drawing.Font("Verdana", 9F);
            this.checkBuscarMaior.Location = new System.Drawing.Point(91, 37);
            this.checkBuscarMaior.Name = "checkBuscarMaior";
            this.checkBuscarMaior.Size = new System.Drawing.Size(220, 18);
            this.checkBuscarMaior.TabIndex = 12;
            this.checkBuscarMaior.Text = "Buscar por maior valor da area";
            this.checkBuscarMaior.UseVisualStyleBackColor = true;
            this.checkBuscarMaior.CheckedChanged += new System.EventHandler(this.checkBuscarMaior_CheckedChanged);
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Enabled = false;
            this.radioB.Font = new System.Drawing.Font("Verdana", 9F);
            this.radioB.Location = new System.Drawing.Point(52, 214);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(160, 18);
            this.radioB.TabIndex = 11;
            this.radioB.TabStop = true;
            this.radioB.Text = "Maior valor biológicas";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioH
            // 
            this.radioH.AutoSize = true;
            this.radioH.Enabled = false;
            this.radioH.Font = new System.Drawing.Font("Verdana", 9F);
            this.radioH.Location = new System.Drawing.Point(52, 180);
            this.radioH.Name = "radioH";
            this.radioH.Size = new System.Drawing.Size(156, 18);
            this.radioH.TabIndex = 10;
            this.radioH.TabStop = true;
            this.radioH.Text = "Maior valor humanas";
            this.radioH.UseVisualStyleBackColor = true;
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Enabled = false;
            this.radioE.Font = new System.Drawing.Font("Verdana", 9F);
            this.radioE.Location = new System.Drawing.Point(52, 147);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(141, 18);
            this.radioE.TabIndex = 9;
            this.radioE.TabStop = true;
            this.radioE.Text = "Maior valor exatas";
            this.radioE.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(142, 262);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 31);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(35, 79);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(65, 14);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Pergunta";
            // 
            // cboxPerg
            // 
            this.cboxPerg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxPerg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxPerg.DropDownWidth = 500;
            this.cboxPerg.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPerg.FormattingEnabled = true;
            this.cboxPerg.Location = new System.Drawing.Point(38, 96);
            this.cboxPerg.MaxDropDownItems = 5;
            this.cboxPerg.Name = "cboxPerg";
            this.cboxPerg.Size = new System.Drawing.Size(318, 22);
            this.cboxPerg.TabIndex = 3;
            // 
            // groupBoxDadosResp
            // 
            this.groupBoxDadosResp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDadosResp.Controls.Add(this.dtGridResp);
            this.groupBoxDadosResp.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDadosResp.Location = new System.Drawing.Point(432, 82);
            this.groupBoxDadosResp.Name = "groupBoxDadosResp";
            this.groupBoxDadosResp.Size = new System.Drawing.Size(747, 418);
            this.groupBoxDadosResp.TabIndex = 109;
            this.groupBoxDadosResp.TabStop = false;
            this.groupBoxDadosResp.Text = "Detalhes das respostas";
            // 
            // dtGridResp
            // 
            this.dtGridResp.AllowUserToAddRows = false;
            this.dtGridResp.AllowUserToDeleteRows = false;
            this.dtGridResp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridResp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridResp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridResp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridResp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridResp.Location = new System.Drawing.Point(7, 31);
            this.dtGridResp.Name = "dtGridResp";
            this.dtGridResp.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridResp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridResp.Size = new System.Drawing.Size(734, 381);
            this.dtGridResp.TabIndex = 0;
            this.dtGridResp.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtGridResp_RowsAdded);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1004, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Limpar pesquisa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errBuscar
            // 
            this.errBuscar.ContainerControl = this;
            // 
            // mdiVisualizarQuestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBuscar);
            this.Controls.Add(this.groupBoxDadosResp);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdiVisualizarQuestoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar questões";
            this.Load += new System.EventHandler(this.mdiVisualizarQuestoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBuscar.ResumeLayout(false);
            this.groupBuscar.PerformLayout();
            this.groupBoxDadosResp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridResp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBuscar;
        private System.Windows.Forms.RadioButton radioH;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cboxPerg;
        private System.Windows.Forms.GroupBox groupBoxDadosResp;
        private System.Windows.Forms.DataGridView dtGridResp;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.CheckBox checkBuscarMaior;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errBuscar;
    }
}