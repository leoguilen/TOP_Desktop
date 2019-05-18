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

namespace Gerenciador.Forms.Atualizações
{
    public partial class mdiModificarQuestao : Form
    {
        private bd_top bd;
        private DataTable dt;
        private BancoDesconectado banco;

        public mdiModificarQuestao()
        {
            InitializeComponent();
        }

        public void CarregarCombo(ComboBox cbox)
        {
            bd = new bd_top();

            foreach (var itemPerg in from perg in bd.tb_pergunta select perg)
            {
                cbox.Items.Add(itemPerg.perg_st_desc);
            }
        }

        public object RetornarID()
        {
            int numRow = dtGridResp.CurrentRow.Index;
            var cell = dtGridResp[1, numRow].Value;

            return cell;
        }

        public void AtualizarGrid()
        {
            bd = new bd_top();
            dt = MontarDataTable();

            var buscar = from resp in bd.v_RelatorioQuestoes select resp;

            foreach (var itemResp in buscar)
            {
                dt.Rows.Add(itemResp.id_pergunta,itemResp.id_resposta, itemResp.desc_resposta, itemResp.perc_exatas, itemResp.perc_humanas, itemResp.perc_biologicas);
            }

            dtGridResp.DataSource = dt;
            dtGridResp.Refresh();
        }

        public DataTable MontarDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("ID Perg",typeof(int));
            dt.Columns.Add("ID Resp", typeof(int));
            dt.Columns.Add("Resposta", typeof(string));
            dt.Columns.Add("Perc Exatas", typeof(float));
            dt.Columns.Add("Perc Humanas", typeof(float));
            dt.Columns.Add("Perc Biologicas", typeof(float));

            return dt;
        }

        public void FiltrarDataView(DataGridView grid, string perg)
        {
            bd = new bd_top();

            dt = MontarDataTable();

            var buscarResps = from resp in bd.v_RelatorioQuestoes.Where(r => r.desc_pergunta.Contains(perg)) select resp;

            foreach (var itemResp in buscarResps)
            {
                dt.Rows.Add(itemResp.id_pergunta,itemResp.id_resposta, itemResp.desc_resposta, itemResp.perc_exatas, itemResp.perc_humanas, itemResp.perc_biologicas);
            }

            grid.DataSource = dt;

        }

        public void CarregarDataView(DataGridView grid)
        {
            bd = new bd_top();

            dt = MontarDataTable();

            var buscarResps = from resp in bd.v_RelatorioQuestoes select resp;

            foreach (var itemResp in buscarResps)
            {
                dt.Rows.Add(itemResp.id_pergunta,itemResp.id_resposta, itemResp.desc_resposta, itemResp.perc_exatas, itemResp.perc_humanas, itemResp.perc_biologicas);
            }

            grid.DataSource = dt;

        }

        private void mdiModificarQuestao_Load(object sender, EventArgs e)
        {
            CarregarDataView(dtGridResp);
            CarregarCombo(cboxPerg);
        }

        private void cboxPerg_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDataView(dtGridResp, cboxPerg.SelectedItem.ToString());
        }

        private void dtGridResp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selecionadas = dtGridResp.GetCellCount(DataGridViewElementStates.Selected);
            if (selecionadas > 0)
                btnVisualizarCad.Visible = true;
            else
                btnVisualizarCad.Visible = false;
        }

        private void btnVisualizarCad_Click(object sender, EventArgs e)
        {
            ModificarResposta modificar = new ModificarResposta(this);
            modificar.MdiParent = ActiveForm;
            modificar.Show();
        }
    }
}
