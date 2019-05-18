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
    public partial class mdiCursosFacul : Form
    {
        private bd_top bd;
        private DataTable tab;

        public mdiCursosFacul()
        {
            InitializeComponent();
        }

        public void CarregarTreeView(TreeView tree)
        {
            bd = new bd_top();
            

        string[] uf = {"AC","AL","AM","AP","BA","CE","DF","ES",
                            "GO","MA","MG","MS","MT","PA","PB","PE",
                            "PI","PR","RJ","RN","RO","RR","RS","SC",
                            "SE","SP","TO"};

            TreeNode fac = tree.Nodes.Add("Faculdade");

            foreach (var letra in uf)
            {
                TreeNode noLetras = fac.Nodes.Add(letra.ToString());

                foreach (var itemFac in from f in bd.tb_faculdade.Where(f => f.facul_st_uf.Equals(letra)) orderby f.facul_st_uf ascending select new { f.facul_st_nome})
                {
                    TreeNode user = noLetras.Nodes.Add(itemFac.facul_st_nome);
                }
            }
        }

        public void CarregarGridCurso(DataGridView dt,TreeView tree)
        {
            tab = new DataTable();

            tab.Columns.Add("ID", typeof(int));
            tab.Columns.Add("Curso", typeof(string));
            tab.Columns.Add("Area", typeof(string));
            tab.Columns.Add("Nota MEC", typeof(int));

            string facul = tree.SelectedNode.Text;

            var lista = from fac in bd.v_relatorioNotaMec.Where(f => f.nome_facul.Contains(facul)) select fac;

            foreach (var itemCur in lista)
            {
                tab.Rows.Add(itemCur.id_curso,itemCur.nome_curso,itemCur.desc_area,itemCur.valor_notaMec);
            }

            dt.DataSource = tab;
            
        }


        private void mdiCursosFacul_Load(object sender, EventArgs e)
        {
            CarregarTreeView(treeViewFacul);
            dtGridCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridCurso.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void treeViewFacul_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CarregarGridCurso(dtGridCurso,treeViewFacul);
        }
    }
}
