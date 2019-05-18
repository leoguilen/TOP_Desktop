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
using Gerenciador.Classes;

namespace Gerenciador.Forms.Cadastros
{
    public partial class mdiCriarPergunta : Form
    {
        private bd_top bd;
        private Pergunta perg;
        private Resposta resp;

        public mdiCriarPergunta()
        {
            InitializeComponent();
        }

        public void NovaQuestao()
        {
            groupBoxAddResposta.Enabled = false;
            groupBoxVisuQuestao.Enabled = false;
            groupBoxCriaPergunta.Enabled = true;
            txtPergunta.Enabled = true;
            btnCancelaPergunta.Enabled = true;
            btnProxResp.Visible = false;
            btnCriaPergunta.Enabled = false;
        }

        public void LimparCampos()
        {
            txtBioResp1.Clear();
            txtBioResp2.Clear();
            txtBioResp3.Clear();
            txtBioResp4.Clear();
            txtExatasResp1.Clear();
            txtExatasResp2.Clear();
            txtExatasResp3.Clear();
            txtExatasResp4.Clear();
            txtHumanasResp1.Clear();
            txtHumanasResp2.Clear();
            txtHumanasResp3.Clear();
            txtHumanasResp4.Clear();
            txtPergunta.Clear();
            txtResp1.Clear();
            txtResp2.Clear();
            txtResp3.Clear();
            txtResp4.Clear();
            listBoxQuestao.Items.Clear();
        }

        public void MontarQuestao(string p,List<Resposta> r)
        {
            perg = new Pergunta(p);
            resp = new Resposta();

            perg.CriarPergunta(perg.DescricaoPergunta);

            foreach (Resposta itemResp in r)
            {
                resp.GerarRespostas(itemResp,p);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnCriaPergunta_Click(object sender, EventArgs e)
        {
            listBoxQuestao.Items.Clear();
            listBoxQuestao.Items.Add("Nova pergunta: " + txtPergunta.Text);
            btnProxResp.Visible = true;
        }

        private void btnCancelaPergunta_Click(object sender, EventArgs e)
        {
            btnProxResp.Visible = false;
            listBoxQuestao.Items.Clear();
            txtPergunta.Clear();
        }

        private void btnProxResp_Click(object sender, EventArgs e)
        {
            groupBoxCriaPergunta.Enabled = false;

            groupBoxAddResposta.Enabled = true;
            txtResp1.Enabled = true;
            txtResp2.Enabled = true;
            txtResp3.Enabled = true;
            txtResp4.Enabled = true;
            btnCancelarResp.Enabled = true;
            btnAddResp.Enabled = false;
        }

        private void txtPergunta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPergunta.Text))
            {
                errCadQuestao.SetError(txtPergunta, "Descreva a nova pergunta a ser cadastrada");
                btnCriaPergunta.Enabled = false;
            }
            else if (txtPergunta.Text.Length <= 6)
            {
                errCadQuestao.SetError(txtPergunta, "Insira uma pergunta valida");
                btnCriaPergunta.Enabled = false;
            }
            else
            {
                errCadQuestao.SetError(txtPergunta, "");
                btnCriaPergunta.Enabled = true;
            }
        }

