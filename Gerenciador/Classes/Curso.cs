using Gerenciador.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Classes
{
    public class Curso
    {
        private bd_top bd;
        private tb_curso _curso;

        public string Nome { get; set; }
        public int AreaCurso { get; set; }
        public string Descricao { get; set; }
        public string TempoDeDuração { get; set; }
        public string UrlImagem { get; set; }
        public string TipoCurso { get; set; }
        public int ValorMax { get; set; }
        public int ValorMin { get; set; }

        public Curso(){}

        public Curso(string nome,int area,string desc,string duracao,string urlImg, string tipo,int min,int max)
        {
            Nome = nome;
            AreaCurso = area;
            Descricao = desc;
            TempoDeDuração = duracao;
            UrlImagem = urlImg;
            TipoCurso = tipo;
            ValorMax = max;
            ValorMin = min;

        }

        public void AtualizarCurso(Curso cur)
        {
            bd = new bd_top();
            int idCur = 0;

            foreach (var itemId in from id in bd.tb_curso .Where(i=>i.cur_st_nome.Contains(cur.Nome)) select id)
            {
                idCur = itemId.cur_in_id;
            }
            
            try
            {
                bd.sp_AtualizaCurso(idCur,cur.AreaCurso,cur.Nome,cur.TipoCurso,cur.TempoDeDuração,cur.Descricao,cur.ValorMax,cur.ValorMin);
                bd.SaveChanges();
                bd.Dispose();
            }
            catch (EntitySqlException entitySqlEX)
            {
                MessageBox.Show("Erro: " + entitySqlEX.Message + "\nGerador do erro: " + entitySqlEX.Source);
            }
            catch (EntityException entityEX)
            {
                MessageBox.Show("Erro: " + entityEX.Message + "\nGerador do erro: " + entityEX.Source);
            }

        }

        public void AdicionarCurso(Curso cur)
        {
            bd = new bd_top();

            try
            {
                _curso = new tb_curso()
                {
                    areaCur_in_id = cur.AreaCurso,
                    cur_st_nome = cur.Nome,
                    cur_st_desc = cur.Descricao,
                    cur_st_duracao = cur.TempoDeDuração,
                    cur_img_prof = cur.UrlImagem,
                    cur_st_tipo = cur.TipoCurso,
                    cur_in_valorMax = cur.ValorMax,
                    cur_in_valorMin = cur.ValorMin
                };

                bd.tb_curso.Add(_curso);
                bd.SaveChanges();
                bd.Dispose();

            }
            catch (EntitySqlException entitySqlEX)
            {
                MessageBox.Show("Erro: " + entitySqlEX.Message + "\nGerador do erro: " + entitySqlEX.Source);
            }
            catch (EntityException entityEX)
            {
                MessageBox.Show("Erro: " + entityEX.Message + "\nGerador do erro: " + entityEX.Source);
            }

        }

        public List<tb_curso> BuscarCursoPorNome(string nomeCurso)
        {
            bd = new bd_top();
            List<tb_curso> _listCurso = new List<tb_curso>();

            var buscaCurso = from cur
                             in bd.tb_curso
                             .Where(c => c.cur_st_nome.Contains(nomeCurso))
                             select cur;

            foreach (var itemCurso in buscaCurso)
            {
                _listCurso.Add(itemCurso);
            }

            return _listCurso;
        }

        public List<tb_curso> BuscarCursoPorTipo(string tipoCurso)
        {
            bd = new bd_top();
            List<tb_curso> _listCurso = new List<tb_curso>();

            var buscarCurso = from cur
                              in bd.tb_curso
                              .Where(c => c.cur_st_tipo.Equals(tipoCurso))
                              select cur;
            foreach (var curso in buscarCurso)
            {
                _listCurso.Add(curso);
            }

            return _listCurso;
        }

    }
}
