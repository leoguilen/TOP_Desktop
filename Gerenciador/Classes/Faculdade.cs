using Gerenciador.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Classes
{
    public class Faculdade
    {
        private bd_top bd;

        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string Endereço { get; private set; }
        public string UF { get; private set; }
        public string Estado { get; private set; }
        public string Cidade { get; private set; }
        public string Site { get; private set; }

        public Faculdade(){}

        public Faculdade(string nome,string endereço,string uf,string estado,string cidade, string site)
        {
            this.Nome = nome;
            this.Endereço = endereço;
            this.UF = uf;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Site = site;
        }

        public void AdicionarFaculdade(Faculdade fac)
        {
            bd = new bd_top();
            
            try
            {
                tb_faculdade facul = new tb_faculdade()
                {
                    facul_st_nome = fac.Nome,
                    facul_st_endereco = fac.Endereço,
                    facul_st_uf = fac.UF,
                    facul_st_estado = fac.Estado,
                    facul_st_cidade = fac.Cidade,
                    facul_st_site = fac.Site
                };

                bd.tb_faculdade.Add(facul);
                bd.SaveChanges();
                bd.Dispose();
            }
            catch (EntitySqlException entitySqlEx)
            {
                MessageBox.Show("Erro: " + entitySqlEx.Message + "\nGerador do erro: " + entitySqlEx.Source);
            }
            catch (EntityException entityEx)
            {
                MessageBox.Show("Erro: " + entityEx.Message + "\nGerador do erro: " + entityEx.Source);
            }
            
            
        }

        public void AdicionarContatoFaculdade(Faculdade fac,int tipoCont,string contato)
        {
            bd = new bd_top();

            try
            {
                var retNovosContFac = bd.sp_inserirContatosFaculdade(fac.Nome,tipoCont,contato);
                
                if(retNovosContFac >= 0)
                {
                    bd.SaveChanges();
                    bd.Dispose();
                } else {

                    throw new EntityException("Algum erro ocorreu quando foi inserir um novo contato");
                }

            }catch(EntitySqlException entitySqlEx)
            {
                MessageBox.Show("Erro: " + entitySqlEx.Message + "\nGerador do erro: " + entitySqlEx.Source);
            }
            catch (EntityException entityEx)
            {
                MessageBox.Show("Erro: " + entityEx.Message + "\nGerador do erro: " + entityEx.Source);
            }
        }

        public List<Faculdade> BuscarFaculdadePorNome(string nomeFacul)
        {
            bd = new bd_top();
            List<Faculdade> _listFacul = new List<Faculdade>();

            var buscarFacul = from fac
                              in bd.tb_faculdade
                              .Where(f => f.facul_st_nome.Contains(nomeFacul))
                              select fac;

            foreach (var fac in buscarFacul)
            {
                Faculdade facul = new Faculdade()
                {
                    ID = fac.facul_in_id,
                    Nome = fac.facul_st_nome,
                    Endereço = fac.facul_st_endereco,
                    UF = fac.facul_st_uf,
                    Estado = fac.facul_st_estado,
                    Cidade = fac.facul_st_cidade,
                    Site = fac.facul_st_site
                };

                _listFacul.Add(facul);
               
            }
            
            return _listFacul;

        }
        
        public List<v_relatorioNotaMec> ListarCursosDessaInstituicao(string nomeFacul)
        {
            bd = new bd_top();
            List<v_relatorioNotaMec> _listCursos = new List<v_relatorioNotaMec>();

            var buscarCurso = from view in bd.v_relatorioNotaMec
                              .Where(v => v.nome_facul.Contains(nomeFacul))
                              select view;

            foreach (var itemCurso in buscarCurso)
            {
                _listCursos.Add(itemCurso);
            }
            
            return _listCursos;
        }

        public void AtualizarFaculdade(int id,Faculdade fac,string tel,string cel,string fax,string email)
        {
            bd = new bd_top();
            
            try
            {
                bd.sp_atualizaFaculdade(id, fac.Nome, fac.Endereço, fac.UF, fac.Estado, fac.Cidade, fac.Site, email, tel, cel, fax);
            }
            catch (EntitySqlException entitySqlEx)
            {
                MessageBox.Show("Erro: " + entitySqlEx.Message + "\nGerador do erro: " + entitySqlEx.Source);
            }
            catch (EntityException entityEx)
            {
                MessageBox.Show("Erro: " + entityEx.Message + "\nGerador do erro: " + entityEx.Source);
            } 
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Erro: " + sqlEx.Message + "\nGerador do erro: " + sqlEx.Source);
            }




        }
    }
}
