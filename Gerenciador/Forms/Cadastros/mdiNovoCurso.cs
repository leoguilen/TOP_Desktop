using Gerenciador.Classes;
using Gerenciador.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Forms.Cadastros
{
    public partial class mdiNovoCurso : Form
    {
        private bd_top bd;
        private Curso curso;
        string urlImgCurso;
        
        public mdiNovoCurso()
        {
            InitializeComponent();
        }

        public void ArmazenarImagem(string filename)
        {
            string pic = @"C:\xampp\htdocs\top\assets\dashboard\img\ImagemCurso\" + filename;
            Image img = this.picImgCurso.Image;
            img.Save(pic,System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void AtualizaComboAreas()
        {
            cboxAreas.Items.Clear();

            foreach (var itemArea in from area in bd.tb_area orderby area.area_st_desc ascending select area)
            {
                cboxAreas.Items.Add(itemArea.area_st_desc);
            }
        }

        public void ObjetosDesabilitados(bool condicao)
        {
            txtNomeCur.Enabled = condicao;
            txtDescCur.Enabled = condicao;
            cboxAreas.Enabled = condicao;
            radioG.Enabled = condicao;
            radioPG.Enabled = condicao;
            cboxDuracao.Enabled = condicao;
            btnBuscarImg.Enabled = condicao;
            btnNovaArea.Enabled = condicao;
            btnCancelar.Visible = condicao;
            btnConfirmar.Visible = condicao;
            maskTxtMax.Visible = condicao;
            maskTxtMin.Visible = condicao;

        }

        public void LimparCampos()
        {
            txtNomeCur.Clear();
            txtDescCur.Clear();
            radioG.Checked = false;
            radioPG.Checked = false;
            cboxDuracao.Items.Clear();
            cboxDuracao.Text = "";
            cboxAreas.Items.Clear();
            cboxAreas.Text = "";
            maskTxtMax.Text = "";
            maskTxtMin.Text = "";
            picImgCurso.Image = new Bitmap(@"C:\Users\LGuilen\Documents\Arquivos Projeto\Projeto Faculdade\CÓDIGO\GerenciadorTOP (Desktop)\Gerenciador\Imagens\fundoBranco.png");
        }

        public void DesabilitarErros(ErrorProvider err)
        {
            err.SetError(txtNomeCur, "");
            err.SetError(txtDescCur, "");
            err.SetError(cboxDuracao, "");
            err.SetError(radioG, "");
            err.SetError(radioPG, "");
            err.SetError(cboxAreas, "");
            err.SetError(maskTxtMax, "");
            err.SetError(maskTxtMin, "");
        }

        public void CarregarCombo(ComboBox cbox, ComboBox cboxArea)
        {
            bd = new bd_top();

            string[] duracao = {"1 ano","1 ano e meio","2 anos","2 anos e meio","3 anos","4 anos","5 anos" };
            foreach (var itemDuracao in duracao)
            {
                cbox.Items.Add(itemDuracao);
            }

            foreach (var itemArea in from area in bd.tb_area orderby area.area_st_desc ascending select area)
            {
                cboxArea.Items.Add(itemArea.area_st_desc);
            }

        }

        private void mdiNovoCurso_Load(object sender, EventArgs e)
        {
            ObjetosDesabilitados(false);
            btnConfirmar.Enabled = false;
        }

        private void btnNovoCad_Click(object sender, EventArgs e)
        {
            ObjetosDesabilitados(true);
            CarregarCombo(cboxDuracao,cboxAreas);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultCancel = MessageBox.Show("Deseja realmente cancelar essa operação?", "Cancelar cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultCancel == DialogResult.Yes)
            {
                LimparCampos();
                MessageBox.Show("Operação Cancelada", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObjetosDesabilitados(false);
                DesabilitarErros(errCadCurso);
                Log.GerarLog("Solicitação de cadastro de usuário cancelada");

            }
            else { return; }
        }

        private void txtNomeCur_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCur.Text))
            {
                errCadCurso.SetError(txtNomeCur, "Insira um nome para o curso");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadCurso.SetError(txtNomeCur, "");
                btnConfirmar.Enabled = false;
            }
        }

        private void txtDescCur_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescCur.Text))
            {
                errCadCurso.SetError(txtDescCur, "Insira uma descrição para o curso");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadCurso.SetError(txtDescCur, "");
                btnConfirmar.Enabled = false;
            }
        }

        private void groupTipoCurso_Validating(object sender, CancelEventArgs e)
        {
            if(radioG.Checked == false && radioPG.Checked == false)
            {
                errCadCurso.SetError(groupTipoCurso,"Selecione um tipo de curso");
                btnConfirmar.Enabled = false;
            } else
            {
                errCadCurso.SetError(groupTipoCurso, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void cboxDuracao_Validating(object sender, CancelEventArgs e)
        {
            if(cboxDuracao.SelectedItem == null)
            {
                errCadCurso.SetError(cboxDuracao,"Selecione uma duração para o curso");
                btnConfirmar.Enabled = false;
            } else
            {
                errCadCurso.SetError(cboxDuracao, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void cboxAreas_Validating(object sender, CancelEventArgs e)
        {
            if (cboxAreas.SelectedItem == null)
            {
                errCadCurso.SetError(cboxAreas, "Selecione uma area para o curso");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadCurso.SetError(cboxAreas, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void btnNovaArea_Click(object sender, EventArgs e)
        {
            novaArea novaArea = new novaArea(this);
            novaArea.MdiParent = ActiveForm;
            novaArea.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bd = new bd_top();
            string tipoCurso = string.Empty;
            int idArea = 0;

            if (radioG.Checked == true)
            { tipoCurso = "G"; }
            else if (radioPG.Checked == true)
            { tipoCurso = "PG"; }

            foreach (var itemArId in from ar in bd.tb_area .Where(a=>a.area_st_desc.Contains(cboxAreas.SelectedItem.ToString()))select ar)
            {
                idArea = itemArId.area_in_id;
            }

            DialogResult ConfResult = MessageBox.Show(string.Format("Deseja cadastrar {0} como um novo curso?", txtNomeCur.Text),
                                                      "Confirmar inserção de novo cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ConfResult == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                try
                {
                    curso = new Curso()
                    {
                        Nome = txtNomeCur.Text,
                        Descricao = txtDescCur.Text,
                        TipoCurso = tipoCurso,
                        TempoDeDuração = cboxDuracao.SelectedItem.ToString(),
                        AreaCurso = idArea,
                        UrlImagem = urlImgCurso,
                        ValorMax = int.Parse(maskTxtMax.Text),
                        ValorMin = int.Parse(maskTxtMin.Text)
                    };

                    curso.AdicionarCurso(curso);

                    MessageBox.Show(string.Format("Curso {0} cadastrado com sucesso", txtNomeCur.Text));
                    ObjetosDesabilitados(false);
                    LimparCampos();
                    Log.GerarLog(string.Format("Novo curso {0} cadastrado", txtNomeCur.Text));
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro - " + ex.Message);
                    Log.GerarLog(ex.Message);
                }
            }
        }

        private void btnBuscarImg_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                picImgCurso.Image = new Bitmap(openFileDialog.FileName);
                urlImgCurso = openFileDialog.SafeFileName;
                ArmazenarImagem(urlImgCurso);

            } else { return; }

        }

        private void maskTxtMin_Validating(object sender, CancelEventArgs e)
        {
            if(maskTxtMin.MaskCompleted == false)
            {
                errCadCurso.SetError(maskTxtMin, "Campo esta incompleto");
                btnConfirmar.Enabled = false;
            } else
            {
                errCadCurso.SetError(maskTxtMin, "");
                btnConfirmar.Enabled = true;
            }
        }

        private void maskTxtMax_Validating(object sender, CancelEventArgs e)
        {
            if (maskTxtMax.MaskCompleted == false)
            {
                errCadCurso.SetError(maskTxtMax, "Campo esta incompleto");
                btnConfirmar.Enabled = false;
            }
            else
            {
                errCadCurso.SetError(maskTxtMax, "");
                btnConfirmar.Enabled = true;
            }
        }
    }
}
