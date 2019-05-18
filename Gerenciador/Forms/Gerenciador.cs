using Gerenciador.Classes;
using Gerenciador.Forms.Atualizações;
using Gerenciador.Forms.Cadastros;
using Gerenciador.Forms.Consultas;
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
    public partial class Gerenciador : Form
    {
        public Gerenciador()
        {
            InitializeComponent();
        }
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.No)
            { return; }
            else
            {
                Application.Exit();
                Application.ExitThread();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiNovoUsuario novoUsuario = new mdiNovoUsuario();
            novoUsuario.MdiParent = this;
            novoUsuario.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiAtualizarUsuario atualizarUsuario = new mdiAtualizarUsuario();
            atualizarUsuario.MdiParent = this;
            atualizarUsuario.Show();
        }

        private void visualizarTestesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiTestesUsuario testeUsuario = new mdiTestesUsuario();
            testeUsuario.MdiParent = this;
            testeUsuario.Show();
        }

        private void gerarRelatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiGerarRelatorio gerarRelatorio = new mdiGerarRelatorio();
            gerarRelatorio.MdiParent = this;
            gerarRelatorio.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mdiNovaFaculdade novaFac = new mdiNovaFaculdade();
            novaFac.MdiParent = this;
            novaFac.Show();
        }

        private void buscarEAtualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiAtualizarFacul atualizarFacul = new mdiAtualizarFacul();
            atualizarFacul.MdiParent = this;
            atualizarFacul.Show();
        }

        private void cursosDeCadaInstituiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiCursosFacul cursosFacul = new mdiCursosFacul();
            cursosFacul.MdiParent = this;
            cursosFacul.Show();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mdiNovoCurso novoCurso = new mdiNovoCurso();
            novoCurso.MdiParent = this;
            novoCurso.Show();
        }

        private void listarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiAtualizarCurso atualizarCurso = new mdiAtualizarCurso();
            atualizarCurso.MdiParent = this;
            atualizarCurso.Show();
        }

        private void cursosPorAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiListarCursosPorArea listarCursos = new mdiListarCursosPorArea();
            listarCursos.MdiParent = this;
            listarCursos.Show();
        }

        private void listarCursoPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiListarCursoPorTipo listarCursoPorTipo = new mdiListarCursoPorTipo();
            listarCursoPorTipo.MdiParent = this;
            listarCursoPorTipo.Show();
        }

        private void atribuirNovaNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiAtribuirNotaMec atribuirNotaMec = new mdiAtribuirNotaMec();
            atribuirNotaMec.MdiParent = this;
            atribuirNotaMec.Show();
        }

        private void buscarAvaliaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiBuscarAvaliacoes buscarAvaliacoes = new mdiBuscarAvaliacoes();
            buscarAvaliacoes.MdiParent = this;
            buscarAvaliacoes.Show();
        }

        private void gerarRelatórioDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiGerarRelatorioNotas relatorioNotas = new mdiGerarRelatorioNotas();
            relatorioNotas.MdiParent = this;
            relatorioNotas.Show();
        }

        private void criarPerguntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiCriarPergunta criarPergunta = new mdiCriarPergunta();
            criarPergunta.MdiParent = this;
            criarPergunta.Show();
        }

        private void visualizarQuestõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiVisualizarQuestoes visualizarQuestoes = new mdiVisualizarQuestoes();
            visualizarQuestoes.MdiParent = this;
            visualizarQuestoes.Show();
        }

        private void buscarModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiModificarQuestao modificarQuestao = new mdiModificarQuestao();
            modificarQuestao.MdiParent = this;
            modificarQuestao.Show();
        }

        private void Gerenciador_MdiChildActivate(object sender, EventArgs e)
        {
            picLogo.Visible = false;
        }
        
    }
}