        private void txtResp1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtResp1.Text))
            {
                errCadQuestao.SetError(txtResp1, "Preencha esse campo com uma resposta");
                btnAddResp.Enabled = false;
            }
            else
            {
                errCadQuestao.SetError(txtResp1, "");
                btnAddResp.Enabled = true;
            }
        }

        private void txtResp2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtResp2.Text))
            {
                errCadQuestao.SetError(txtResp2, "Preencha esse campo com uma resposta");
                btnAddResp.Enabled = false;
            }
            else
            {
                errCadQuestao.SetError(txtResp2, "");
                btnAddResp.Enabled = true;
            }
        }

        private void txtResp3_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtResp3.Text))
            {
                errCadQuestao.SetError(txtResp3, "Preencha esse campo com uma resposta");
                btnAddResp.Enabled = false;
            }
            else
            {
                errCadQuestao.SetError(txtResp3, "");
                btnAddResp.Enabled = true;
            }
        }

        private void txtResp4_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtResp4.Text))
            {
                errCadQuestao.SetError(txtResp4, "Preencha esse campo com uma resposta");
                btnAddResp.Enabled = false;
            }
            else
            {
                errCadQuestao.SetError(txtResp4, "");
                btnAddResp.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja cancelar essa nova questão?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                groupBoxVisuQuestao.Enabled = false;
                groupBoxCriaPergunta.Enabled = true;
                txtPergunta.Clear();
                txtResp1.Clear();
                txtResp2.Clear();
                txtResp3.Clear();
                txtResp4.Clear();
                listBoxQuestao.Items.Clear();
                MessageBox.Show("Operação cancelada!");
            } else { return; }
            
        }
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<Resposta> pergs = new List<Resposta>();
            DialogResult result = MessageBox.Show("Deseja criar essa nova questão?", "Nova Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                pergs.Add(new Resposta(txtResp1.Text, float.Parse(txtExatasResp1.Text), float.Parse(txtHumanasResp1.Text), float.Parse(txtBioResp1.Text)));
                pergs.Add(new Resposta(txtResp2.Text, float.Parse(txtExatasResp2.Text), float.Parse(txtHumanasResp2.Text), float.Parse(txtBioResp2.Text)));
                pergs.Add(new Resposta(txtResp3.Text, float.Parse(txtExatasResp3.Text), float.Parse(txtHumanasResp3.Text), float.Parse(txtBioResp3.Text)));
                pergs.Add(new Resposta(txtResp4.Text, float.Parse(txtExatasResp4.Text), float.Parse(txtHumanasResp4.Text), float.Parse(txtBioResp4.Text)));

                try
                {
                    MontarQuestao(txtPergunta.Text, pergs);
                } catch(Exception ex)
                {
                    MessageBox.Show("Error!! " + ex.Message);
                    Log.GerarLog(ex.Message);
                }
                
                Log.GerarLog("Nova Questão adicionada ao sistema");
                LimparCampos();
                NovaQuestao();

                MessageBox.Show("Nova questão montada");

            } else { return; }

            
        }

        private void groupBoxValorResp1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtExatasResp1.Text) || string.IsNullOrEmpty(txtHumanasResp1.Text) || string.IsNullOrEmpty(txtBioResp1.Text))
            {
                errCadQuestao.SetError(groupBoxValorResp1,"Todos os valores da resposta são obrigatorios");
                btnAddResp.Enabled = false;
            } else
            {
                errCadQuestao.SetError(groupBoxValorResp1, "");
                btnAddResp.Enabled = true;
            }
        }

        private void groupBoxValorResp2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtExatasResp2.Text) || string.IsNullOrEmpty(txtHumanasResp2.Text) || string.IsNullOrEmpty(txtBioResp2.Text))
            {
                errCadQuestao.SetError(groupBoxValorResp2, "Todos os valores da resposta são obrigatorios");
                btnAddResp.Enabled = false;
            }
            else
            {
                errCadQuestao.SetError(groupBoxValorResp2, "");
                btnAddResp.Enabled = true;
            }
        }

        private void groupBoxValorResp3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtExatasResp3.Text) || string.IsNullOrEmpty(txtHumanasResp3.Text) || string.IsNullOrEmpty(txtBioResp3.Text))
            {
                errCadQuestao.SetError(groupBoxValorResp3, "Todos os valores da resposta são obrigatorios");
                btnAddResp.Enabled = false;
            }
            else
            {
                errCadQuestao.SetError(groupBoxValorResp3, "");
                btnAddResp.Enabled = true;
            }
        }

        private void groupBoxValorResp4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtExatasResp4.Text) || string.IsNullOrEmpty(txtHumanasResp4.Text) || string.IsNullOrEmpty(txtBioResp4.Text))
            {
                errCadQuestao.SetError(groupBoxValorResp4, "Todos os valores da resposta são obrigatorios");
                btnAddResp.Enabled = false;
            }
            else
            {
                errCadQuestao.SetError(groupBoxValorResp4, "");
                btnAddResp.Enabled = true;
            }
        }

        private void btnAddResp_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxQuestao.Items.Clear();
                listBoxQuestao.Items.Add("Nova pergunta: " + txtPergunta.Text);

                listBoxQuestao.Items.Add("1) Resposta: " + txtResp1.Text + "    Exatas: " + float.Parse(txtExatasResp1.Text) + "% / Humanas: " +
                    float.Parse(txtHumanasResp1.Text) + "% / Biológicas: " + float.Parse(txtBioResp1.Text) + "%");

                listBoxQuestao.Items.Add("2) Resposta: " + txtResp2.Text + "    Exatas: " + float.Parse(txtExatasResp2.Text) + "% / Humanas: " +
                    float.Parse(txtHumanasResp2.Text) + "% / Biológicas: " + float.Parse(txtBioResp2.Text) + "%");

                listBoxQuestao.Items.Add("3) Resposta: " + txtResp3.Text + "    Exatas: " + float.Parse(txtExatasResp3.Text) + "% / Humanas: " +
                    float.Parse(txtHumanasResp3.Text) + "% / Biológicas: " + float.Parse(txtBioResp3.Text) + "%");

                listBoxQuestao.Items.Add("4) Resposta: " + txtResp4.Text + "    Exatas: " + float.Parse(txtExatasResp4.Text) + "% / Humanas: " +
                    float.Parse(txtHumanasResp4.Text) + "% / Biológicas: " + float.Parse(txtBioResp4.Text) + "%");

                btnProxVisu.Visible = true;
            } catch(Exception)
            {
                MessageBox.Show("Você deve preencher corretamente todos os campos");
                return;
            }
            
        }

        private void btnCancelarResp_Click(object sender, EventArgs e)
        {
            txtResp1.Clear();
            txtResp2.Clear();
            txtResp3.Clear();
            txtResp4.Clear();
            txtExatasResp1.Clear();
            txtExatasResp2.Clear();
            txtExatasResp3.Clear();
            txtExatasResp4.Clear();
            txtHumanasResp1.Clear();
            txtHumanasResp2.Clear();
            txtHumanasResp3.Clear();
            txtHumanasResp4.Clear();
            txtBioResp1.Clear();
            txtBioResp2.Clear();
            txtBioResp3.Clear();
            txtBioResp4.Clear();
            listBoxQuestao.Items.Clear();
            listBoxQuestao.Items.Add("Nova pergunta: " + txtPergunta.Text);
            btnProxVisu.Visible = false;

        }

        private void btnProxVisu_Click_1(object sender, EventArgs e)
        {
            groupBoxAddResposta.Enabled = false;
            btnProxVisu.Visible = false;

            groupBoxVisuQuestao.Enabled = true;
            listBoxQuestao.Enabled = true;
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        
    }
}
