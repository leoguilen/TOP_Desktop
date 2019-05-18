using Gerenciador.Classes;
using Gerenciador.Classes.ObjetosBanco;
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
    public partial class AtualizaCadastroFacul : Form
    {
        mdiAtualizarFacul atualizarFacul;
        public AtualizaCadastroFacul(mdiAtualizarFacul atualizarFacul)
        {
            InitializeComponent();
            this.atualizarFacul = atualizarFacul;
        }

        public void CarregarCombos(ComboBox uf)
        {

            string[] ufs = {"AC","AL","AM","AP","BA","CE","DF","ES",
                            "GO","MA","MG","MS","MT","PA","PB","PE",
                            "PI","PR","RJ","RN","RO","RR","RS","SC",
                            "SE","SP","TO"};
            
            foreach (var itemUF in ufs)
            {
                uf.Items.Add(itemUF);
            }
        }

        int IDSelecionado;
        private bd_top bd;
        private Banco b;

        private void AtualizaCadastroFacul_Load(object sender, EventArgs e)
        {
            bd = new bd_top();
            IDSelecionado = (int)atualizarFacul.RetornarID();
            CarregarCombos(cboxUF);
            var dadosFac = new v_relatorioFaculdades();
            string tel = "", cel = "",email = "",fax = "";

            foreach (var itemFac in from user in bd.v_relatorioFaculdades.Where(f => f.id_facul == IDSelecionado && f.tipoContado_facul.Contains("Telefone")) select user)
            {
                dadosFac = itemFac;
                tel = itemFac.contato_facul;
            }
            foreach (var itemFac in from user in bd.v_relatorioFaculdades.Where(f => f.id_facul == IDSelecionado && f.tipoContado_facul.Contains("Celular")) select user)
            {
                dadosFac = itemFac;
                cel = itemFac.contato_facul;
            }
            foreach (var itemFac in from user in bd.v_relatorioFaculdades.Where(f => f.id_facul == IDSelecionado && f.tipoContado_facul.Contains("Email")) select user)
            {
                dadosFac = itemFac;
                email = itemFac.contato_facul;
            }
            foreach (var itemFac in from user in bd.v_relatorioFaculdades.Where(f => f.id_facul == IDSelecionado && f.tipoContado_facul.Contains("Fax")) select user)
            {
                dadosFac = itemFac;
                fax = itemFac.contato_facul;
            }

            lblNomeSelecionado.Text += dadosFac.nome_facul;
            txtNomeFac.Text = dadosFac.nome_facul;
            txtEmailFac.Text = email;
            txtFax.Text = fax;
            txtCelFac.Text = cel;
            txtTelFac.Text = tel;
            txtSite.Text = dadosFac.site_facul;
            txtEnd.Text = dadosFac.endereco_facul;
            txtCidade.Text = dadosFac.cidade_facul;
            cboxUF.SelectedItem = dadosFac.uf_facul;
            txtEstado.Text = dadosFac.estado_facul;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Atualização cancelada");
            Log.GerarLog("Atualização da faculdade " + txtNomeFac.Text + " foi cancelada");
        }

        private void AtualizaCadastroFacul_FormClosing(object sender, FormClosingEventArgs e)
        {
            atualizarFacul.AtualizarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Faculdade fac = new Faculdade(txtNomeFac.Text,txtEnd.Text,cboxUF.SelectedItem.ToString(),txtEstado.Text,txtCidade.Text,txtSite.Text);
            fac.AtualizarFaculdade(IDSelecionado,fac,txtTelFac.Text,txtCelFac.Text,txtFax.Text,txtEmailFac.Text);
            
            MessageBox.Show("Atualização feita com sucesso");
            Log.GerarLog("Atualização da faculdade " + txtNomeFac.Text + " efetuado com sucesso");

            ActiveForm.Refresh();
        }
    }
}
