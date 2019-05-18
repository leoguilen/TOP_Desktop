using Gerenciador.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Gerenciador.Classes;
using System.Threading;

namespace Gerenciador.Forms
{
    public partial class mdiGerarRelatorio : Form
    {
        public mdiGerarRelatorio()
        {
            InitializeComponent();
        }

        private bd_top bd;
        TreeNode noRelatorioUser;

        public void GerarRelatorioPDF(TreeNodeCollection tree)
        {
            bd = new bd_top();
            string diretorio = @"\RelatoriosResultados\";
            string caminho = Directory.GetCurrentDirectory() + diretorio;

            if (Directory.Exists(caminho))
            {
                foreach (TreeNode nome in tree)
                {
                    Document doc = new Document(PageSize.GetRectangle("1150 600"),-130,-130,25,0);
                    PdfWriter write;

                    if (!File.Exists(caminho + nome.Text + ".pdf"))
                    {
                        write = PdfWriter.GetInstance(doc, new FileStream(caminho + nome.Text + ".pdf", FileMode.Create));
                    } else
                    {
                        Random r = new Random();
                        int num = r.Next(1,1000);
                        write = PdfWriter.GetInstance(doc, new FileStream(caminho + nome.Text + num + ".pdf", FileMode.Create));
                    }
                    
                    doc.Open();

                    PdfPTable tabela = new PdfPTable(17);

                    var contentByte = write.DirectContent;
                    var image = Image.GetInstance(@"C:\Users\LGuilen\Documents\Arquivos Projeto\Projeto Faculdade\CÓDIGO\GerenciadorTOP (Desktop)\Gerenciador\Resources\Logo.png");
                    image.ScaleToFit(69, 40);
                    image.SetAbsolutePosition(20, 20);
                    contentByte.AddImage(image);

                    Font fonte = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 12);
                    Font fontTitle = FontFactory.GetFont(BaseFont.TIMES_BOLD, 20);

                    Paragraph titulo = new Paragraph("Relatório de resultados\n", fontTitle);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    doc.Add(new Paragraph("\n"));

                    Paragraph col1 = new Paragraph("ID", fonte);
                    Paragraph col2 = new Paragraph("Username", fonte);
                    Paragraph col3 = new Paragraph("IDTeste", fonte);
                    Paragraph col4 = new Paragraph("Inicio", fonte);
                    Paragraph col5 = new Paragraph("Final", fonte);
                    Paragraph col6 = new Paragraph("Duração", fonte);
                    Paragraph col7 = new Paragraph("Exatas", fonte);
                    Paragraph col8 = new Paragraph("Humanas", fonte);
                    Paragraph col9 = new Paragraph("Biologicas", fonte);
                    Paragraph col10 = new Paragraph("Curso", fonte);
                    Paragraph col11 = new Paragraph("Tipo", fonte);
                    Paragraph col12 = new Paragraph("Duração", fonte);
                    Paragraph col13 = new Paragraph("Area", fonte);
                    Paragraph col14 = new Paragraph("Faculdade", fonte);
                    Paragraph col15 = new Paragraph("Estado", fonte);
                    Paragraph col16 = new Paragraph("Site", fonte);
                    Paragraph col17 = new Paragraph("NotaMEC", fonte);
                    
                    var cel1 = new PdfPCell();
                    var cel2 = new PdfPCell();
                    var cel3 = new PdfPCell();
                    var cel4 = new PdfPCell();
                    var cel5 = new PdfPCell();
                    var cel6 = new PdfPCell();
                    var cel7 = new PdfPCell();
                    var cel8 = new PdfPCell();
                    var cel9 = new PdfPCell();
                    var cel10 = new PdfPCell();
                    var cel11 = new PdfPCell();
                    var cel12 = new PdfPCell();
                    var cel13 = new PdfPCell();
                    var cel14 = new PdfPCell();
                    var cel15 = new PdfPCell();
                    var cel16 = new PdfPCell();
                    var cel17 = new PdfPCell();

                    cel1.AddElement(col1);
                    cel2.AddElement(col2);
                    cel3.AddElement(col3);
                    cel4.AddElement(col4);
                    cel5.AddElement(col5);
                    cel6.AddElement(col6);
                    cel7.AddElement(col7);
                    cel8.AddElement(col8);
                    cel9.AddElement(col9);
                    cel10.AddElement(col10);
                    cel11.AddElement(col11);
                    cel12.AddElement(col12);
                    cel13.AddElement(col13);
                    cel14.AddElement(col14);
                    cel15.AddElement(col15);
                    cel16.AddElement(col16);
                    cel17.AddElement(col17);

                    tabela.AddCell(cel1);
                    tabela.AddCell(cel2);
                    tabela.AddCell(cel3);
                    tabela.AddCell(cel4);
                    tabela.AddCell(cel5);
                    tabela.AddCell(cel6);
                    tabela.AddCell(cel7);
                    tabela.AddCell(cel8);
                    tabela.AddCell(cel9);
                    tabela.AddCell(cel10);
                    tabela.AddCell(cel11);
                    tabela.AddCell(cel12);
                    tabela.AddCell(cel13);
                    tabela.AddCell(cel14);
                    tabela.AddCell(cel15);
                    tabela.AddCell(cel16);
                    tabela.AddCell(cel17);

                    foreach (TreeNode node in tree)
                    {
                        foreach (var userId in from id in bd.tb_usuario
                                             .Where(i => i.user_st_nome.Contains(node.Text))
                                               select new { id.user_in_id })
                        {
                            foreach (var info in from inf in bd.v_relatorioResultado
                                                 .Where(i => i.id_user == userId.user_in_id)
                                                 orderby inf.id_user ascending select inf)
                            {
                                Phrase IdUs = new Phrase(info.id_user.ToString());
                                Phrase username = new Phrase(info.username_user);
                                Phrase IdTest = new Phrase(info.id_teste.ToString());
                                Phrase inicio = new Phrase(info.inicio_teste.ToString());
                                Phrase final = new Phrase(info.final_teste.ToString());
                                Phrase duracao = new Phrase(string.Format("{0} Minutos", info.tempo_resultado));
                                Phrase resExatas = new Phrase(string.Format("{0}%", info.exatas_resultado));
                                Phrase resHumanas = new Phrase(string.Format("{0}%", info.humanas_resultado));
                                Phrase resBio = new Phrase(string.Format("{0}%", info.biologicas_resultado));
                                Phrase curso = new Phrase(info.nome_curso);
                                Phrase tipoCurso = new Phrase(info.tipo_curso);
                                Phrase duracaoCurso = new Phrase(string.Format("{0} Anos",info.duracao_curso.ToString()));
                                Phrase descArea = new Phrase(info.desc_area);
                                Phrase facul = new Phrase(info.nome_facul);
                                Phrase estadoFacul = new Phrase(info.estado_facul);
                                Phrase siteFacul = new Phrase(info.site_facul);
                                Phrase notaMec = new Phrase(string.Format("{0}", info.valor_notaMec));

                                var cell = new PdfPCell(IdUs);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(username);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(IdTest);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(inicio);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(final);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(duracao);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(resExatas);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(resHumanas);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(resBio);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(curso);
                                tabela.AddCell(cell);
                                
                                cell = new PdfPCell(tipoCurso);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(duracaoCurso);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(descArea);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(facul);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(estadoFacul);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(siteFacul);
                                tabela.AddCell(cell);

                                cell = new PdfPCell(notaMec);
                                tabela.AddCell(cell);
                            }
                        }
                    }

                    doc.Add(tabela);
                    doc.Close();
                }

                MessageBox.Show("Geração de relatório concluido");
                Log.GerarLog("Novo relatório gerado");
            }
        }

