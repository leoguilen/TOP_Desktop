using Gerenciador.Classes;
using Gerenciador.Classes.ObjetosCrud;
using Gerenciador.Classes.ObjetosDataSet;
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
    public partial class mdiAtualizarFacul : Form
    {
        public mdiAtualizarFacul()
        {
            InitializeComponent();
        }


        private bd_top bd = new bd_top();
        private BancoDesconectado bancoDesc;
        private Faculdade fac;
        private Gerenciador geren;

        public object RetornarID()
        {
            int numRow = dtGridFacul.CurrentRow.Index;
            var cell = dtGridFacul[0, numRow].Value;

            return cell;
        }

        public void AtualizarGrid()
        {
            bancoDesc = new BancoDesconectado(bd.Database.Connection.ConnectionString);
            dtGridFacul.DataSource = bancoDesc.RetornarTabela("Faculdade");
        }

        private void mdiAtualizarFacul_Load(object sender, EventArgs e)
        {
            bancoDesc = new BancoDesconectado(bd.Database.Connection.ConnectionString);
            dtGridFacul.DataSource = bancoDesc.RetornarTabela("Faculdade");
            dtGridFacul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridFacul.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dtGridFacul_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            bancoDesc = new BancoDesconectado(bd.Database.Connection.ConnectionString);
            dtGridFacul.Columns.Clear();
            dtGridFacul.DataSource = bancoDesc.RetornarTabela("Faculdade");
            MessageBox.Show("Atualização cancelada");
            Log.GerarLog("Atualização de Faculdade cancelada");
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            bancoDesc.AtualizaRegistro(bancoDesc.facTbAdapt, bancoDesc.dataSet, "Faculdade");
            MessageBox.Show("Atualização salva");
            Log.GerarLog("Atualização de Faculdade efetuada");
        }

        private void txtBuscarFac_TextChanged(object sender, EventArgs e)
        {
            fac = new Faculdade();
            dtGridFacul.DataSource = fac.BuscarFaculdadePorNome(txtBuscarFac.Text);
            dtGridFacul.Update();
            dtGridFacul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridFacul.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnVisualizarCad_Click_1(object sender, EventArgs e)
        {
            geren = new Gerenciador();
            AtualizaCadastroFacul atualCad = new AtualizaCadastroFacul(this);
            atualCad.MdiParent = geren.ActiveMdiChild;
            atualCad.Show();
        }

        private void dtGridFacul_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selecionadas = dtGridFacul.GetCellCount(DataGridViewElementStates.Selected);
            dtGridFacul.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (selecionadas > 0)
                btnVisualizarCad.Visible = true;
            else
                btnVisualizarCad.Visible = false;
        }
    }
}
