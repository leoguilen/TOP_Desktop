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
    public partial class mdiAtualizarUsuario : Form
    {
        public mdiAtualizarUsuario()
        {
            InitializeComponent();
        }


        private bd_top bd = new bd_top();
        private BancoDesconectado bancoDesc;
        private Usuario user;
        private Gerenciador geren;
        
        public object RetornarID()
        {
            int numRow = dtGridUsuarios.CurrentRow.Index;
            var cell = dtGridUsuarios[0, numRow].Value;

            return cell;
        }

        public void AtualizarGrid()
        {
            bancoDesc = new BancoDesconectado(bd.Database.Connection.ConnectionString);
            dtGridUsuarios.DataSource = bancoDesc.RetornarTabela("Usuario");
        }

        private void mdiAtualizarUsuario_Load(object sender, EventArgs e)
        {
            bancoDesc = new BancoDesconectado(bd.Database.Connection.ConnectionString);
            dtGridUsuarios.DataSource = bancoDesc.RetornarTabela("Usuario");
            dtGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dtGridUsuarios_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bancoDesc = new BancoDesconectado(bd.Database.Connection.ConnectionString);
            dtGridUsuarios.Columns.Clear();
            dtGridUsuarios.DataSource = bancoDesc.RetornarTabela("Usuario");
            MessageBox.Show("Atualização cancelada");
            Log.GerarLog("Atualização de usuário cancelada");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bancoDesc.AtualizaRegistro(bancoDesc.usTbAdapt,bancoDesc.dataSet,"Usuario");
            MessageBox.Show("Atualização salva");
            Log.GerarLog("Atualização de usuário efetuada");
        }

        private void dtGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selecionadas = dtGridUsuarios.GetCellCount(DataGridViewElementStates.Selected);
            dtGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (selecionadas > 0)
                btnVisualizarCad.Visible = true;
            else
                btnVisualizarCad.Visible = false;
        }

        private void txtBuscarUs_TextChanged(object sender, EventArgs e)
        {
            user = new Usuario();
            dtGridUsuarios.DataSource = user.BuscarUsuario(txtBuscarUs.Text);
            dtGridUsuarios.Update();
            dtGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnVisualizarCad_Click(object sender, EventArgs e)
        {
            geren = new Gerenciador();
            AtualizaCadastro atualCad = new AtualizaCadastro(this);
            atualCad.MdiParent = geren.ActiveMdiChild;
            atualCad.Show();
            
        }
    }
}