        public void AddOuRemoveCbox(CheckBox cbox)
        {
            TreeNode noRelatorioCampos;

            if (cbox.Checked)
            {
                noRelatorioCampos = noRelatorioUser.Nodes.Add(cbox.Text);
                treeViewVisuRelatorio.ExpandAll();
            } 
        }

        public void CarregarTreeViewUsuario(TreeView tree)
        {
            bd = new bd_top();

            string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            TreeNode users = tree.Nodes.Add("Usuário");

            foreach (var letra in letras)
            {
                TreeNode noLetras = users.Nodes.Add(letra.ToString());

                foreach (var itemUs in from user in bd.tb_usuario.Where(u => u.user_st_nome.StartsWith(letra)) orderby user.user_st_nome ascending select new { user.user_in_id, user.user_st_nome })
                {
                    TreeNode user = noLetras.Nodes.Add(itemUs.user_st_nome);
                }
            }
        }

        public void MarcarCbox(bool condicao)
        {
            cboxDetCurso.Checked = condicao;
            cboxDetFacul.Checked = condicao;
            cboxDuracao.Checked = condicao;
            cboxFinal.Checked = condicao;
            cboxIdTeste.Checked = condicao;
            cboxIdUser.Checked = condicao;
            cboxInicio.Checked = condicao;
            cboxNota.Checked = condicao;
            cboxResultados.Checked = condicao;
            cboxUsername.Checked = condicao;
        }

        private void mdiGerarRelatorio_Load(object sender, EventArgs e)
        {
            CarregarTreeViewUsuario(treeViewUsuarios);
        }

        private void treeViewVisuRelatorio_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btnRemover.Visible = true;
        }

        private void treeViewUsuarios_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MarcarCbox(false);
            TreeNode userSelect = treeViewUsuarios.SelectedNode;
            Thread.Sleep(1000);
            noRelatorioUser = treeViewVisuRelatorio.Nodes.Add(userSelect.Text);
            MarcarCbox(true);
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorioPDF(treeViewVisuRelatorio.Nodes);
            MarcarCbox(false);
            treeViewVisuRelatorio.Nodes.Clear();
            treeViewUsuarios.CollapseAll();

            DialogResult pergunta = MessageBox.Show("Deseja ver os novos relatórios gerados?", "Relatórios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("Explorer", @"C:\Users\LGuilen\Documents\Arquivos Projeto\Projeto Faculdade\CÓDIGO\GerenciadorTOP (Desktop)\Gerenciador\bin\Debug\RelatoriosResultados\");
            }
            else { return; }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult excluir = MessageBox.Show("Deseja excluir esse item do relatório?","Excluir item",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(excluir == DialogResult.Yes)
            {
                treeViewVisuRelatorio.SelectedNode.Remove();
                MarcarCbox(false);
                
            } else { return; }

            btnRemover.Visible = false;

        }
        
        private void cboxIdUser_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxIdUser);
        }

        private void cboxUsername_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxUsername);
        }

        private void cboxIdTeste_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxIdTeste);
        }

        private void cboxInicio_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxInicio);
        }

        private void cboxFinal_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxFinal);
        }

        private void cboxDuracao_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxDuracao);
        }

        private void cboxResultados_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxResultados);
        }

        private void cboxDetCurso_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxDetCurso);
        }

        private void cboxDetFacul_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxDetFacul);
        }

        private void cboxNota_CheckedChanged(object sender, EventArgs e)
        {
            AddOuRemoveCbox(cboxNota);
        }
        
    }
}
