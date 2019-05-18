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
    public partial class ModificarResposta : Form
    {
        private bd_top bd;
        private mdiModificarQuestao modificarQuestao;

        public ModificarResposta(mdiModificarQuestao modificarQuestao)
        {
            InitializeComponent();
            this.modificarQuestao = modificarQuestao;
        }

        int IdSelecionado;

        private void ModificarResposta_Load(object sender, EventArgs e)
        {
            bd = new bd_top();

            IdSelecionado = (int)modificarQuestao.RetornarID();

            var resposta = (from resp in bd.v_RelatorioQuestoes.Where(r=>r.id_resposta==IdSelecionado) select resp).FirstOrDefault();

            lblRespSelecionada.Text += resposta.desc_resposta;
            txtDescResp.Text = resposta.desc_resposta;
            txtExatas.Text = resposta.perc_exatas.ToString();
            txtHumanas.Text = resposta.perc_humanas.ToString();
            txtBio.Text = resposta.perc_biologicas.ToString();
            txtPerg.Text = resposta.desc_pergunta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Modificação foi cancelada");
            Log.GerarLog("Modificação da resposta " + txtDescResp.Text + " foi cancelada");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bd = new bd_top();
            int idPerg = 0;

            foreach (var itemIdPerg in from perg in bd.v_RelatorioQuestoes.Where(p=>p.id_resposta == IdSelecionado) select perg)
            {
                idPerg = itemIdPerg.id_pergunta;
            }

            bd.sp_atualizarQuestao(idPerg,IdSelecionado,txtDescResp.Text,float.Parse(txtExatas.Text),float.Parse(txtHumanas.Text),float.Parse(txtBio.Text));
            bd.SaveChanges();
            bd.Dispose();

            ActiveForm.Refresh();

            MessageBox.Show("Resposta atualizada com sucesso!");
            Log.GerarLog("Resposta modificada");
        }

        private void ModificarResposta_FormClosing(object sender, FormClosingEventArgs e)
        {
            modificarQuestao.AtualizarGrid();
        }
    }
}
