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

namespace Gerenciador.Forms.Consultas
{
    public partial class mdiVisualizarQuestoes : Form
    {
        private bd_top bd;
        private DataTable dt;

        public mdiVisualizarQuestoes()
        {
            InitializeComponent();
        }

        public DataTable MontarDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("ID Perg", typeof(int));
            dt.Columns.Add("Pergunta", typeof(string));
            dt.Columns.Add("ID Resp", typeof(int));
            dt.Columns.Add("Resposta", typeof(string));
            dt.Columns.Add("Perc Exatas", typeof(float));
            dt.Columns.Add("Perc Humanas", typeof(float));
            dt.Columns.Add("Perc Biologicas", typeof(float));

            return dt;

        }

        public void CarregarCombo(ComboBox cbox)
        {
            bd = new bd_top();

            foreach (var itemPerg in from perg in bd.tb_pergunta select perg)
            {
                cbox.Items.Add(itemPerg.perg_st_desc);
            }
        }

        private void mdiVisualizarQuestoes_Load(object sender, EventArgs e)
        {
            CarregarCombo(cboxPerg);
            dt = MontarDataTable();
            dtGridResp.DataSource = dt;
        }

        private void checkBuscarMaior_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBuscarMaior.Checked)
            {
                radioB.Enabled = true;
                radioE.Enabled = true;
                radioH.Enabled = true;
            } else
            {
                radioB.Enabled = false;
                radioE.Enabled = false;
                radioH.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dt.Clear();
            bd = new bd_top();
            
            var maiorExatas = from ex in bd.v_RelatorioQuestoes.Where(ex=>ex.desc_pergunta.Contains(cboxPerg.SelectedItem.ToString())) orderby ex.perc_exatas descending select ex;
            var maiorHumanas = from hu in bd.v_RelatorioQuestoes.Where(h=>h.desc_pergunta.Contains(cboxPerg.SelectedItem.ToString())) orderby hu.perc_humanas descending select hu;
            var maiorBiologicas = from bio in bd.v_RelatorioQuestoes.Where(b=>b.desc_pergunta.Contains(cboxPerg.SelectedItem.ToString())) orderby bio.perc_biologicas descending select bio;

            if (radioE.Checked && cboxPerg.SelectedItem != null)
            {
                foreach (var itemExatas in maiorExatas)
                {
                    dt.Rows.Add(itemExatas.id_pergunta, itemExatas.desc_pergunta, itemExatas.id_resposta, itemExatas.desc_resposta, itemExatas.perc_exatas, itemExatas.perc_humanas, itemExatas.perc_biologicas);
                }
            }

            else if (radioB.Checked && cboxPerg.SelectedItem != null)
            {
                foreach (var itemBio in maiorBiologicas)
                {
                    dt.Rows.Add(itemBio.id_pergunta, itemBio.desc_pergunta, itemBio.id_resposta, itemBio.desc_resposta, itemBio.perc_exatas, itemBio.perc_humanas, itemBio.perc_biologicas);
                }
            }

            else if (radioH.Checked && cboxPerg.SelectedItem != null)
            {
                foreach (var itemHumanas in maiorHumanas)
                {
                    dt.Rows.Add(itemHumanas.id_pergunta, itemHumanas.desc_pergunta, itemHumanas.id_resposta, itemHumanas.desc_resposta, itemHumanas.perc_exatas, itemHumanas.perc_humanas, itemHumanas.perc_biologicas);
                }
            }

            else if((radioE.Checked == false && radioB.Checked == false && radioH.Checked == false) && cboxPerg.SelectedItem != null )
            {
                foreach (var itemTodos in from td in bd.v_RelatorioQuestoes.Where(t => t.desc_pergunta.Contains(cboxPerg.SelectedItem.ToString())) select td)
                {
                    dt.Rows.Add(itemTodos.id_pergunta, itemTodos.desc_pergunta, itemTodos.id_resposta, itemTodos.desc_resposta, itemTodos.perc_exatas, itemTodos.perc_humanas, itemTodos.perc_biologicas);
                }
            }
            
            else if (radioE.Checked && cboxPerg.SelectedItem == null)
            {
                foreach (var itemExatas in from ex in bd.v_RelatorioQuestoes orderby ex.perc_exatas descending select ex)
                {
                    dt.Rows.Add(itemExatas.id_pergunta, itemExatas.desc_pergunta, itemExatas.id_resposta, itemExatas.desc_resposta, itemExatas.perc_exatas, itemExatas.perc_humanas, itemExatas.perc_biologicas);
                }
            }

            else if (radioB.Checked && cboxPerg.SelectedItem == null)
            {
                foreach (var itemBio in from hu in bd.v_RelatorioQuestoes orderby hu.perc_humanas descending select hu)
                {
                    dt.Rows.Add(itemBio.id_pergunta, itemBio.desc_pergunta, itemBio.id_resposta, itemBio.desc_resposta, itemBio.perc_exatas, itemBio.perc_humanas, itemBio.perc_biologicas);
                }
            }

            else if (radioH.Checked && cboxPerg.SelectedItem == null)
            {
                foreach (var itemHumanas in from bio in bd.v_RelatorioQuestoes orderby bio.perc_biologicas descending select bio)
                {
                    dt.Rows.Add(itemHumanas.id_pergunta, itemHumanas.desc_pergunta, itemHumanas.id_resposta, itemHumanas.desc_resposta, itemHumanas.perc_exatas, itemHumanas.perc_humanas, itemHumanas.perc_biologicas);
                }
            }

            else 
            {
                foreach (var itemTodos in from td in bd.v_RelatorioQuestoes select td)
                {
                    dt.Rows.Add(itemTodos.id_pergunta, itemTodos.desc_pergunta, itemTodos.id_resposta, itemTodos.desc_resposta, itemTodos.perc_exatas, itemTodos.perc_humanas, itemTodos.perc_biologicas);
                }
            }
            
            dtGridResp.DataSource = dt;

        }

        private void dtGridResp_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(radioE.Checked)
            {
                dtGridResp.Rows[e.RowIndex].Cells["Perc Exatas"].Style.BackColor = Color.LightBlue;
            }
            else if(radioH.Checked)
            {
                dtGridResp.Rows[e.RowIndex].Cells["Perc Humanas"].Style.BackColor = Color.LightBlue;
            }
            else if(radioB.Checked)
            {
                dtGridResp.Rows[e.RowIndex].Cells["Perc Biologicas"].Style.BackColor = Color.LightBlue;
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtGridResp.Columns.Clear();
            cboxPerg.SelectedItem = null;
            radioH.Checked = false;
            radioE.Checked = false;
            radioB.Checked = false;
            checkBuscarMaior.Checked = false;
            dt = MontarDataTable();
            dtGridResp.DataSource = dt;
        }
    }
}
