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

namespace Gerenciador.Forms.Cadastros
{
    public partial class novaArea : Form
    {
        private bd_top bd;
        private tb_area area;
        private mdiNovoCurso novoCurso;

        public novaArea(mdiNovoCurso novoCurso)
        {
            InitializeComponent();
            this.novoCurso = novoCurso;
        }

        private void novaArea_Load(object sender, EventArgs e)
        {
        }

        private void txtNovaArea_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNovaArea.Text))
            {
                errCadNovaArea.SetError(txtNovaArea, "Insira o valor da nova area");
                btnSalvar.Enabled = false;
            } else
            {
                errCadNovaArea.SetError(txtNovaArea, "");
                btnSalvar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultCancel = MessageBox.Show("Deseja realmente cancelar essa operação?", "Cancelar cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultCancel == DialogResult.Yes)
            {
                MessageBox.Show("Operação Cancelada", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Log.GerarLog("Solicitação de cadastro de nova area cancelada");
                txtNovaArea.Clear();
                btnSalvar.Enabled = false;
            }
            else { return; }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult ConfResult = MessageBox.Show(string.Format("Deseja cadastrar {0} como uma nova area?", txtNovaArea.Text),
                                                      "Confirmar inserção de novo cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ConfResult == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                bd = new bd_top();

                try{

                    area = new tb_area() { area_st_desc = txtNovaArea.Text };
                    bd.tb_area.Add(area);
                    bd.SaveChanges();
                    bd.Dispose();
                    MessageBox.Show("Nova area cadastrada");
                    txtNovaArea.Clear();
                    Log.GerarLog("Cadastro de nova area");

                } catch(Exception ex) {

                    MessageBox.Show("Erro - " + ex.Message);
                    Log.GerarLog(ex.Message);

                }
            }
        }

        private void novaArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            novoCurso.AtualizaComboAreas();
        }
    }
}
