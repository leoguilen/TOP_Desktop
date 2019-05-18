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

namespace Gerenciador.Forms.Cadastros
{
    public partial class mdiAtribuirNotaMec : Form
    {
        private bd_top bd;
        private tb_notaMec notaMec;

        public mdiAtribuirNotaMec()
        {
            InitializeComponent();
        }

        public void ValidarCampo(ComboBox cbox)
        {
            if (cbox.SelectedItem == null)
            {
                errAtribuicao.SetError(cbox, "Obrigatório a seleção de uma opção");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errAtribuicao.SetError(cbox, "");
                btnConfirmar.Enabled = true;
            }
        }

        public void LimparCampos()
        {
            cboxCurso.Text = "";
            cboxCurso.Items.Clear();
            cboxInstituicao.Text = "";
            cboxNota.Text = "";
        }

        public void CarregarCombos(ComboBox cboxCur,ComboBox cboxNt)
        {
            bd = new bd_top();
            cboxNt.Items.Clear();

            var curso = from cur in bd.tb_curso orderby cur.cur_st_nome ascending select cur;
           
            int[] notas = {1,2,3,4,5};
            
            foreach (var Cur in curso)
            {
                cboxCur.Items.Add(Cur.cur_st_nome);
            }
            
            foreach (var nts in notas)
            {
                cboxNt.Items.Add(nts);
            }
        }

        private void mdiAtribuirNotaMec_Load(object sender, EventArgs e)
        {
            CarregarCombos(cboxCurso,cboxNota);
            btnConfirmar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultCancel = MessageBox.Show("Deseja realmente cancelar essa operação?", "Cancelar atribuição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultCancel == DialogResult.Yes)
            {
                MessageBox.Show("Operação Cancelada", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarCombos( cboxCurso, cboxNota);
                Log.GerarLog("Solicitação de atribuição de nota cancelada");

            }
            else { return; }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bd = new bd_top();
            
            var IdInstituicao = (from inst in bd.tb_faculdade.Where(i=>i.facul_st_nome.Equals(cboxInstituicao.SelectedItem.ToString()))select new { inst.facul_in_id }).FirstOrDefault();
            var IdCurso = (from cur in bd.tb_curso.Where(c => c.cur_st_nome.Equals(cboxCurso.SelectedItem.ToString())) select new { cur.cur_in_id }).First();

            DialogResult ConfResult = MessageBox.Show(string.Format("Deseja atribuir nota {0} para o curso {1} na faculdade {2}?",cboxNota.SelectedItem,cboxCurso.SelectedItem,cboxInstituicao.SelectedItem),
                                                      "Confirmar atribuição de nova nota do MEC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ConfResult == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                try
                {
                    notaMec = new tb_notaMec()
                    {
                        notaMecFacul_in_id = IdInstituicao.facul_in_id,
                        notaMecCur_in_id = IdCurso.cur_in_id,
                        notaMec_in_valor = (int)cboxNota.SelectedItem
                    };

                    bd.tb_notaMec.Add(notaMec);
                    bd.SaveChanges();
                    bd.Dispose();

                    MessageBox.Show("Nova nota atribuida");
                    Log.GerarLog("Nova atribuição de nota a faculdade " + cboxInstituicao.SelectedItem);
                    LimparCampos();
                    CarregarCombos(cboxCurso,cboxNota);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel atribuir a nota! Ocorreu um erro: " + ex.Message);
                    Log.GerarLog(ex.Message);
                }
            }
            
        }

        private void cboxInstituicao_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(cboxInstituicao);
        }

        private void cboxCurso_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(cboxCurso);
        }

        private void cboxNota_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(cboxNota);
        }

        private void cboxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxInstituicao.Items.Clear();

            var viewCur = from cur in bd.v_relatorioNotaMec.Where(c => c.nome_curso.Equals(cboxCurso.SelectedItem.ToString())) select new { cur.id_facul };
            var viewFac = from fac in bd.tb_faculdade select new { fac.facul_in_id };
            List<int> idFac = new List<int>();
            List<int> idFacPorCur = new List<int>();

            if (cboxCurso.SelectedItem == null)
            {
                cboxInstituicao.Enabled = false;
            } else
            {
                foreach (var itemIdFac in viewFac)
                {
                    idFac.Add(itemIdFac.facul_in_id);
                }
                foreach (var itemCur in viewCur)
                {
                    idFacPorCur.Add(itemCur.id_facul);
                }

                //Except pega os ids de todas as faculdade e compara com os ids das linhas selecionadas atraves do curso selecionado  
                IEnumerable<int> idsRetornados = idFac.Except(idFacPorCur);

                foreach (var itemIds in idsRetornados)
                {
                    foreach (var itemFaculs in from fac in bd.tb_faculdade.Where(f => f.facul_in_id == itemIds) select new { fac.facul_st_nome })
                    {
                        cboxInstituicao.Items.Add(itemFaculs.facul_st_nome);
                    }
                }

                cboxInstituicao.Enabled = true;
            }

            
        }
    }
}
