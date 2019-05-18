using Gerenciador.Classes;
using Gerenciador.Classes.ObjetosCrud;
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
    public partial class mdiNovoUsuario : Form
    {
        public mdiNovoUsuario()
        {
            InitializeComponent();
        }

        private Usuario us;
        private bd_top bd;
        
        public void ObjetosDesabilitados(bool condicao)
        {
            txtNome.Enabled = condicao;
            txtEmail.Enabled = condicao;
            radiobtnMasc.Enabled = condicao;
            radiobtnFem.Enabled = condicao;
            txtUsername.Enabled = condicao;
            txtSenha.Enabled = condicao;
            txtConfSenha.Enabled = condicao;
            txtDataNasc.Enabled = condicao;
            txtCidade.Enabled = condicao;
            cboxUF.Enabled = condicao;
            cboxNivel.Enabled = condicao;
            btnCancelar.Visible = condicao;
            btnConfirmar.Visible = condicao;
            maskTxtCel.Enabled = condicao;
            maskTxtTel.Enabled = condicao;
        }
        
        public void LimparCampos()
        {
            maskTxtCel.Clear();
            maskTxtTel.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtConfSenha.Clear();
            txtDataNasc.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtUsername.Clear();
            cboxNivel.Items.Clear();
            cboxUF.Items.Clear();
            radiobtnFem.Checked = false;
            radiobtnMasc.Checked = false;
        }

        public void CarregarCombos(ComboBox uf, ComboBox nivel)
        {

            string[] ufs = {"AC","AL","AM","AP","BA","CE","DF","ES",
                            "GO","MA","MG","MS","MT","PA","PB","PE",
                            "PI","PR","RJ","RN","RO","RR","RS","SC",
                            "SE","SP","TO"};

            bd = new bd_top();

            nivel.Items.Add(string.Empty);

            foreach (var itemNiv in from niv in bd.tb_nivelAcademico select new { niv.nivelAcad_st_desc })
            {
                nivel.Items.Add(itemNiv.nivelAcad_st_desc);
            }

            foreach (var itemUF in ufs)
            {
                uf.Items.Add(itemUF);
            }
        }
        public void DesabilitarErros(ErrorProvider erro)
        {
            erro.SetError(txtNome, "");
            erro.SetError(txtEmail, "");
            erro.SetError(txtSenha, "");
            erro.SetError(txtConfSenha, "");
            erro.SetError(txtCidade, "");
            erro.SetError(txtDataNasc, "");
            erro.SetError(cboxNivel, "");
            erro.SetError(cboxUF, "");
            erro.SetError(groupbxSexo, "");
            erro.SetError(maskTxtTel, "");
            erro.SetError(maskTxtCel, "");
            erro.SetError(txtUsername, "");
        }
        private void mdiNovoUsuario_Load(object sender, EventArgs e)
        {
            ObjetosDesabilitados(false);
            btnBuscarCep.Enabled = false;
            txtCep.Enabled = false;

            CarregarCombos(cboxUF,cboxNivel);

        }

        private void btnNovoCad_Click(object sender, EventArgs e)
        {
            ObjetosDesabilitados(true);
            btnConfirmar.Enabled = false;
            Log.GerarLog("Criação de usuário");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultCancel = MessageBox.Show("Deseja realmente cancelar essa operação?", "Cancelar cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultCancel == DialogResult.Yes)
            {
                LimparCampos();
                MessageBox.Show("Operação Cancelada", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObjetosDesabilitados(false);
                DesabilitarErros(errCadUsuario);
                Log.GerarLog("Solicitação de cadastro de usuário cancelada");

            }
            else { return; }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var sexo = "";
            DialogResult ConfResult = MessageBox.Show(string.Format("Deseja cadastrar {0} como novo usuário?", txtNome.Text),
                                                      "Confirmar inserção de novo cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ConfResult == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                if (radiobtnMasc.Checked)
                    sexo = "M";
                if (radiobtnFem.Checked)
                    sexo = "F";

                us = new Usuario()
                {
                    Nome = txtNome.Text,
                    Sexo = sexo,
                    DataNascimento = DateTime.Parse(txtDataNasc.Text),
                    Username = txtUsername.Text,
                    Senha = txtSenha.Text,
                    Cidade = txtCidade.Text,
                    Uf = cboxUF.SelectedItem.ToString(),
                    Nivel = cboxNivel.SelectedIndex,
                    DataCadastro = DateTime.Now,
                    FezTeste = 0
                };

                try
                {
                    us.AdicionarUsuario(us, txtEmail.Text, maskTxtTel.Text, maskTxtCel.Text);
                    MessageBox.Show("Cadastrado");
                    LimparCampos();
                    ObjetosDesabilitados(false);
                    DesabilitarErros(errCadUsuario);
                    Log.GerarLog("Usuário " + us.Nome + " cadastrado");

                }
                catch(Exception ex)
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
            cboxUF.Text = cep.uf;
        }

        private void checkBxBuscarCep_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBxBuscarCep.Checked == true)
            {
                txtCep.Enabled = true;
                btnBuscarCep.Enabled = true;
            } else
            {
                txtCep.Enabled = false;
                btnBuscarCep.Enabled = false;
            }
        }

        private void maskTxtCel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNome.Text))
            {
                errCadUsuario.SetError(txtNome, "Informe o nome do usuário");
                btnConfirmar.Enabled = false;
            }else if(txtNome.TextLength < 6)
            {
                errCadUsuario.SetError(txtNome, "Campo nome precisa no minimo de 6 caracteres para ser valido");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadUsuario.SetError(txtNome, "");
                btnConfirmar.Enabled = true;
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".com"))
            {
                errCadUsuario.SetError(txtEmail, "");
                btnConfirmar.Enabled = true;
            } else if(string.IsNullOrEmpty(txtEmail.Text))
            {
                errCadUsuario.SetError(txtEmail, "Informe um endereço de email");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadUsuario.SetError(txtEmail, "Insira um endereço de email valido");
                btnConfirmar.Enabled = false;
            } 
        }

        private void groupbxSexo_Validating(object sender, CancelEventArgs e)
        {
            if (radiobtnFem.Checked == false && radiobtnMasc.Checked == false)
            {
                errCadUsuario.SetError(groupbxSexo, "Selecione seu genero");
                btnConfirmar.Enabled = false;
            } else
            {
                errCadUsuario.SetError(groupbxSexo, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void txtDataNasc_Validating(object sender, CancelEventArgs e)
        {
            if (txtDataNasc.MaskCompleted == false)
            {
                errCadUsuario.SetError(txtDataNasc, "Complete o campo com uma data valida");
                btnConfirmar.Enabled = false;
            } else if (string.IsNullOrEmpty(txtDataNasc.Text))
            {
                errCadUsuario.SetError(txtDataNasc, "Insira a data de nascimento");
                btnConfirmar.Enabled = false;
            } else
            {
                errCadUsuario.SetError(txtDataNasc, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errCadUsuario.SetError(txtUsername, "Informe um username para o usuário");
                btnConfirmar.Enabled = false;
            }
            else if (txtUsername.TextLength < 6)
            {
                errCadUsuario.SetError(txtUsername, "Campo nome precisa no minimo de 6 caracteres para ser valido");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadUsuario.SetError(txtUsername, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            if(txtSenha.TextLength<6)
            {
                errCadUsuario.SetError(txtSenha,"Senha deve ter no minimo 6 caracteres para ser valida");
                btnConfirmar.Enabled = false;
            } else if(string.IsNullOrEmpty(txtSenha.Text)){
                errCadUsuario.SetError(txtSenha, "Insira uma senha");
                btnConfirmar.Enabled = false;
            } else
            {
                errCadUsuario.SetError(txtSenha, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void txtConfSenha_Validating(object sender, CancelEventArgs e)
        {
            if(!txtConfSenha.Text.Equals(txtSenha.Text))
            {
                errCadUsuario.SetError(txtConfSenha, "Senhas não conferem");
                btnConfirmar.Enabled = false;
            } else if(string.IsNullOrEmpty(txtConfSenha.Text))
            {
                errCadUsuario.SetError(txtConfSenha, "Insira a confirmação da senha");
                btnConfirmar.Enabled = false;
            } else
            {
                errCadUsuario.SetError(txtConfSenha, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void txtCidade_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                errCadUsuario.SetError(txtCidade, "Informe uma cidade");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadUsuario.SetError(txtCidade, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void cboxUF_Validating(object sender, CancelEventArgs e)
        {
            if(cboxUF.SelectedItem == null)
            {
                errCadUsuario.SetError(cboxUF, "Selecione uma UF");
                btnConfirmar.Enabled = false;
            } else
            {
                errCadUsuario.SetError(cboxUF, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void cboxNivel_Validating(object sender, CancelEventArgs e)
        {
            if (cboxNivel.SelectedItem == null)
            {
                errCadUsuario.SetError(cboxNivel, "Selecione um nivel academico");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadUsuario.SetError(cboxNivel, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void maskTxtTel_Validating(object sender, CancelEventArgs e)
        {
            if (maskTxtTel.MaskCompleted == false)
            {
                errCadUsuario.SetError(maskTxtTel, "Complete o campo com um numero de telefone valido");
                btnConfirmar.Enabled = false;
            }
            else if (string.IsNullOrEmpty(maskTxtTel.Text))
            {
                errCadUsuario.SetError(maskTxtTel, "Insira um telefone");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadUsuario.SetError(maskTxtTel, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void maskTxtCel_Validating(object sender, CancelEventArgs e)
        {
            if (maskTxtCel.MaskCompleted == false)
            {
                errCadUsuario.SetError(maskTxtCel, "Complete o campo com um numero de celular valido");
                btnConfirmar.Enabled = false;
            }
            else if (string.IsNullOrEmpty(maskTxtCel.Text))
            {
                errCadUsuario.SetError(maskTxtCel, "Insira um celular");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadUsuario.SetError(maskTxtCel, "");
                btnConfirmar.Enabled = true;
            }
        }
    }
}
