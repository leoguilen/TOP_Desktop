using Gerenciador.Classes;
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
    public partial class mdiListarCursosPorArea : Form
    {
        private bd_top bd;

        public mdiListarCursosPorArea()
        {
            InitializeComponent();
        }

        public void CarregarCursos(TreeView tree)
        {
            bd = new bd_top();

            int[] ids = { };

            TreeNode inicio =  tree.Nodes.Add("Areas");

            foreach (var itemAr in from ar in bd.tb_area orderby ar.area_st_desc ascending select ar)
            {
                TreeNode areas = inicio.Nodes.Add(itemAr.area_st_desc);

                foreach (var itemCur in from cur in bd.tb_curso.Where(c=>c.areaCur_in_id == itemAr.area_in_id) select cur)
                {
                    TreeNode curso = areas.Nodes.Add(itemCur.cur_st_nome);
                }
            }
        }

        private void mdiListarCursos_Load(object sender, EventArgs e)
        {
            CarregarCursos(treeViewCurso);
        }

        private void treeViewCurso_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = treeViewCurso.SelectedNode;
            var curso = new v_RelatorioCurso();

            foreach (var c in from cur in bd.v_RelatorioCurso.Where(t => node.Text.Contains(t.nome_curso.ToString())) select cur)
            {
                curso = c;
            }

            txtIdCurso.Text = curso.id_curso.ToString();
            txtCurso.Text = curso.nome_curso;
            txtArea.Text = curso.desc_area;
            txtDuracao.Text = curso.duracao_curso;
            txtDescCurso.Text = curso.desc_curso;
            
            if(curso.tipo_curso.Equals("PG"))
            {
                txtTipoCurso.Text = "Pós-Graduação";
            } else { txtTipoCurso.Text = "Graduação"; }
            
            if(string.IsNullOrEmpty(curso.imagem_curso))
            {
                picImgCurso.Image = new Bitmap(@"C:\Users\LGuilen\Documents\Arquivos Projeto\Projeto Faculdade\CÓDIGO\GerenciadorTOP (Desktop)\Gerenciador\Imagens\no-image-found.png");
            } else
            {
                picImgCurso.Image = new Bitmap(@"C:\xampp\htdocs\top\assets\dashboard\img\ImagemCurso\" + curso.imagem_curso);
            }
            
            Log.GerarLog("Consulta de informações sobre testes realizada");
        }
    }
}
