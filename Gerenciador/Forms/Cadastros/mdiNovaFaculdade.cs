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
    public partial class mdiNovaFaculdade : Form
    {
        public mdiNovaFaculdade()
        {
            InitializeComponent();
        }

        private Faculdade fac;
        private bd_top bd;

        public void ObjetosDesabilitados(bool condicao)
        {
            txtCelFac.Enabled = condicao;
            txtCep.Enabled = condicao;
            txtCidade.Enabled = condicao;
            txtEmailFac.Enabled = condicao;
            txtEnd.Enabled = condicao;
            txtEstado.Enabled = condicao;
            txtFax.Enabled = condicao;
            txtNomeFac.Enabled = condicao;
            txtSite.Enabled = condicao;
            txtTelFac.Enabled = condicao;
            cboxUF.Enabled = condicao;
            checkBxBuscarCep.Enabled = condicao;
            btnConfirmar.Visible = condicao;
            btnCancelar.Visible = condicao;
        }

        public void CarregarCombos(ComboBox cboxuf)
        {

            string[] ufs = {"AC","AL","AM","AP","BA","CE","DF","ES",
                            "GO","MA","MG","MS","MT","PA","PB","PE",
                            "PI","PR","RJ","RN","RO","RR","RS","SC",
                            "SE","SP","TO"};

            foreach (var uf in ufs)
            {
                cboxuf.Items.Add(uf.ToString());
            }

        }

        public void LimparCampos()
        {
            txtCelFac.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEmailFac.Clear();
            txtEnd.Clear();
            txtEstado.Clear();
            txtFax.Clear();
            txtNomeFac.Clear();
            txtSite.Clear();
            txtTelFac.Clear();
            cboxUF.Items.Clear();
            cboxUF.Text = "";
            checkBxBuscarCep.Checked = false;
        }

        public void DesabilitarErros(ErrorProvider erro)
        {
            erro.SetError(txtCelFac, "");
            erro.SetError(txtCidade, "");
            erro.SetError(txtEmailFac, "");
            erro.SetError(txtEnd, "");
            erro.SetError(txtEstado, "");
            erro.SetError(txtFax, "");
            erro.SetError(txtNomeFac, "");
            erro.SetError(txtSite, "");
            erro.SetError(txtTelFac, "");
            erro.SetError(cboxUF, "");
        }

        private void mdiNovaFaculdade_Load(object sender, EventArgs e)
        {
            ObjetosDesabilitados(false);
            CarregarCombos(cboxUF);

            txtCep.Enabled = false;
            btnBuscarCep.Enabled = false;
        }

        private void btnNovoCad_Click(object sender, EventArgs e)
        {
            ObjetosDesabilitados(true);
            txtCep.Enabled = false;
            btnBuscarCep.Enabled = false;

            Log.GerarLog("Criação de faculdade");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultCancel = MessageBox.Show("Deseja realmente cancelar essa operação?", "Cancelar cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultCancel == DialogResult.Yes)
            {
                LimparCampos();
                MessageBox.Show("Operação Cancelada", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObjetosDesabilitados(false);
                DesabilitarErros(errCadFacul);
                Log.GerarLog("Solicitação de cadastro de faculdade cancelada");
                CarregarCombos(cboxUF);

            }
            else { return; }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult ConfResult = MessageBox.Show(string.Format("Deseja cadastrar {0} como nova faculdade?", txtNomeFac.Text),
                                                      "Confirmar inserção de novo cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ConfResult == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                fac = new Faculdade(txtNomeFac.Text,txtEnd.Text,cboxUF.SelectedItem.ToString(),
                                    txtEstado.Text,txtCidade.Text,txtSite.Text);
               
                try
                {
                    fac.AdicionarFaculdade(fac);
                    fac.AdicionarContatoFaculdade(fac,1,txtEmailFac.Text);
                    fac.AdicionarContatoFaculdade(fac, 2, txtFax.Text);
                    fac.AdicionarContatoFaculdade(fac, 3, txtTelFac.Text);
                    fac.AdicionarContatoFaculdade(fac, 4, txtCelFac.Text);

                    MessageBox.Show("Cadastrado");
                    LimparCampos();
                    ObjetosDesabilitados(false);
                    DesabilitarErros(errCadFacul);
                    Log.GerarLog("Nova faculdade " + fac.Nome + " cadastrada");
                    CarregarCombos(cboxUF);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro - " + ex.Message + "Inner Message - " + ex.InnerException);
                    Log.GerarLog(ex.Message);
                }

            }
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            CEP cep = new CEP(txtCep.Text);

            txtCidade.Text = cep.localidade;
            txtEnd.Text = cep.logradouro;
            cboxUF.Text = cep.uf;
        }

        private void checkBxBuscarCep_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxBuscarCep.Checked == true)
            {
                txtCep.Enabled = true;
                btnBuscarCep.Enabled = true;
            }
            else
            {
                txtCep.Enabled = false;
                btnBuscarCep.Enabled = false;
            }
        }

        private void txtNomeFac_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNomeFac.Text))
            {
                errCadFacul.SetError(txtNomeFac, "Insira um nome de faculdade");
            } else if(txtNomeFac.Text.Length < 4)
            {
                errCadFacul.SetError(txtNomeFac, "Nome de faculdade inválido");
            }
            else
            {
                errCadFacul.SetError(txtNomeFac, "");
            }
        }

        private void txtEmailFac_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmailFac.Text.Contains("@") && txtEmailFac.Text.Contains("."))
            {
                errCadFacul.SetError(txtEmailFac, "");
                btnConfirmar.Enabled = true;
            }
            else if (string.IsNullOrEmpty(txtEmailFac.Text))
            {
                errCadFacul.SetError(txtEmailFac, "Informe um endereço de email");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadFacul.SetError(txtEmailFac, "Insira um endereço de email valido");
                btnConfirmar.Enabled = false;
            }
        }

        private void txtFax_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFax.Text))
            {
                errCadFacul.SetError(txtFax, "Insira um nome de faculdade");
            }
            else
            {
                errCadFacul.SetError(txtFax, "");
            }
        }

        private void txtTelFac_Validating(object sender, CancelEventArgs e)
        {
            if(txtTelFac.MaskCompleted == false)
            {
                errCadFacul.SetError(txtTelFac, "Insira um numero de telefone");
                
            } else
            {
                errCadFacul.SetError(txtTelFac, "");
            }
        }

        private void txtCelFac_Validating(object sender, CancelEventArgs e)
        {
            if (txtCelFac.MaskCompleted == false)
            {
                errCadFacul.SetError(txtCelFac, "Insira um numero de telefone");

            }
            else
            {
                errCadFacul.SetError(txtCelFac, "");
            }
        }

        private void txtSite_Validating(object sender, CancelEventArgs e)
        {
            if(txtSite.Text.Contains(".com")==false)
            {
                errCadFacul.SetError(txtSite, "Url de site invalida");
            } else if(string.IsNullOrEmpty(txtSite.Text))
            {
                errCadFacul.SetError(txtSite, "Insira a url do site");
            } else
            {
                errCadFacul.SetError(txtSite, "");
            }
        }

        private void txtEnd_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtEnd.Text))
            {
                errCadFacul.SetError(txtEnd, "Insira um endereço");
            } else
            {
                errCadFacul.SetError(txtEnd, "");
            }
        }

        private void txtEstado_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                errCadFacul.SetError(txtEstado, "Insira um endereço");
            }
            else
            {
                errCadFacul.SetError(txtEstado, "");
            }
        }

        private void cboxUF_Validating(object sender, CancelEventArgs e)
        {
            if(cboxUF.SelectedItem == null)
            {
                errCadFacul.SetError(cboxUF, "Selecione uma UF");
            } else
            {
                errCadFacul.SetError(cboxUF, "");
            }
        }

        private void txtCidade_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtCidade.Text))
            {
                errCadFacul.SetError(txtCidade, "Insira uma cidade");
            } else
            {
                errCadFacul.SetError(txtCidade, "");
            }
        }

        private void cboxUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            string uf = cboxUF.SelectedItem.ToString();

            switch (uf)
            {
                case "AC":
                    txtEstado.Text = "Acre";
                    break;
                case "AL":
                    txtEstado.Text = "Alagoas";
                    break;
                case "AM":
                    txtEstado.Text = "Amazonas";
                    break;
                case "AP":
                    txtEstado.Text = "Amapá";
                    break;
                case "BA":
                    txtEstado.Text = "Bahia";
                    break;
                case "CE":
                    txtEstado.Text = "Ceará";
                    break;
                case "DF":
                    txtEstado.Text = "Distrito Federal";
                    break;
                case "ES":
                    txtEstado.Text = "Espírito Santo";
                    break;
                case "GO":
                    txtEstado.Text = "Goiás";
                    break;
                case "MA":
                    txtEstado.Text = "Maranhão";
                    break;
                case "MG":
                    txtEstado.Text = "Minas Gerais";
                    break;
                case "MT":
                    txtEstado.Text = "Mato Grosso";
                    break;
                case "MS":
                    txtEstado.Text = "Mato Grosso do Sul";
                    break;
                case "PA":
                    txtEstado.Text = "Pará";
                    break;
                case "PB":
                    txtEstado.Text = "Paraíba";
                    break;
                case "PR":
                    txtEstado.Text = "Paraná";
                    break;
                case "PI":
                    txtEstado.Text = "Piauí";
                    break;
                case "PE":
                    txtEstado.Text = "Pernambuco";
                    break;
                case "RJ":
                    txtEstado.Text = "Rio de Janeiro";
                    break;
                case "RN":
                    txtEstado.Text = "Rio Grande do Norte";
                    break;
                case "RS":
                    txtEstado.Text = "Rio Grande so Sul";
                    break;
                case "RO":
                    txtEstado.Text = "Rondônia";
                    break;
                case "RR":
                    txtEstado.Text = "Roraima";
                    break;
                case "SC":
                    txtEstado.Text = "Santa Catarina";
                    break;
                case "SP":
                    txtEstado.Text = "São Paulo";
                    break;
                case "SE":
                    txtEstado.Text = "Sergipe";
                    break;
                case "TO":
                    txtEstado.Text = "Tocantins";
                    break;
                default:
                    break;
            }
        }
    }
}
