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
    public partial class mdiBuscarAvaliacoes : Form
    {
        private bd_top bd;
        private DataTable dt;

        public mdiBuscarAvaliacoes()
        {
            InitializeComponent();
        }

        public DataTable MontarDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("ID Faculdade", typeof(int));
            dt.Columns.Add("Faculdade", typeof(string));
            dt.Columns.Add("UF", typeof(string));
            dt.Columns.Add("ID Curso", typeof(int));
            dt.Columns.Add("Curso", typeof(string));
            dt.Columns.Add("Area", typeof(string));
            dt.Columns.Add("Nota MEC", typeof(int));

            return dt;

        }

        public void CarregarComboAreas(ComboBox cboxAr,ComboBox cboxNt)
        {
            bd = new bd_top();
            int[] notas = { 1, 2, 3, 4, 5 };
            
            foreach (var itemArea in from ar in bd.tb_area select ar)
            {
                cboxAr.Items.Add(itemArea.area_st_desc);
            }

            foreach (var nts in notas)
            {
                cboxNt.Items.Add(nts);
            }


        }

        private void mdiBuscarAvaliacoes_Load(object sender, EventArgs e)
        {
            CarregarComboAreas(cboxArea, cboxNts);
            txtNomeInst.Enabled = false;
            cboxArea.Enabled = false;
            
        }

        private void ckFiltroNome_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFiltroNome.Checked)
            {
                txtNomeInst.Enabled = true;
            }
            else
            {
                txtNomeInst.Clear();
                txtNomeInst.Enabled = false;
            }
        }

        private void ckFiltroArea_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFiltroArea.Checked)
            {
                cboxArea.Enabled = true;
            }
            else
            {
                cboxArea.SelectedItem = null;

                cboxArea.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bd = new bd_top();
            dt = MontarDataTable();

            var buscarAva = from ava in bd.v_relatorioNotaMec.Where(a => a.valor_notaMec == (int)cboxNts.SelectedItem) orderby ava.nome_facul ascending select ava;

            if (ckFiltroArea.Checked && ckFiltroNome.Checked == false)
            {
                foreach (var itemAva in from ava in bd.v_relatorioNotaMec.Where(a => a.valor_notaMec == (int)cboxNts.SelectedItem && a.desc_area.Contains(cboxArea.SelectedItem.ToString())) orderby ava.nome_curso ascending select ava)
                {
                    dt.Rows.Add(itemAva.id_facul, itemAva.nome_facul, itemAva.uf_facul, itemAva.id_curso, itemAva.nome_curso, itemAva.desc_area, itemAva.valor_notaMec);
                }
            }
            else if (ckFiltroNome.Checked && ckFiltroArea.Checked == false)
            {
                foreach (var itemAva in from ava in bd.v_relatorioNotaMec.Where(a => a.valor_notaMec == (int)cboxNts.SelectedItem && a.nome_facul.Contains(txtNomeInst.Text)) orderby ava.nome_curso ascending select ava)
                {
                    dt.Rows.Add(itemAva.id_facul, itemAva.nome_facul, itemAva.uf_facul, itemAva.id_curso, itemAva.nome_curso, itemAva.desc_area, itemAva.valor_notaMec);
                }
            }
            else if (ckFiltroNome.Checked && ckFiltroArea.Checked)
            {
                foreach (var itemAva in from ava in bd.v_relatorioNotaMec.Where(a => a.valor_notaMec == (int)cboxNts.SelectedItem && a.nome_facul.Contains(txtNomeInst.Text) && a.desc_area.Contains(cboxArea.SelectedItem.ToString())) orderby ava.nome_curso ascending select ava)
                {
                    dt.Rows.Add(itemAva.id_facul, itemAva.nome_facul, itemAva.uf_facul, itemAva.id_curso, itemAva.nome_curso, itemAva.desc_area, itemAva.valor_notaMec);
                }
            }
            else
            {
                foreach (var itemAva in buscarAva)
                {
                    dt.Rows.Add(itemAva.id_facul, itemAva.nome_facul, itemAva.uf_facul, itemAva.id_curso,itemAva.nome_curso,itemAva.desc_area,itemAva.valor_notaMec);
                }
            }

            dtGridDetalhes.DataSource = dt;
        }
    }
}
