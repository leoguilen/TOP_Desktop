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

namespace Gerenciador.Forms.Atualizações
{
    public partial class AtualizarCurso : Form
    {
        private bd_top bd;
        private mdiAtualizarCurso atualizarCurso;
        int IdSelecionado;

        public AtualizarCurso(mdiAtualizarCurso atualizarCurso)
        {
            InitializeComponent();
            this.atualizarCurso = atualizarCurso;
        }

        public void CarregarCombo(ComboBox cbox, ComboBox cboxArea)
        {
            bd = new bd_top();

            string[] duracao = { "2 anos", "2 anos e meio", "3 anos", "4 anos", "5 anos" };
            foreach (var itemDuracao in duracao)
            {
                cbox.Items.Add(itemDuracao);
            }

            foreach (var itemArea in from area in bd.tb_area orderby area.area_st_desc ascending select area)
            {
                cboxArea.Items.Add(itemArea.area_st_desc);
            }

        }

        private void AtualizarCurso_Load(object sender, EventArgs e)
        {
            bd = new bd_top();

            CarregarCombo(cboxDuracao,cboxAreas);

            IdSelecionado = (int)atualizarCurso.RetornarID();

            var itemCur = (from cur in bd.v_RelatorioCurso.Where(c => c.id_curso == IdSelecionado) select cur).FirstOrDefault();

            lblCursoSelecionado.Text += itemCur.nome_curso;
            txtNomeCur.Text = itemCur.nome_curso;
            txtDescCur.Text = itemCur.desc_curso;
            cboxDuracao.Text = itemCur.duracao_curso;
            cboxAreas.Text = itemCur.desc_area;
            maskTxtMax.Text = itemCur.valor_max.ToString();
            maskTxtMin.Text = itemCur.valor_min.ToString();

            if (itemCur.tipo_curso == "PG")
            {
                radioG.Checked = false;
                radioPG.Checked = true;
            }
            else
            {
                radioG.Checked = true;
                radioPG.Checked = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Atualização cancelada");
            Log.GerarLog("Atualização do curso " + txtNomeCur.Text + " foi cancelada");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bd = new bd_top();

            int idArea = 0;
            string tipo = "";

            if (radioG.Checked) tipo = "G";
            else tipo = "PG";

            foreach (var itemId in from id in bd.tb_area .Where(i=>i.area_st_desc.Contains(cboxAreas.SelectedItem.ToString())) select id)
            {
                idArea = itemId.area_in_id;
            }

            Curso cur = new Curso()
            {
                Nome = txtNomeCur.Text,
                Descricao = txtDescCur.Text,
                TempoDeDuração = cboxDuracao.Text.ToString(),
                TipoCurso = tipo,
                AreaCurso = idArea,
                ValorMax = int.Parse(maskTxtMax.Text),
                ValorMin = int.Parse(maskTxtMin.Text)
            };

            cur.AtualizarCurso(cur);

            MessageBox.Show("Atualização feita com sucesso");
            Log.GerarLog("Atualização do curso " + txtNomeCur.Text + " efetuado com sucesso");

            atualizarCurso.AtualizarGrid();
        }

        private void AtualizarCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            atualizarCurso.AtualizarGrid();
        }
    }
}
