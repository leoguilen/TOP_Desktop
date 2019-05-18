using Gerenciador.Classes;
using Gerenciador.Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;

namespace Gerenciador.Forms.Consultas
{
    public partial class mdiGerarRelatorioNotas : Form
    {
        private bd_top bd;
        private v_RelatorioCurso relatorioCurso;
        private TreeNode noRelatorioAv;
        private TreeNode noPrinFac;
        private TreeNode noPrinCur;
        private TreeNode noPrinNt;
        private string tipoNo;
        

        public mdiGerarRelatorioNotas()
        {
            InitializeComponent();
        }
        
        public void GerarRelatorioPDF(TreeNodeCollection tree)
        {
            bd = new bd_top();
            string diretorio = @"\RelatoriosAvaliacoes\";
            string caminho = Directory.GetCurrentDirectory() + diretorio;
            IEnumerable<v_relatorioNotaMec> relatorioNotaMec = null;

            if (Directory.Exists(caminho))
            {
                foreach (TreeNode nome in tree)
                {
                    Document doc = new Document(PageSize.GetRectangle("1150 600"), -90, -90, 25, 0);
                    PdfWriter write;

                    if (!File.Exists(caminho + nome.Text + ".pdf"))
                    {

                        write = PdfWriter.GetInstance(doc, new FileStream(caminho + nome.Text + ".pdf", FileMode.Create));
                    }
                    else
                    {
                        Random r = new Random();
                        int num = r.Next(1, 1000);
                        write = PdfWriter.GetInstance(doc, new FileStream(caminho + nome.Text + num + ".pdf", FileMode.Create));
                    }

                    doc.Open();

                    PdfPTable tabela = new PdfPTable(7);

                    var contentByte = write.DirectContent;
                    var image = Image.GetInstance(@"C:\Users\LGuilen\Documents\Arquivos Projeto\Projeto Faculdade\CÓDIGO\GerenciadorTOP (Desktop)\Gerenciador\Resources\Logo.png");
                    image.ScaleToFit(69, 40);
                    image.SetAbsolutePosition(20, 20);
                    contentByte.AddImage(image);

                    Font fonte = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 12);
                    Font fontTitle = FontFactory.GetFont(BaseFont.TIMES_BOLD, 20);

                    Paragraph titulo = new Paragraph("Relatório de avaliações\n", fontTitle);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    doc.Add(new Paragraph("\n"));

                    Paragraph col1 = new Paragraph("ID Faculdade", fonte);
                    Paragraph col2 = new Paragraph("Faculdade", fonte);
                    Paragraph col3 = new Paragraph("UF", fonte);
                    Paragraph col4 = new Paragraph("ID Curso", fonte);
                    Paragraph col5 = new Paragraph("Curso", fonte);
                    Paragraph col6 = new Paragraph("Area", fonte);
                    Paragraph col7 = new Paragraph("Nota MEC", fonte);

                    var cel1 = new PdfPCell();
                    var cel2 = new PdfPCell();
                    var cel3 = new PdfPCell();
                    var cel4 = new PdfPCell();
                    var cel5 = new PdfPCell();
                    var cel6 = new PdfPCell();
                    var cel7 = new PdfPCell();

                    cel1.AddElement(col1);
                    cel2.AddElement(col2);
                    cel3.AddElement(col3);
                    cel4.AddElement(col4);
                    cel5.AddElement(col5);
                    cel6.AddElement(col6);
                    cel7.AddElement(col7);

                    tabela.AddCell(cel1);
                    tabela.AddCell(cel2);
                    tabela.AddCell(cel3);
                    tabela.AddCell(cel4);
                    tabela.AddCell(cel5);
                    tabela.AddCell(cel6);
                    tabela.AddCell(cel7);
                    
                foreach (TreeNode node in tree)
                    {
                        switch (tipoNo)
                        {
                            case "Nota":
                                {
                                    relatorioNotaMec = (from ret in bd.v_relatorioNotaMec.Where(r => r.valor_notaMec == int.Parse(node.Text)) select ret);
                                break;
                                }

                            case "Faculdade":
                                {
                                    relatorioNotaMec = (from ret in bd.v_relatorioNotaMec.Where(r => r.nome_facul.Contains(node.Text)) select ret);
                                    break;
                                }

                            case "Curso":
                                {
                                    relatorioNotaMec = (from ret in bd.v_relatorioNotaMec.Where(r => r.nome_curso.Contains(node.Text)) select ret);
                                    break;
                                }

                            default:
                                break;
                        }



                        foreach (var av in relatorioNotaMec)
                        {
                            Phrase IdFac = new Phrase(av.id_facul.ToString());
                            Phrase fac = new Phrase(av.nome_facul);
                            Phrase IdCur = new Phrase(av.id_curso.ToString());
                            Phrase cur = new Phrase(av.nome_curso);
                            Phrase area = new Phrase(av.desc_area);
                            Phrase uf = new Phrase(av.uf_facul.ToString());
                            Phrase nota = new Phrase(av.valor_notaMec.ToString());

                            var cell = new PdfPCell(IdFac);
                            tabela.AddCell(cell);

                            cell = new PdfPCell(fac);
                            tabela.AddCell(cell);

                            cell = new PdfPCell(uf);
                            tabela.AddCell(cell);

                            cell = new PdfPCell(IdCur);
                            tabela.AddCell(cell);

                            cell = new PdfPCell(cur);
                            tabela.AddCell(cell);

                            cell = new PdfPCell(area);
                            tabela.AddCell(cell);

                            cell = new PdfPCell(nota);
                            tabela.AddCell(cell);
                        }
                    }

                    doc.Add(tabela);
                    doc.Close();

            }

            MessageBox.Show("Geração de relatório concluido");
                Log.GerarLog("Novo relatório gerado");
        }
    }

