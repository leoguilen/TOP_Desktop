using Gerenciador.Classes;
using Gerenciador.Classes.ObjetosDataSet;
using Gerenciador.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Forms.Atualizações
{
    public partial class mdiAtualizarCurso : Form
    {
        private bd_top bd;
        private DataTable dt;
        private BancoDesconectado banco;

        public mdiAtualizarCurso()
        {
            InitializeComponent();
        }

        public object RetornarID()
        {
            int numRow = dtGridCursos.CurrentRow.Index;
            var cell = dtGridCursos[0, numRow].Value;

            return cell;
        }

        public DataTable AtualizarGrid()
        {
            bd = new bd_top();
            dt = MontarDataTable();
            
            foreach (var itemDt in from dt in bd.v_RelatorioCurso select dt)
            {
                string tipo = "";

                if (itemDt.tipo_curso.Equals("PG"))
                { tipo = "Pós-Graduação"; }
                else
                { tipo = "Graduação"; }

                dt.Rows.Add(itemDt.id_curso, itemDt.nome_curso, itemDt.desc_area, tipo ,itemDt.duracao_curso,itemDt.valor_max,itemDt.valor_min );
            }

            dt.AcceptChanges();

            return dt;
        }

        public DataTable MontarDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Curso", typeof(string));
            dt.Columns.Add("Area", typeof(string));
            dt.Columns.Add("Tipo do Curso", typeof(string));
            dt.Columns.Add("Duração", typeof(string));
            dt.Columns.Add("MAX", typeof(int));
            dt.Columns.Add("MIN", typeof(int));

            return dt;
        }

        public void FiltrarDataView(DataGridView grid,string curso)
        {
            bd = new bd_top();

            dt = MontarDataTable();

            var buscaCurso = from cur in bd.v_RelatorioCurso .Where(c=>c.nome_curso.Contains(curso)) select cur;

            foreach (var itemCur in buscaCurso)
            {
                string tipo = "";

                if (itemCur.tipo_curso.Equals("PG"))
                { tipo = "Pós-Graduação"; }
                else
                { tipo = "Graduação"; }

                dt.Rows.Add(itemCur.id_curso, itemCur.nome_curso, itemCur.desc_area, tipo, itemCur.duracao_curso, itemCur.valor_max, itemCur.valor_min);
            }

            grid.DataSource = dt;

        }

        public void CarregarDataView(DataGridView grid)
        {
            bd = new bd_top();

            dt = MontarDataTable();

            var buscaCurso = from cur in bd.v_RelatorioCurso select cur ;

            foreach (var itemCur in buscaCurso)
            {
                string tipo = "";

                if(itemCur.tipo_curso.Equals("PG"))
                { tipo = "Pós-Graduação";}
                else
                { tipo = "Graduação";}

                dt.Rows.Add(itemCur.id_curso, itemCur.nome_curso, itemCur.desc_area, tipo, itemCur.duracao_curso, itemCur.valor_max, itemCur.valor_min);
            }

            grid.DataSource = dt;
            
        }

        private void mdiAtualizarCurso_Load(object sender, EventArgs e)
        {
            CarregarDataView(dtGridCursos);
            dtGridCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridCursos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void txtBuscarcCur_TextChanged(object sender, EventArgs e)
        {
            FiltrarDataView(dtGridCursos,txtBuscarcCur.Text);
        }
        
        private void dtGridCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selecionadas = dtGridCursos.GetCellCount(DataGridViewElementStates.Selected);
            dtGridCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (selecionadas > 0)
                btnVisualizarCad.Visible = true;
            else
                btnVisualizarCad.Visible = false;
        }

        private void btnVisualizarCad_Click(object sender, EventArgs e)
        {
            AtualizarCurso atualizarCurso = new AtualizarCurso(this);
            atualizarCurso.MdiParent = ActiveForm;
            atualizarCurso.Show();
        }
    }
}
