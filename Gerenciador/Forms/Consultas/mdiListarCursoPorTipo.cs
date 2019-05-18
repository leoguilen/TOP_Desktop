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

namespace Gerenciador.Forms.Consultas
{
    public partial class mdiListarCursoPorTipo : Form
    {
        private bd_top bd;
        private DataTable dt;

        public mdiListarCursoPorTipo()
        {
            InitializeComponent();
        }

        public DataTable MontarDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("ID",typeof(int));
            dt.Columns.Add("Curso", typeof(string));
            dt.Columns.Add("Area", typeof(string));
            dt.Columns.Add("Tipo Curso", typeof(string));
            dt.Columns.Add("Duração", typeof(string));

            return dt;

        }

        public void CarregarComboAreas(ComboBox cbox)
        {
            bd = new bd_top();

            foreach (var itemArea in from ar in bd.tb_area select ar)
            {
                cbox.Items.Add(itemArea.area_st_desc);
            }
        }

        private void mdiListarCursoPorTipo_Load(object sender, EventArgs e)
        {
            txtNomeCur.Enabled = false;
            cboxArea.Enabled = false;
            CarregarComboAreas(cboxArea);
        }

        private void ckFiltroNome_CheckedChanged(object sender, EventArgs e)
        {
            if(ckFiltroNome.Checked)
            {
                txtNomeCur.Enabled = true;
            } else
            {
                txtNomeCur.Clear();
                txtNomeCur.Enabled = false;
            }
        }

        private void ckFiltroArea_CheckedChanged(object sender, EventArgs e)
        {
            if(ckFiltroArea.Checked)
            {
                cboxArea.Enabled = true;
            } else
            {
                cboxArea.Enabled = false;
                cboxArea.SelectedItem = null;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bd = new bd_top();
            dt = MontarDataTable();

            var buscarGradu = from gra in bd.v_RelatorioCurso.Where(g=>g.tipo_curso.Equals("G")) orderby gra.nome_curso ascending select gra;
            var buscarPos = from pos in bd.v_RelatorioCurso.Where(p => p.tipo_curso.Equals("PG")) orderby pos.nome_curso ascending select pos;

            if(radioG.Checked)
            {
                if(ckFiltroArea.Checked && ckFiltroNome.Checked == false)
                {
                    foreach (var itemGra in from gra in bd.v_RelatorioCurso.Where(g => g.tipo_curso.Equals("G") && g.desc_area.Contains(cboxArea.SelectedItem.ToString())) orderby gra.nome_curso ascending select gra)
                    {
                        dt.Rows.Add(itemGra.id_curso, itemGra.nome_curso, itemGra.desc_area, itemGra.tipo_curso, itemGra.duracao_curso);
                    }
                }
                else if(ckFiltroNome.Checked && ckFiltroArea.Checked == false)
                {
                    foreach (var itemGra in from gra in bd.v_RelatorioCurso.Where(g => g.tipo_curso.Equals("G") && g.nome_curso.Contains(txtNomeCur.Text)) orderby gra.nome_curso ascending select gra)
                    {
                        dt.Rows.Add(itemGra.id_curso, itemGra.nome_curso, itemGra.desc_area, itemGra.tipo_curso, itemGra.duracao_curso);
                    }
                }
                else if(ckFiltroNome.Checked && ckFiltroArea.Checked)
                {
                    foreach (var itemGra in from gra in bd.v_RelatorioCurso.Where(g => g.tipo_curso.Equals("G") && g.desc_area.Contains(cboxArea.SelectedItem.ToString()) && g.nome_curso.Contains(txtNomeCur.Text)) orderby gra.nome_curso ascending select gra)
                    {
                        dt.Rows.Add(itemGra.id_curso, itemGra.nome_curso, itemGra.desc_area, itemGra.tipo_curso, itemGra.duracao_curso);
                    }
                }
                else
                {
                    foreach (var itemGra in buscarGradu)
                    {
                        dt.Rows.Add(itemGra.id_curso, itemGra.nome_curso, itemGra.desc_area, itemGra.tipo_curso, itemGra.duracao_curso);
                    }
                }
            }
            else
            {
                if (ckFiltroArea.Checked && ckFiltroNome.Checked == false)
                {
                    foreach (var itemPos in from gra in bd.v_RelatorioCurso.Where(p => p.tipo_curso.Equals("PG") && p.desc_area.Contains(cboxArea.SelectedItem.ToString())) orderby gra.nome_curso ascending select gra)
                    {
                        dt.Rows.Add(itemPos.id_curso, itemPos.nome_curso, itemPos.desc_area, itemPos.tipo_curso, itemPos.duracao_curso);
                    }
                }
                else if (ckFiltroNome.Checked && ckFiltroArea.Checked == false)
                {
                    foreach (var itemPos in from gra in bd.v_RelatorioCurso.Where(p => p.tipo_curso.Equals("PG") && p.nome_curso.Contains(txtNomeCur.Text)) orderby gra.nome_curso ascending select gra)
                    {
                        dt.Rows.Add(itemPos.id_curso, itemPos.nome_curso, itemPos.desc_area, itemPos.tipo_curso, itemPos.duracao_curso);
                    }
                }
                else if (ckFiltroNome.Checked && ckFiltroArea.Checked)
                {
                    foreach (var itemPos in from gra in bd.v_RelatorioCurso.Where(p => p.tipo_curso.Equals("PG") && p.desc_area.Contains(cboxArea.SelectedItem.ToString()) && p.nome_curso.Contains(txtNomeCur.Text)) orderby gra.nome_curso ascending select gra)
                    {
                        dt.Rows.Add(itemPos.id_curso, itemPos.nome_curso, itemPos.desc_area, itemPos.tipo_curso, itemPos.duracao_curso);
                    }
                }
                else
                {
                    foreach (var itemPos in buscarPos)
                    {
                        dt.Rows.Add(itemPos.id_curso, itemPos.nome_curso, itemPos.desc_area, itemPos.tipo_curso, itemPos.duracao_curso);
                    }
                }
            }

            dtGridCurso.DataSource = dt;
        }
    }
}