        public void CarregarTreeView(TreeView t)
        {
            bd = new bd_top();

            noPrinFac = t.Nodes.Add("Faculdades");
            noPrinCur = t.Nodes.Add("Cursos");
            noPrinNt = t.Nodes.Add("Notas MEC");

            int[] notas = {1,2,3,4,5 };

            foreach (var nt in notas)
            {
                TreeNode noNotas = noPrinNt.Nodes.Add(nt.ToString());
            }

            foreach (var fac in from f in bd.tb_faculdade select f)
            {
                TreeNode noFac = noPrinFac.Nodes.Add(fac.facul_st_nome);
            }

            foreach (var cur in from c in bd.tb_curso select c)
            {
                TreeNode noCurso = noPrinCur.Nodes.Add(cur.cur_st_nome);
            }
        }

        public void MarcarCbox(bool condicao)
        {
            cboxDetFac.Checked = condicao;
            cboxDetCur.Checked = condicao;
            cboxDescArea.Checked = condicao;
            cboxNota.Checked = condicao;
        }

        public void AddOuRemoveCbox(CheckBox cbox)
        {
            TreeNode noRelatorioCampos;

            if (cbox.Checked)
            {
                noRelatorioCampos = noRelatorioAv.Nodes.Add(cbox.Text);
                treeViewVisuRelatorio.ExpandAll();
            }
        }

        private void mdiGerarRelatorioNotas_Load(object sender, EventArgs e)
        {
            CarregarTreeView(treeViewOp);

        }

        private void treeViewVisuRelatorio_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btnRemover.Visible = true;
        }

        private void treeViewOp_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == noPrinCur)
                return;
            else if (e.Node == noPrinFac)
                return;
            else if (e.Node == noPrinNt)
                return;

            foreach (var noFilho in noPrinNt.Nodes)
            {
                if (e.Node == noFilho)
                {
                    tipoNo = "Nota";
                }
            }

            foreach (var noFilho in noPrinFac.Nodes)
            {
                if (e.Node == noFilho)
                {
                    tipoNo = "Faculdade";
                }
            }

            foreach (var noFilho in noPrinCur.Nodes)
            {
                if (e.Node == noFilho)
                {
                    tipoNo = "Curso";
                }
            }

            MarcarCbox(false);
            TreeNode userSelect = treeViewOp.SelectedNode;
            Thread.Sleep(1000);
            noRelatorioAv = treeViewVisuRelatorio.Nodes.Add(userSelect.Text);
            MarcarCbox(true);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult excluir = MessageBox.Show("Quer mesmo excluir esse item do relatório?", "Excluir item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (excluir == DialogResult.Yes)
            {
                treeViewVisuRelatorio.SelectedNode.Remove();
                MarcarCbox(false);

            }
            else { return; }

            btnRemover.Visible = false;
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorioPDF(treeViewVisuRelatorio.Nodes);
            MarcarCbox(false);
            treeViewVisuRelatorio.Nodes.Clear();
            treeViewOp.CollapseAll();

            DialogResult pergunta = MessageBox.Show("Deseja ver os novos relatórios gerados?", "Relatórios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("Explorer", @"C:\Users\LGuilen\Documents\Arquivos Projeto\Projeto Faculdade\CÓDIGO\GerenciadorTOP (Desktop)\Gerenciador\bin\Debug\RelatoriosAvaliacoes\");
            }
            else { return; }
        }

        private void cboxDetFac_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxDetFac);
        }

        private void cboxDetCur_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxDetCur);
        }

        private void cboxDescArea_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxDescArea);
        }

        private void cboxNota_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxNota);
        }
}
}
