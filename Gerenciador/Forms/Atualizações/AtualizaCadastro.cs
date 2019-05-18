using Gerenciador.Classes;
using Gerenciador.Classes.ObjetosBanco;
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
    public partial class AtualizaCadastro : Form
    {
        private mdiAtualizarUsuario mdiAtualizar;

        public AtualizaCadastro(mdiAtualizarUsuario mdiAtualizar)
        {
            InitializeComponent();
            this.mdiAtualizar = mdiAtualizar;
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

        int IDSelecionado;
        private bd_top bd;
        private Banco b;

        private void AtualizaCadastro_Load(object sender, EventArgs e)
        {
            bd = new bd_top();
            IDSelecionado = (int)mdiAtualizar.RetornarID();
            CarregarCombos(cboxUF, cboxNivel);
            var dadosUsuario = new v_relatorioUsuario();
            string tel = "", cel = "";

            //foreach (var itemUser in from user in bd.v_relatorioUsuario.Where(u => (u.id_user == IDSelecionado && u.desc_tipoCont.Equals("Telefone")) || string.IsNullOrEmpty(u.desc_cont)) select user)
            //{
            //    if(string.IsNullOrEmpty(itemUser.desc_cont))
            //    {
            //        dadosUsuario = itemUser;
            //        tel = null;
            //    }
            //    else
            //    {
            //        dadosUsuario = itemUser;
            //        tel = itemUser.desc_cont;
            //    }
                
            //}

            foreach (var itemUser in from user in bd.v_relatorioUsuario.Where(u => u.id_user == IDSelecionado && u.desc_tipoCont.Equals("Celular")) select user)
            {
                dadosUsuario = itemUser;
                cel = itemUser.desc_cont;
            }

            lblNomeSelecionado.Text += dadosUsuario.nome_user;
            txtNome.Text = dadosUsuario.nome_user;
            txtEmail.Text = dadosUsuario.desc_email;
            txtUsername.Text = dadosUsuario.username_user;
            txtDataNasc.Text = dadosUsuario.nasc_user.ToString();
            txtCidade.Text = dadosUsuario.cidade_user;
            maskTxtCel.Text = cel;
            maskTxtTel.Text = tel;
            cboxNivel.SelectedItem = dadosUsuario.desc_nivelAcad;
            cboxUF.SelectedItem = dadosUsuario.uf_user;

            if (dadosUsuario.sexo_user == "M") { 
                radiobtnMasc.Checked = true;
                radiobtnFem.Checked = false;
            }
            else
            {
                radiobtnFem.Checked = true;
                radiobtnMasc.Checked = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (radiobtnMasc.Checked == true){ sexo = "M";}
            else { sexo = "F"; }

            Usuario us = new Usuario(txtNome.Text,sexo,DateTime.Parse(txtDataNasc.Text),txtUsername.Text,cboxUF.SelectedItem.ToString(),txtCidade.Text,cboxNivel.SelectedIndex);
            Contato cont = new Contato(maskTxtTel.Text,maskTxtCel.Text);
            Email mail = new Email(txtEmail.Text);

            bd.sp_atualizaCadastro(IDSelecionado,mail.DescEmail,us.Nivel,us.Cidade,us.Uf,cont.Telefone,cont.Celular,"","");
            MessageBox.Show("Atualização feita com sucesso");
            Log.GerarLog("Atualização do usuário " + txtNome.Text + " efetuado com sucesso");

            ActiveForm.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Atualização cancelada");
            Log.GerarLog("Atualização do usuário " + txtNome.Text + " foi cancelada");
        }

        private void AtualizaCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            mdiAtualizar.AtualizarGrid();
        }
    }
}
