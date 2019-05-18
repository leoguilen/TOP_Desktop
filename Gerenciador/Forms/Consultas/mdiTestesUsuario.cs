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

namespace Gerenciador.Forms
{
    public partial class mdiTestesUsuario : Form
    {
        public mdiTestesUsuario()
        {
            InitializeComponent();
        }

        private bd_top bd;

        public void CarregarTreeView(TreeView tree)
        {
            bd = new bd_top();

            string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            TreeNode users = tree.Nodes.Add("Usuário");

            foreach (var letra in letras)
            {
                TreeNode noLetras = users.Nodes.Add(letra.ToString());

                foreach (var itemUs in from user in bd.tb_usuario .Where(u=>u.user_st_nome.StartsWith(letra)) orderby user.user_st_nome ascending select new {user.user_in_id,user.user_st_nome} )
                {
                    TreeNode user = noLetras.Nodes.Add(itemUs.user_st_nome);

                    try
                    {
                        foreach (var itemTest in from test in bd.v_relatorioResultado.Where(t => t.id_user == itemUs.user_in_id) orderby test.id_teste ascending select new { test.id_teste })
                        {
                            TreeNode teste = user.Nodes.Add("ID Teste " + itemTest.id_teste);
                        }
                    } catch (Exception ex)
                    {
                        return;
                    }
                   
                }
            }
        }
        
        private void mdiTestesUsuario_Load(object sender, EventArgs e)
        {
            bd = new bd_top();
            CarregarTreeView(treeViewTeste);
        }

        private void treeViewTeste_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = treeViewTeste.SelectedNode;
            var teste = new v_relatorioResultado();

            foreach (var t in from test in bd.v_relatorioResultado .Where(t=>node.Text.Contains(t.id_teste.ToString())) select test)
            {
                teste = t;
            }

            try
            {
                txtIdTeste.Text = teste.id_teste.ToString();
                txtIDUser.Text = teste.id_user.ToString();
                txtUsername.Text = teste.username_user;
                txtDuracao.Text = teste.duracao_curso.ToString() + " Minutos";
                txtExatas.Text = teste.exatas_resultado + "%";
                txtHumanas.Text = teste.humanas_resultado + "%";
                txtBiologicas.Text = teste.biologicas_resultado + "%";
                txtCurso.Text = teste.nome_curso;
                txtArea.Text = teste.desc_area;
            }
            catch
            {
                return;
            }
            

            Log.GerarLog("Consulta de informações sobre testes realizada");

        }
    }
}
